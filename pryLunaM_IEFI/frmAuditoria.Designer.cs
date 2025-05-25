namespace pryLunaM_IEFI
{
    partial class frmAuditoria
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
            this.dgvAuditar = new System.Windows.Forms.DataGridView();
            this.btnAuditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditar
            // 
            this.dgvAuditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditar.Location = new System.Drawing.Point(37, 27);
            this.dgvAuditar.Name = "dgvAuditar";
            this.dgvAuditar.Size = new System.Drawing.Size(726, 330);
            this.dgvAuditar.TabIndex = 0;
            // 
            // btnAuditar
            // 
            this.btnAuditar.Location = new System.Drawing.Point(281, 385);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(216, 40);
            this.btnAuditar.TabIndex = 1;
            this.btnAuditar.Text = "Auditar Empleados";
            this.btnAuditar.UseVisualStyleBackColor = true;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.dgvAuditar);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditar;
        private System.Windows.Forms.Button btnAuditar;
    }
}