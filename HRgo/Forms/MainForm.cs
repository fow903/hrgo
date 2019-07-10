using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRgo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CandidatosForm candidatosForm = new CandidatosForm();

            candidatosForm.Show();
            candidatosForm.MdiParent = this;
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentosForm departamentosForm = new DepartamentosForm();

            departamentosForm.Show();
            departamentosForm.MdiParent = this;
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomasForm idiomasForm = new IdiomasForm();

            idiomasForm.Show();
            idiomasForm.MdiParent = this;
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuestosForm puestosForm = new PuestosForm();

            puestosForm.Show();
            puestosForm.MdiParent = this;
        }

        private void experienciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoesForm empleadosForm = new EmpleadoesForm();

            empleadosForm.Show();
            empleadosForm.MdiParent = this;
        }
    }
}
