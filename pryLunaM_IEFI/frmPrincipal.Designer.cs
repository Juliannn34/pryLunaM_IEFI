namespace pryLunaM_IEFI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuarioIniciado = new System.Windows.Forms.Label();
            this.lblCargoIniciado = new System.Windows.Forms.Label();
            this.lblFechaDeIngreso = new System.Windows.Forms.Label();
            this.pnlAuditoria = new System.Windows.Forms.Panel();
            this.timerTiempoTrabajo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.cerrar_sesion;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Checked = true;
            this.tareasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTareasToolStripMenuItem,
            this.listarTareasToolStripMenuItem});
            this.tareasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tareasToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.Tareas____1_;
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.tareasToolStripMenuItem.Text = "Tareas...";
            // 
            // registrarTareasToolStripMenuItem
            // 
            this.registrarTareasToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.Agregar_Tarea;
            this.registrarTareasToolStripMenuItem.Name = "registrarTareasToolStripMenuItem";
            this.registrarTareasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.registrarTareasToolStripMenuItem.Text = "Registrar Tareas...";
            this.registrarTareasToolStripMenuItem.Click += new System.EventHandler(this.registrarTareasToolStripMenuItem_Click);
            // 
            // listarTareasToolStripMenuItem
            // 
            this.listarTareasToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.Listar_Tarea;
            this.listarTareasToolStripMenuItem.Name = "listarTareasToolStripMenuItem";
            this.listarTareasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listarTareasToolStripMenuItem.Text = "Listar Tareas...";
            this.listarTareasToolStripMenuItem.Click += new System.EventHandler(this.listarTareasToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.administraciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.administraciónToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.Administracion;
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.administraciónToolStripMenuItem.Text = "Administración...";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.Agregar_Usuario;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios...";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Image = global::pryLunaM_IEFI.Properties.Resources.Auditoria;
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.auditoriaToolStripMenuItem.Text = "Auditoria...";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // lblUsuarioIniciado
            // 
            this.lblUsuarioIniciado.AutoSize = true;
            this.lblUsuarioIniciado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioIniciado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarioIniciado.Location = new System.Drawing.Point(21, 415);
            this.lblUsuarioIniciado.Name = "lblUsuarioIniciado";
            this.lblUsuarioIniciado.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioIniciado.TabIndex = 1;
            this.lblUsuarioIniciado.Text = "Usuario";
            // 
            // lblCargoIniciado
            // 
            this.lblCargoIniciado.AutoSize = true;
            this.lblCargoIniciado.BackColor = System.Drawing.Color.Transparent;
            this.lblCargoIniciado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCargoIniciado.Location = new System.Drawing.Point(126, 415);
            this.lblCargoIniciado.Name = "lblCargoIniciado";
            this.lblCargoIniciado.Size = new System.Drawing.Size(35, 13);
            this.lblCargoIniciado.TabIndex = 2;
            this.lblCargoIniciado.Text = "Cargo";
            // 
            // lblFechaDeIngreso
            // 
            this.lblFechaDeIngreso.AutoSize = true;
            this.lblFechaDeIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDeIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaDeIngreso.Location = new System.Drawing.Point(637, 415);
            this.lblFechaDeIngreso.Name = "lblFechaDeIngreso";
            this.lblFechaDeIngreso.Size = new System.Drawing.Size(74, 13);
            this.lblFechaDeIngreso.TabIndex = 3;
            this.lblFechaDeIngreso.Text = "Fecha ingreso";
            // 
            // pnlAuditoria
            // 
            this.pnlAuditoria.BackColor = System.Drawing.Color.Transparent;
            this.pnlAuditoria.Location = new System.Drawing.Point(0, 0);
            this.pnlAuditoria.Name = "pnlAuditoria";
            this.pnlAuditoria.Size = new System.Drawing.Size(800, 452);
            this.pnlAuditoria.TabIndex = 4;
            this.pnlAuditoria.MouseLeave += new System.EventHandler(this.pnlAuditoria_MouseLeave);
            this.pnlAuditoria.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAuditoria_MouseMove);
            // 
            // timerTiempoTrabajo
            // 
            this.timerTiempoTrabajo.Tick += new System.EventHandler(this.timerTiempoTrabajo_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryLunaM_IEFI.Properties.Resources._1_fseafaww1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAuditoria);
            this.Controls.Add(this.lblFechaDeIngreso);
            this.Controls.Add(this.lblCargoIniciado);
            this.Controls.Add(this.lblUsuarioIniciado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuarioIniciado;
        private System.Windows.Forms.Label lblCargoIniciado;
        private System.Windows.Forms.Label lblFechaDeIngreso;
        private System.Windows.Forms.Panel pnlAuditoria;
        private System.Windows.Forms.Timer timerTiempoTrabajo;
        private System.Windows.Forms.ToolStripMenuItem registrarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}