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
        }

        private void Estadistica_Load(object sender, EventArgs e)
        {
            this.cargarDestinosConPasajesMasComprados();
        }

        private void cargarDestinosConPasajesMasComprados()
        {
            string query = "SELECT TOP 5 ciudades.nombre ciudad, COUNT(pasajes.codigo) cantidad " +
                "FROM JUST_DO_IT.Ciudades ciudades, JUST_DO_IT.Pasajes pasajes, JUST_DO_IT.Vuelos vuelos, JUST_DO_IT.Rutas rutas " +
                "WHERE vuelos.id = Pasajes.vuelo_id AND rutas.id = vuelos.ruta_id AND rutas.ciu_id_destino = ciudades.id " +
                "GROUP BY ciudades.nombre ORDER BY cantidad DESC";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvDestinosMasPasajesComprados.Rows.Add(reader["ciudad"].ToString(), reader["cantidad"].ToString());
            }
        }
    }
}
