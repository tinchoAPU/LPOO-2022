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
    public partial class frmVentas : Form
    { 
        
        private  BindingList<VentaDetalle> ListVentaDetalle;
        public frmVentas()
        {
            ListVentaDetalle = new BindingList<VentaDetalle>();
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            this.cmbCliente.DataSource = DAO.TraerClientes();
            this.cmbCliente.DisplayMember = "Cli_Nombre";
            this.cmbProducto.DataSource = DAO.TraerProductos();
            this.cmbProducto.DisplayMember = "Prod_Descripcion";

            this.listBox1.DataSource = ListVentaDetalle;
            this.listBox1.DisplayMember = "Prod_Nombre"; 
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                List<VentaDetalle> list = new List<VentaDetalle>();
                foreach (var item in listBox1.Items)
                {
                    list.Add((VentaDetalle)item);
                }

                bool resultado = DAO.GuardaVenta(list, dtpFecha.Value, (Cliente)cmbCliente.SelectedValue);
                if (resultado)
                {
                    MessageBox.Show("Se guardo la venta");
                    this.Close();   
                }
                else
                {
                    MessageBox.Show("Hubo un error");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error:\n" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Producto prod= (Producto)cmbProducto.SelectedValue;

                ListVentaDetalle.Add(new VentaDetalle
                {
                    Producto = prod,
                    Det_Cantidad = nudCantidad.Value,
                    Det_Precio = nudPrecio.Value,
                    Det_Total = nudCantidad.Value * nudPrecio.Value,
                    Prod_Nombre = prod.Prod_Descripcion
                });
                cmbProducto.SelectedIndex = 0;
                nudCantidad.Value = 0;
                nudPrecio.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
