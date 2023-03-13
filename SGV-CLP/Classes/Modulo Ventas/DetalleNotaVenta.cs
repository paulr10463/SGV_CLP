using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class DetalleNotaVenta
    {
        public int? numDetalle { get; set; }
        public int? codNotaVenta { get; set; }
        public int cantidad { get; set; }
        public double? subtotal { get; set; }
        public Producto? producto  { get; set; }

        public DetalleNotaVenta(int? numDetalle, int? codNotaVenta, Producto? producto)
        {
            this.numDetalle = numDetalle;
            this.codNotaVenta = codNotaVenta;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
            this.producto = producto;
        }

        public DetalleNotaVenta()
        {
            this.cantidad = 0;
            this.subtotal = 0;
        }

    }
}
