using AerolineaFrba.Abm_Ruta;
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

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class Alta_Viaje : Form
    {
        public Ruta ruta_seleccionada{ get; set; }

        public Alta_Viaje()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Alta_Viaje_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            var ListadoView = new Abm_Ruta.Listado_Rutas(this);
            ListadoView.Show();
        }

        public void cargarLabels(Ruta ruta)
        {
            ruta_seleccionada = ruta;
            lblCiudadOrigen.Text = ruta_seleccionada.ciudad_origen;
            lblCiudadDestino.Text = ruta_seleccionada.ciudad_destino;
        }

        private void btnSeleccionarAeronave_Click(object sender, EventArgs e)
        {
            var ListadoView = new Abm_Aeronave.Listado_Aeronaves(this, dtpFechaSalidaVuelo.Value, dtpFechaLlegadaEstimadaVuelo.Value);
            ListadoView.Show();   
        }
    }
}
