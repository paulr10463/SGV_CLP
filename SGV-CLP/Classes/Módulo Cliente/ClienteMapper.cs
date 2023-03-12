using Npgsql;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class ClienteMapper
    {
        // String de conexión a la BD
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Ingresar Cliente
        public static void IngresarCliente(Cliente cliente)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Cliente\"(\"cc_Cliente\", \"primer_Nombre\", \"segundo_Nombre\", \"primer_Apellido\", \"segundo_Apellido\", \"direccion_Domicilio\", telefono, \"correo_Electronico\") VALUES (@CC_Cliente, @Primer_Nombre, @Segundo_Nombre, @Primer_Apellido, @Segundo_Apellido, @Direccion_Domicilio, @Telefono, @Correo_Electronico)", connection))
            {

                cmd.Parameters.AddWithValue("@CC_Cliente", cliente.Cc_Cliente);
                cmd.Parameters.AddWithValue("@Primer_Nombre", cliente.Primer_Nombre);
                cmd.Parameters.AddWithValue("@Segundo_Nombre", cliente.Segundo_Nombre);
                cmd.Parameters.AddWithValue("@Primer_Apellido", cliente.Primer_Apellido);
                cmd.Parameters.AddWithValue("@Segundo_Apellido", cliente.Segundo_Apellido);
                cmd.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion_Domicilio);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Correo_Electronico", cliente.Correo_Electronico);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Cliente
        public static void EliminarCliente(string cc_Cliente)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Cliente\" WHERE \"cc_Cliente\" = @cc_Cliente", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Cliente", cc_Cliente);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Producto 
        public static void EditarCliente(string cc_Cliente, string direccion_Domicilio, string correo_Electronico, string telefono)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Cliente\" SET \"direccion_Domicilio\" = @direccion_Domicilio, \"correo_Electronico\" = @correo_Electronico, \"telefono\" = @telefono WHERE \"cc_Cliente\" = @cc_Cliente", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Cliente", cc_Cliente);
                cmd.Parameters.AddWithValue("@direccion_Domicilio", direccion_Domicilio);
                cmd.Parameters.AddWithValue("@correo_Electronico", correo_Electronico);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Clientes
        public static List<Cliente> ConsultarClientes()
        {
            List<Cliente> clientesRegistrados = new List<Cliente>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Cliente\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        clientesRegistrados.Add(
                            new Cliente(
                                reader.GetString(0), 
                                reader.GetString(1),
                                !reader.IsDBNull(2)? reader.GetString(2):null, 
                                reader.GetString(3),
                                !reader.IsDBNull(4) ? reader.GetString(4) : null,
                                reader.GetString(5), 
                                reader.GetString(6), 
                                reader.GetString(7)));
                    }
                }
            }
            return clientesRegistrados;
        }

        // Consultar un atributo de un Cliente
        public static string ConsultarAtributoCliente(string cc_Cliente, string atributo)
        {
            string valorAtributo = string.Empty;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{atributo}\" FROM \"Cliente\" WHERE \"cc_Cliente\" = @cc_Cliente", connection))
                {
                    cmd.Parameters.AddWithValue("@cc_Cliente", cc_Cliente);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            valorAtributo = reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            return valorAtributo;
        }

        public static async Task<bool> ModificarCliente(Cliente cliente)
        {
            int result = 0;
            if (cliente.Cc_Cliente != null)
            {
                await using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
                connection.Open();
                await using NpgsqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE public.\"CLiente\" SET  \"cc_Cliente\"=@CC_Cliente, \"primer_Nombre\"=@Primer_Nombre, \"segundo_Nombre\"=@Segundo_Nombre, \"primer_Apellido\"=@Primer_Apellido, \"segundo_Apellido\"=@Segundo_Apellido, \"direccion_Domicilio\"=@Direccion_Domicilio, telefono=@Telefono, \"correo_Electronico\"=@Correo_Electronico WHERE \"cc_Cliente\" = @CC_Cliente;";
                command.Parameters.AddWithValue("@CC_Cliente", cliente.Cc_Cliente);
                command.Parameters.AddWithValue("@Primer_Nombre", cliente.Primer_Nombre);
                command.Parameters.AddWithValue("@Segundo_Nombre", cliente.Segundo_Nombre);
                command.Parameters.AddWithValue("@Primer_Apellido", cliente.Primer_Apellido);
                command.Parameters.AddWithValue("@Segundo_Apellido", cliente.Segundo_Apellido);
                command.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion_Domicilio);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo_Electronico", cliente.Correo_Electronico);
                command.Parameters.AddWithValue("@CC_Cliente", cliente.Cc_Cliente);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }
    }
}