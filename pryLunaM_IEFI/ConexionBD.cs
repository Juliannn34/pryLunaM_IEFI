using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaM_IEFI
{
    internal class ConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=IEFI;Trusted_Connection=True;";

        //conector
        SqlConnection coneccionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;


        public string nombreBaseDeDatos;


        //Conectar a la base de datos
        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }


        //-----------------------------------------------------------------------------------

        //Tabla Usuarios//


        //obtener datos de la tabla productos
        public DataTable ObtenerUsuarios()
        {
            DataTable tablaUsuarios = new DataTable();

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "SELECT * FROM Usuarios";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccionBaseDatos);
                    adaptador.Fill(tablaUsuarios);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener Usuario: " + error.Message);
            }

            return tablaUsuarios;
        }
        public void AgregarUsuario(clsUsuarios usuario)
        {
            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "INSERT INTO Usuarios (Nombre, Contraseña, Categoria) " +
                                      "VALUES (@Nombre, @Contraseña, @Categoria)";

                    using (comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos))
                    {
                        comandoBaseDatos.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comandoBaseDatos.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                        comandoBaseDatos.Parameters.AddWithValue("@Categoria", usuario.Categoria);

                        comandoBaseDatos.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar usuario: " + error.Message);
            }
        }

    }
}
