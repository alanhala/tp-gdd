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

namespace AerolineaFrba.Compra
{
    public partial class AgregarPasajero : Form, ClienteParaPasaje
    {
        private int vuelo_id;
        private bool clienteNuevo;

        public AgregarPasajero()
        {
        }

        public AgregarPasajero(int id)
        {
            InitializeComponent();
            this.vuelo_id = id;
            this.clienteNuevo = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPasajero_Load(object sender, EventArgs e)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT DISTINCT numero FROM JUST_DO_IT.butacasLibres(" + this.vuelo_id + ")";
            respuesta = server.query(queryCombo);
            int cont = 0;
            while (respuesta.Read())
            {
                cmbButacas.Items.Add(respuesta["numero"].ToString());
            }
            respuesta.Close();
        }

        public void cargarCliente(string dni, string nombre, string apellido, string direccion, string telefono, string mail, string fecha)
        {
            this.clienteNuevo = false;

            this.txtDNI.Text = dni;
            this.txtDNI.Enabled = false;
            this.txtNombrePasajero.Text = nombre;
            this.txtNombrePasajero.Enabled = false;
            this.txtApellidoPasajero.Text = apellido;
            this.txtApellidoPasajero.Enabled = false;
            this.txtDireccionPasajero.Text = direccion;
            this.txtDireccionPasajero.Enabled = false;
            this.txtTelefonoPasajero.Text = telefono;
            this.txtTelefonoPasajero.Enabled = false;
            this.txtMailPasajero.Text = mail;
            this.txtMailPasajero.Enabled = false;
            this.dtpFechaNacimientoPasajero.Text = fecha;
            this.dtpFechaNacimientoPasajero.Enabled = false;
        }

        private void btnSoyCliente_Click(object sender, EventArgs e)
        {
            new SoyCliente(this).Show();
        }
    }
}
