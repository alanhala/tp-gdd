using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class Alta : Form
    {
        public SqlDataReader respuesta;
        public string matriculaAReemplazar { get; set; }
        public Abm_Aeronave.ReemplazoAeronave owner { get; set; }

        public Alta()
        {
            InitializeComponent();
        }

        public Alta(string matriculaAReemplazar, Abm_Aeronave.ReemplazoAeronave owner)
        {
            InitializeComponent();
            this.matriculaAReemplazar = matriculaAReemplazar;
            this.owner = owner;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Aeronaves", "fabricante", cbFabricante);
            Commons.getInstance().cargarComboBox("TiposServicios", "nombre", cbTipoServicio);
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
            tbNumeroMatricula.Clear();
            tbModelo.Clear();
            cbFabricante.Items.Clear();
            cbTipoServicio.Items.Clear();
            tbCantButacas.Clear();
            tbEspacioTotalParaEncomiendas.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.validarCampos()) {
                if (this.aeronaveValida())
                {
                    string altaAeronave;
                    string generarButacas;
                    string matricula = tbNumeroMatricula.Text;
                    string modelo = tbModelo.Text;
                    string fabricante = this.buscarSegunPosicion(cbFabricante.SelectedIndex, "Aeronaves", "fabricante");
                    int tipoDeServicio = TiposServicios.obtenerID(cbTipoServicio.Text);
                    int espacioParaEncomiendas = int.Parse(tbEspacioTotalParaEncomiendas.Text);
                    int cantidadButacas = int.Parse(tbCantButacas.Text);

                    altaAeronave = "EXEC JUST_DO_IT.almacenarAeronave '" + matricula + "', '" + modelo + "', '" + fabricante + "', " + tipoDeServicio + ", " + espacioParaEncomiendas + ", " + cantidadButacas;
                    generarButacas = "EXEC JUST_DO_IT.generar_butacas '" + matricula + "', " + cantidadButacas;
                    try
                    {
                        Server.getInstance().realizarQuery(altaAeronave);
                        Server.getInstance().realizarQuery(generarButacas);
                        MessageBox.Show("La aeronave se agrego satisfactoriamente");
                        if (this.matriculaAReemplazar != null)
                        {
                            owner.aeronaveCreada(matricula);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe crear una aeronave con el mismo fabricante, tipo de servicio, cantidad de butacas y kilogramos disponibles");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar datos validos");
            }
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool validarCampos() {
            return (tbNumeroMatricula.Text.Trim() != "" && tbModelo.Text.Trim() != ""
                && cbFabricante.Text.Trim() != "" && cbTipoServicio.Text.Trim() != "" &&
                tbCantButacas.Text.Trim() != "" && tbEspacioTotalParaEncomiendas.Text.Trim() != "");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool aeronaveValida()
        {
            bool retorno;
            if (this.matriculaAReemplazar != null)
            {
                string query = "SELECT * FROM JUST_DO_IT.Aeronaves a, JUST_DO_IT.TiposServicios t WHERE a.tipo_servicio = t.id AND a.matricula = '" + matriculaAReemplazar + "'";
                SqlDataReader reader = Server.getInstance().query(query);
                reader.Read();
                retorno = this.cbFabricante.SelectedItem.ToString() == reader["fabricante"].ToString() && this.cbTipoServicio.SelectedItem.ToString() == reader["nombre"].ToString() &&
                this.tbCantButacas.Text.ToString() == reader["butacas_totales"].ToString() && this.tbEspacioTotalParaEncomiendas.Text == reader["kgs_disponibles"].ToString();
                reader.Close();
            }
            else retorno = true;
            return retorno;
        }

    }
}
