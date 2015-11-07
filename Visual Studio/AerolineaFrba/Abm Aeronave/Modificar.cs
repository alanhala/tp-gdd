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
        private string matriculaAModificar;
        public modificarAeronave()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cargarDatos(); 
            //this.matriculaAModificar = ..
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server server = Server.getInstance();
            if (this.validarCampos())
            {
                string matricula = tbNumeroMatricula.Text;
                string modelo = tbModelo.Text;
                string fabricante = this.buscarSegunPosicion(cbFabricante.SelectedIndex, "Aeronaves", "fabricante");
                int tipoDeServicio = TiposServicios.obtenerID(cbTipoServicio.Text);
                int espacioParaEncomiendas = int.Parse(tbEspacioTotalParaEncomiendas.Text);
                string fechaFueraServicio = dtpFechaFueraDeServicio.Value.ToString("yyyy-dd-MM");
                string fechaReinicioServicio = dtpFechaReinicioDeServicio.Value.ToString("yyyy-dd-MM");

                string modificarAeronave = "EXEC JUST_DO_IT.modificarAeronave '" + matricula + "', '" + modelo + "', '" + fabricante + "', " + tipoDeServicio + ", " + espacioParaEncomiendas + ", " + fechaReinicioServicio + ", " + fechaFueraServicio;
                try
                {
                    Server.getInstance().realizarQuery(modificarAeronave);
                    MessageBox.Show("La aeronave se modifico satisfactoriamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            Commons.getInstance().cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            Commons.getInstance().cargarComboBox("Aeronaves", "tipo_servicio", cbTipoServicio);
            this.cargarTextBox("Aeronaves", "matricula", tbNumeroMatricula);
            this.cargarTextBox("Aeronaves", "modelo", tbModelo);
            this.cargarTextBox("Aeronaves", "kgs_disponibles", tbEspacioTotalParaEncomiendas);
            this.autoCompletarCombo("Aeronaves", "fabricante", cbFabricante, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
            this.autoCompletarCombo("Aeronaves", "tipo_servicio", cbTipoServicio, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
            this.cargarDateTimePicker("Aeronaves", "fecha_reinicio_servicio", dtpFechaReinicioDeServicio, "Aeronaves.matricula = '" + tbNumeroMatricula.Text + "'");
        }

        private bool validarCampos()
        {
            return (tbNumeroMatricula.Text.Trim() != "" && tbModelo.Text.Trim() != ""
                && cbFabricante.Text.Trim() != "" && cbTipoServicio.Text.Trim() != "" &&
                 tbEspacioTotalParaEncomiendas.Text.Trim() != "");
        }

        public string buscarSegunPosicion(int posicion, string entidad, string atributo)
        {
            Server server = Server.getInstance();
            SqlDataReader respuesta = server.query("SELECT DISTINCT " + atributo + " AS atributo FROM JUST_DO_IT." + entidad);
            for (int i = 0; i <= posicion; i++)
            {
                respuesta.Read();
            }
            string fabricante = respuesta["atributo"].ToString();
            respuesta.Close();
            return fabricante;
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
