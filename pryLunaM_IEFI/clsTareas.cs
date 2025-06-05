using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLunaM_IEFI
{
    public class clsTareas
    {
        public int ID { get; set; } // Lo podés usar si después hacés editar/borrar
        public int TipoTareaID { get; set; }
        public DateTime Fecha { get; set; }
        public int LugarID { get; set; }

        public bool UniformeInsumo { get; set; }
        public bool LicenciaEstudio { get; set; }
        public bool LicenciaVacaciones { get; set; }
        public bool ReclamoSalario { get; set; }
        public bool ReclamoRecibo { get; set; }

        public string Comentario { get; set; }


        public clsTareas() { }

        
        public clsTareas(int id, int tipoTareaID, DateTime fecha, int lugarID,
                        bool uniformeInsumo, bool licenciaEstudio, bool licenciaVacaciones,
                        bool reclamoSalario, bool reclamoRecibo, string comentario)
        {
            ID = id;
            TipoTareaID = tipoTareaID;
            Fecha = fecha;
            LugarID = lugarID;
            UniformeInsumo = uniformeInsumo;
            LicenciaEstudio = licenciaEstudio;
            LicenciaVacaciones = licenciaVacaciones;
            ReclamoSalario = reclamoSalario;
            ReclamoRecibo = reclamoRecibo;
            Comentario = comentario;
        }
    }
}
