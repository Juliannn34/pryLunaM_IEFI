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
                                t.Nombre AS [Nombre de la Tarea],     -- Nuevo campo
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
                        (Nombre, TipoTareaID, Fecha, LugarID) 
                        VALUES 
                        (@Nombre, @TipoTareaID, @Fecha, @LugarID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", tarea.Nombre);
                        cmd.Parameters.AddWithValue("@TipoTareaID", tarea.TipoTareaID);
                        cmd.Parameters.AddWithValue("@Fecha", tarea.Fecha);
                        cmd.Parameters.AddWithValue("@LugarID", tarea.LugarID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tarea agendada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
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
                    string consulta = "SELECT ID, Nombre AS Tarea FROM TipoTarea";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tablaTipoTarea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tipo de tareas: " + ex.Message);
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
                    string consulta = "SELECT ID, Nombre AS Lugar FROM Lugar";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tablaLugar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener lugares: " + ex.Message);
            }

            return tablaLugar;
        }

        public DataTable ObtenerTareasAgendadas()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT ID, Nombre FROM Tareas";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }



        //-----------------------------------------------------------------------------------


        public bool ModificarDetallesTarea(int id, bool insumo, bool licenciaEstudio, bool licenciaVacaciones, bool reclamoSalario, bool reclamoRecibo, string comentario)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = @"UPDATE Tareas 
                            SET UniformeInsumo = @insumo,
                                LicenciaEstudio = @licenciaEstudio,
                                LicenciaVacaciones = @licenciaVacaciones,
                                ReclamoSalario = @reclamoSalario,
                                ReclamoRecibo = @reclamoRecibo,
                                Comentario = @comentario
                            WHERE ID = @id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@insumo", insumo);
                    comando.Parameters.AddWithValue("@licenciaEstudio", licenciaEstudio);
                    comando.Parameters.AddWithValue("@licenciaVacaciones", licenciaVacaciones);
                    comando.Parameters.AddWithValue("@reclamoSalario", reclamoSalario);
                    comando.Parameters.AddWithValue("@reclamoRecibo", reclamoRecibo);
                    comando.Parameters.AddWithValue("@comentario", comentario ?? string.Empty); // evita null

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }



        //-----------------------------------------------------------------------------------
    }
}
