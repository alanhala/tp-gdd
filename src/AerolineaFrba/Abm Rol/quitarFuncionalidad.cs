using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class quitarFuncionalidad : Form
    {
        public quitarFuncionalidad(int idRol)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dgvShowRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizarTabla()
        {
            dgvShowRoles.Rows.Clear();
            dgvShowRoles.Refresh();


            string query = "SELECT * FROM JUST_DO_IT.nombresRolesYFuncionalidades()";
            
            SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvShowRoles.Rows.Add(reader["nombreFuncionalidad"].ToString());
            }
            reader.Close();

        }

        private void seleccionar_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvShowRoles);
            if (int.Parse(row.Cells[1].Value.ToString()) == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna funcionalidad");
            }
            else
            {
                string nombreRol = row.Cells[0].Value.ToString();
                string descripcionFuncionalidad = row.Cells[1].Value.ToString();
                int idRol = Rol.obtenerID(nombreRol);
                int idFuncionalidad = Funcionalidad.obtenerID(descripcionFuncionalidad);

                string query = "EXEC JUST_DO_IT.bajaRol_Funcionalidad" + idRol + "," + idFuncionalidad;
                try
                {
                    Server.getInstance().realizarQuery(query);
                    MessageBox.Show("La funcionalidad se eliminó satisfactoriamente");
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
                this.Hide();
            }
        }
    }
}
