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
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";
        //USAR using SGV_CLP.Classes
        //--------
        //CREATE
        public static List<Cliente> consultarClientes()
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
                        clientesRegistrados.Add(new Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                    }
                }
            }
            return clientesRegistrados;
        }


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
        //var cliente = new Cliente { Id_Cliente = 1, Nombre = "Joel", Telefono = "0995618466", Fecha_Ingreso = DateTime.Now };
        //var idCliente = await ClienteMapper.IngresarCliente(cliente);
        //--------
        //READ
        public static async Task<Cliente> MostrarClientes(string CC_Cliente)
        {
            await using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            await using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT \"cc_Cliente\", \"primer_Nombre\", \"segundo_Nombre\", \"primer_Apellido\", \"segundo_Apellido\", \"direccion_Domicilio\", telefono, \"correo_Electronico\" FROM public.\"Cliente\" WHERE \"cc_Cliente\" = @ccCliente limit 1;";
            command.Parameters.AddWithValue("@ccCliente", CC_Cliente);
            NpgsqlDataReader reader = await command.ExecuteReaderAsync();
            if (reader.HasRows)
            {
                reader.Read();
                string primerNombre = (string)reader["primer_Nombre"];
                string segundoNombre = (string)reader["segundo_Nombre"];
                string primerApellido = (string)reader["primer_Apellido"];
                string segundoApellido = (string)reader["segundo_Apellido"];
                string direccionDomicilio = (string)reader["direccion_Domicilio"];
                string telefono = (string)reader["telefono"];
                string correoElectronico = (string)reader["correo_Electronico"];
                string ccCLiente = (string)reader["cc_Cliente"];
                return new Cliente(ccCLiente, primerNombre, segundoNombre, primerApellido, segundoApellido, direccionDomicilio, telefono, correoElectronico);
            }
            return null;
        }
        //var client = await ClienteMapper.MostrarClientes(idCliente);
        //Console.WriteLine($"{client.Id_Cliente} ,{client.Nombre},{client.Telefono},{client.Fecha_Ingreso} ");
        //--------
        //UPDATE
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
        //client.Id_Cliente += 1;
        //client.Nombre += "Julian";
        //client.Telefono += "0954186584";
        //client.Fecha_Ingreso = DateTime.Now;
        //await ClienteMapper.ModificarCliente(client);
        //var client2 = await ClienteMapper.MostrarClientes(client.Id_Cliente);
        //Console.WriteLine($"{client2.Id_Cliente} {client2.Nombre},{client2.Telefono},{client2.Fecha_Ingreso} ");
        //--------
        //DELETE
        public static async Task<bool> EliminarCliente(string CC_Cliente)
        {
            await using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            await using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM public.\"CLiente\" WHERE \"cc_Cliente\" = @CC_Cliente;";
            command.Parameters.AddWithValue("@CC_Cliente", CC_Cliente);
            var result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        //await ClienteMapper.EliminarCliente(1);
    }
}