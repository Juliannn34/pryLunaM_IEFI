using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLunaM_IEFI
{
    internal class clsUsuarios
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }    
        public string Contraseña { get; set; }
        public bool Categoria { get; set; }

        public clsUsuarios() { }

        public clsUsuarios(int id, string nombre, string contraseña, bool categoria)
        {
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
            Categoria = categoria;
        
        }
    }
}
