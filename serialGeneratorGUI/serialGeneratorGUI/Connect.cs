using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialGenerator
{
    internal class Connect
    {
        public MySqlConnection connection;


        string db;
        string srv;
        string usr;
        string pass;


        string connectionString;

        public Connect()
        {
            srv = "localhost";
            db = "serial";
            usr = "root";
            pass = "";

            connectionString = "SERVER=" + srv + ";" + "DATABASE=" + db + ";" + "UID=" + usr + ";" + "PASSWORD=" + pass + ";" + "SslMode=None;";

            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                //MessageBox.Show("Sikeres csatlakozás");
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        

    }
}
