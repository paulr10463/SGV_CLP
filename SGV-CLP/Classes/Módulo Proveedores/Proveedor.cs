using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class Proveedor
    {
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Proveedor(string ruc, string nombre, string direccion, string telefono)
        {
            Ruc = ruc;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
