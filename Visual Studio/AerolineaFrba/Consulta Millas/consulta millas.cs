using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {
        public ConsultaMillas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            if (DNI.Trim() == "" || nombre.Trim() == "" || apellido.Trim() == "")
            {
                MessageBox.Show("Debe completar los 3 campos");
            }
            else
            {
                string query = "SELECT puntos.millas millas, puntos.vencimiento vencimiento FROM JUST_DO_IT.Puntos AS puntos, JUST_DO_IT.Usuarios AS usuarios " +
                    "WHERE usuarios.id = puntos.usuario_id AND usuarios.dni = '" + DNI + "' AND usuarios.nombre = '" + nombre + 
                    "' AND usuarios.apellido = '" + apellido + "'";
                SqlDataReader reader = Server.getInstance().query(query);
                int cont = 0;
                while (reader.Read())
                {
                    dgvDetalleMillas.Rows.Add(reader["millas"].ToString(), reader["vencimiento"].ToString(), "------");
                    cont++;
                }
                if (cont == 0)
                    MessageBox.Show("El usuario ingresado no existe o no posee millas");
                reader.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
