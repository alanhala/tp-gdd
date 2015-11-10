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
        private List<int> usuarios;
        private List<int> butacas;

        public Pasajeros() { }
        public Pasajeros(int id, float costo)
        {
            InitializeComponent();
            this.vuelo_id = id;
            this.costo_viaje = costo;
            this.usuarios = new List<int>();
            this.butacas = new List<int>();
        }

        public void agregarPasajero(string usuario, int usuario_id, string butaca)
        {
            lstPasajeros.Items.Add(usuario);
            this.usuarios.Add(usuario_id);
            this.butacas.Add(int.Parse(butaca));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new AgregarPasajero(this.vuelo_id, this).Show();
        }


    }
}
