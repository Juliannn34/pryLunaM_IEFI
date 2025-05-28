namespace pryLunaM_IEFI
{
    partial class frmGestionUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtCalleHogar = new System.Windows.Forms.TextBox();
            this.lblCalleHogar = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnRecargarGrilla = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(469, 22);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(800, 514);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargarGrilla);
            this.groupBox1.Controls.Add(this.btnLimpiarCampos);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.btnBuscarId);
            this.groupBox1.Controls.Add(this.lblSueldo);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblEstadoCivil);
            this.groupBox1.Controls.Add(this.txtCalleHogar);
            this.groupBox1.Controls.Add(this.lblCalleHogar);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbCargo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 539);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestionar Usuario";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(162, 428);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(188, 42);
            this.txtSueldo.TabIndex = 20;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.Location = new System.Drawing.Point(259, 24);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(162, 35);
            this.btnBuscarId.TabIndex = 19;
            this.btnBuscarId.Text = "Buscar ID";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(22, 428);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(87, 43);
            this.lblSueldo.TabIndex = 18;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(162, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(82, 42);
            this.txtId.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(22, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(48, 43);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(6, 366);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(137, 43);
            this.lblEstadoCivil.TabIndex = 12;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtCalleHogar
            // 
            this.txtCalleHogar.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleHogar.Location = new System.Drawing.Point(165, 307);
            this.txtCalleHogar.Name = "txtCalleHogar";
            this.txtCalleHogar.Size = new System.Drawing.Size(188, 42);
            this.txtCalleHogar.TabIndex = 11;
            // 
            // lblCalleHogar
            // 
            this.lblCalleHogar.AutoSize = true;
            this.lblCalleHogar.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalleHogar.Location = new System.Drawing.Point(6, 306);
            this.lblCalleHogar.Name = "lblCalleHogar";
            this.lblCalleHogar.Size = new System.Drawing.Size(126, 43);
            this.lblCalleHogar.TabIndex = 10;
            this.lblCalleHogar.Text = "CalleHogar:";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(165, 250);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(188, 42);
            this.txtDNI.TabIndex = 9;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(165, 366);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(188, 42);
            this.cmbEstadoCivil.TabIndex = 8;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(17, 250);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(63, 43);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(17, 192);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(78, 43);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(165, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(188, 42);
            this.txtContraseña.TabIndex = 5;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(14, 133);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(129, 43);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(165, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 42);
            this.txtNombre.TabIndex = 3;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(165, 192);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(188, 42);
            this.cmbCargo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 43);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(19, 587);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(162, 35);
            this.btnEliminarUsuario.TabIndex = 8;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(187, 587);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(162, 35);
            this.btnModificarUsuario.TabIndex = 7;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(355, 587);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(162, 35);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnRecargarGrilla
            // 
            this.btnRecargarGrilla.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarGrilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargarGrilla.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargarGrilla.Image = global::pryLunaM_IEFI.Properties.Resources.Recargar_2;
            this.btnRecargarGrilla.Location = new System.Drawing.Point(181, 495);
            this.btnRecargarGrilla.Name = "btnRecargarGrilla";
            this.btnRecargarGrilla.Size = new System.Drawing.Size(40, 38);
            this.btnRecargarGrilla.TabIndex = 21;
            this.btnRecargarGrilla.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Image = global::pryLunaM_IEFI.Properties.Resources.LimpiarCampos;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(6, 495);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(169, 38);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1_fseafaww1.jpg");
            this.imageList1.Images.SetKeyName(1, "11_aswasdas1.jpg");
            this.imageList1.Images.SetKeyName(2, "abstract-view-modern-architecture.jpg");
            this.imageList1.Images.SetKeyName(3, "add_8532597.png");
            this.imageList1.Images.SetKeyName(4, "add-button_10703134.png");
            this.imageList1.Images.SetKeyName(5, "ContraseñaVisible.png.png");
            this.imageList1.Images.SetKeyName(6, "creativity_7407522.png");
            this.imageList1.Images.SetKeyName(7, "delete_6861362.png");
            this.imageList1.Images.SetKeyName(8, "duplicate_12108396.png");
            this.imageList1.Images.SetKeyName(9, "edit_8273154.png");
            this.imageList1.Images.SetKeyName(10, "Ejemplo de grafo 1.png");
            this.imageList1.Images.SetKeyName(11, "Ejemplo de grafo 2.jpg");
            this.imageList1.Images.SetKeyName(12, "email_16513874.png");
            this.imageList1.Images.SetKeyName(13, "engineering_18642986.png");
            this.imageList1.Images.SetKeyName(14, "freepik__upload__41513.png");
            this.imageList1.Images.SetKeyName(15, "geometria-3d_3840x2160_xtrafondos.com.jpg");
            this.imageList1.Images.SetKeyName(16, "Icono de luna 1.ico");
            this.imageList1.Images.SetKeyName(17, "Icono de luna 2.ico");
            this.imageList1.Images.SetKeyName(18, "LimpiarCampos.png");
            this.imageList1.Images.SetKeyName(19, "luca-bravo-g_LG9LGyTk8-unsplash.jpg");
            this.imageList1.Images.SetKeyName(20, "ondas-azules_5120x2880_xtrafondos.com.jpg");
            this.imageList1.Images.SetKeyName(21, "pencil_10296476.png");
            this.imageList1.Images.SetKeyName(22, "Recargar 2.png");
            this.imageList1.Images.SetKeyName(23, "refresh 1.png");
            this.imageList1.Images.SetKeyName(24, "Reprecentacion de una Cola.jpg");
            this.imageList1.Images.SetKeyName(25, "Reprecentacion de una Pila.jpg");
            this.imageList1.Images.SetKeyName(26, "Representacion de Listas Simples Entrelazadas.jpg");
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Name = "frmGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtCalleHogar;
        private System.Windows.Forms.Label lblCalleHogar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnRecargarGrilla;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ImageList imageList1;
    }
}