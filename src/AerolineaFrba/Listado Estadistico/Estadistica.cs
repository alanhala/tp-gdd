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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class Estadistica : Form
    {
        public Estadistica()
        {
            InitializeComponent();
            this.cargarDestinosConPasajesMasComprados();
            this.cargarTopAeronavesFueraDeServicio();
            this.cargarDestinosConAeronavesMasVacias();
            this.clientesConMasPuntos();
        }

        private void Estadistica_Load(object sender, EventArgs e)
        {
            

        }

        private void cargarDestinosConAeronavesMasVacias()
        {
            string query = "SELECT * FROM JUST_DO_IT.DestinosConAeronavesMasVacias()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvDestinosConAeronavesMasVacias.Rows.Add(reader["destino"].ToString(), reader["cantidad"].ToString());
            }
            reader.Close();
        }
        private void cargarDestinosConPasajesMasComprados()
        {
            string query = "SELECT * FROM JUST_DO_IT.DestinosConPasajesMasComprados()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvDestinosMasPasajesComprados.Rows.Add(reader["ciudad"].ToString(), reader["cantidad"].ToString());
            }
            reader.Close();
        }

        public void cargarTopAeronavesFueraDeServicio()
        {
            string query = "SELECT * FROM JUST_DO_IT.top_aeroanves_fuera_de_servicio()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvAeronavesConMayorCantDiasFueraDeServicio.Rows.Add(reader["matricula"].ToString(), reader["cantidad_dias"].ToString());
            }
            reader.Close();
        }

        public void clientesConMasPuntos()
        {
            string query = "SELECT * FROM JUST_DO_IT.usuarios_con_mas_puntaje()";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvClientesConMasPuntos.Rows.Add(reader["nombre"].ToString(), reader["apellido"].ToString(), reader["millas_totales"].ToString());
            }
            reader.Close();
        }
    }
}
