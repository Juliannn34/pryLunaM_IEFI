using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaM_IEFI
{
    public partial class frmAuditoria : Form
    {

        private clsUsuarios usuarioLogueado;


        public frmAuditoria(clsUsuarios usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado.Cargo != "Administrador")
            {
                btnAuditar.Enabled = false;
                MessageBox.Show("Solo los administradores pueden acceder a esta funcionalidad.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=localhost;Database=IEFI;Trusted_Connection=True;";
            string consulta = "SELECT NombreUsuario, FechaHoraInicio, FechaHoraFin, CoordenadaX, CoordenadaY FROM AuditoriaUsuarios";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvAuditar.DataSource = tabla;
                }
            }
        }

        
    }
}
