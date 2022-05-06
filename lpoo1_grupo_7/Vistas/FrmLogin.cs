using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean userFound = false;
            Rol rolAdmin = new Rol(001,"Descripcion Admin");
            Rol rolOperador = new Rol(002, "Descripcion Operador");
            Rol rolAuditor = new Rol(003,"Descripcion Auditor");
            Usuario usuario1 = new Usuario("usuario1","1234",rolAdmin.Rol_Codigo);
            Usuario usuario2 = new Usuario("usuario2", "4567",rolOperador.Rol_Codigo);
            Usuario usuario3 = new Usuario("usuario3", "8910", rolAuditor.Rol_Codigo);
            FrmMain frmMain = new FrmMain();
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            if (usuario1.Usu_NombreUsuario == txtUsuario.Text && usuario1.Usu_Contrasena == txtContrasena.Text)
            {
                userFound = true;
            }
            else if(usuario2.Usu_NombreUsuario == txtUsuario.Text && usuario2.Usu_Contrasena == txtContrasena.Text){
                userFound = true;
            }
            else if (usuario3.Usu_NombreUsuario == txtUsuario.Text && usuario3.Usu_Contrasena == txtContrasena.Text)
            {
                userFound = true;
            }

            if (userFound)
            {
                MessageBox.Show("Bienvenido! " + txtUsuario.Text);
                this.Hide();
                frmPrincipal.FormClosed += (s, args) => this.Close();
                frmPrincipal.Show();
            }
            else {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void resaltar(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.Green;
            txtUsuario.BackColor = Color.LightGreen;
        }

        private void quitarResalto(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void resaltarPwd(object sender, EventArgs e)
        {
            txtContrasena.ForeColor = Color.Green;
            txtContrasena.BackColor = Color.LightGreen;
        }

        private void quitarResaltoPwd(object sender, EventArgs e)
        {
            txtContrasena.BackColor = Color.White;
        }

        private void resaltarBoton(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.LightGreen;
        }

        private void quitarResaltoBoton(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
        }
    }
}
