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
        public SeleccionarSiDarDeBajaOCancelarVuelos()
        {
            
        }

        public SeleccionarSiDarDeBajaOCancelarVuelos(string unaMatricula)
        {
            InitializeComponent();
            matricula = unaMatricula;
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

            string comboQuery = "SELECT vuelos.id FROM JUST_DO_IT.Vuelos AS vuelos, JUST_DO_IT.Aeronaves AS aeronaves WHERE vuelos.aeronave_id = aeronaves.id AND vuelos.aeronave_id = " + idAeronave;
            respuesta = server.query(comboQuery);
            while (respuesta.Read())
            {
               respuesta["vuelos.id"].ToString();
            }
            respuesta.Close();
        }
    }
}
