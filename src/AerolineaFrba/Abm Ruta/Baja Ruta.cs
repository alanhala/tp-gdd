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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class Baja_Ruta : Form
    {
        public Baja_Ruta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Baja_Ruta_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbDestino);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbOrigen);
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            if (!(cmbDestino.Text == "" || cmbOrigen.Text == ""))
            {
                int origen = Ciudades.obtenerID(cmbOrigen.Text);
                int destino = Ciudades.obtenerID(cmbDestino.Text);
                List<string> codigos = new List<string>();
                List<int> servicios = new List<int>();
                string query = "SELECT codigo, tipo_servicio FROM JUST_DO_IT.Rutas WHERE ciu_id_origen=" + origen + " AND ciu_id_destino=" + destino;
                SqlDataReader reader = Server.getInstance().query(query);
                while (reader.Read())
                {
                    codigos.Add(reader["codigo"].ToString());
                    servicios.Add(int.Parse(reader["tipo_servicio"].ToString()));
                    
                }
                reader.Close();
                int i;
                for (i = 0; i < codigos.Count; i ++)
                {
                    string servicio = TiposServicios.obtenerNombre(servicios.ElementAt(i));
                    cmbRutas.Items.Add(codigos.ElementAt(i) + " - " + servicio);
                }
            }
        }
    }
}
