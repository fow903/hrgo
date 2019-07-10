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
    public partial class CandidatosForm : Form
    {
        Candidatoes model = new Candidatoes();
        public CandidatosForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtNombre.Text = txtSal.Text = txtSal.Text = "";
            model.IdCandidato = 0;
            btnDelete.Enabled = false;
            btnSave.Text = "Guardar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = ValidaCedula(txtCedula.Text.Trim());

            if (isValid) {
                model.Nombre = txtNombre.Text.Trim();
                model.SalarioDeseado = float.Parse(txtSal.Text);
                model.Cedula = txtCedula.Text.Trim();
                model.Puesto_IdPuesto = int.Parse((cbPuesto.SelectedItem as ComboboxItem).Value.ToString());
                model.Departamento_IdDepartamento = int.Parse((cbDepartamento.SelectedItem as ComboboxItem).Value.ToString());
                model.Recomendador = txtRecomend.Text.Trim();


                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    if (model.IdCandidato == 0)//insert
                        db.Candidatoes.Add(model);
                    else //update
                        db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                }
                LlenarDataGridView();
                Clear();
                MessageBox.Show("Candidato Guardado Satisfactoriamente!");
            }
            else
            {
                MessageBox.Show("La cedula digitada no es valida");
            }
            
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
                dgvCandidato.AutoGenerateColumns = false;
                dgvCandidato.DataSource = db.Candidatoes.ToList<Candidatoes>();
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

        private void dgvCandidato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgvCandidato_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCandidato.CurrentRow.Index != -1)
            {
                model.IdCandidato = Convert.ToInt32(dgvCandidato.CurrentRow.Cells["IdCandidato"].Value);

                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    model = db.Candidatoes.Where(x => x.IdCandidato == model.IdCandidato).FirstOrDefault();
                    var puesto = db.Puestoes.Where(x => x.IdPuesto == model.Puesto_IdPuesto).FirstOrDefault();
                    var departamento = db.Departamentoes.Where(x => x.IdDepartamento == model.Departamento_IdDepartamento).FirstOrDefault();
                    txtNombre.Text = model.Nombre;
                    txtSal.Text = model.SalarioDeseado.ToString();
                    txtCedula.Text = model.Cedula.ToString();
                    txtRecomend.Text = model.Recomendador.ToString();
                    cbDepartamento.SelectedIndex = cbDepartamento.FindStringExact(departamento.Nombre.ToString());
                    cbPuesto.SelectedIndex = cbPuesto.FindStringExact(puesto.Nombre.ToString());

                }
                btnSave.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void idiomasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        public bool ValidaCedula(string cedula)
            {
                //Declaración de variables a nivel de método o función.
                int verificador = 0;
                int digito = 0;
              int digitoVerificador = 0;
                int digitoImpar = 0;
                int sumaPar = 0;
                int sumaImpar = 0;
               int longitud = Convert.ToInt32(cedula.Length);
               /*Control de errores en el código*/
               try
               {
                   //verificamos que la longitud del parametro sea igual a 11
                   if (longitud == 11)
                   {
                    digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                      //recorremos en un ciclo for cada dígito de la cédula
                      for (int i = 9; i >= 0; i--)
                      {
                          //si el digito no es par multiplicamos por 2
                          digito = Convert.ToInt32(cedula.Substring(i, 1));
                          if ((i % 2) != 0)
                          {
                              digitoImpar = digito* 2;
                              //si el digito obtenido es mayor a 10, restamos 9
                              if (digitoImpar >= 10)
                              {
                                  digitoImpar = digitoImpar - 9;
                              }
                              sumaImpar = sumaImpar + digitoImpar;
                          }
                          /*En los demás casos sumamos el dígito y lo aculamos 
                           en la variable */
                           else
                           {
                               sumaPar = sumaPar + digito;
                           }
                       }
                      /*Obtenemos el verificador restandole a 10 el modulo 10 
                      de la suma total de los dígitos*/
                      verificador = 10 - ((sumaPar + sumaImpar) % 10);
                    /*si el verificador es igual a 10 y el dígito verificador
                      es igual a cero o el verificador y el dígito verificador 
                      son iguales retorna verdadero*/
                 if (((verificador == 10) && (digitoVerificador == 0))
                      || (verificador == digitoVerificador))
                      {
                           return true;
                      }
                  }
                  else
                 {
                  Console.WriteLine("La cédula debe contener once(11) digitos");
                 }
              }
             catch
              {
                Console.WriteLine("No se pudo validar la cédula");
             }
              return false;
         }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que quieres eliminar este elementoo ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (hrgoEntities1 db = new hrgoEntities1())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Candidatoes.Attach(model);
                    db.Candidatoes.Remove(model);
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

        private void dgvCandidato_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
            if (model.IdCandidato != 0)
            {
                CapacitacionesForm capacitacionesForm = new CapacitacionesForm(model.IdCandidato);

                capacitacionesForm.Show();
            }
            else {
                MessageBox.Show("Debe seleccionar un candidato para agregar Capacitaciones");
            }
            
        }

        private void btnCompetencia_Click(object sender, EventArgs e)
        {
            if (model.IdCandidato != 0)
            {
               CompetenciasForm competenciasForm = new CompetenciasForm(model.IdCandidato);
                competenciasForm.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un candidato para agregar Competencias");
            }

        }

        private void btnExperiencia_Click(object sender, EventArgs e)
        {
            if (model.IdCandidato != 0)
            {
                ExperienciasForm experienciasForm = new ExperienciasForm(model.IdCandidato);
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

        private void btnContratar_Click(object sender, EventArgs e)
        {
            using (hrgoEntities1 db = new hrgoEntities1())
            {
                bool exists = db.Empleadoes.Any(x => x.Cedula == model.Cedula);

                if (exists)
                {
                    MessageBox.Show("Este Candidato ya ha sido contratado");
                }
                else {
                    Empleadoes empleado = new Empleadoes();
                    empleado.Cedula = model.Cedula;
                    empleado.Nombre = model.Nombre;
                    empleado.Puesto_IdPuesto = model.Puesto_IdPuesto;
                    empleado.Departamento_IdDepartamento = model.Departamento_IdDepartamento;
                    empleado.Salario = model.SalarioDeseado;
                    empleado.FechaIngreso = DateTime.Now;
                    empleado.Estado = true;

                    db.Empleadoes.Add(empleado);

                    db.SaveChanges();
                    LlenarDataGridView();
                    Clear();
                    MessageBox.Show("Candidato contratado");
                }


            }
            
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
