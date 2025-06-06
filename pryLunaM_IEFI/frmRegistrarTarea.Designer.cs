namespace pryLunaM_IEFI
{
    partial class frmRegistrarTarea
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.lblTarea = new System.Windows.Forms.Label();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.dgvTarea = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkReclamoRecibo = new System.Windows.Forms.CheckBox();
            this.chkReclamoSalario = new System.Windows.Forms.CheckBox();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.chkLicenciaVacaciones = new System.Windows.Forms.CheckBox();
            this.chkLicenciaEstudio = new System.Windows.Forms.CheckBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.lblElegirTarea = new System.Windows.Forms.Label();
            this.cmbElegirTarea = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(218, 127);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(143, 29);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(294, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(350, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(149, 67);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbTarea.TabIndex = 3;
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(24, 67);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(77, 13);
            this.lblTarea.TabIndex = 4;
            this.lblTarea.Text = "Tipo de Tarea:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(350, 64);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 21);
            this.cmbLugar.TabIndex = 6;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(294, 67);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 5;
            this.lblLugar.Text = "Lugar:";
            // 
            // dgvTarea
            // 
            this.dgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarea.Location = new System.Drawing.Point(96, 174);
            this.dgvTarea.Name = "dgvTarea";
            this.dgvTarea.Size = new System.Drawing.Size(445, 124);
            this.dgvTarea.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cmbElegirTarea);
            this.groupBox1.Controls.Add(this.lblElegirTarea);
            this.groupBox1.Controls.Add(this.chkReclamoRecibo);
            this.groupBox1.Controls.Add(this.chkReclamoSalario);
            this.groupBox1.Controls.Add(this.lblReclamo);
            this.groupBox1.Controls.Add(this.chkLicenciaVacaciones);
            this.groupBox1.Controls.Add(this.chkLicenciaEstudio);
            this.groupBox1.Controls.Add(this.lblLicencia);
            this.groupBox1.Controls.Add(this.chkInsumo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(39, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // chkReclamoRecibo
            // 
            this.chkReclamoRecibo.AutoSize = true;
            this.chkReclamoRecibo.Location = new System.Drawing.Point(337, 105);
            this.chkReclamoRecibo.Name = "chkReclamoRecibo";
            this.chkReclamoRecibo.Size = new System.Drawing.Size(60, 17);
            this.chkReclamoRecibo.TabIndex = 18;
            this.chkReclamoRecibo.Text = "Recibo";
            this.chkReclamoRecibo.UseVisualStyleBackColor = true;
            // 
            // chkReclamoSalario
            // 
            this.chkReclamoSalario.AutoSize = true;
            this.chkReclamoSalario.Location = new System.Drawing.Point(273, 106);
            this.chkReclamoSalario.Name = "chkReclamoSalario";
            this.chkReclamoSalario.Size = new System.Drawing.Size(58, 17);
            this.chkReclamoSalario.TabIndex = 16;
            this.chkReclamoSalario.Text = "Salario";
            this.chkReclamoSalario.UseVisualStyleBackColor = true;
            // 
            // lblReclamo
            // 
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.Location = new System.Drawing.Point(211, 106);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(52, 13);
            this.lblReclamo.TabIndex = 15;
            this.lblReclamo.Text = "Reclamo:";
            // 
            // chkLicenciaVacaciones
            // 
            this.chkLicenciaVacaciones.AutoSize = true;
            this.chkLicenciaVacaciones.Location = new System.Drawing.Point(337, 64);
            this.chkLicenciaVacaciones.Name = "chkLicenciaVacaciones";
            this.chkLicenciaVacaciones.Size = new System.Drawing.Size(82, 17);
            this.chkLicenciaVacaciones.TabIndex = 14;
            this.chkLicenciaVacaciones.Text = "Vacaciones";
            this.chkLicenciaVacaciones.UseVisualStyleBackColor = true;
            // 
            // chkLicenciaEstudio
            // 
            this.chkLicenciaEstudio.AutoSize = true;
            this.chkLicenciaEstudio.Location = new System.Drawing.Point(273, 65);
            this.chkLicenciaEstudio.Name = "chkLicenciaEstudio";
            this.chkLicenciaEstudio.Size = new System.Drawing.Size(61, 17);
            this.chkLicenciaEstudio.TabIndex = 12;
            this.chkLicenciaEstudio.Text = "Estudio";
            this.chkLicenciaEstudio.UseVisualStyleBackColor = true;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(211, 65);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(50, 13);
            this.lblLicencia.TabIndex = 11;
            this.lblLicencia.Text = "Licencia:";
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(273, 31);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(60, 17);
            this.chkInsumo.TabIndex = 10;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uniforme:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(163, 608);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(312, 608);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(143, 29);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(78, 486);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(463, 94);
            this.txtComentario.TabIndex = 11;
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Location = new System.Drawing.Point(24, 30);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(104, 13);
            this.lblNombreTarea.TabIndex = 12;
            this.lblNombreTarea.Text = "Nombre de la Tarea:";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(149, 27);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(121, 20);
            this.txtNombreTarea.TabIndex = 13;
            // 
            // lblElegirTarea
            // 
            this.lblElegirTarea.AutoSize = true;
            this.lblElegirTarea.Location = new System.Drawing.Point(36, 33);
            this.lblElegirTarea.Name = "lblElegirTarea";
            this.lblElegirTarea.Size = new System.Drawing.Size(67, 13);
            this.lblElegirTarea.TabIndex = 14;
            this.lblElegirTarea.Text = "Elegir Tarea:";
            // 
            // cmbElegirTarea
            // 
            this.cmbElegirTarea.FormattingEnabled = true;
            this.cmbElegirTarea.Location = new System.Drawing.Point(39, 60);
            this.cmbElegirTarea.Name = "cmbElegirTarea";
            this.cmbElegirTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbElegirTarea.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(374, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Vacaciones";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 659);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.lblNombreTarea);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTarea);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.cmbTarea);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.DataGridView dgvTarea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkReclamoRecibo;
        private System.Windows.Forms.CheckBox chkReclamoSalario;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.CheckBox chkLicenciaVacaciones;
        private System.Windows.Forms.CheckBox chkLicenciaEstudio;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label lblElegirTarea;
        private System.Windows.Forms.ComboBox cmbElegirTarea;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}