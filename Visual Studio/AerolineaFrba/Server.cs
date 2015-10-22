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
        private SqlDataReader reader;

        public static Server getInstance()
        {
            if (server == null)
            {
                server = new Server();
                server.conectar();
            }
            return server;
        }

        public SqlDataReader query(string query)
        {
            SqlCommand command = new SqlCommand(query, this.connection);
            this.reader = command.ExecuteReader();
            return this.reader;
        }

        public int rowsLastQuery()
        {
            int cont = 0;
            while (this.reader.Read())
                cont++;
            return cont;
        }
        

        public void conectar()
        {
            try
            {
                connection = new SqlConnection("Data Source=" + servidor +
                    ";Initial Catalog=" + db + ";Integrated Security=False;User ID=" + user + ";Password=" + password);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
