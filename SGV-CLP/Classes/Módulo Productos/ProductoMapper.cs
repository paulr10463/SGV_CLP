using Npgsql;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    public class ProductoMapper
    {
        // String de conexión a la BD
        private static readonly string _connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Métodos en tabla Producto
        // Ingresar Producto
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

        // Eliminar Producto
        public static void EliminarProducto(string cod_Producto)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Producto\" WHERE \"cod_Producto\" = @cod_Producto", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", cod_Producto);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Producto 
        public static void EditarProducto(string cod_Producto, string categoria, double precio_Elaboracion, double precio_Unitario, string ruta_Imagen)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Producto\" SET \"categoria\" = @categoria, \"precio_Elaboracion\" = @precio_Elaboracion, \"precio_Unitario\" = @precio_Unitario, \"ruta_Imagen\" = @ruta_Imagen WHERE \"cod_Producto\" = @cod_Producto", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", cod_Producto);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@precio_Elaboracion", precio_Elaboracion);
                cmd.Parameters.AddWithValue("@precio_Unitario", precio_Unitario);
                cmd.Parameters.AddWithValue("@ruta_Imagen", ruta_Imagen);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Productos
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

        // Consultar nombres de los Productos
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

        // Consultar id de un Producto
        public static string ConsultarIdProducto(string nombreProducto)
        {
            string IdProductoRegistrado = string.Empty;
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

        // Consultar un atributo de un Producto
        public static string ConsultarAtributoProducto(string cod_Producto, string atributo)
        {
            string valorAtributo = string.Empty;
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{atributo}\" FROM \"Producto\" WHERE \"cod_Producto\" = @cod_Producto", connection))
                {
                    cmd.Parameters.AddWithValue("@cod_Producto", cod_Producto);
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

        // Verificar existencia de un Producto con un id
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

        // Verificar existencia de un Producto con un nombre
        public static bool NombreProductoExiste(string nombre)
        {
            bool existe = false;
            nombre = nombre.Trim();

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
    }
}