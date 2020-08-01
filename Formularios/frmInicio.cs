using Clase_1_PAV.Formularios;
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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        private void Form_Inicio_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            panelUsuario.Visible = true;
        }

        private void btnSalir_Leave(object sender, EventArgs e)
        {
            btnCerrarSesion.Visible = false;
            btnSalir.Visible = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void panelUsuario_Leave(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void panelUsuario_MouseLeave(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panelUsuario.Visible = false;
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmTareas());
        }

        private void btnPromedios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPromedios());
        }
    }
}
