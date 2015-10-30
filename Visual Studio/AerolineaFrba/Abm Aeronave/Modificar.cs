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
            string altaAeronave = "UPDATE JUST_DO_IT.Aeronaves(matricula, modelo, fabricante, tipo_servicio, kgs_disponibles) VALUES ('" + tbNumeroMatricula.Text + "', '" + tbModelo.Text + "', '" + cbFabricante.Text + "', '" + cbTipoServicio.Text + "', " + tbEspacioTotalParaEncomiendas.Text + ")";
            server.query(altaAeronave);
            server.closeReader();
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
            string queryComboBox = "SELECT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad + " WHERE " + condicion;
            respuesta = server.query(queryComboBox);
            respuesta.Read();
            string nombreAtributo = respuesta["atributo"].ToString();
            respuesta.Close();

            int idAtributo = 0;
            respuesta = server.query("SELECT DISTINCT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad);
            while (respuesta.Read()){
                if (String.CompareOrdinal(nombreAtributo, respuesta["atributo"].ToString()) == 0){
                    break;
                }
                idAtributo++;
            }
            comboBox.SelectedIndex = idAtributo;
            respuesta.Close();
        }

        public void cargarDateTimePicker(string entidad, string atributo, DateTimePicker dateTimePicker, string condicion)
        {
            Server server = Server.getInstance();
            string queryDateTimePicker = "SELECT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad + " WHERE " + condicion;
            respuesta = server.query(queryDateTimePicker);
            respuesta.Read();
            string nombreAtributo = respuesta["atributo"].ToString();
            dateTimePicker.Text = nombreAtributo;
            respuesta.Close();
        }

        public void cargarDatos()
        {
            this.cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            this.cargarComboBox("Aeronaves", "tipo_servicio", cbTipoServicio);
            this.cargarTextBox("Aeronaves", "matricula", tbNumeroMatricula);
            this.cargarTextBox("Aeronaves", "modelo", tbModelo);
            this.cargarTextBox("Aeronaves", "kgs_disponibles", tbEspacioTotalParaEncomiendas);
            this.autoCompletarCombo("Aeronaves", "fabricante", cbFabricante, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
            this.autoCompletarCombo("Aeronaves", "tipo_servicio", cbTipoServicio, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
            this.cargarDateTimePicker("Aeronaves", "fecha_reinicio_servicio", dtpFechaReinicioDeServicio, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
        }

        private void dtpFechaReinicioDeServicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbNumeroMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
