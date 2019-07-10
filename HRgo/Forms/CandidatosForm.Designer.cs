namespace HRgo.Forms
{
    partial class CandidatosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCandidato = new System.Windows.Forms.DataGridView();
            this.IdCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioDeseado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recomendador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtRecomend = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCapacitaciones = new System.Windows.Forms.Button();
            this.btnCompetencia = new System.Windows.Forms.Button();
            this.btnExperiencia = new System.Windows.Forms.Button();
            this.btnContratar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Salario al que aspira";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre";
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCandidato,
            this.Nombre,
            this.Cedula,
            this.SalarioDeseado,
            this.Recomendador});
            this.dgvCandidato.Location = new System.Drawing.Point(480, 42);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.ReadOnly = true;
            this.dgvCandidato.Size = new System.Drawing.Size(734, 229);
            this.dgvCandidato.TabIndex = 42;
            this.dgvCandidato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidato_CellContentClick_1);
            this.dgvCandidato.DoubleClick += new System.EventHandler(this.dgvCandidato_DoubleClick);
            // 
            // IdCandidato
            // 
            this.IdCandidato.DataPropertyName = "IdCandidato";
            this.IdCandidato.HeaderText = "Id";
            this.IdCandidato.Name = "IdCandidato";
            this.IdCandidato.ReadOnly = true;
            this.IdCandidato.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // SalarioDeseado
            // 
            this.SalarioDeseado.DataPropertyName = "SalarioDeseado";
            this.SalarioDeseado.HeaderText = "SalarioDeseado";
            this.SalarioDeseado.Name = "SalarioDeseado";
            this.SalarioDeseado.ReadOnly = true;
            // 
            // Recomendador
            // 
            this.Recomendador.DataPropertyName = "Recomendador";
            this.Recomendador.HeaderText = "Recomendador";
            this.Recomendador.Name = "Recomendador";
            this.Recomendador.ReadOnly = true;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(152, 181);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 20);
            this.txtSal.TabIndex = 40;
            this.txtSal.TextChanged += new System.EventHandler(this.txtSal_TextChanged);
            this.txtSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeric_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(158, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(153, 98);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Puesto";
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(153, 126);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(121, 21);
            this.cbPuesto.TabIndex = 47;
            this.cbPuesto.SelectedIndexChanged += new System.EventHandler(this.cbPuesto_SelectedIndexChanged);
            this.cbPuesto.SelectedValueChanged += new System.EventHandler(this.cbPuesto_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(153, 152);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cbDepartamento.TabIndex = 47;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbPuesto_SelectedIndexChanged);
            this.cbDepartamento.SelectedValueChanged += new System.EventHandler(this.cbPuesto_SelectedValueChanged);
            // 
            // txtRecomend
            // 
            this.txtRecomend.Location = new System.Drawing.Point(152, 222);
            this.txtRecomend.Name = "txtRecomend";
            this.txtRecomend.Size = new System.Drawing.Size(100, 20);
            this.txtRecomend.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Recomendado Por";
            // 
            // btnCapacitaciones
            // 
            this.btnCapacitaciones.Location = new System.Drawing.Point(480, 331);
            this.btnCapacitaciones.Name = "btnCapacitaciones";
            this.btnCapacitaciones.Size = new System.Drawing.Size(136, 23);
            this.btnCapacitaciones.TabIndex = 38;
            this.btnCapacitaciones.Text = "Capacitaciones";
            this.btnCapacitaciones.UseVisualStyleBackColor = true;
            this.btnCapacitaciones.Click += new System.EventHandler(this.btnCapacitaciones_Click);
            // 
            // btnCompetencia
            // 
            this.btnCompetencia.Location = new System.Drawing.Point(717, 331);
            this.btnCompetencia.Name = "btnCompetencia";
            this.btnCompetencia.Size = new System.Drawing.Size(136, 23);
            this.btnCompetencia.TabIndex = 38;
            this.btnCompetencia.Text = "Competencias";
            this.btnCompetencia.UseVisualStyleBackColor = true;
            this.btnCompetencia.Click += new System.EventHandler(this.btnCompetencia_Click);
            // 
            // btnExperiencia
            // 
            this.btnExperiencia.Location = new System.Drawing.Point(915, 331);
            this.btnExperiencia.Name = "btnExperiencia";
            this.btnExperiencia.Size = new System.Drawing.Size(136, 23);
            this.btnExperiencia.TabIndex = 38;
            this.btnExperiencia.Text = "Experiencias Laborales";
            this.btnExperiencia.UseVisualStyleBackColor = true;
            this.btnExperiencia.Click += new System.EventHandler(this.btnExperiencia_Click);
            // 
            // btnContratar
            // 
            this.btnContratar.Location = new System.Drawing.Point(35, 24);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(75, 23);
            this.btnContratar.TabIndex = 36;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // CandidatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HRgo.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(1286, 749);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCandidato);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtRecomend);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExperiencia);
            this.Controls.Add(this.btnCompetencia);
            this.Controls.Add(this.btnCapacitaciones);
            this.Controls.Add(this.btnSave);
            this.Name = "CandidatosForm";
            this.Text = "CandidatosForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCandidato;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.TextBox txtRecomend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCapacitaciones;
        private System.Windows.Forms.Button btnCompetencia;
        private System.Windows.Forms.Button btnExperiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioDeseado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recomendador;
        private System.Windows.Forms.Button btnContratar;
    }
}