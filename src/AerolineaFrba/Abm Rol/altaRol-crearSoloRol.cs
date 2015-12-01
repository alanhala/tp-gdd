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
    public partial class altaRol_crearSoloRol : Form
    {
        public altaRol_crearSoloRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //siguiente
        {
            if (nombreRol.Text.Trim() != "")
            {
                string nombreR = tbNombreNuevo.Text;
                string query_rol = "EXEC JUST_DO_IT.almacenarRol'" + nombreR + "'";
                try
                {
                    Server.getInstance().realizarQuery(query_rol);
                    int IdRol = Rol.obtenerID(nombreR);
                    new altaRol_elegirFuncionalidades(IdRol).Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No ingresó el nombre del nuevo rol");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
