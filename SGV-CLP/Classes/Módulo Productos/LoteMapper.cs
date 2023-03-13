using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class LoteMapper
    {
        // String de conexión a la BD
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Ingresar Lote
        public static void IngresarLote(Lote lote)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Lote\"(\"cod_Lote\", \"cod_Producto\", \"cantidad\", \"fecha\") VALUES (@cod_Lote, @cod_Producto, @cantidad, @fecha)", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Lote", lote.Cod_Lote);
                cmd.Parameters.AddWithValue("@cod_Producto", lote.Cod_Producto);
                cmd.Parameters.AddWithValue("@cantidad", lote.Cantidad);
                cmd.Parameters.AddWithValue("@fecha", lote.FechaElaboracion);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Lote
        public static void EliminarLote(string cod_Lote)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Lote\" WHERE \"cod_Lote\" = @cod_Lote", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Lote", cod_Lote);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Lote 
        public static void EditarLote(string cod_Lote, int cantidad, DateTime fecha)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Lote\" SET \"cantidad\" = @cantidad, \"fecha\" = @fecha WHERE \"cod_Lote\" = @cod_Lote ", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Lote", cod_Lote);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Lotes
        public static List<Lote> ConsultarLotes()
        {
            List<Lote> LotesRegistrados = new List<Lote>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Lote\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LotesRegistrados.Add(new Lote(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetDateTime(3).Date + reader.GetDateTime(3).TimeOfDay)
                            );
                    }
                }
            }
            return LotesRegistrados;
        }

        // Consultar un atributo de un Lote
        public static string ConsultarAtributoLote(string cod_Lote, string atributo)
        {
            string valorAtributo = string.Empty;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{atributo}\" FROM \"Lote\" WHERE \"cod_Lote\" = @cod_Lote", connection))
                {
                    cmd.Parameters.AddWithValue("@cod_Lote", cod_Lote);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (atributo == "fecha")
                        {
                            if (reader.Read())
                            {
                                valorAtributo = reader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss");
                            }
                        }
                        else
                        {
                            if (reader.Read())
                            {
                                valorAtributo = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
            }
            return valorAtributo;
        }

        public static string ConsultarUltimoCodLote(string cod_Producto)
        {
            string codLote = string.Empty;
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand($"SELECT \"cod_Lote\" FROM public.\"Lote\" WHERE \"cod_Lote\" ~* '^{cod_Producto}[0-9]+.*$' ORDER BY \"cod_Lote\" DESC LIMIT 1", connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        codLote = reader["cod_Lote"].ToString();
                    }
                }
            }
            return codLote;
        }

    }
}
