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
    public partial class CompetenciasForm : Form
    {
        int idCandidato;
        Competencias model = new Competencias();
        public CompetenciasForm(int candidato)
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
            txtDescripcion.Text = "";
            txtEstado.SelectedItem = "Activo";
            model.IdCompetencia = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Descripcion = txtDescripcion.Text.Trim();
            model.Estado = txtEstado.SelectedItem.Equals("Activo") ? true : false;
            model.Candidato_IdCandidato = idCandidato;

            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdCompetencia == 0)//insert
                    db.Competencias.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Competencia Guardado");
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvCompetencia.AutoGenerateColumns = false;
                dgvCompetencia.DataSource = db.Competencias.Where(x=> x.Candidato_IdCandidato == idCandidato).ToList<Competencias>();
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

        private void dgvCompetencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvCompetencia_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCompetencia.CurrentRow.Index != -1)
            {
                model.IdCompetencia = Convert.ToInt32(dgvCompetencia.CurrentRow.Cells["IdCompetencia"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Competencias.Where(x => x.Candidato_IdCandidato == idCandidato && x.IdCompetencia == model.IdCompetencia).FirstOrDefault();
                    txtDescripcion.Text = model.Descripcion;
                    txtEstado.SelectedItem = model.Estado == true ? "Activo" : "inactivo";
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
                        db.Competencias.Attach(model);
                    db.Competencias.Remove(model);
                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Elemento eliminado satisfactoriamente");
                }
            }
        }

        private void dgvCompetencia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompetenciasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
