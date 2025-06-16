namespace pryLunaM_IEFI
{
    partial class frmListarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarTarea));
            this.dgvListarTarea = new System.Windows.Forms.DataGridView();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnUltminoAgregado = new System.Windows.Forms.Button();
            this.btnBuscarTipoTarea = new System.Windows.Forms.Button();
            this.cmBuscarTipoTarea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarTarea
            // 
            this.dgvListarTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTarea.Location = new System.Drawing.Point(49, 29);
            this.dgvListarTarea.Name = "dgvListarTarea";
            this.dgvListarTarea.Size = new System.Drawing.Size(689, 286);
            this.dgvListarTarea.TabIndex = 0;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerTodo.Location = new System.Drawing.Point(525, 381);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(119, 57);
            this.btnVerTodo.TabIndex = 1;
            this.btnVerTodo.Text = "Ver Todo";
            this.btnVerTodo.UseVisualStyleBackColor = false;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnUltminoAgregado
            // 
            this.btnUltminoAgregado.Location = new System.Drawing.Point(669, 381);
            this.btnUltminoAgregado.Name = "btnUltminoAgregado";
            this.btnUltminoAgregado.Size = new System.Drawing.Size(119, 57);
            this.btnUltminoAgregado.TabIndex = 2;
            this.btnUltminoAgregado.Text = "Ver Ultimo Agregado";
            this.btnUltminoAgregado.UseVisualStyleBackColor = true;
            this.btnUltminoAgregado.Click += new System.EventHandler(this.btnUltminoAgregado_Click);
            // 
            // btnBuscarTipoTarea
            // 
            this.btnBuscarTipoTarea.Location = new System.Drawing.Point(154, 381);
            this.btnBuscarTipoTarea.Name = "btnBuscarTipoTarea";
            this.btnBuscarTipoTarea.Size = new System.Drawing.Size(119, 57);
            this.btnBuscarTipoTarea.TabIndex = 3;
            this.btnBuscarTipoTarea.Text = "Buscar Por tipo de Tarea";
            this.btnBuscarTipoTarea.UseVisualStyleBackColor = true;
            this.btnBuscarTipoTarea.Click += new System.EventHandler(this.btnBuscarTipoTarea_Click);
            // 
            // cmBuscarTipoTarea
            // 
            this.cmBuscarTipoTarea.FormattingEnabled = true;
            this.cmBuscarTipoTarea.Location = new System.Drawing.Point(12, 400);
            this.cmBuscarTipoTarea.Name = "cmBuscarTipoTarea";
            this.cmBuscarTipoTarea.Size = new System.Drawing.Size(121, 21);
            this.cmBuscarTipoTarea.TabIndex = 4;
            // 
            // frmListarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmBuscarTipoTarea);
            this.Controls.Add(this.btnBuscarTipoTarea);
            this.Controls.Add(this.btnUltminoAgregado);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.dgvListarTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Tareas";
            this.Load += new System.EventHandler(this.frmListarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarTarea;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnUltminoAgregado;
        private System.Windows.Forms.Button btnBuscarTipoTarea;
        private System.Windows.Forms.ComboBox cmBuscarTipoTarea;
    }
}