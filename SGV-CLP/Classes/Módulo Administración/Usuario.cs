using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class Usuario
    {
        public string? NombreUsuario { get; set; }
        public string? Cc_Usuario { get; set; }
        public string? Contraseña { get; set; }
        public string? Primer_Nombre { get; set; }
        public string? Segundo_Nombre { get; set; }
        public string? Primer_Apellido { get; set; }
        public string? Segundo_Apellido { get; set; }
        public string? Cargo { get; set; }

        public Usuario(string nombreUsuario, string cc_Usuario, string contraseña, string primer_Nombre, string segundo_Nombre, string primer_Apellido, string segundo_Apellido, string cargo)
        {
            NombreUsuario = nombreUsuario;
            Cc_Usuario = cc_Usuario;
            Contraseña = contraseña;
            Primer_Nombre = primer_Nombre;
            Segundo_Nombre = segundo_Nombre;
            Primer_Apellido = primer_Apellido;
            Segundo_Apellido = segundo_Apellido;
            Cargo = cargo;
        }
    }
}
