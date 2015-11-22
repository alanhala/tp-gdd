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
    public partial class modificarRol : Form
    {

        public modificarRol()
        {
            InitializeComponent();
        }

        private void dgvShowRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizarTabla()
        {
            dgvShowRoles.Rows.Clear();
            dgvShowRoles.Refresh();

            string query = "SELECT R.nombre FROM JUST_DO_IT.Roles AS R";
            System.Data.SqlClient.SqlDataReader reader = Server.getInstance().query(query);
            while (reader.Read())
            {
                dgvShowRoles.Rows.Add(reader["nombre"].ToString());
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

        private void modificarNombre_Click_1(object sender, EventArgs e)
        {
            
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvShowRoles);

//            if (int.Parse(row.Cells[0].Value.ToString()) == 0)
//            {
//                MessageBox.Show("No se ha seleccionado ningun rol");
//            }
//            else
//            {
                string nombreRol = row.Cells[0].Value.ToString();
                int idRol = Rol.obtenerID(nombreRol);

                new modificarNombre(idRol,nombreRol).Show();
                this.Hide();
//            }
        }

    

        private void agregarFuncionalidad_Click(object sender, EventArgs e)
        {
                DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvShowRoles);
            if (int.Parse(row.Cells[0].Value.ToString()) == 0)
            {
                MessageBox.Show("No se ha seleccionado ningun rol");
            }
            else
            {
                string nombreRol = row.Cells[0].Value.ToString();
                int idRol = Rol.obtenerID(nombreRol);

                new agregarFuncionalidad(idRol).Show();
                this.Hide();       
        }
    }

        private void quitarFunc_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Commons.getInstance().getSelectedRow(dgvShowRoles);
            if (int.Parse(row.Cells[0].Value.ToString()) == 0)
            {
                MessageBox.Show("No se ha seleccionado ningun rol");
            }
            else
            {
                string nombreRol = row.Cells[0].Value.ToString();
                int idRol = Rol.obtenerID(nombreRol);

                new quitarFuncionalidad(idRol).Show();
                this.Hide();       
        
            }
        }
    }
}
