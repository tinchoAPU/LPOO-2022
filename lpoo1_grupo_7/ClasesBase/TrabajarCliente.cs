using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    class TrabajarCliente
    {
        public static DataTable list_clientes()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText = "cli_dni as 'DNI'";
            cmd.CommandText = "cli_apellido as 'Apellido'";
            cmd.CommandText = "cli_nombre as 'Nombre'";
            cmd.CommandText = "cli_direccion as 'Direccion'";
            cmd.CommandText = "cli_nro_carnet as 'Carnet'";
            cmd.CommandText = "os_cuit as 'Cuit'";
            
            cmd.CommandText += "FROM Clientes as C";
            cmd.CommandText += "LEFT JOIN ObrasSociales as OS ON (OS.os_cuit=C.os_cuit)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(cli_dni,cli_apellido,cli_nombre,cli_direccion,cli_nro_carnet,os_cuit) values(@dni,@ape,@nom,@dir,@car,@cuit)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@ape", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dir", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@car", cliente.Cli_NroCarnet);
            cmd.Parameters.AddWithValue("@cuit", cliente.Os_CUIT);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
