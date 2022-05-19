using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {

        private int _Ven_Nro;
        public int Ven_Nro
        {
            get { return _Ven_Nro; }
            set { _Ven_Nro = value; }
        }

        private DateTime _Ven_Fecha;
        public DateTime Ven_Fecha
        {
            get { return _Ven_Fecha; }
            set { _Ven_Fecha = value; }
        }

        private string _Cli_DNI;
        public string Cli_DNI
        {
            get { return _Cli_DNI; }
            set { _Cli_DNI = value; }
        }
    }
}
