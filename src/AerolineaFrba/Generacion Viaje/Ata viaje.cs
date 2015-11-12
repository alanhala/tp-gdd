using AerolineaFrba.Abm_Aeronave;
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
        public Aeronave aeronave_seleccionada { get; set; }

        public Alta_Viaje()
        {
            InitializeComponent();
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            if (this.fechasValidas())
            {
                var ListadoView = new Abm_Ruta.Listado_Rutas(this);
                ListadoView.Show();
            }
            else
            {
                MessageBox.Show("La Fecha de Salida debe ser previa a la Fecha de Llegada Estimada");
            }
            
        }

        public void cargarLabelsRuta(Ruta ruta)
        {
            ruta_seleccionada = ruta;
            lblCiudadOrigen.Text = ruta_seleccionada.ciudad_origen;
            lblCiudadDestino.Text = ruta_seleccionada.ciudad_destino;
        }

        public void cargarLabelsAeronave(Aeronave aeronave)
        {
            aeronave_seleccionada = aeronave;
            lblTipoServicioAeronave.Text = aeronave_seleccionada.servicio;
            lblKgDisponiblesEncomiendasAeronave.Text = aeronave_seleccionada.kgs_disponibles.ToString();
            lblCantButacasAeronave.Text = aeronave_seleccionada.butacas_totales.ToString();
            lblModeloAeronave.Text = aeronave_seleccionada.modelo;
            lblMatriculaAeronave.Text = aeronave_seleccionada.matricula;
            lblFabricanteAeronave.Text = aeronave_seleccionada.fabricante;
        }

        private void btnSeleccionarAeronave_Click(object sender, EventArgs e)
        {
            if (this.fechasValidas())
            {
                var ListadoView = new Abm_Aeronave.Listado_Aeronaves(this, dtpFechaSalidaVuelo.Value, dtpFechaLlegadaEstimadaVuelo.Value);
                ListadoView.Show();
            }
            else
            {
                MessageBox.Show("La Fecha de Salida debe ser previa a la Fecha de Llegada Estimada");
            }   
        }

        public bool fechasValidas()
        {
            return (dtpFechaSalidaVuelo.Value < dtpFechaLlegadaEstimadaVuelo.Value);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ruta_seleccionada != null || aeronave_seleccionada != null)
            {
                string query = "EXEC JUST_DO_IT.almacenarVuelo '" + dtpFechaSalidaVuelo.Value + "', '" + dtpFechaLlegadaEstimadaVuelo.Value + "', " + ruta_seleccionada.id + ", " + aeronave_seleccionada.id +
                                ", " + aeronave_seleccionada.butacas_totales + ", '" + ruta_seleccionada.servicio + "', '" + aeronave_seleccionada.servicio + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("El vuelo se agrego satisfactoriamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ruta y una aeronave");
            }
                
        }

        private void dtpFechaSalidaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.emptyForm();
        }

        public void emptyForm()
        {
            lblCantButacasAeronave.Text = "";
            lblCiudadDestino.Text = "";
            lblCiudadOrigen.Text = "";
            lblFabricanteAeronave.Text = "";
            lblKgDisponiblesEncomiendasAeronave.Text = "";
            lblMatriculaAeronave.Text = "";
            lblModeloAeronave.Text = "";
            lblTipoServicioAeronave.Text = "";
            ruta_seleccionada = null;
            aeronave_seleccionada = null;
        }

        private void dtpFechaLlegadaEstimadaVuelo_ValueChanged(object sender, EventArgs e)
        {
            this.emptyForm();
        }
    }
}
