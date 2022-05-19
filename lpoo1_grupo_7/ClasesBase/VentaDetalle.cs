using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class VentaDetalle
    {

        private int _Det_Nro; 
        public int Det_Nro
        {
            get { return _Det_Nro; }
            set { _Det_Nro = value; }
        }

        private Producto _producto;
        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        private decimal _Det_Precio;
        public decimal Det_Precio
        {
            get { return _Det_Precio; }
            set { _Det_Precio = value; }
        }
        private decimal _Det_Cantidad;

        public decimal Det_Cantidad
        {
            get { return _Det_Cantidad; }
            set { _Det_Cantidad = value; }
        }
        private decimal _Det_Total;

        public decimal Det_Total
        {
            get { return _Det_Total; }
            set { _Det_Total = value; }
        }
        private string _Prod_Nombre;

        public string Prod_Nombre
        {
            get { return _Prod_Nombre; }
            set { _Prod_Nombre = value; }
        }
    }
}
