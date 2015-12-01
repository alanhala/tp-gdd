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
    public partial class altaRol_elegirFuncionalidades : Form
    {
        public int idRol;
        public altaRol_elegirFuncionalidades(int idR)
        {
            InitializeComponent();
            this.idRol = idR;
            Commons.getInstance().cargarComboBox("Funcionalidades","descripcion",comboBoxFunc);
        }

        private void btnAgregarFunc_Click(object sender, EventArgs e)
        {
            if (comboBoxFunc.Text == "")
            {
                MessageBox.Show("No ingresó una funcionalidad");
            }
            else
            {
                string descrFunc = comboBoxFunc.Text;
                int idFuncionalidad = Funcionalidad.obtenerID(descrFunc);
                string query = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + idRol + "," + idFuncionalidad;
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("La funcionalidad se agrego satisfactoriamente");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            }
        }

        private void btnAgregarMasFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.altaRol_elegirFuncionalidades(idRol).Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }


    }
}
