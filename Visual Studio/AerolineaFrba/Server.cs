using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AerolineaFrba
{
    class Server
    {
        const string servidor = "localhost\\SQLSERVER2012";
        const string db = "GD2C2015";
        const string user = "sa";
        const string password = "gestiondedatos";
        public static Server server;
        private SqlConnection connection;

        public SqlConnection getConnection()
        {
            return this.connection;
        }

        public static Server getInstance()
        {
            if (server == null)
            {
                server = new Server();
                server.conectar();
            }
            return server;
        }

        public void conectar()
        {
            try
            {
                connection = new SqlConnection("Data Source=" + servidor +
                    ";Initial Catalog=" + db + ";Integrated Security=False;User ID=" + user + ";Password=" + password);
                connection.Open();
                MessageBox.Show("sii");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
