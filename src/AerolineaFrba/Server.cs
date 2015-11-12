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
        const string user = "gd";
        const string password = "gd2015";
        public static Server server;
        private string username;
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

        public int successfullLog()
        {
            int cont = 0;
            while (this.reader.Read())
            {
                this.username = this.reader["username"].ToString();
                cont++;
            }
            this.reader.Close();
            if (cont == 1)
                return cont;

            return 0;
        }

        public void closeReader()
        {
            this.reader.Close();
        }

        public void setUser(string username)
        {
            this.username = username;
        }

        public string getUser()
        {
            return this.username;
        }

        public void realizarQuery(string query) {
            this.query(query);
            this.closeReader();
        }

        private void conectar()
        {
            try
            {
                this.connection = new SqlConnection("Data Source=" + servidor +
                    ";Initial Catalog=" + db + ";Integrated Security=False;User ID=" + user + ";Password=" + password);
                this.connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
