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
    public partial class FrmNuevoProducto : Form
    {
        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            Producto nuevoProducto = new Producto();
            nuevoProducto.Prod_Codigo = txtNewProdCod.Text;
            nuevoProducto.Prod_Categoria = txtNewProdCat.Text; ;
            nuevoProducto.Prod_Descripcion = txtNewProdDesc.Text; ;
            nuevoProducto.Prod_Precio = Convert.ToDouble(txtNewProdPrecio.Text);
            MessageBox.Show("Producto creado!" + "Codigo: " + nuevoProducto.Prod_Codigo
                + "Categoria: " + nuevoProducto.Prod_Categoria + "Descripcion: "
                + nuevoProducto.Prod_Descripcion + "Precio: $" + nuevoProducto.Prod_Precio);
            txtNewProdCod.Text = "";
            txtNewProdCat.Text = "";
            txtNewProdDesc.Text = "";
            txtNewProdPrecio.Text = "";
            this.Hide();
            frmNuevoProducto.Show();
        }

        private void txtNewProdCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewProdPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
