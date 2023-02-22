using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Modulo_Ventas
{
    public class TotalVenta
    {
        public Cliente cliente;
        public string codFactura;
        public string formaPago;
        public double precioFinal;
        public string fechaVenta;

        public TotalVenta(Cliente cliente, string codFactura, string formaPago, double precioFinal, string fechaVenta)
        {
            this.cliente = cliente;
            this.codFactura = codFactura;
            this.formaPago = formaPago;
            this.precioFinal = precioFinal;
            this.fechaVenta = fechaVenta;
        }
    }
}
