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

namespace AerolineaFrba.Compra
{
    public partial class compraPasaje : Form
    {
        public compraPasaje()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("ciudades", "nombre", cmbOrigen);
            Commons.getInstance().cargarComboBox("ciudades", "nombre", cmbDestino);
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void dtpFechaSalidaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void dtpFechaLlegadaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void actualizarTabla()
        {
            if (cmbOrigen.Text == "" || cmbDestino.Text == "")
            {
            }
            else
            {
                int origen = Ciudades.obtenerID(cmbOrigen.Text);
                int destino = Ciudades.obtenerID(cmbDestino.Text);
                string query = "SELECT * FROM JUST_DO_IT.vuelosDisponibles(" + origen + ", " + destino + ", '" +
                    dtpFechaSalidaVuelo.Value.ToString("yyyy-dd-MM") + "')";
                SqlDataReader reader = Server.getInstance().query(query);
                while (reader.Read())
                {
                    dgvViajesDisponibles.Rows.Add(reader["vuelo"].ToString(), reader["cantidad"].ToString(),
                            reader["kgsDisponibles"].ToString(), reader["salida"].ToString(), reader["llegada"].ToString(),
                            reader["tipoServicio"].ToString());
                }
                reader.Close();
            }
        }

    }
}
