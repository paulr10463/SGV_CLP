using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class NotaVenta
    {
        public List<DetalleNotaVenta> detalles { get; set; }
        //public string? Cod_NotaVenta { get; set; }
        public string? Cc_Cliente { get; set; }
        public double? Total_Venta { get; set; }
        public DateTime? Fecha { get; set; }

        public NotaVenta( string? cc_Cliente, double? total_Venta, DateTime? fecha)
        {
            detalles = new List<DetalleNotaVenta>();
            Cc_Cliente = cc_Cliente;
            Total_Venta = total_Venta;
            Fecha = fecha;
        }

        public NotaVenta(string? cc_Cliente, double? total_Venta, DateTime? fecha, List<DetalleNotaVenta> detalles)
        {
            this.detalles = detalles;
            Cc_Cliente = cc_Cliente;
            Total_Venta = total_Venta;
            Fecha = fecha;
        }
    }
}
