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
    public partial class ReemplazoAeronave : Form
    {
        Boolean finVidaUtil;
        DateTimePicker fechaFueraServicio;
        DateTimePicker fechaReinicioServicio;

        private string matriculaAReemplazar;
        public ReemplazoAeronave(string matricula)
        {
            InitializeComponent();
            matriculaAReemplazar = matricula;
            finVidaUtil = true;
        }

        public ReemplazoAeronave(string matricula, DateTimePicker fechaFueraServicio, DateTimePicker fechaReinicioServicio)
        {
            InitializeComponent();
            matriculaAReemplazar = matricula;
            this.fechaFueraServicio = fechaFueraServicio;
            this.fechaReinicioServicio = fechaReinicioServicio;
            finVidaUtil = false;
        }

        private void ReemplazoAeronaveFinVidaUtil_Load(object sender, EventArgs e)
        {
            string query = "";
            if (finVidaUtil)
            {

            }
            else {
                query = "SELECT * FROM JUST_DO_IT.obtener_aeronaves_que_reemplacen_a('" + this.matriculaAReemplazar + "')";
            }
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvAeronaves.Rows.Add(reader["matricula"].ToString(), reader["butacas"].ToString(),
                    reader["kgs"].ToString(), reader["tipoServicio"].ToString());
            }
            reader.Close();
        }

        private void listadoDeRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReemplazarAeronave_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvAeronaves);
            string matriculaNueva = row.Cells[0].Value.ToString();
            string query = "EXEC JUST_DO_IT.reemplazar_vuelos_aeronave '" + this.matriculaAReemplazar + "', '" + matriculaNueva + "'";
            SqlDataReader reader = Server.getInstance().query(query);
            reader.Close();
        }
    }
}
