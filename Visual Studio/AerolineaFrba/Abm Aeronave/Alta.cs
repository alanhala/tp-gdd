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
    public partial class Alta : Form
    {
        public SqlDataReader respuesta;


        public Alta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            this.cargarComboBox("Aeronaves", "tipo_servicio", cbTipoServicio);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            string altaAeronave = "INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, fabricante, tipo_servicio, kgs_disponibles)"+
            " VALUES (" + tbNumeroMatricula.Text + " , " + tbModelo.Text + " , 'cbFabricante.Text','Ejecutivo', 123 )";
            server.query(altaAeronave);
            server.closeReader();
        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbModelo_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void tbEspacioTotalParaEncomiendas_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cargarComboBox(string entidad, string atributo, ComboBox comboBox)
        {
            Server server = Server.getInstance();
            string queryCombo = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " AS " + entidad;
            respuesta = server.query(queryCombo);

            while (respuesta.Read())
            {
                comboBox.Items.Add(respuesta[atributo].ToString());
            }
            respuesta.Close();
        }

    }
}
