using Npgsql;
using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SGV_CLP.Classes.Modulo_Ventas
{
    internal class NotaVentaMapper
    {
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";
        //USAR using SGV_CLP.Classes
        //--------
        //CREATE
        public static List<NotaVenta> ConsultarNotaVenta()
        {
            List<NotaVenta> notasDeVenta = new List<NotaVenta>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"NotaVenta\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notasDeVenta.Add(new NotaVenta(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDateTime(4)));
                    }
                }
            }
            return notasDeVenta;
        }


        public static void IngresarNotaVenta(NotaVenta notaVenta)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"NotaVenta\"(\"cc_Cliente\", \"userName\", \"total_Venta\", \"fecha_emision\") VALUES (@Cc_Cliente, @UserName, @Total_Venta, @Fecha_emision)", connection))
            {
                cmd.Parameters.AddWithValue("@Cc_Cliente", notaVenta.cliente.Cc_Cliente);
                cmd.Parameters.AddWithValue("@UserName", notaVenta.usuario.userName);
                cmd.Parameters.AddWithValue("@Total_Venta", notaVenta.precioFinal);
                cmd.Parameters.AddWithValue("@Fecha_emision", notaVenta.fechaVenta);
                cmd.ExecuteNonQuery();
            }
        }
    }
        
}
