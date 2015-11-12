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

        private void button1_Click(object sender, EventArgs e)
        {

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
                string query_rol = "EXEC JUST_DO_IT.almacenarRol'" + nombre + "'";
                try
                {
                    Server.getInstance().realizarQuery(query_rol);
                    MessageBox.Show("El rol se agrego satisfactoriamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                int IdRol = Rol.obtenerID(nombre);
                int IdFuncionalidad1 = Funcionalidad.obtenerID(func1);

                string queryRol_Funcionalidad1 = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + IdRol + "," + IdFuncionalidad1;
                
                try
                {
                    Server.getInstance().realizarQuery(queryRol_Funcionalidad1);
                    MessageBox.Show("rol-funcionalidad agregado -> OK");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

//       private void validar_que_no_exista_el_rol(string nombre)
//       {
//            string rolExiste = "SELECT nombre FROM JUST_DO_IT.validarRolSinRepetidos '" + nombre + "'";
//            Server.getInstance().realizarQuery(rolExiste);
//        }

         private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFuncionalidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
