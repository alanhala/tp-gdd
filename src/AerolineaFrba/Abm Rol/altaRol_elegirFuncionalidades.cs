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
        public string nombreRol1;
        public int primeraEjecución=0;

        public altaRol_elegirFuncionalidades(string nombreR)
        {
            InitializeComponent();
            nombreRol1 = nombreR;
            Commons.getInstance().cargarComboBox("Funcionalidades","descripcion",comboBoxFunc);
            
        }



        private void btnAgregarFunc_Click(object sender, EventArgs e)
        {
            if (comboBoxFunc.Text == "")
                MessageBox.Show("No ingresó una funcionalidad");
            else
            {
                string descrFunc = comboBoxFunc.Text;
                string query = "EXEC JUST_DO_IT.existeFuncionalidad '" + descrFunc + "'";
                try
                {
                    Server.getInstance().realizarQuery(query);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    return;
                }

                if (primeraEjecución == 0)
                {
                    query = "EXEC JUST_DO_IT.almacenarRol '" + nombreRol1 + "'";
                    try
                    {
                        primeraEjecución = 1;
                        Server.getInstance().realizarQuery(query);
                        idRol = Rol.obtenerID(nombreRol1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Hide();
                        new Vistas_Inicio.Inicio_Admin().Show();
                        return;
                    }
                }

                int idFuncionalidad = Funcionalidad.obtenerID(descrFunc);
                query = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + idRol + "," + idFuncionalidad;
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // controlar que el rol ya tenga asignado por lo menos 1 funcionalidad
            System.Data.SqlClient.SqlDataReader respuesta;
            string query = "SELECT JUST_DO_IT.cantFuncionalidadQuePosee (" + idRol + ") AS atributo";
            respuesta = Server.getInstance().query(query);
            respuesta.Read();
            string atributo = respuesta["atributo"].ToString();
            respuesta.Close();

            if (atributo == "0")
                MessageBox.Show("No ha seleccionado ninguna funcionalidad para el nuevo rol");

        }
        
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlDataReader respuesta;
            string query = "SELECT JUST_DO_IT.cantFuncionalidadQuePosee (" + idRol + ") AS atributo";
            respuesta = Server.getInstance().query(query);
            respuesta.Read();
            string atributo = respuesta["atributo"].ToString();
            respuesta.Close();

            if (atributo == "0")
                MessageBox.Show("No ha seleccionado ninguna funcionalidad para el nuevo rol");
            else
            {
                this.Hide();
                new Vistas_Inicio.Inicio_Admin().Show();
            }
        }


    }
}
