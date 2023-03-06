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
    public class ProductoMapper
    {
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        //--------
        // INGRESAR PRODUCTO
        public static void IngresarProducto(Producto producto)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Producto\"(\"cod_Producto\", \"nombre_Producto\", \"precio_Elaboracion\", \"precio_Unitario\", \"categoria\", \"cantidad_Total\", \"ruta_Imagen\") VALUES (@cod_Producto, @nombre_Producto, @precio_Elaboracion, @precio_Unitario, @categoria, @cantidad_Total, @ruta_Imagen)", connection))
            {

                cmd.Parameters.AddWithValue("@cod_Producto", producto.Id);
                cmd.Parameters.AddWithValue("@nombre_Producto", producto.Nombre);
                cmd.Parameters.AddWithValue("@precio_Elaboracion", producto.PrecioElaboracion);
                cmd.Parameters.AddWithValue("@precio_Unitario", producto.PVP);
                cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
                cmd.Parameters.AddWithValue("@cantidad_Total", producto.CantidadTotal);
                cmd.Parameters.AddWithValue("@ruta_Imagen", producto.Imagen);
                cmd.ExecuteNonQuery();
            }
        }

        //--------
        // CONSULTAR PRODUCTOS
        public static List<Producto> ConsultarProductos()
        {
            List<Producto> ProductosRegistrados = new List<Producto>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductosRegistrados.Add(new Producto(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetString(4), reader.GetDouble(5), reader.GetString(6)));
                    }
                }
            }
            return ProductosRegistrados;
        }

        //--------
        // CONSULTAR NOMBRES PRODUCTOS
        public static List<string> ConsultarNombresProductos()
        {
            List<string> NombresProductosRegistrados = new List<string>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT \"nombre_Producto\" FROM \"Producto\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NombresProductosRegistrados.Add(reader.GetString(0));
                    }
                }
            }
            return NombresProductosRegistrados;
        }

        //--------
        // CONSULTAR ID PRODUCTO
        public static string ConsultarIdProducto(string nombreProducto)
        {
            string IdProductoRegistrado = "";
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT \"cod_Producto\" FROM \"Producto\" WHERE \"nombre_Producto\" = @nombre_Producto", connection))
                {
                    command.Parameters.AddWithValue("@nombre_Producto", nombreProducto);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IdProductoRegistrado = reader.GetString(0);
                        }
                    }
                }
            }
            return IdProductoRegistrado;
        }

        //--------
        // INGRESAR LOTE
        public static void IngresarLote(Lote lote)
        {
            // Conexión a BD
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

        //--------
        // CONSULTAR LOTES
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
                        LotesRegistrados.Add(new Lote(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3)));
                    }
                }
            }
            return LotesRegistrados;
        }

        public static bool IDproductoExiste(string id)
        {
            bool existe = false;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\" WHERE \"cod_Producto\" ILIKE @cod_Producto", connection))
                {
                    command.Parameters.AddWithValue("@cod_Producto", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existe = true;
                        }
                    }
                }
            }
            return existe;
        }

        public static bool NombreProductoExiste(string nombre)
        {
            bool existe = false;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\" WHERE \"nombre_Producto\" ILIKE @nombre_Producto", connection))
                {
                    command.Parameters.AddWithValue("@nombre_Producto", nombre);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existe = true;
                        }
                    }
                }
            }
            return existe;
        }

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

    }
}