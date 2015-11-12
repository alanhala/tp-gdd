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
        private bool clienteNuevo;
        private int vuelo_id;
        private int usuario_id;
        private Pasajeros form_pasajeros;
        public AgregarPasajero() {}

        public AgregarPasajero(int id, Pasajeros pasajeros)
        {
            InitializeComponent();
            this.vuelo_id = id;
            this.form_pasajeros = pasajeros;
            this.clienteNuevo = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPasajero_Load(object sender, EventArgs e)
        {
            SqlDataReader respuesta;
            Server server = Server.getInstance();
            string queryCombo = "SELECT id, numero, tipo FROM JUST_DO_IT.butacasLibres(" + this.vuelo_id + ") ORDER BY numero";
            respuesta = server.query(queryCombo);
            ComboBoxItem item = new ComboBoxItem();
            item.bindCombobox(cmbButacas);
            while (respuesta.Read())
            {
                item.Value = respuesta["id"].ToString();
                item.Text = respuesta["numero"].ToString() + " - " + respuesta["tipo"].ToString();
                cmbButacas.Items.Add (item);
            }

            respuesta.Close();
        }

        public void cargarCliente(int id, string dni, string nombre, string apellido, string direccion, string telefono, string mail, string fecha)
        {
            this.clienteNuevo = false;
            this.usuario_id = id;

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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           if (this.clienteNuevo)
                MessageBox.Show("El alta de usuario no era requerida, ingrese en soy cliente y entre con uno existente");
           else if (cmbButacas.Text == "")
               MessageBox.Show("Debe seleccionar una butaca");
           else
           {
               this.form_pasajeros.agregarPasajero(txtApellidoPasajero.Text + ", " + txtNombrePasajero.Text,
                                                   this.usuario_id,
                                                   ((ComboBoxItem)cmbButacas.SelectedItem).Value.ToString());
               this.Hide();
           }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
