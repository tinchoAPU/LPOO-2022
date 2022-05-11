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
    public partial class FrmNuevaObraSocial : Form
    {
        public FrmNuevaObraSocial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevaObraSocial frmNuevaObraSocial = new FrmNuevaObraSocial();
            ObraSocial nuevaObraSocial = new ObraSocial();
            nuevaObraSocial.Os_CUIT = txtNewOSCuit.Text;
            nuevaObraSocial.Os_RazonSocial = txtNewRazonSocial.Text;
            nuevaObraSocial.Os_Direccion = txtNewOSDireccion.Text;
            nuevaObraSocial.Os_Telefono = txtNewOSTelefono.Text;
            MessageBox.Show("Obra Social Creada!" + "CUIT: " + nuevaObraSocial.Os_CUIT
                + "RazonSocial: " + nuevaObraSocial.Os_RazonSocial + "Direccion: "
                + nuevaObraSocial.Os_Direccion + "Telefono: " + nuevaObraSocial.Os_Telefono);
            txtNewOSCuit.Text = "";
            txtNewRazonSocial.Text = "";
            txtNewOSDireccion.Text = "";
            txtNewOSTelefono.Text = "";
            this.Hide();
            frmNuevaObraSocial.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
