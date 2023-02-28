using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class Cliente
    {
        public Cliente()
        {
        }
        public Cliente(string cc_Cliente, string primer_Nombre, string segundo_Nombre, string primer_Apellido, string segundo_Apellido, string direccion_Domicilio, string telefono, string correo_Electronico)
        {

            this.Cc_Cliente = cc_Cliente;
            this.Primer_Nombre = primer_Nombre;
            this.Segundo_Nombre = segundo_Nombre;
            this.Primer_Apellido = primer_Apellido;
            this.Segundo_Apellido = segundo_Apellido;
            this.Direccion_Domicilio = direccion_Domicilio;
            this.Telefono = telefono;
            this.Correo_Electronico = correo_Electronico;
        }
        public string? Cc_Cliente { get; set; }
        public string? Primer_Nombre { get; set; }
        public string? Segundo_Nombre { get; set; }
        public string? Primer_Apellido { get; set; }
        public string? Segundo_Apellido { get; set; }
        public string? Direccion_Domicilio { get; set; }
        public string? Telefono { get; set; }
        public string? Correo_Electronico { get; set; }
    }
}