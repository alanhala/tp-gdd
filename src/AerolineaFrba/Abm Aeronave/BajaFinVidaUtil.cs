﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaFinVidaUtil : Form
    {
        public BajaFinVidaUtil()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            new SeleccionarSiDarDeBajaOCancelarVuelos(cbMatricula.Text).Show();
            this.chequearYProcederFrenteARutasProgramadas();
        }

        public void darDeBajaAeronave(string matricula) {
            try
            {
                Server.getInstance().realizarQuery("UPDATE JUST_DO_IT.Aeronaves SET baja_vida_util = 1 WHERE matricula = '" + matricula + "'");
                MessageBox.Show("La aeronave se dió de baja satisfactoriamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }
        private void chequearYProcederFrenteARutasProgramadas() {

        }

        private void BajaFinVidaUtil_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBoxOrderBy("AeronavesDisponiblesParaBaja()", "matricula", cbMatricula);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
