using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Sales_Module
{
    public class InvoiceDetailMapper
    {

        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";
        //USAR using SGV_CLP.Classes
        //--------
        //CREATE
 

        public static void AddInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"DetalleNotaVenta\"(\"num_Detalle\", \"cod_NotaVenta\", \"cod_Producto\", \"cantidad\", \"subTotal\") VALUES (@NumDetalle, @Cod_NotaVenta, @Cod_Producto, @Cantidad, @SubTotal)", connection))
            {
                cmd.Parameters.AddWithValue("@NumDetalle", invoiceDetail.detailNumber);
                cmd.Parameters.AddWithValue("@Cod_NotaVenta", invoiceDetail.invoiceCode);
                cmd.Parameters.AddWithValue("@Cod_Producto", invoiceDetail.product.productCode);
                cmd.Parameters.AddWithValue("@Cantidad", invoiceDetail.soldQuantity);
                cmd.Parameters.AddWithValue("@SubTotal", invoiceDetail.subTotal);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
