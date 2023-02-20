//using SGV_CLP.Classes;

//var cliente = new Cliente { Id_Cliente = 1, Nombre = "Joel", Telefono = "0995618466", Fecha_Ingreso = DateTime.Now };
//var idCliente = await ClienteMapper.IngresarCliente(cliente);

//var client = await ClienteMapper.MostrarClientes(idCliente);
//Console.WriteLine($"{client.Id_Cliente} ,{client.Nombre},{client.Telefono},{client.Fecha_Ingreso} ");

/*
client.Id_Cliente += 1;
client.Nombre += "Julian";
client.Telefono += "0954186584";
client.Fecha_Ingreso = DateTime.Now;
await ClienteMapper.ModificarCliente(client);
var client2 = await ClienteMapper.MostrarClientes(client.Id_Cliente);
Console.WriteLine($"{client2.Id_Cliente} {client2.Nombre},{client2.Telefono},{client2.Fecha_Ingreso} ");
*/

//await ClienteMapper.EliminarCliente(1);

namespace SGV_CLP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
