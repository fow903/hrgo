using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRgo.Forms
{
    public partial class ExperienciasForm : Form
    {
        int idCandidato;
        Experiencias model = new Experiencias();
        public ExperienciasForm(int candidato)
        {
            InitializeComponent();
            idCandidato = candidato;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtEmpresa.Text = "";
            txtPuesto.Text = "";
            txtSal.Text = "";
            model.IdExperiencia = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Empresa = txtEmpresa.Text.Trim();
            model.Puesto = txtPuesto.Text.Trim();
            model.FechaDesde = dtpDesde.Value;
            model.FechaHasta = dtpHasta.Value;
            model.Salario = float.Parse(txtSal.Text.Trim());
            model.Candidato_IdCandidato = idCandidato;


            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdExperiencia == 0)//insert
                    db.Experiencias.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Experiencia Guardado");
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvExperiencia.AutoGenerateColumns = false;
                dgvExperiencia.DataSource = db.Experiencias.Where(x => x.Candidato_IdCandidato == idCandidato).ToList<Experiencias>();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LlenarDataGridView();
        }

        private void dgvExperiencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvExperiencia_DoubleClick(object sender, EventArgs e)
        {
            if (dgvExperiencia.CurrentRow.Index != -1)
            {
                model.IdExperiencia = Convert.ToInt32(dgvExperiencia.CurrentRow.Cells["IdExperiencia"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Experiencias.Where(x => x.Candidato_IdCandidato == idCandidato && x.IdExperiencia == model.IdExperiencia).FirstOrDefault();
                    txtEmpresa.Text = model.Empresa;
                    txtPuesto.Text = model.Puesto;
                    txtSal.Text = model.Salario.ToString();
                    dtpDesde.Value = model.FechaDesde;
                    dtpHasta.Value = model.FechaHasta;

                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void idiomasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que quieres eliminar este elementoo ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Experiencias.Attach(model);
                    db.Experiencias.Remove(model);
                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Elemento eliminado satisfactoriamente");
                }
            }
        }

        private void dgvExperiencia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExperienciasForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
