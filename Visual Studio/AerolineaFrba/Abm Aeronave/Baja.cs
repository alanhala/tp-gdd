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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BajaFinVidaUtil().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BajaFueraDeServicio().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
