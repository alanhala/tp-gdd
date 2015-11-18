using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ReemplazoAeronaveFinVidaUtil : Form
    {
        private string matriculaAReemplazar;
        public ReemplazoAeronaveFinVidaUtil(string matricula)
        {
            InitializeComponent();
            matriculaAReemplazar = matricula;
        }

        private void ReemplazoAeronaveFinVidaUtil_Load(object sender, EventArgs e)
        {

        }
    }
}
