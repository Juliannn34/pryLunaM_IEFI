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
        public bool Cargo { get; set; }

        public clsUsuarios() { }

        public clsUsuarios(int id, string nombre, string contraseña, bool cargo)
        {
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
            Cargo = cargo;
        
        }
    }
}
