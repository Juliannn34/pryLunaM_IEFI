using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLunaM_IEFI
{
    public class clsUsuarios
    {
        public int Id { get; set; }                    // Clave primaria
        public string Nombre { get; set; }             // No nulo
        public string Contraseña { get; set; }         // No nulo
        public string Cargo { get; set; }              // Restricción: 'Administrador', 'Empleado', etc.
        public string DNI { get; set; }                // Único, no nulo
        public string CalleHogar { get; set; }         // Puede ser nulo
        public string EstadoCivil { get; set; }        // Restricción: 'Soltero', 'Casado', etc.
        public decimal Sueldo { get; set; }

        public clsUsuarios() { }

        public clsUsuarios(int id, string nombre, string contraseña, string cargo, string dni, string callehogar, string estadocivil, decimal sueldo)
        {
            Id = id;
            Nombre = nombre;
            Contraseña = contraseña;
            Cargo = cargo;
            DNI = dni;
            CalleHogar = callehogar;
            EstadoCivil = estadocivil;
            Sueldo = sueldo;
        }
    }
}
