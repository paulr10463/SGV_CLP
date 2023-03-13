using Npgsql;
using SGV_CLP.Classes.Módulo_Ventas;
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

        /*
        * Permite consultar clientes en base a un párametro especifico  
        * 
        */

        public static List<NotaVenta> ConsultarNotaVenta(string parameter, string value)
        {
            List<NotaVenta> notasDeVenta = new List<NotaVenta>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var queryString = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"" + parameter + "\" LIKE '%" + value + "%'";
                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int codVenta = (int)reader["cod_NotaVenta"];
                        string ccCliente = (string)reader["cc_Cliente"];
                        string primerNombre = (string)reader["primer_Nombre"];
                        string primerApellido = (string)reader["primer_Apellido"];
                        string telefono = (string)reader["telefono"];
                        double totalVenta = (double)reader["total_Venta"];
                        DateTime fecha = (DateTime)reader["fecha_emision"];
                        notasDeVenta.Add(new NotaVenta(
                            codVenta,
                            new Cliente(ccCliente, primerNombre, null, primerApellido, null, null, telefono, null),
                            totalVenta,
                            fecha));
                    }
                }
            }
            return notasDeVenta;
        }

        public static List<NotaVenta> ConsultarNotaVenta(string value)
        {
            List<NotaVenta> notasDeVenta = new List<NotaVenta>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var queryString = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"NotaVenta\".\"cc_Cliente\" LIKE '%" + value + "%'";
                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int codVenta = (int)reader["cod_NotaVenta"];
                        string ccCliente = (string)reader["cc_Cliente"];
                        string primerNombre = (string)reader["primer_Nombre"];
                        string primerApellido = (string)reader["primer_Apellido"];
                        string telefono = (string)reader["telefono"];
                        double totalVenta = (double)reader["total_Venta"];
                        DateTime fecha = (DateTime)reader["fecha_emision"];
                        notasDeVenta.Add(new NotaVenta(
                            codVenta,
                            new Cliente(ccCliente, primerNombre, null, primerApellido, null, null, telefono, null),
                            totalVenta,
                            fecha));
                    }
                }
            }
            return notasDeVenta;
        }


        public static List<NotaVenta> ConsultarNotaVentabyDate(string value)
        {
            List<NotaVenta> notasDeVenta = new List<NotaVenta>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var queryString = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"fecha_emision\" = '" + value + "'";
                using (var command = new NpgsqlCommand(queryString, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int codVenta = (int)reader["cod_NotaVenta"];
                        string ccCliente = (string)reader["cc_Cliente"];
                        string primerNombre = (string)reader["primer_Nombre"];
                        string primerApellido = (string)reader["primer_Apellido"];
                        string telefono = (string)reader["telefono"];
                        double totalVenta = (double)reader["total_Venta"];
                        DateTime fecha = (DateTime)reader["fecha_emision"];
                        notasDeVenta.Add(new NotaVenta(
                            codVenta,
                            new Cliente(ccCliente, primerNombre, null, primerApellido, null, null, telefono, null),
                            totalVenta,
                            fecha));
                    }
                }
            }
            return notasDeVenta;
        }

        public static List<NotaVenta> ConsultarNotaVenta(int codNotaVenta)
        {
            using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM \"NotaVenta\" JOIN \"Cliente\" ON \"NotaVenta\".\"cc_Cliente\" = \"Cliente\".\"cc_Cliente\" WHERE \"cod_NotaVenta\" = @CodNotaVenta limit 1;";
            command.Parameters.AddWithValue("@CodNotaVenta", codNotaVenta);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int codVenta = (int)reader["cod_NotaVenta"];
                string ccCliente = (string)reader["cc_Cliente"];
                string primerNombre = (string)reader["primer_Nombre"];
                string primerApellido = (string)reader["primer_Apellido"];
                string telefono = (string)reader["telefono"];
                double totalVenta = (double)reader["total_Venta"];
                DateTime fecha = (DateTime)reader["fecha_emision"];
                return new List<NotaVenta> {
                    new NotaVenta(
                    codVenta,
                    new Cliente(ccCliente, primerNombre, null, primerApellido, null, null, telefono, null),
                    totalVenta,
                    fecha)};
            }
            return null;

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

        public static int ConsultarUltimoID()
        {
            int codVenta = -1;
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand("SELECT \"cod_NotaVenta\" FROM public.\"NotaVenta\" ORDER BY \"cod_NotaVenta\" DESC LIMIT 1", connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        codVenta = (int)reader["cod_NotaVenta"];
                    }
                }
            }
            return codVenta;
        }


    }


}
