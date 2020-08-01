using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_1_PAV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtPass.Text == "")
            {
                txtIngresarDatos.Visible = true;
            }
            else
            {
                txtIngresarDatos.Visible = false;
                frmInicio ventana = new frmInicio();
                ventana.Show();
                this.Hide();

            }
        }
    }
}
