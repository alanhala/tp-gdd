using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Vistas_Inicio
{
    public partial class Inicio_Admin : Form
    {
        public Inicio_Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void altaAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.Alta().Show();
        }

        private void altaRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Alta_Ruta().Show();
        }

        private void modificarRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Modificar_Ruta().Show();
        }

        private void bajaRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.Baja_Ruta().Show();
        }

        private void modificarAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.modificarAeronave().Show();
        }

        private void bajaAeronave_Click(object sender, EventArgs e)
        {
            new Abm_Aeronave.Baja().Show();
        }

        private void altaViaje_Click(object sender, EventArgs e)
        {
            new Generacion_Viaje.Alta_Viaje().Show();
        }

        private void registroLlegada_Click(object sender, EventArgs e)
        {
            new Registro_Llegada_Destino.Registro().Show();
        }

        private void compraPasajes_Encom_Click(object sender, EventArgs e)
        {
            new Compra.compraPasaje().Show();
        }

        private void crearFuncionalidad_Click(object sender, EventArgs e)
        {
            new Abm_Funcionalidades.Alta().Show();
        }

        private void modificarFuncionalidad_Click(object sender, EventArgs e)
        {

        }

        private void bajaFuncionalidad_Click(object sender, EventArgs e)
        {
            new Abm_Funcionalidades.bajaFunc().Show();
        }

        private void bajaPasaje_Encom_Click(object sender, EventArgs e)
        {
            new Devolucion.Baja().Show();
        }

        private void estadisticas_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.Estadistica().Show();
        }

        private void crearRol_Click(object sender, EventArgs e)
        {
         //   new Abm_Rol.altaRol().Show();
        }
    }
}
