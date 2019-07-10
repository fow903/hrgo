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
    public partial class PuestosForm : Form
    {
        Puestoes model = new Puestoes();
        public PuestosForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtNombre.Text = txtSalMax.Text = txtSalMin.Text = "";
            txtEstado.SelectedItem = "Activo";
            model.IdPuesto = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Nombre = txtNombre.Text.Trim();
            model.Estado = txtEstado.SelectedItem.Equals("Activo") ? true : false;
            model.SalarioMin = float.Parse(txtSalMin.Text);
            model.SalarioMax = float.Parse(txtSalMax.Text);
            model.NivelDeRiesgo = cbNivel.SelectedItem.ToString();


            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdPuesto == 0)//insert
                    db.Puestoes.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Puesto Guardado");
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvPuesto.AutoGenerateColumns = false;
                dgvPuesto.DataSource = db.Puestoes.ToList<Puestoes>();
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

        private void dgvPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvPuesto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPuesto.CurrentRow.Index != -1)
            {
                model.IdPuesto = Convert.ToInt32(dgvPuesto.CurrentRow.Cells["IdPuesto"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Puestoes.Where(x => x.IdPuesto == model.IdPuesto).FirstOrDefault();
                    txtNombre.Text = model.Nombre;
                    txtEstado.SelectedItem = model.Estado == true ? "Activo" : "inactivo";
                    txtSalMin.Text = model.SalarioMin.ToString();
                    txtSalMax.Text = model.SalarioMax.ToString();
                    cbNivel.Text = model.NivelDeRiesgo;

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
                        db.Puestoes.Attach(model);
                    db.Puestoes.Remove(model);
                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Elemento eliminado satisfactoriamente");
                }
            }
        }

        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalMin_VisibleChanged(object sender, EventArgs e)
        {
            txtSalMax.Minimum = txtSalMin.Value;
        }
    }



}
