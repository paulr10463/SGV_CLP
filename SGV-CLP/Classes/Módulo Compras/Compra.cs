using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public  class Compra
    {
        public string CodCompra { get; set; }
        public string RUC { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }

        public Compra(string codCompra, string ruc, DateTime fechaCompra, double costo, string descripcion)
        {
            CodCompra = codCompra;
            RUC = ruc;
            FechaCompra = fechaCompra;
            Descripcion = descripcion;
            Costo = costo;
        }
    }
}
