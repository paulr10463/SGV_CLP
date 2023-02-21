using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class Lote
    {
        public Lote(string cod_Lote, string cod_Producto, int cantidad, DateTime fechaElaboracion)
        {
            Cod_Lote = cod_Lote;
            Cod_Producto = cod_Producto;
            Cantidad = cantidad;
            FechaElaboracion = fechaElaboracion;
        }
        public string? Cod_Lote { get; set; }
        public string? Cod_Producto { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaElaboracion { get; set; }
    }
}