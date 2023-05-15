using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using capaNegocio;
using capaEntidad;

namespace sistemaBCNFJLJE
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btningresar_Click(object sender, EventArgs e)
        {

            List<rol> TEST = new CN_Usuario().Listar();
            
            
            rol ousuario = new CN_Usuario().Listar().Where( u => u.ID_doctor.ToString()  == txtdocumento.Text &&
            u.clave == txtclave.Text).FirstOrDefault();


            if(ousuario != null)
            {

            inicio form = new inicio();
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
            }else
            {
                MessageBox.Show("no se encontro usuario");
            }

        }

        private void frm_closing( object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";

            this.Show();
        }

    }
}
