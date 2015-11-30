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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaFueraDeServicio : Form
    {
        public AltaFueraDeServicio()
        {
            InitializeComponent();
            this.cargarComboBox();
        }

        public void cargarComboBox()
        {
            string query = "SELECT matricula FROM JUST_DO_IT.Aeronaves WHERE baja_fuera_servicio = 1";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                this.comboBox1.Items.Add(reader["matricula"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matricula = this.comboBox1.SelectedItem.ToString();
            string query = "EXEC JUST_DO_IT.alta_aeronave_fuera_de_servicio('" + matricula + "')";
            Server.getInstance().realizarQuery(query);
            this.Close(); 
        }
    }
}
