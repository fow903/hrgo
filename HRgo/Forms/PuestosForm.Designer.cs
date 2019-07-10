namespace HRgo.Forms
{
    partial class PuestosForm
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
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPuesto = new System.Windows.Forms.DataGridView();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalMax = new System.Windows.Forms.NumericUpDown();
            this.txtSalMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalMin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Alto",
            "Medio",
            "Bajo"});
            this.cbNivel.Location = new System.Drawing.Point(119, 101);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(121, 21);
            this.cbNivel.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nivel De Riesgo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // dgvPuesto
            // 
            this.dgvPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPuesto,
            this.Nombre,
            this.NivelDeRiesgo,
            this.SalarioMin,
            this.SalarioMax,
            this.Estado});
            this.dgvPuesto.Location = new System.Drawing.Point(358, 55);
            this.dgvPuesto.Name = "dgvPuesto";
            this.dgvPuesto.ReadOnly = true;
            this.dgvPuesto.Size = new System.Drawing.Size(704, 524);
            this.dgvPuesto.TabIndex = 27;
            this.dgvPuesto.DoubleClick += new System.EventHandler(this.dgvPuesto_DoubleClick);
            // 
            // IdPuesto
            // 
            this.IdPuesto.DataPropertyName = "IdPuesto";
            this.IdPuesto.HeaderText = "Id";
            this.IdPuesto.Name = "IdPuesto";
            this.IdPuesto.ReadOnly = true;
            this.IdPuesto.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NivelDeRiesgo
            // 
            this.NivelDeRiesgo.DataPropertyName = "NivelDeRiesgo";
            this.NivelDeRiesgo.HeaderText = "Nivel de Riesgo";
            this.NivelDeRiesgo.Name = "NivelDeRiesgo";
            this.NivelDeRiesgo.ReadOnly = true;
            // 
            // SalarioMin
            // 
            this.SalarioMin.DataPropertyName = "SalarioMin";
            this.SalarioMin.HeaderText = "Salario Minimo";
            this.SalarioMin.Name = "SalarioMin";
            this.SalarioMin.ReadOnly = true;
            // 
            // SalarioMax
            // 
            this.SalarioMax.DataPropertyName = "SalarioMax";
            this.SalarioMax.HeaderText = "Salario Maximo";
            this.SalarioMax.Name = "SalarioMax";
            this.SalarioMax.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 556);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(134, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.Location = new System.Drawing.Point(119, 182);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 21);
            this.txtEstado.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Salario Minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Salario Maximo";
            // 
            // txtSalMax
            // 
            this.txtSalMax.Location = new System.Drawing.Point(119, 156);
            this.txtSalMax.Name = "txtSalMax";
            this.txtSalMax.Size = new System.Drawing.Size(120, 20);
            this.txtSalMax.TabIndex = 36;
            // 
            // txtSalMin
            // 
            this.txtSalMin.Location = new System.Drawing.Point(119, 130);
            this.txtSalMin.Name = "txtSalMin";
            this.txtSalMin.Size = new System.Drawing.Size(120, 20);
            this.txtSalMin.TabIndex = 36;
            // 
            // PuestosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1175, 610);
            this.Controls.Add(this.txtSalMin);
            this.Controls.Add(this.txtSalMax);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "PuestosForm";
            this.Text = "PuestosForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPuesto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelDeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioMax;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.NumericUpDown txtSalMax;
        private System.Windows.Forms.NumericUpDown txtSalMin;
    }
}