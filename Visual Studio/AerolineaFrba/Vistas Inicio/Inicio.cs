using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void invitado_CheckedChanged(object sender, EventArgs e)
        {
            new Vistas_Inicio.Menu_Invitado().Show();

        }

        private void administrador_CheckedChanged(object sender, EventArgs e)
        {
            new Vistas_Inicio.Inicio_Admin().Show();
        }
    }
}
