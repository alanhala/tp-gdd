using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AeronaveAModificar : Form
    {
        private ObservableCollection<Aeronave> aeronaves;


        public AeronaveAModificar()
        {
            InitializeComponent();
            aeronaves = new ObservableCollection<Aeronave>();
            this.cargarAeronaves();
            this.dgvModificarAeronave.DataSource = aeronaves;
            dgvModificarAeronave.Columns["id"].Visible = false;
        }

        private void cargarAeronaves()
        {
            string query =
                "SELECT aeronaves.id, matricula, modelo, kgs_disponibles, butacas_totales, fabricante , tipoServicio.nombre AS tipo_servicio "
                    + "FROM JUST_DO_IT.Aeronaves aeronaves, JUST_DO_IT.TiposServicios tipoServicio "
                    + "WHERE aeronaves.tipo_servicio = tipoServicio.id "
                    + "ORDER BY aeronaves.id";
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                var aeronave = new Aeronave();
                aeronave.id = Convert.ToInt32(reader["id"]);
                aeronave.matricula = reader["matricula"].ToString();
                aeronave.modelo = reader["modelo"].ToString();
                aeronave.kgs_disponibles = Convert.ToInt32(reader["kgs_disponibles"]);
                aeronave.butacas_totales = Convert.ToInt32(reader["butacas_totales"]);
                aeronave.fabricante = reader["fabricante"].ToString();
                aeronave.servicio = reader["tipo_servicio"].ToString();

                aeronaves.Add(aeronave);

            }
            reader.Close();
        }

        private void AeronaveAModificar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aeronave aeronave = (Aeronave)dgvModificarAeronave.CurrentRow.DataBoundItem;
            new modificarAeronave(aeronave.matricula).Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
