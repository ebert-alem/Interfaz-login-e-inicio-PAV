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

namespace Clase_1_PAV
{
    public partial class frmLogin : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = pavtrabajoPractico.mssql.somee.com; Persist Security Info = True; User ID = fede; Password = fede1674");

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
                //conectar a bd

                try
                {
                    // guardar variables
                    string nom = txtNom.Text;
                    string pass = txtPass.Text;
                 // se abre la conexion
                    conexion.Open();
                    // select para ver si el usuario existe en la bd y esta bien la contraseña
                    string consulta = "SELECT * FROM USUARIOS WHERE nombreUsuario = '" + nom + "' and contraseña = HASHBYTES('SHA1','" + pass + "')";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                    // si hay un elemento en el select
                    if (lector.Read())
                    {

                        string nombre = lector.GetString(0);
                        string contra = lector.GetString(1);
                        if (nombre != "" && contra != "")
                        {
                            // codigo de ebert
                            conexion.Close();

                            txtIngresarDatos.Visible = false;
                            frmInicio ventana = new frmInicio();
                            ventana.Show();
                            this.Hide();
                        }




                    }
                    else
                    {

                        MessageBox.Show("Usuario y/o contraseña incorrectas");
                        conexion.Close();

                    }





                }
                catch (Exception ex)
                {

                    MessageBox.Show("" + ex);
                    conexion.Close();
                }
        

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string pass = txtPass.Text;
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO USUARIOS (nombreUsuario,contraseña) VALUES ('" + nom + "',HASHBYTES('SHA1','" + pass + "'))";


                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant = comando.ExecuteNonQuery();

                if (cant > 0)
                {

                    frmInicio ventana = new frmInicio();
                    ventana.Show();
                    conexion.Close();



                }
                else
                {

                    MessageBox.Show("Error , verifique los datos ingresados , el usuario ya existe ");
                    conexion.Close();

                }










            }
            catch (Exception ex)
            {

                MessageBox.Show("El usuario ya existe");
                conexion.Close();
            }
        }
    }
}
