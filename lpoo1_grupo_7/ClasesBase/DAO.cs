using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace ClasesBase
{
    public static class DAO
    {
        //TRAE LA LISTA DE CLIENTES

        public static List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
             using(SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["optica"].ConnectionString))
            {
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from cliente", _conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        clientes.Add(new Cliente()
                        {
                            Cli_Apellido = dr["Cli_Apellido"].ToString(),
                            Cli_Direccion = dr["Cli_Direccion"].ToString(),
                            Cli_DNI = dr["Cli_DNI"].ToString(),
                            Cli_Nombre = dr["Cli_Nombre"].ToString(),
                            Cli_NroCarnet = dr["Cli_NroCarnet"].ToString(),
                            Os_CUIT = dr["Os_CUIT"].ToString()
                        }
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            return clientes;
        }
        //TRAE LAS VENTAS PARA MOSTRAR EN EL REPORTE 
        public static List<Venta> TraerVentas()
        {

            List<Venta> ventas = new List<Venta>();
            using (SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["optica"].ConnectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Venta", _conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ventas.Add(new Venta()
                    {
                        Cli_DNI = dr["Cli_DNI"].ToString(),
                        Ven_Fecha = (DateTime)dr["Ven_Fecha"],
                        Ven_Nro = (int)dr["Ven_Nro"]
                    }
                    );
                }
            }
            return ventas;
        }

        //TRAE LOS PRODUCTOS
        public static List<Producto> TraerProductos()
        {
            List<Producto> Productos = new List<Producto>();
            using (SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["optica"].ConnectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Producto", _conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Productos.Add(new Producto()
                    {
                        Prod_Categoria = dr["Prod_Categoria"].ToString(),
                        Prod_Codigo = dr["Prod_Codigo"].ToString(),
                        Prod_Descripcion = dr["Prod_Descripcion"].ToString()
                    }
                    );
                }
            }
            return Productos;
        }

        public static bool GuardaVenta(List<VentaDetalle> detalle, DateTime Ven_fecha, Cliente cliente)
        { 
            //BANDERA PARA VALIDAR SI TODO ESTA OK
            int grabo = 0;
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["optica"].ConnectionString))
            {
                // ABRE LA CONEXION
                _conn.Open();
                // TRAER ULTIMO NUMERO DE VENTA + 1
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Ven_Nro),0) FROM VENTA", _conn);
                int Ven_Nro = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                // TRAER ULTIMO NUMERO DE VENTADetalle + 1
                cmd = new SqlCommand("SELECT ISNULL(MAX(Det_Nro),0) FROM VentaDetalle", _conn);
                int Det_Nro = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                //INSERTA EL REGISTRO DE VENTA
                cmd = new SqlCommand("INSERT INTO Venta VALUES(@Ven_Nro,@Ven_fecha,@Cli_DNI)", _conn);
                cmd.Parameters.Add(new SqlParameter("@Ven_Nro", Ven_Nro));
                cmd.Parameters.Add(new SqlParameter("@Ven_fecha", Ven_fecha));
                cmd.Parameters.Add(new SqlParameter("@Cli_DNI", cliente.Cli_DNI));
                grabo = cmd.ExecuteNonQuery();

                //INSERTA LOS REGISTROS DETALLE DE VENTA 
                foreach (VentaDetalle det in detalle)
                {
                    cmd = new SqlCommand("INSERT INTO VentaDetalle VALUES(@Det_Nro,@Vet_Nro,@Prod_Codigo,@Det_Precio,@Det_Cantidad,@Det_Total)", _conn);
                    cmd.Parameters.Add(new SqlParameter("@Det_Nro", Det_Nro));
                    cmd.Parameters.Add(new SqlParameter("@Vet_Nro", Ven_Nro));
                    cmd.Parameters.Add(new SqlParameter("@Prod_Codigo", det.Producto.Prod_Codigo));
                    cmd.Parameters.Add(new SqlParameter("@Det_Precio", det.Det_Precio));
                    cmd.Parameters.Add(new SqlParameter("@Det_Cantidad", det.Det_Cantidad));
                    cmd.Parameters.Add(new SqlParameter("@Det_Total", det.Det_Total));
                    grabo = cmd.ExecuteNonQuery();
                    Det_Nro = Det_Nro + 1;
                }

            }
            return grabo == 1;
        }





    }
}
