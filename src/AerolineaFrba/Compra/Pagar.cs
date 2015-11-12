using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class Pagar : Form, ClienteParaPasaje
    {
        private int vuelo_id;
        private float costo_viaje;
        private int usuario_id;

        public Pagar()
        {
        }

        public Pagar(int vuelo_id, float costo_viaje)
        {
            InitializeComponent();
            this.vuelo_id = vuelo_id;
            this.costo_viaje = costo_viaje;
            lblCosto.Text = this.costo_viaje.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSoyCliente_Click(object sender, EventArgs e)
        {
            new SoyCliente(this).Show();
        }

        public void cargarCliente(int id, string dni, string nombre, string apellido, string direccion, string telefono, string mail, string fecha)
        {
            this.usuario_id = id;

            this.txtDNI.Text = dni;
            this.txtDNI.Enabled = false;
            this.txtNombrePasajero.Text = nombre;
            this.txtNombrePasajero.Enabled = false;
            this.txtApellidoPasajero.Text = apellido;
            this.txtApellidoPasajero.Enabled = false;
            this.txtDireccionPasajero.Text = direccion;
            this.txtTelefonoPasajero.Text = telefono;
            this.txtMailPasajero.Text = mail;
            this.dtpFechaNacimientoPasajero.Text = fecha;
            this.dtpFechaNacimientoPasajero.Enabled = false;
        }

        private void btnPagaConTarjeta_Click(object sender, EventArgs e)
        {
            new pagoTarjeta(this).Show();
        }

        internal void cargarDatos(int numero, int codigo, int vencimiento, int cuotas)
        {
            
        }
    }
}
