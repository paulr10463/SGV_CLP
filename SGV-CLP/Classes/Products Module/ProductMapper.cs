using Npgsql;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Products_module
{
    public class ProductMapper
    {
        // String de conexión a la BD
        private static readonly string s_connectionString = "Host=localhost:5432;Username=postgres;Password=P@ssw0rd;Database=SGV-CLP";

        // Métodos en tabla Producto
        // Ingresar Producto
        public static void AddProduct(Product product)
        {
            // Conexión a BD
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("INSERT INTO public.\"Producto\"(\"cod_Producto\", \"nombre_Producto\", \"precio_Elaboracion\", \"precio_Unitario\", \"categoria\", \"cantidad_Total\", \"ruta_Imagen\") VALUES (@cod_Producto, @nombre_Producto, @precio_Elaboracion, @precio_Unitario, @categoria, @cantidad_Total, @ruta_Imagen)", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", product.productCode);
                cmd.Parameters.AddWithValue("@nombre_Producto", product.productName);
                cmd.Parameters.AddWithValue("@precio_Elaboracion", product.productionPrice);
                cmd.Parameters.AddWithValue("@precio_Unitario", product.salesPriceToThePubic);
                cmd.Parameters.AddWithValue("@categoria", product.category);
                cmd.Parameters.AddWithValue("@cantidad_Total", product.totalQuantity);
                cmd.Parameters.AddWithValue("@ruta_Imagen", product.imagePath);
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar Producto
        public static void DeleteProduct(string productCode)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.\"Producto\" WHERE \"cod_Producto\" = @cod_Producto", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", productCode);
                cmd.ExecuteNonQuery();
            }
        }

        //  Editar Producto 
        public static void EditProduct(string productCode, string category, double productionPrice, double salesPriceToThePubic, string imagePath)
        {
            using var connection = new NpgsqlConnection(s_connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand("UPDATE \"Producto\" SET \"categoria\" = @categoria, \"precio_Elaboracion\" = @precio_Elaboracion, \"precio_Unitario\" = @precio_Unitario, \"ruta_Imagen\" = @ruta_Imagen WHERE \"cod_Producto\" = @cod_Producto", connection))
            {
                cmd.Parameters.AddWithValue("@cod_Producto", productCode);
                cmd.Parameters.AddWithValue("@categoria", category);
                cmd.Parameters.AddWithValue("@precio_Elaboracion", productionPrice);
                cmd.Parameters.AddWithValue("@precio_Unitario", salesPriceToThePubic);
                cmd.Parameters.AddWithValue("@ruta_Imagen", imagePath);
                cmd.ExecuteNonQuery();
            }
        }

        // Consultar Productos
        public static List<Product> GetAllProduct()
        {
            List<Product> registeredProducts = new List<Product>();
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\"", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        registeredProducts.Add(new Product(reader.GetString(0), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetString(4), reader.GetDouble(5), reader.GetString(6)));
                    }
                }
            }
            return registeredProducts;
        }

        // Consultar nombres de los Productos
        public static List<string> GetProductsNames()
        {
            List<string> NombresProductosRegistrados = new List<string>();
            using (var connection = new NpgsqlConnection(s_connectionString))
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
        public static string GetProductCode(string productName)
        {
            string productCode = string.Empty;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT \"cod_Producto\" FROM \"Producto\" WHERE \"nombre_Producto\" = @nombre_Producto", connection))
                {
                    command.Parameters.AddWithValue("@nombre_Producto", productName);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productCode = reader.GetString(0);
                        }
                    }
                }
            }
            return productCode;
        }

        // Consultar un atributo de un Producto
        public static string GetProductField(string productCode, string field)
        {
            string fieldValue = string.Empty;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand($"SELECT \"{field}\" FROM \"Producto\" WHERE \"cod_Producto\" = @cod_Producto", connection))
                {
                    cmd.Parameters.AddWithValue("@cod_Producto", productCode);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fieldValue = reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            return fieldValue;
        }

        // Verificar existencia de un Producto con un id
        public static bool ProductExistsByCode(string productCode)
        {
            bool exists = false;
            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\" WHERE \"cod_Producto\" ILIKE @cod_Producto", connection))
                {
                    command.Parameters.AddWithValue("@cod_Producto", productCode);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exists = true;
                        }
                    }
                }
            }
            return exists;
        }

        // Verificar existencia de un Producto con un nombre
        public static bool ProductExistsByName(string productName)
        {
            bool exists = false;
            productName = productName.Trim();

            using (var connection = new NpgsqlConnection(s_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Producto\" WHERE \"nombre_Producto\" ILIKE @nombre_Producto", connection))
                {
                    command.Parameters.AddWithValue("@nombre_Producto", productName);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exists = true;
                        }
                    }
                }
            }
            return exists;
        }
    }
}