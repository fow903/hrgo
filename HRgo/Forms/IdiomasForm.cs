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

namespace HRgo
{
    public partial class IdiomasForm : Form
    {
        Idiomas model = new Idiomas();
        public IdiomasForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear() {
            txtNombre.Text = "";
            txtEstado.SelectedItem = "Activo";
            model.IdiomaId = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Nombre = txtNombre.Text.Trim();
            model.Estado = txtEstado.SelectedItem.Equals("Activo") ? true : false;


            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdiomaId == 0)//insert
                    db.Idiomas.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Idioma Guardado");
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvIdioma.AutoGenerateColumns = false;
                dgvIdioma.DataSource = db.Idiomas.ToList<Idiomas>();
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

        private void dgvIdioma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void dgvIdioma_DoubleClick(object sender, EventArgs e)
        {
            if (dgvIdioma.CurrentRow.Index != -1)
            {
                model.IdiomaId = Convert.ToInt32(dgvIdioma.CurrentRow.Cells["IdiomaId"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Idiomas.Where(x => x.IdiomaId == model.IdiomaId).FirstOrDefault();
                    txtNombre.Text = model.Nombre;
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
            if (MessageBox.Show("Estas Seguro que quieres eliminar este elementoo ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Idiomas.Attach(model);
                    db.Idiomas.Remove(model);
                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Elemento eliminado satisfactoriamente");
                }
            }
        }
    }
}
