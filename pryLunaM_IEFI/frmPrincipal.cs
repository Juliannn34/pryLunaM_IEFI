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
    public partial class frmPrincipal : Form
    {
        private clsUsuarios usuarioLogueado;
        private DateTime fechaInicio;

        private int auditoriaID; // el ID generado en la tabla AuditoriaUsuarios
        private Dictionary<Point, int> mapaCoordenadas = new Dictionary<Point, int>();

        public frmPrincipal(clsUsuarios usuario, DateTime inicio)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            fechaInicio = inicio;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pnlAuditoria.SendToBack();
            lblUsuarioIniciado.Text = "Usuario: " + usuarioLogueado.Nombre;
            lblCargoIniciado.Text = "Cargo: " + usuarioLogueado.Cargo;
            lblFechaDeIngreso.Text = "Inicio: " + fechaInicio.ToString("dd/MM/yyyy HH:mm");


           InsertarAuditoriaInicio(usuarioLogueado.Nombre, fechaInicio); 


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionUsuarios UsuariosVentana = new frmGestionUsuarios();
            UsuariosVentana.ShowDialog();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria AuditoriaVentana = new frmAuditoria(usuarioLogueado);
            AuditoriaVentana.ShowDialog();
        }


        //-----------------------------------------CODIGO AUDITORIA------------------------------------------------------------


        private void pnlAuditoria_MouseMove(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);

            if (mapaCoordenadas.ContainsKey(punto))
                mapaCoordenadas[punto]++;
            else
                mapaCoordenadas[punto] = 1;
        }

        private void pnlAuditoria_MouseLeave(object sender, EventArgs e)
        {
            timerTiempoTrabajo.Enabled = false;    
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime finSesion = DateTime.Now;

            Point coordenadaMasVisitada = mapaCoordenadas
                .OrderByDescending(c => c.Value)
                .FirstOrDefault().Key;

            ActualizarAuditoriaFinal(auditoriaID, finSesion, coordenadaMasVisitada);
        }


        private void timerTiempoTrabajo_Tick(object sender, EventArgs e)
        {

        }

        private void InsertarAuditoriaInicio(string nombreUsuario, DateTime inicio)
        {
            string conexion = "Server=localhost;Database=IEFI;Trusted_Connection=True;";
            string sql = "INSERT INTO AuditoriaUsuarios (NombreUsuario, FechaHoraInicio) OUTPUT INSERTED.ID VALUES (@NombreUsuario, @FechaHoraInicio)";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@FechaHoraInicio", inicio);

                    auditoriaID = (int)cmd.ExecuteScalar(); // Guarda el ID generado
                }
            }
        }


        private void ActualizarAuditoriaFinal(int auditoriaId, DateTime fin, Point coord)
        {
            string conexion = "Server=localhost;Database=IEFI;Trusted_Connection=True;";
            string sql = "UPDATE AuditoriaUsuarios SET FechaHoraFin = @Fin, CoordenadaX = @X, CoordenadaY = @Y WHERE ID = @ID";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fin", fin);
                    cmd.Parameters.AddWithValue("@X", coord.X);
                    cmd.Parameters.AddWithValue("@Y", coord.Y);
                    cmd.Parameters.AddWithValue("@ID", auditoriaId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        

        //---------------------------------------------------------------------------------------------------------------------

    }
}
