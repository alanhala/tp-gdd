using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Funcionalidades
{
    public partial class bajaFunc : Form
    {
        public bajaFunc()
        {
            InitializeComponent();
            Commons.getInstance().cargarComboBox("Funcionalidades", "descripcion", comboBoxFunc);
        }


        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Vistas_Inicio.Inicio_Admin().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxFunc.Text.Trim() != "")
            {
                string descripcion = comboBoxFunc.Text;

                string query = "EXEC JUST_DO_IT.eliminarFuncionalidad '" + descripcion + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("La funcionalidad se eliminó satisfactoriamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese la descripción");
            }
        }
    }
}
