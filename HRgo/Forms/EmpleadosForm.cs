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
    public partial class EmpleadoesForm : Form
    {
        Empleadoes model = new Empleadoes();
        public EmpleadoesForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtNombre.Text = txtCedula.Text= txtSal.Text = txtSal.Text = "";
            model.IdEmpleado = 0;
            txtEstado.SelectedItem = "Activo";
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Nombre = txtNombre.Text.Trim();
            model.Cedula = txtCedula.Text.Trim();
            model.Puesto_IdPuesto = int.Parse((cbPuesto.SelectedItem as ComboboxItem).Value.ToString());
            model.Departamento_IdDepartamento = int.Parse((cbDepartamento.SelectedItem as ComboboxItem).Value.ToString());
            model.Salario = float.Parse(txtSal.Text);
            model.FechaIngreso = dtpHasta.Value;


            using (hrgoEntities1 db = new hrgoEntities1())
            {
                if (model.IdEmpleado == 0)//insert
                    db.Empleadoes.Add(model);
                else //update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();

            }
            LlenarDataGridView();
            Clear();
            MessageBox.Show("Puesto Guardado");
        }

        void LlenarComboPuestos()
        {
            List<Puestoes> listaPuestos = new List<Puestoes>();
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                listaPuestos = db.Puestoes.ToList<Puestoes>();
            }

            foreach (var puesto in listaPuestos)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = puesto.Nombre;
                item.Value = puesto.IdPuesto;
                cbPuesto.Items.Add(item);

            }
        }

        void LlenarComboDepartamentos()
        {
            List<Departamentoes> listaDepartamentos = new List<Departamentoes>();
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                listaDepartamentos = db.Departamentoes.ToList<Departamentoes>();
            }

            foreach (var departamento in listaDepartamentos)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = departamento.Nombre;
                item.Value = departamento.IdDepartamento;
                cbDepartamento.Items.Add(item);

            }
        }


        void LlenarDataGridView()
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                dgvEmpleado.AutoGenerateColumns = false;
                dgvEmpleado.DataSource = db.Empleadoes.ToList<Empleadoes>();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LlenarDataGridView();
            LlenarComboPuestos();
            LlenarComboDepartamentos();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmpleado.CurrentRow.Index != -1)
            {
                model.IdEmpleado = Convert.ToInt32(dgvEmpleado.CurrentRow.Cells["IdEmpleado"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Empleadoes.Where(x => x.IdEmpleado == model.IdEmpleado).FirstOrDefault();
                    var puesto = db.Puestoes.Where(x => x.IdPuesto == model.Puesto_IdPuesto).FirstOrDefault();
                    var departamento = db.Departamentoes.Where(x => x.IdDepartamento == model.Departamento_IdDepartamento).FirstOrDefault();
                    txtNombre.Text = model.Nombre;
                    txtSal.Text = model.Salario.ToString();
                    txtCedula.Text = model.Cedula.ToString();
                    cbDepartamento.SelectedIndex = cbDepartamento.FindStringExact(departamento.Nombre.ToString());
                    cbPuesto.SelectedIndex = cbPuesto.FindStringExact(puesto.Nombre.ToString());
                    dtpHasta.Value = model.FechaIngreso;
                    txtEstado.SelectedItem = model.Estado == true ? "Activo" : "inactivo";
                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que quieres eliminar este elementoo ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Empleadoes.Attach(model);
                    db.Empleadoes.Remove(model);
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

        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPuesto_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbcompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            if (model.IdEmpleado != 0)
            {
                CapacitacionesForm capacitacionesForm = new CapacitacionesForm(model.IdEmpleado);

                capacitacionesForm.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un candidato para agregar Capacitaciones");
            }

        }

        private void btnCompetencia_Click(object sender, EventArgs e)
        {
            if (model.IdEmpleado != 0)
            {
                CompetenciasForm competenciasForm = new CompetenciasForm(model.IdEmpleado);
                competenciasForm.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un candidato para agregar Competencias");
            }

        }

        private void btnExperiencia_Click(object sender, EventArgs e)
        {
            if (model.IdEmpleado != 0)
            {
                ExperienciasForm experienciasForm = new ExperienciasForm(model.IdEmpleado);
                experienciasForm.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un candidato para agregar Experiencias");
            }
        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }

}
