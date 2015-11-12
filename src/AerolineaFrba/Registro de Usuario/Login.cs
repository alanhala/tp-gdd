using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class Login : Form
    {
        Form previous;

        public Login() { }

        public Login(Form p)
        {
            InitializeComponent();
            this.previous = p;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            string queryLogueo = "SELECT * FROM JUST_DO_IT.Usuarios WHERE username='"+username.Text+"' AND pass='"+password.Text+"'";
            server.query(queryLogueo);
            if (server.successfullLog() == 1)
            {
                this.Hide();
                this.previous.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña invalidos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaMillas_Click(object sender, EventArgs e)
        {
            new Consulta_Millas.ConsultaMillas().Show();
        }
    }
}
