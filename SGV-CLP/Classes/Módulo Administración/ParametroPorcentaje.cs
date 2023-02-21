using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class ParametroPorcentaje
    {
        public string? IdParametro { get; set; }
        public string? Producto { get; set; }
        public int? Porcentaje { get; set; }

        public ParametroPorcentaje(string? idParametro, string? producto, int? porcentaje)
        {
            IdParametro = idParametro;
            Producto = producto;
            Porcentaje = porcentaje;
        }
    }
}
