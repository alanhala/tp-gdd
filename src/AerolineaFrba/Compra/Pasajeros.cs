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
    public partial class Pasajeros : Form
    {
        private int vuelo_id;
        private float costo_viaje;

        public Pasajeros() { }
        public Pasajeros(int id, float costo)
        {
            InitializeComponent();
            this.vuelo_id = id;
            this.costo_viaje = costo;
        }

        public void agregarPasajero(string usuario, int usuario_id, string butaca)
        {
            lstPasajeros.Items.Add(usuario);
            string query = "EXEC JUST_DO_IT.reservarButaca " + usuario_id + ", " + this.vuelo_id + ", " + butaca;
            Server.getInstance().realizarQuery(query);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new AgregarPasajero(this.vuelo_id, this).Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (lstPasajeros.Items.Count == 0)
                MessageBox.Show("Debe agregar algun pasajero");
            else
            {
                new Pagar(this.vuelo_id, this.costo_viaje).Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM JUST_DO_IT.ButacasReservadas WHERE vuelo_id=" + this.vuelo_id;
            Server.getInstance().realizarQuery(query);
            new compraPasaje().Show();
            this.Hide();
        }
    }
}
