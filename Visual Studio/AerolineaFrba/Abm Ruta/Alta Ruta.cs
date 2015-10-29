﻿using System;
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
    public partial class Alta_Ruta : Form
    {
        public Alta_Ruta()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cmbTipoServicio);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbOrigen);
            Commons.getInstance().cargarComboBox("Ciudades", "nombre", cmbDestino);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            float kgs = float.Parse(txtPrecioBasePorKg.Text);
            float pasaje = float.Parse(txtPrecioBasePorPasaje.Text);
            int destino = Commons.getInstance().obtenerIDCiudad(cmbDestino.Text);
            int origen = Commons.getInstance().obtenerIDCiudad(cmbOrigen.Text);
            string servicio = cmbTipoServicio.Text;

            string query = "JUST_DO_IT.almacenarRuta(" + codigo + ", " + kgs + ", " + pasaje + ", " + origen + ", " +
                destino + ", " + servicio + ")";
            Server.getInstance().realizarQuery(query);  
        }
    }
}
