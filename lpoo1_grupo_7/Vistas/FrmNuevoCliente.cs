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
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Cli_Nombre = txtNewClientNombre.Text; 
            nuevoCliente.Cli_Apellido = txtNewClientApellido.Text;
            nuevoCliente.Cli_DNI = txtNewClientDNI.Text;
            nuevoCliente.Cli_NroCarnet = txtNewClientCarnet.Text;
            if (string.IsNullOrWhiteSpace(txtNewClientApellido.Text) && string.IsNullOrWhiteSpace(txtNewClientNombre.Text) &&
                string.IsNullOrWhiteSpace(txtNewClientCarnet.Text) && string.IsNullOrWhiteSpace(txtNewClientDNI.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos del cliente");
            }
            else {
                MessageBox.Show("Cliente creado!" + "Nombre: " + nuevoCliente.Cli_Nombre
                    + "Apellido: " + nuevoCliente.Cli_Apellido + "DNI: "
                    + nuevoCliente.Cli_DNI + "Nro Carnet: " + nuevoCliente.Cli_NroCarnet);
                txtNewClientNombre.Text = "";
                txtNewClientApellido.Text = "";
                txtNewClientDNI.Text = "";
                txtNewClientCarnet.Text = "";
                this.Hide();
                frmNuevoCliente.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNewClientCUIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtNewClientApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNewClientValidating(object sender, CancelEventArgs e)
        {

        }

        private void txtNewClientApellidoValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClientApellido.Text))
            {
                e.Cancel = false;
                txtNewClientApellido.Focus();
                errorProvider1.SetError(txtNewClientApellido, "Debe ingresar un apellido");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewClientApellido, "");
            }
        }

        private void txtNewClientNombreValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClientNombre.Text))
            {
                e.Cancel = false;
                txtNewClientNombre.Focus();
                errorProvider1.SetError(txtNewClientNombre, "Debe ingresar un nombre");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewClientNombre, "");
            }
        }

        private void txtNewClientDNIValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClientDNI.Text))
            {
                e.Cancel = false;
                txtNewClientDNI.Focus();
                errorProvider1.SetError(txtNewClientDNI, "Debe ingresar un DNI");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewClientDNI, "");
            }
        }

        private void txtNewClientValidatingDireccion(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClientDireccion.Text))
            {
                e.Cancel = false;
                txtNewClientDireccion.Focus();
                errorProvider1.SetError(txtNewClientDireccion, "Debe ingresar una direccion");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewClientDireccion, "");
            }
        }

        private void txtNewClientCUITValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClientCUIT.Text))
            {
                e.Cancel = false;
                txtNewClientCUIT.Focus();
                errorProvider1.SetError(txtNewClientCUIT, "Debe ingresar un CUIT");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewClientCUIT, "");
            }
        }

        private void txtNewClientCarnetValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClientCarnet.Text))
            {
                e.Cancel = false;
                txtNewClientCarnet.Focus();
                errorProvider1.SetError(txtNewClientCarnet, "Debe ingresar un numero de Carnet");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewClientCarnet, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
