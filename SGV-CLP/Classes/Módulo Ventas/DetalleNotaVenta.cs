using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class DetalleNotaVenta
    {
        public string? cod_Producto { get; set; }
        public int? cantidad { get; set; }
        public double? subtotal { get; set; }

        public DetalleNotaVenta(string? cod_Producto, int? cantidad, double? subtotal)
        {
            this.cod_Producto = cod_Producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }
    }
}
