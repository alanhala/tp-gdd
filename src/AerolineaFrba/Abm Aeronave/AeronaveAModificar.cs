using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AeronaveAModificar : Form
    {
        public AeronaveAModificar()
        {
            InitializeComponent();
        }

        private void AeronaveAModificar_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBoxOrderBy("Aeronaves", "matricula", cbMatricula);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            new modificarAeronave(cbMatricula.Text).Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
