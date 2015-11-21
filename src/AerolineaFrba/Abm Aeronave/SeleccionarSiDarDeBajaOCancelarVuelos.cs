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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class SeleccionarSiDarDeBajaOCancelarVuelos : Form
    {
        public string matricula;
        DateTimePicker fechaFueraServicio;
        DateTimePicker fechaReinicioServicio;
        Boolean finVidaUtil;

        public SeleccionarSiDarDeBajaOCancelarVuelos()
        {
            
        }

        public SeleccionarSiDarDeBajaOCancelarVuelos(string unaMatricula)
        {
            InitializeComponent();
            matricula = unaMatricula;
            finVidaUtil = true;
        }

        public SeleccionarSiDarDeBajaOCancelarVuelos(string unaMatricula, DateTimePicker fechaFueraServicio, DateTimePicker fechaReinicioServicio)
        {
            InitializeComponent();
            matricula = unaMatricula;
            this.fechaFueraServicio = fechaFueraServicio;
            this.fechaReinicioServicio = fechaReinicioServicio;
            finVidaUtil = false;
        }

        private void SeleccionarSiDarDeBajaOCancelarVuelos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string query = "SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula('" + matricula + "') AS idAeronave";
            respuesta = server.query(query);
            respuesta.Read();
            string idAeronave = respuesta["idAeronave"].ToString();
            respuesta.Close();

            if (finVidaUtil)
            {
                string comboQuery = "SELECT vuelos.id FROM JUST_DO_IT.Vuelos AS vuelos WHERE vuelos.fecha_llegada IS NULL AND vuelos.fecha_salida > CURRENT_TIMESTAMP AND vuelos.vuelo_eliminado = 0 AND vuelos.aeronave_id = " + idAeronave;
                respuesta = server.query(comboQuery);
            }
            else {
                string comboQuery = "SELECT vuelos.id FROM JUST_DO_IT.Vuelos AS vuelos WHERE ((" + fechaFueraServicio.Text + " BETWEEN vuelos.fecha_salida AND vuelos.fecha_llegada) OR (" + fechaReinicioServicio.Text + " BETWEEN vuelos.fecha_salida AND vuelos.fecha_llegada)) AND vuelos.vuelo_eliminado = 0 AND vuelos.aeronave_id = " + idAeronave;
                respuesta = server.query(comboQuery);
            }
            while (respuesta.Read())
            {
                server.query("EXEC JUST_DO_IT.eliminar_vuelo " + respuesta["vuelos.id"].ToString());
            }
            respuesta.Close();
        }
    }
}
