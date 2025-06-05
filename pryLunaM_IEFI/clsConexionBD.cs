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
    internal class clsConexionBD
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

                    string consulta = @"INSERT INTO Usuarios 
                               (Nombre, Contraseña, Cargo, DNI, CalleHogar, EstadoCivil, Sueldo) 
                                VALUES 
                               (@Nombre, @Contraseña, @Cargo, @DNI, @CalleHogar, @EstadoCivil, @Sueldo)";

                    using (comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos))
                    {
                        comandoBaseDatos.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comandoBaseDatos.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                        comandoBaseDatos.Parameters.AddWithValue("@Cargo", usuario.Cargo);
                        comandoBaseDatos.Parameters.AddWithValue("@DNI", usuario.DNI);
                        comandoBaseDatos.Parameters.AddWithValue("@CalleHogar", usuario.CalleHogar);
                        comandoBaseDatos.Parameters.AddWithValue("@EstadoCivil", usuario.EstadoCivil);
                        comandoBaseDatos.Parameters.AddWithValue("@Sueldo", usuario.Sueldo);

                        comandoBaseDatos.ExecuteNonQuery();
                        MessageBox.Show("Usuario agregado correctamente.");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar usuario: " + error.Message);
            }
        }


        public bool ModificarUsuario(clsUsuarios usuario)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Usuarios SET Nombre = @Nombre, Contraseña = @Contraseña, Cargo = @Cargo, DNI = @DNI, CalleHogar = @CalleHogar, EstadoCivil = @EstadoCivil, Sueldo = @Sueldo WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Cargo", usuario.Cargo);
                cmd.Parameters.AddWithValue("@DNI", usuario.DNI);
                cmd.Parameters.AddWithValue("@CalleHogar", usuario.CalleHogar);
                cmd.Parameters.AddWithValue("@EstadoCivil", usuario.EstadoCivil);
                cmd.Parameters.AddWithValue("@Sueldo", usuario.Sueldo);
                cmd.Parameters.AddWithValue("@ID", usuario.Id);

                conn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "DELETE FROM Usuarios WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void BuscarUsuarioPorID(int id, TextBox txtNombre, TextBox txtContraseña, ComboBox cmbCargo, TextBox txtDNI, TextBox txtCalle, ComboBox cmbEstadoCivil, TextBox txtSueldo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = "SELECT * FROM Usuarios WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtContraseña.Text = reader["Contraseña"].ToString();
                            txtDNI.Text = reader["DNI"].ToString();
                            txtCalle.Text = reader["CalleHogar"] != DBNull.Value ? reader["CalleHogar"].ToString() : ""; // Para evitar errores si es NULL
                            txtSueldo.Text = reader["Sueldo"].ToString();

                            // Estos se asignan con .Text en lugar de .SelectedItem
                            cmbCargo.Text = reader["Cargo"].ToString();
                            cmbEstadoCivil.Text = reader["EstadoCivil"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un usuario con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable ObtenerCargos()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT DISTINCT Cargo FROM Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable ObtenerEstadoCivil()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT DISTINCT EstadoCivil FROM Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }




        //-----------------------------------------------------------------------------------

        //Tabla Tareas//


        public DataTable ObtenerTareas()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();

                    string consulta = @"
                        SELECT 
                            tt.Nombre AS Tarea, 
                            t.Fecha AS Fecha, 
                            l.Nombre AS Lugar
                        FROM Tareas t
                        INNER JOIN TipoTarea tt ON t.TipoTareaID = tt.ID
                        INNER JOIN Lugar l ON t.LugarID = l.ID";

                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tareas: " + ex.Message);
            }

            return tabla;
        }

        public void AgregarTarea(clsTareas tarea)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = @"INSERT INTO Tareas 
                            (TipoTareaID, Fecha, LugarID, 
                             UniformeInsumo, LicenciaEstudio, LicenciaVacaciones, 
                             ReclamoSalario, ReclamoRecibo, Comentario) 
                             VALUES 
                            (@TipoTareaID, @Fecha, @LugarID, 
                             @UniformeInsumo, @LicenciaEstudio, @LicenciaVacaciones, 
                             @ReclamoSalario, @ReclamoRecibo, @Comentario)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TipoTareaID", tarea.TipoTareaID);
                        cmd.Parameters.AddWithValue("@Fecha", tarea.Fecha);
                        cmd.Parameters.AddWithValue("@LugarID", tarea.LugarID);
                        cmd.Parameters.AddWithValue("@UniformeInsumo", tarea.UniformeInsumo);
                        cmd.Parameters.AddWithValue("@LicenciaEstudio", tarea.LicenciaEstudio);
                        cmd.Parameters.AddWithValue("@LicenciaVacaciones", tarea.LicenciaVacaciones);
                        cmd.Parameters.AddWithValue("@ReclamoSalario", tarea.ReclamoSalario);
                        cmd.Parameters.AddWithValue("@ReclamoRecibo", tarea.ReclamoRecibo);
                        cmd.Parameters.AddWithValue("@Comentario", string.IsNullOrEmpty(tarea.Comentario) ? DBNull.Value : (object)tarea.Comentario);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tarea agendada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agendar la tarea: " + ex.Message);
            }
        }







        //-----------------------------------------------------------------------------------


        public DataTable ObtenerDatosDeTablaTipoTareas()
        {
            DataTable tablaTipoTarea = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Nombre, Nombre FROM TipoTarea";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tablaTipoTarea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }

            return tablaTipoTarea;
        }

        public DataTable ObtenerDatosDeTablaLugares()
        {
            DataTable tablaLugar = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Nombre, Nombre FROM Lugar";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tablaLugar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }

            return tablaLugar;
        }


        //-----------------------------------------------------------------------------------

    }
}
