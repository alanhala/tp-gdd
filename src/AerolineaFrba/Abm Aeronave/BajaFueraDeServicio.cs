using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaFueraDeServicio : Form
    {
        public BajaFueraDeServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "EXEC JUST_DO_IT.dar_de_baja_aeronave_por_fuera_de_servicio '" + cbMatricula.Text + "', '" + dtpFechaFueraServicio.Value.ToString("yyyy-dd-MM") + "', '" + dtpFechaReinicioServicio.Value.ToString("yyyy-dd-MM") + "'";
                Server.getInstance().realizarQuery(query);
                new SeleccionarSiDarDeBajaOCancelarVuelos(cbMatricula.Text, dtpFechaFueraServicio, dtpFechaReinicioServicio).Show();
                MessageBox.Show("La aeronave se dió de baja satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBoxOrderBy("Aeronaves", "matricula", cbMatricula);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaFueraServicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
