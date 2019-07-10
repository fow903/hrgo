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
    public partial class DepartamentosForm : Form
    {
        Departamentoes model = new Departamentoes();
        public DepartamentosForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtDescripcion.Text = "";
            txtEstado.SelectedItem = "Activo";
            model.IdDepartamento = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Nombre = txtDescripcion.Text.Trim();
            model.Estado = txtEstado.SelectedItem.Equals("Activo") ? true : false;


            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdDepartamento == 0)//insert
                    db.Departamentoes.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Departamento Guardado");
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvDepartamento.AutoGenerateColumns = false;
                dgvDepartamento.DataSource = db.Departamentoes.ToList<Departamentoes>();
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

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvDepartamento_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDepartamento.CurrentRow.Index != -1)
            {
                model.IdDepartamento = Convert.ToInt32(dgvDepartamento.CurrentRow.Cells["IdDepartamento"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Departamentoes.Where(x => x.IdDepartamento == model.IdDepartamento).FirstOrDefault();
                    txtDescripcion.Text = model.Nombre;
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
                        db.Departamentoes.Attach(model);
                    db.Departamentoes.Remove(model);
                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Elemento eliminado satisfactoriamente");
                }
            }
        }

        private void dgvDepartamento_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
