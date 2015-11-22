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
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quitarFuncionalidad_Click(object sender, EventArgs e)
        {
            new Abm_Rol.quitarFuncionalidad().Show();
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
                dgvShowRoles.Rows.Add(reader["nombreRol"].ToString(), reader["nombreFuncionalidad"].ToString());
 //               dgvShowRoles.Rows.Add(reader["nombre"].ToString() + " - " + reader["baja_rol"].ToString());

            }
            reader.Close();

        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            this.actualizarTabla();
        }

    }
}
