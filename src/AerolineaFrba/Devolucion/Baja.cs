using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void Baja_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Pasaje");
            cmbTipo.Items.Add("Paquete");
            cmbTipo.SelectedIndex = 0;
        }
    }
}
