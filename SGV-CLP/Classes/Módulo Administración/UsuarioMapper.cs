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
        public static Usuario getUser(string userName, string contrasenia)
        {
            using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  \"primer_Nombre\",\"cargo\" FROM public.\"Usuario\" WHERE \"userName\" = @UserName and \"contrasenia\" = @Contrasenia ;";
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Contrasenia", contrasenia);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string primerNombre = (string)reader["primer_Nombre"];
                string cargo = (string)reader["cargo"];
                return new Usuario(null, userName, contrasenia, primerNombre, null, null,null,cargo);
            }
            return null;
        }
        //var cliente = new Cliente { Id_Cliente = 1, Nombre = "Joel", Telefono = "0995618466", Fecha_Ingreso = DateTime.Now };
        //var idCliente = await ClienteMapper.IngresarCliente(cliente);
        //--------
        //READ
        public static async Task<Cliente> getUserData(string CC_Cliente)
        {
            await using NpgsqlConnection connection = new(_connectionString);
            connection.Open();
            await using NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT  \"primer_Nombre\" FROM public.\"Cliente\" WHERE \"cc_Cliente\" = @ccCliente limit 1;";
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

    }
}
