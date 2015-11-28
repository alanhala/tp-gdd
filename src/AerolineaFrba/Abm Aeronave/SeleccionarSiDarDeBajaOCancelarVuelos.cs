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
using System.Collections;

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
            try
            {
                SqlDataReader respuestaAeronave;
                Server server = Server.getInstance();
                string query = "SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula('" + matricula + "') AS idAeronave";
                respuestaAeronave = server.query(query);
                respuestaAeronave.Read();
                int idAeronave = int.Parse(respuestaAeronave["idAeronave"].ToString());
                respuestaAeronave.Close();
                SqlDataReader respuestaVuelo;

                if (finVidaUtil)
                {
                    string comboQuery = "SELECT vuelos FROM JUST_DO_IT.obtener_vuelos_segun_id_aeronave(" + idAeronave + ")";
                    respuestaVuelo = server.query(comboQuery);
                }
                else
                {
                    string comboQuery = "SELECT vuelos FROM JUST_DO_IT.obtener_vuelos_segun_id_aeronave_y_fechas(" + idAeronave + ", " + fechaFueraServicio.Text + ", " + fechaReinicioServicio.Text + ")";
                    respuestaVuelo = server.query(comboQuery);
                }
                ArrayList vuelos = new ArrayList();
                int cantVuelos = 0;

                while (respuestaVuelo.Read())
                {
                    vuelos.Add(int.Parse(respuestaVuelo["vuelos"].ToString()));
                    cantVuelos++;
                }

                respuestaVuelo.Close();

                foreach (object vuelo in vuelos)
                {
                    query = "EXEC JUST_DO_IT.eliminar_vuelos " + vuelo;
                    server.query(query);
                }
                MessageBox.Show("Los vuelos se han cancelado");
                if (finVidaUtil)
                {
                    new BajaFinVidaUtil().darDeBajaAeronave(matricula);
                }
                else {
                    new BajaFueraDeServicio().darDeBajaAeronave(matricula, this.fechaFueraServicio, this.fechaReinicioServicio);
                }
            }
            catch {
                MessageBox.Show("Los vuelos no fueron cancelados");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReemplazarAeronave_Click(object sender, EventArgs e)
        {
            if (finVidaUtil)
            {
                new ReemplazoAeronave(matricula).Show();
            }
            else 
            {
                new ReemplazoAeronave(matricula, this.fechaFueraServicio, this.fechaReinicioServicio).Show();
            }
        }
    }
}
