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
    public partial class altaRol : Form
    {
        public altaRol()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Commons.getInstance().cargarComboBox("Funcionalidades", "descripcion", cbFuncionalidad1);
            Commons.getInstance().cargarComboBox("Funcionalidades", "descripcion", cbFuncionalidad2);
            Commons.getInstance().cargarComboBox("Funcionalidades", "descripcion", cbFuncionalidad3);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.Trim() != "")
            {
                string nombre = tbNombre.Text;
                string func1 = cbFuncionalidad1.Text;
                string func2 = cbFuncionalidad2.Text;
                string func3 = cbFuncionalidad3.Text;

                string query_rol = "EXEC JUST_DO_IT.almacenarRol'" + nombre + "'";
                try
                {
                    Server.getInstance().realizarQuery(query_rol);
                    int IdRol = Rol.obtenerID(nombre);
                    int IdFuncionalidad1 = Funcionalidad.obtenerID(func1);
                    string queryRol_Funcionalidad1 = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + IdRol + "," + IdFuncionalidad1;
                    
                    int IdFuncionalidad2 = Funcionalidad.obtenerID(func2);
                    string queryRol_Funcionalidad2 = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + IdRol + "," + IdFuncionalidad2;
                    
                    int IdFuncionalidad3 = Funcionalidad.obtenerID(func1);
                    string queryRol_Funcionalidad3 = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + IdRol + "," + IdFuncionalidad3;

                    try
                    {
                        Server.getInstance().realizarQuery(queryRol_Funcionalidad1);
                        Server.getInstance().realizarQuery(queryRol_Funcionalidad2);
                        Server.getInstance().realizarQuery(queryRol_Funcionalidad3);
                        MessageBox.Show("El rol se agrego satisfactoriamente");
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message);
                    }
                }              
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
        }

         private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFuncionalidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
