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
    public partial class frmRegistrarTarea : Form
    {
        public frmRegistrarTarea()
        {
            InitializeComponent();
        }

        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();

            // Llenar los combos de lugares 
            cmbLugar.DataSource = objConexion.ObtenerDatosDeTablaLugares();
            cmbLugar.DisplayMember = "Lugar";    
            cmbLugar.ValueMember = "ID";
            cmbLugar.SelectedIndex = -1;

            // Llenar los combos de tipo de tareas
            cmbTarea.DataSource = objConexion.ObtenerDatosDeTablaTipoTareas();
            cmbTarea.DisplayMember = "Tarea";    
            cmbTarea.ValueMember = "ID";
            cmbTarea.SelectedIndex = -1;

            // Llenar los combos de Tareas ya agendadas
            cmbElegirTarea.DataSource = objConexion.ObtenerTareasAgendadas();
            cmbElegirTarea.DisplayMember = "Nombre";
            cmbElegirTarea.ValueMember = "ID";
            cmbElegirTarea.SelectedIndex = -1;

            // Llenar la grilla de tareas
            dgvTarea.DataSource = objConexion.ObtenerTareas();
        }



        //-------------------------------- BOTONES PRINCIPALES ---------------------------------
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            clsConexionBD conexion = new clsConexionBD();


            if (cmbTarea.SelectedValue == null || cmbLugar.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccioná un tipo de tarea y un lugar.");
                return;
            }

            try
            {
                clsTareas nuevaTarea = new clsTareas
                {
                    Nombre = txtNombreTarea.Text.Trim(),
                    TipoTareaID = Convert.ToInt32(cmbTarea.SelectedValue),
                    Fecha = dtpFecha.Value.Date,
                    LugarID = Convert.ToInt32(cmbLugar.SelectedValue)
                };

               
                conexion.AgregarTarea(nuevaTarea);

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
                return;
            }
           

            
            // Opcional: actualizar grilla después de agregar
            dgvTarea.DataSource = conexion.ObtenerTareas();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cmbElegirTarea.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccioná una tarea para modificar.");
                return;
            }

            int idTarea = Convert.ToInt32(cmbElegirTarea.SelectedValue);

            bool insumo = chkInsumo.Checked;
            bool licenciaEstudio = chkLicenciaEstudio.Checked;
            bool licenciaVacaciones = chkLicenciaVacaciones.Checked;
            bool reclamoSalario = chkReclamoSalario.Checked;
            bool reclamoRecibo = chkReclamoRecibo.Checked;
            string comentario = txtComentario.Text;

            clsConexionBD conexion = new clsConexionBD();
            bool exito = conexion.ModificarDetallesTarea(
                idTarea,
                insumo,
                licenciaEstudio,
                licenciaVacaciones,
                reclamoSalario,
                reclamoRecibo,
                comentario
            );

            if (exito)
            {
                MessageBox.Show("Tarea actualizada correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar la tarea.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbElegirTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            cmbTarea.SelectedIndex = -1;

            chkInsumo.Checked = false;
            chkLicenciaEstudio.Checked = false;
            chkLicenciaVacaciones.Checked = false;
            chkReclamoSalario.Checked = false;
            chkReclamoRecibo.Checked = false;

            txtComentario.Text = string.Empty;
            txtNombreTarea.Text = string.Empty; 
            

            txtNombreTarea.Focus();
        }
        //---------------------------------------------------------------------------------------
    }
}
