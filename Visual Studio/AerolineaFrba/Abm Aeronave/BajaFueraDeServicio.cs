﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaFueraDeServicio : Form
    {
        public BajaFueraDeServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            string bajaAeronave = "UPDATE JUST_DO_IT.Aeronaves SET baja_fuera_servicio = 1, fecha_fuera_servicio = '" + dtpFechaFueraServicio.Value.ToString("yyyy-dd-MM") + "' , fecha_reinicio_servicio = '" + dtpFechaReinicioServicio.Value.ToString("yyyy-dd-MM") + "' WHERE matricula = '" + tbNumeroMatricula.Text + "'";
            server.query(bajaAeronave);
            server.closeReader();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Baja_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaFueraServicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
