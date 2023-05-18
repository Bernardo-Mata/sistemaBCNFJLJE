using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;

namespace sistemaBCNFJLJE
{
    public partial class inicio : Form
    {
        private static rol usuarioActual;
        public inicio( rol objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuusuario_Click(object sender, EventArgs e)
        {

        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }

        private void menuventas_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuarioActual.NombreDoc;
        }
    }
}
