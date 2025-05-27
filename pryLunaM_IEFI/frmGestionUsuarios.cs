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
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();



            // Llnar el combo de cargos
            cmbCargo.DataSource = objConexion.ObtenerCargos();
            cmbCargo.DisplayMember = "Cargo";  // nombre de la columna
            cmbCargo.ValueMember = "Cargo";

            // Llenar el combo de estado civil
            cmbEstadoCivil.DataSource = objConexion.ObtenerEstadoCivil();
            cmbEstadoCivil.DisplayMember = "EstadoCivi";  // nombre de la columna
            cmbEstadoCivil.ValueMember = "EstadoCivil";



            //Llenar la grilla de productos
            dgvUsuarios.DataSource = objConexion.ObtenerUsuarios();
            

        }




        //-------------------------------- BOTONES PRINCIPALES ---------------------------------

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                clsConexionBD conectarBD = new clsConexionBD();

                // Llamada al nuevo método BuscarIDUsuario (que deberías crear en clsConexionBD)
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

                // Verificás si no se encontró el usuario
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
                dgvUsuarios.DataSource = objConexion.ObtenerUsuarios();

                // Limpiar campos
                txtNombre.Clear();
                txtContraseña.Clear();
                txtDNI.Clear();
                txtCalleHogar.Clear();
                txtSueldo.Clear();
                cmbCargo.SelectedIndex = -1;
                cmbEstadoCivil.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }


        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {

        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        

        //---------------------------------------------------------------------------------------
    }
}
