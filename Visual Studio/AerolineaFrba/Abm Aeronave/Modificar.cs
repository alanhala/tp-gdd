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
    public partial class modificarAeronave : Form
    {

        public SqlDataReader respuesta;

        public modificarAeronave()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarDatos(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        public void cargarTextBox(string entidad, string atributo, TextBox textbox)
        {
            Server server = Server.getInstance();
            string queryTextBox = "SELECT DISTINCT " + atributo + " FROM JUST_DO_IT." + entidad + " AS " + entidad;
            respuesta = server.query(queryTextBox);

            respuesta.Read();
            textbox.Text = Convert.ToString(respuesta[atributo]);

            respuesta.Close();
        }

        public void cargarDatos()
        {
            this.cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            this.cargarComboBox("Aeronaves", "tipo_servicio", cbTipoServicio);
            this.cargarTextBox("Aeronaves", "matricula", tbNumeroMatricula);
            this.cargarTextBox("Aeronaves", "modelo", tbModelo);
            this.cargarTextBox("Aeronaves", "kgs_disponibles", tbEspacioTotalParaEncomiendas);
        }
    }
}
