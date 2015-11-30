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
    public partial class Modificar_Ruta : Form
    {
        private double ruta;
        public Modificar_Ruta() { }

        public Modificar_Ruta(string id)
        {
            InitializeComponent();
            this.ruta = double.Parse(id);
        }

        private void Modificar_Ruta_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbCiudadOrigen);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbCiudadDestino);
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cmbTipoServicio);

            string query = "SELECT * FROM JUST_DO_IT.Rutas WHERE id=" + this.ruta;
            SqlDataReader reader = Server.getInstance().query(query);
            reader.Read();
            txtCodigoRuta.Text = reader["codigo"].ToString();
            txtPrecioBasePorKg.Text = reader["precio_baseKG"].ToString();
            txtPrecioBasePorPasaje.Text = reader["precio_basePasaje"].ToString();
            string id_origen = reader["ciu_id_origen"].ToString();
            string id_destino = reader["ciu_id_destino"].ToString();
            string tipo_servicio = reader["tipo_servicio"].ToString();
            reader.Close();
        }
    }
}
