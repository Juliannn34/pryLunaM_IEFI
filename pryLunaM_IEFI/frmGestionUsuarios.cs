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
    public partial class frmGestionUsuarios : Form
    {
        private clsUsuarios usuarioLogueado;

        public frmGestionUsuarios(clsUsuarios usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado.Cargo != "Administrador" && usuarioLogueado.Cargo != "Supervisor")
            {
                MessageBox.Show("Acceso denegado. Solo administradores o supervisores pueden acceder.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            clsConexionBD objConexion = new clsConexionBD();



            // Llnar el combo de cargos
            cmbCargo.DataSource = objConexion.ObtenerCargos();
            cmbCargo.DisplayMember = "Cargo";  // nombre de la columna
            cmbCargo.ValueMember = "Cargo";
            cmbCargo.SelectedIndex = -1;

            // Llenar el combo de estado civil
            cmbEstadoCivil.DataSource = objConexion.ObtenerEstadoCivil();
            cmbEstadoCivil.DisplayMember = "EstadoCivi";  // nombre de la columna
            cmbEstadoCivil.ValueMember = "EstadoCivil";
            cmbEstadoCivil.SelectedIndex = -1;



            //Llenar la grilla de productos
            dgvUsuarios.DataSource = objConexion.ObtenerUsuarios();
            

        }


        public void RecargarGrilla()
        {
            clsConexionBD objConexion = new clsConexionBD();
            dgvUsuarios.DataSource = objConexion.ObtenerUsuarios();
        }
        //-------------------------------- METODOS ---------------------------------

        public void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtCalleHogar.Text = string.Empty;
            txtSueldo.Text = string.Empty;

            cmbCargo.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;

            txtNombre.Focus();
        }


        private bool ValidarCamposUSUARIOS()
        {
            // Validar Nombre: no vacío y no solo números
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del usuario.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show("El nombre del usuario no puede ser un número.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            // Validar Contraseña: no vacía
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return false;
            }

            if (!long.TryParse(txtContraseña.Text, out _))
            {
                MessageBox.Show("La Contraseña debe contener solo números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return false;
            }

            // Validar DNI: no vacío y numérico
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, ingresa el DNI del usuario.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return false;
            }

            if (!long.TryParse(txtDNI.Text, out _))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return false;
            }

            // Validar CalleHogar: puede estar vacío, pero si no lo está, no debe ser solo números
            if (!string.IsNullOrWhiteSpace(txtCalleHogar.Text) && int.TryParse(txtCalleHogar.Text, out _))
            {
                MessageBox.Show("La calle del hogar no puede ser solo números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCalleHogar.Focus();
                return false;
            }

            // Validar Cargo: debe seleccionarse uno
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un cargo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCargo.Focus();
                return false;
            }

            // Validar Estado Civil: debe seleccionarse uno
            if (cmbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un estado civil.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEstadoCivil.Focus();
                return false;
            }

            // Validar Sueldo: no vacío y decimal válido
            if (string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("Por favor, ingresa el sueldo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSueldo.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSueldo.Text, out _))
            {
                MessageBox.Show("El sueldo debe ser un número decimal válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSueldo.Focus();
                return false;
            }

            return true; // Todos los campos son válidos
        }

        //--------------------------------------------------------------------------


        //-------------------------------- BOTONES PRINCIPALES ---------------------------------

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt16(txtId.Text);


            clsConexionBD conectarBD = new clsConexionBD();

            conectarBD.BuscarUsuarioPorID(Id, txtNombre, txtContraseña, cmbCargo,
                txtDNI, txtCalleHogar, cmbEstadoCivil, txtSueldo);


            if (int.TryParse(txtId.Text, out int id))
            {
                

                
                conectarBD.BuscarUsuarioPorID(
                    id,
                    txtNombre,
                    txtContraseña,
                    cmbCargo,
                    txtDNI,
                    txtCalleHogar,
                    cmbEstadoCivil,
                    txtSueldo
                );

               
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("No se encontró un usuario con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposUSUARIOS())
                return;


            clsConexionBD objConexion = new clsConexionBD();

            try
            {
                clsUsuarios nuevoUsuario = new clsUsuarios
                {
                    Nombre = txtNombre.Text,
                    Contraseña = txtContraseña.Text,
                    Cargo = cmbCargo.Text,
                    DNI = txtDNI.Text,
                    CalleHogar = txtCalleHogar.Text,
                    EstadoCivil = cmbEstadoCivil.Text,
                    Sueldo = Convert.ToDecimal(txtSueldo.Text)
                };

                objConexion.AgregarUsuario(nuevoUsuario);

                // Refrescar grilla de usuarios
                RecargarGrilla();

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }


        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposUSUARIOS())
                return;
            try
            {
                clsUsuarios usuario = new clsUsuarios
                {
                    Id = Convert.ToInt32(txtId.Text), 
                    Nombre = txtNombre.Text,
                    Contraseña = txtContraseña.Text,
                    Cargo = cmbCargo.Text,
                    DNI = txtDNI.Text,
                    CalleHogar = txtCalleHogar.Text,
                    EstadoCivil = cmbEstadoCivil.Text,
                    Sueldo = Convert.ToDecimal(txtSueldo.Text)
                };

                clsConexionBD conexion = new clsConexionBD();
                bool exito = conexion.ModificarUsuario(usuario);

                if (exito)
                {
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuarios.DataSource = conexion.ObtenerUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RecargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el usuario: " + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres eliminar este registro?",
                                                     "Eliminar contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                clsConexionBD conexion = new clsConexionBD();
                conexion.EliminarUsuario(id);
                RecargarGrilla();

            }
        }


        //-------------------------------- BOTONES EXTRAS ---------------------------------
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRecargarGrilla_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
            
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbCargo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDNI.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCalleHogar.Text = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbEstadoCivil.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSueldo.Text = dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        //---------------------------------------------------------------------------------------




        //---------------------------------------------------------------------------------------
    }
}
