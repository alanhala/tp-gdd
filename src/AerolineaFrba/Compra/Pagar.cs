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
        private string numero;
        private string codigo;
        private string vencimiento;
        private string cuotas;
        private string tipo;
        private bool efectivo;
        private bool soyCliente;
        private bool cargoPago;

        public Pagar()
        {
        }

        public Pagar(int vuelo_id, float costo_viaje)
        {
            InitializeComponent();
            this.vuelo_id = vuelo_id;
            this.costo_viaje = costo_viaje;
            lblCosto.Text = this.costo_viaje.ToString();
            this.soyCliente = false;
            this.cargoPago = false;
            this.efectivo = false;

            this.numero = "NULL";
            this.codigo = "NULL";
            this.vencimiento = "NULL";
            this.cuotas = "1";
            this.tipo = "NULL";
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

            this.soyCliente = true;
        }

        private void btnPagaConTarjeta_Click(object sender, EventArgs e)
        {
            new pagoTarjeta(this).Show();
        }

        internal void cargarDatosTarjeta(string numero, string codigo, string vencimiento, string cuotas, string tipo)
        {
            this.numero = numero;
            this.codigo = codigo;
            this.vencimiento = vencimiento;
            this.cuotas = cuotas;
            this.tipo = tipo;
            this.cargoPago = true;
            this.btnPagaEnEfectivo.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!this.soyCliente)
            {
                MessageBox.Show("El alta de usuario no era requerida, ingrese en soy cliente y entre con uno existente");
            }
            else if (this.cargoPago)
            {
                try
                {
                    string query;
                    if (this.txtMailPasajero.Text == "" || this.txtDireccionPasajero.Text == "" || this.txtTelefonoPasajero.Text == "")
                        MessageBox.Show("Debe completar todos los campos");
                    else
                    {
                        query = "EXEC JUST_DO_IT.actualizarUsuario " + this.usuario_id + ", " + this.txtMailPasajero.Text + ", "
                                   + this.txtDireccionPasajero.Text + ", " + this.txtTelefonoPasajero.Text;
                        Server.getInstance().realizarQuery(query);
                        int idMedioDePago;
                        if (this.efectivo)
                            idMedioDePago = MedioDePago.obtenerID("Efectivo");
                        else
                            idMedioDePago = MedioDePago.obtenerID(this.tipo);

                        query = "EXEC JUST_DO_IT.almacenarPasaje " + this.vuelo_id + ", " + this.costo_viaje + ", " +
                                        this.usuario_id + ", " + this.numero + ", " + this.codigo + ", " + this.vencimiento + ", " +
                                        this.cuotas + ", " + idMedioDePago;
                        Server.getInstance().realizarQuery(query);
                        MessageBox.Show("El pasaje ha sido almacenado");
                        new Vistas_Inicio.Inicio_Admin().Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Debe elegir un medio de pago");
        }

        private void btnPagaEnEfectivo_Click(object sender, EventArgs e)
        {
            btnPagaConTarjeta.Enabled = false;
            this.efectivo = true;
            this.cargoPago = true;
        }
    }
}
