using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quitarFuncionalidad_Click(object sender, EventArgs e)
        {
            new Abm_Rol.quitarFuncionalidad().Show();
        }
    }
}
