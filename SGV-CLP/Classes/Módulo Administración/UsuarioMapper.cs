using Npgsql;
using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Módulo_Administración
{
    internal class UsuarioMapper
    {
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";


        public static void IngresarUsuario(Usuario usuario)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Usuario\"(\"cc_Usuario\", \"userName\",\"contrasenia\",\"primer_Nombre\", \"segundo_Nombre\", \"primer_Apellido\", \"segundo_Apellido\", \"cargo\") VALUES (@cc_Usuario, @userName,@contrasenia, @primer_Nombre, @segundo_Nombre, @primer_Apellido, @segundo_Apellido, @cargo)", connection))
            {
                cmd.Parameters.AddWithValue("@cc_Usuario", usuario.cc_Usuario);
                cmd.Parameters.AddWithValue("@userName", usuario.userName);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                cmd.Parameters.AddWithValue("@primer_Nombre", usuario.primer_Nombre);
                cmd.Parameters.AddWithValue("@segundo_Nombre", usuario.segundo_Nombre);
                cmd.Parameters.AddWithValue("@primer_Apellido", usuario.primer_Apellido);
                cmd.Parameters.AddWithValue("@segundo_Apellido", usuario.segundo_Apellido);
                cmd.Parameters.AddWithValue("@cargo", usuario.cargo);
                cmd.ExecuteNonQuery();
            }
        }
        //var cliente = new Cliente { Id_Cliente = 1, Nombre = "Joel", Telefono = "0995618466", Fecha_Ingreso = DateTime.Now };
        //var idCliente = await ClienteMapper.IngresarCliente(cliente);
        //--------
        //READ
        public static bool checkUser(string userName, string contrasenia)
        {
            using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM public.\"Usuario\" WHERE \"userName\" = @UserName and \"contrasenia\" = @Contrasenia ;";
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Contrasenia", contrasenia);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            return false;
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
