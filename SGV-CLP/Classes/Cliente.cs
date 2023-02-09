using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    internal class Cliente
    {
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        // Constructor para crear un nuevo cliente en la base de datos
        public Cliente(string cedula, string nombres, string apellidos, string direccion, string telefono)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        
        
    }
}
