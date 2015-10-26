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
            Server server = Server.getInstance();
            string altaAeronave = "UPDATE JUST_DO_IT.Aeronaves(matricula, modelo, fabricante, tipo_servicio, kgs_disponibles) VALUES (" + tbNumeroMatricula.Text + ", " + tbModelo.Text + ", " + cbFabricante.Text + ", " + cbTipoServicio.Text + ", " + tbEspacioTotalParaEncomiendas.Text + ")";
            server.query(altaAeronave);
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

        public void autoCompletarCombo(string entidad, string atributo, ComboBox comboBox, string condicion) {
            Server server = Server.getInstance();
            string queryComboBox = "SELECT " + atributo + " FROM JUST_DO_IT." + entidad + " WHERE " + condicion;
            respuesta = server.query(queryComboBox);
            respuesta.Read();
            string fabricante = respuesta.GetString(1);
            int idFabricante = 4;
            if (fabricante == "Airbus") {
                idFabricante = 0;
            }
            else if (fabricante == "Boeing")
            {
                idFabricante = 1;
            }
            else if (fabricante == "Bombardier") {
                idFabricante = 2;
            }
            else if (fabricante == "Embraer")
            {
                idFabricante = 3;
            }
            comboBox.SelectedIndex = idFabricante;
            respuesta.Close();
        }

        public void cargarDatos()
        {
            this.cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            this.autoCompletarCombo("Aeronaves", "fabricante", cbFabricante, "'tbNumeroMatricula' = 'Aeronaves.matricula'");
            
            this.cargarComboBox("Aeronaves", "tipo_servicio", cbTipoServicio);
            this.cargarTextBox("Aeronaves", "matricula", tbNumeroMatricula);
            this.cargarTextBox("Aeronaves", "modelo", tbModelo);
            this.cargarTextBox("Aeronaves", "kgs_disponibles", tbEspacioTotalParaEncomiendas);
        }
    }
}
