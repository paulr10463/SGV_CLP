using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Módulo_Ventas
{
    public class DetalleNotaVentaMapper
    {

        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";
        //USAR using SGV_CLP.Classes
        //--------
        //CREATE
 

        public static void IngresarDetalleNotaVenta(DetalleNotaVenta detalleNotaVenta)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"DetalleNotaVenta\"(\"num_Detalle\", \"cod_NotaVenta\", \"cod_Producto\", \"cantidad\", \"subTotal\") VALUES (@NumDetalle, @Cod_NotaVenta, @Cod_Producto, @Cantidad, @SubTotal)", connection))
            {
                cmd.Parameters.AddWithValue("@NumDetalle", detalleNotaVenta.numDetalle);
                cmd.Parameters.AddWithValue("@Cod_NotaVenta", detalleNotaVenta.codNotaVenta);
                cmd.Parameters.AddWithValue("@Cod_Producto", detalleNotaVenta.producto.Id);
                cmd.Parameters.AddWithValue("@Cantidad", detalleNotaVenta.cantidad);
                cmd.Parameters.AddWithValue("@SubTotal", detalleNotaVenta.subtotal);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
