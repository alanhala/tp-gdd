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



        private void aceptar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvFuncionalidades);
            if (row == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna funcionalidad");
                return;
            }

            if (nombreRol.Text.Trim() != "")
            {
                string nombreR = nombreRol.Text;
                string query_rol = "EXEC JUST_DO_IT.almacenarRol'" + nombreR + "'";
                try
                {
                    Server.getInstance().realizarQuery(query_rol);
                    int IdRol = Rol.obtenerID(nombreR);

//                    foreach (DataGridViewRow row in dgvFuncionalidades.SelectedRows)

                    string descripcionFuncionalidad = row.Cells[0].Value.ToString();
                    int idFuncionalidad = Funcionalidad.obtenerID(descripcionFuncionalidad);
                    string query = "EXEC JUST_DO_IT.almacenarRol_Funcionalidad " + IdRol + "," + idFuncionalidad;

                    try
                    {
                        Server.getInstance().realizarQuery(query);
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


        private void actualizarTabla()
        {
            dgvFuncionalidades.Rows.Clear();
            dgvFuncionalidades.Refresh();

            string query = "SELECT * FROM JUST_DO_IT.Funcionalidades";

            System.Data.SqlClient.SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvFuncionalidades.Rows.Add(reader["descripcion"].ToString());
            }
            reader.Close();

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
