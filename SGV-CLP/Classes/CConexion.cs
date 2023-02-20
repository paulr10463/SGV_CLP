using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes
{
    internal class CConexion
    {
        /*
        NpgsqlConnection conex = new NpgsqlConnection();
        static String server = "localhost";
        static String db = "SGV-CLP";
        static String user = "postgres";
        static String password = "root";
        static String port = "5432";

        String cadenaConexion = "server = " + server + "; " + " port = " + port + "; " + " user id = " + user + "; " + " password = " + password + "; " + " database = " + db + ";"; 

        public NpgsqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conectó correctamente a la base de datos");
            } catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos de PostgreSQL, error: " + e.ToString());
            }
            return conex;
             

        }*/

    }
}
