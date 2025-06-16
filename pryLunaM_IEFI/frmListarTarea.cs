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
    public partial class frmListarTarea : Form
    {
        private clsUsuarios usuarioLogueado;

        public frmListarTarea(clsUsuarios usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void frmListarTarea_Load(object sender, EventArgs e)
        {
            if (usuarioLogueado.Cargo != "Administrador" && usuarioLogueado.Cargo != "Supervisor")
            {
                MessageBox.Show("Solo los usuarios con cargo de Administrador o Supervisor pueden acceder a esta funcionalidad.",
                                "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Cierra el formulario si no tiene permiso
                return;
            }

            clsConexionBD objConexion = new clsConexionBD();

            cmBuscarTipoTarea.DataSource = objConexion.ObtenerDatosDeTablaTipoTareas();
            cmBuscarTipoTarea.DisplayMember = "Tarea";
            cmBuscarTipoTarea.ValueMember = "ID";
            cmBuscarTipoTarea.SelectedIndex = -1;

            // Llenar la grilla de tareas
            dgvListarTarea.DataSource = objConexion.ObtenerTodasTareas();

        }

        private void btnBuscarTipoTarea_Click(object sender, EventArgs e)
        {
            if (cmBuscarTipoTarea.SelectedIndex != -1)
            {
                int tipoTareaId = Convert.ToInt32(cmBuscarTipoTarea.SelectedValue);
                clsConexionBD objConexion = new clsConexionBD();
                dgvListarTarea.DataSource = objConexion.ObtenerTareasPorTipo(tipoTareaId);
            }
            else
            {
                MessageBox.Show("Por favor, seleccioná un tipo de tarea.");
            }
        }

        private void btnUltminoAgregado_Click(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();
            dgvListarTarea.DataSource = objConexion.ObtenerUltimaTarea();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();
            dgvListarTarea.DataSource = objConexion.ObtenerTodasTareas();
        }
    }

}
