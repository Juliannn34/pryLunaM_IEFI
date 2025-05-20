using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaM_IEFI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionUsuarios UsuariosVentana = new frmGestionUsuarios();
            UsuariosVentana.Show();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
