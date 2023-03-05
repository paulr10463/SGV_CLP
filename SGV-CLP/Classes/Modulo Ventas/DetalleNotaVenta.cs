using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class DetalleNotaVenta
    {
        public string? numDetalle { get; set; }
        public string? codNotaVenta { get; set; }
        public string? cod_Producto { get; set; }
        public int cantidad { get; set; }
        public double? subtotal { get; set; }
        public Producto? producto  { get; set; }

        public DetalleNotaVenta(string? numDetalle, string? codNotaVenta, string? cod_Producto, int cantidad, double? subtotal)
        {
            this.numDetalle = numDetalle;
            this.codNotaVenta = codNotaVenta;
            this.cod_Producto = cod_Producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public DetalleNotaVenta(string? numDetalle, string? codNotaVenta, Producto? producto)
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
