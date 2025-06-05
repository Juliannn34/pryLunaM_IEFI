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
            cmbLugar.ValueMember = "Nombre";

            // Llenar los combos de tipo de tareas
            cmbTarea.DataSource = objConexion.ObtenerDatosDeTablaTipoTareas();
            cmbTarea.DisplayMember = "Tarea";
            cmbTarea.ValueMember = "Nombre";

            // Llenar la grilla de tareas
            dgvTarea.DataSource = objConexion.ObtenerTareas();
        }



        //-------------------------------- BOTONES PRINCIPALES ---------------------------------
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedValue == null || cmbLugar.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccioná un tipo de tarea y un lugar.");
                return;
            }

            clsTareas nuevaTarea = new clsTareas
            {
                TipoTareaID = Convert.ToInt32(cmbTarea.SelectedValue),
                Fecha = dtpFecha.Value.Date,
                LugarID = Convert.ToInt32(cmbLugar.SelectedValue),
                UniformeInsumo = chkInsumo.Checked,
                LicenciaEstudio = chkLicenciaEstudio.Checked,
                LicenciaVacaciones = chkLicenciaVacaciones.Checked,
                ReclamoSalario = chkReclamoSalario.Checked,
                ReclamoRecibo = chkReclamoRecibo.Checked,
                Comentario = txtComentario.Text
            };

            clsConexionBD conexion = new clsConexionBD();
            conexion.AgregarTarea(nuevaTarea);

            // Opcional: actualizar grilla después de agregar
            dgvTarea.DataSource = conexion.ObtenerTareas();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------
    }
}
