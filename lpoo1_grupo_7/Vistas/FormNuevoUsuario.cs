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
    public partial class FormNuevoUsuario : Form
    {
        public FormNuevoUsuario()
        {
            InitializeComponent();
            load_combo_roles();
            load_usuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRoles.DisplayMember = "rol_descrip";
            comboBoxRoles.ValueMember = "rol_id";
            comboBoxRoles.DataSource = TrabajarUsuario.list_roles();
        }

        private void load_combo_roles()
        {

            comboBoxRoles.DisplayMember = "rol_descrip";
            comboBoxRoles.ValueMember = "rol_id";
            comboBoxRoles.DataSource = TrabajarUsuario.list_roles();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();

            load_usuarios();
        }

        private void load_usuarios()
        {
            dataGridUsuarios.DataSource = TrabajarUsuario.list_usuarios();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario oUser = new FormNuevoUsuario();

            oUser.Rol_Codigo = (int)comboBoxRoles.SelectedValue;
            oUser.Usu_ApellidoNombre = txtBoxApellido.Text;
            oUser.Usu_NombreUsuario = txtBoxNombreUsuario.Text;
            oUser.Usu_Contrasena = txtBoxContra.Text;
            TrabajarUsuario.insert_usuario(oUser);
            load_usuarios();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
