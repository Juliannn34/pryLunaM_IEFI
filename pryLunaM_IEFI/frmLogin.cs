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
    public partial class frmLogin : Form
    {
        private clsUsuarios usuarioLogueado;
        private DateTime fechaInicio;


        public frmLogin()
        {
            InitializeComponent();

        }



       int intentosFallidos = 0;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=IEFI;Trusted_Connection=True;";
            string NombreUsuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            string query = @"
                  SELECT Id, Nombre, Contraseña, Cargo 
                   FROM Usuarios 
                   WHERE Nombre COLLATE Latin1_General_CS_AS = @nombre 
                   AND Contraseña COLLATE Latin1_General_CS_AS = @contraseña";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", NombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", Contraseña);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                       
                        clsUsuarios usuario = new clsUsuarios
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            Cargo = reader["Cargo"].ToString()
                        };

                        DateTime fechaInicio = DateTime.Now;

                   
                        this.Hide();
                        frmPrincipal principal = new frmPrincipal(usuario, fechaInicio);
                        principal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        intentosFallidos++;
                        MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentosFallidos + " de 3.");

                        if (intentosFallidos >= 3)
                        {
                            MessageBox.Show("Demasiados intentos fallidos. El formulario se cerrará.");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnContraseñaVisible_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '\0')
            {
                txtContraseña.PasswordChar = '*'; // Ocultar contraseña
            }
            else
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar contraseña
            }
        }
    }
}
