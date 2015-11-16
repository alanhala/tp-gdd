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
    public partial class bajaRol : Form
    {
        public bajaRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //aceptar
        {
            if (tbNombre.Text.Trim() != "")
            {
                try
                {
                    string nombre = tbNombre.Text;
                    string query_rol = "EXEC JUST_DO_IT.bajaRol '" + nombre + "'";
                    Server.getInstance().realizarQuery(query_rol);
                    MessageBox.Show("El rol se ha dado de baja correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // cancelar
        {
            this.Close();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
