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
    public partial class AgregarPasajero : Form, ClienteParaPasaje
    {
        int vuelo_id;
        public AgregarPasajero()
        {
        }

        public AgregarPasajero(int id)
        {
            InitializeComponent();
            this.vuelo_id = id;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPasajero_Load(object sender, EventArgs e)
        {

        }

        public void cargarCliente(string dni, string nombre, string apellido, string direccion, string telefono, string mail)
        {
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
        }

        private void btnSoyCliente_Click(object sender, EventArgs e)
        {
            new SoyCliente(this).Show();
        }
    }
}
