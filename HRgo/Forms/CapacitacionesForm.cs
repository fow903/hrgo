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
    public partial class CapacitacionesForm : Form
    {
        int idCandidato;
        Capacitacions model = new Capacitacions();
        public CapacitacionesForm(int idCand)
        {
            InitializeComponent();
            idCandidato = idCand;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            DateTime aDate = DateTime.Now;
            txtDescripcion.Text = txtInstitucion.Text = "";
            cbNivel.Text = "";
            //dtpDesde.CustomFormat = dtpHasta.CustomFormat = " ";
            //dtpDesde.Format = dtpHasta.Format = DateTimePickerFormat.Custom;    
            model.IdCapacitacion = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Descripcion = txtDescripcion.Text.Trim();
            model.Institucion = txtDescripcion.Text.Trim();
            model.FechaDesde = dtpDesde.Value;
            model.FechaHasta = dtpHasta.Value;
            model.Nivel = cbNivel.SelectedItem.ToString();
            model.Candidato_IdCandidato = idCandidato;

            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdCapacitacion == 0)//insert
                    db.Capacitacions.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Capacitacion Guardado");
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvCapacitacion.AutoGenerateColumns = false;
                dgvCapacitacion.DataSource = db.Capacitacions.Where(x=> x.Candidato_IdCandidato == idCandidato).ToList<Capacitacions>();
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

        private void dgvCapacitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvCapacitacion_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCapacitacion.CurrentRow.Index != -1)
            {
                model.IdCapacitacion = Convert.ToInt32(dgvCapacitacion.CurrentRow.Cells["IdCapacitacion"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Capacitacions.Where(x => (x.IdCapacitacion == model.IdCapacitacion && x.Candidato_IdCandidato == idCandidato)).FirstOrDefault();
                    txtDescripcion.Text = model.Descripcion;
                    cbNivel.SelectedItem = model.Nivel;
                    dtpDesde.Value = model.FechaDesde;
                    dtpHasta.Value = model.FechaHasta;
                    txtInstitucion.Text = model.Institucion;
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
                        db.Capacitacions.Attach(model);
                    db.Capacitacions.Remove(model);
                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Elemento eliminado satisfactoriamente");
                }
            }
        }

        private void dgvCapacitacion_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCapacitacion_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
