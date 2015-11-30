﻿using System;
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
            try
            {
                DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvAeronaves);
                string matriculaNueva = row.Cells[0].Value.ToString();
                string query;
                if (finVidaUtil)
                {
                    query = "EXEC JUST_DO_IT.reemplazar_vuelos_aeronave_fin_vida_util '" + this.matriculaAReemplazar + "', '" + matriculaNueva + "'";
                }
                else {
                    query = "EXEC JUST_DO_IT.reemplazar_vuelos_aeronave_fuera_servicio '" + this.matriculaAReemplazar + "', '" + matriculaNueva + "', '" + this.fechaFueraServicio.Value.ToString("yyyy-dd-MM") + "', '" + this.fechaReinicioServicio.Value.ToString("yyyy-dd-MM") + "'";
                }
                SqlDataReader reader = Server.getInstance().query(query);
                MessageBox.Show("Los vuelos han sido reemplazados y la aeronave se dio de baja satisfactoriamente");
                reader.Close();
            }
            catch {
                MessageBox.Show("Error: Los vuelos no han sido reemplazados");
            }

        }
    }
}