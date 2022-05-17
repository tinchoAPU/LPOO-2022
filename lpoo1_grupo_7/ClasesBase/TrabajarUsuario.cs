using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable list_roles()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable list_usuarios()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_codigo as 'Rol', ";
            cmd.CommandText += " usu_apellido_nombre as 'Apellido'";
            cmd.CommandText += " usu_nombre_usuario as 'Usuario', usu_contrasenia as 'Contraseña'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(rol_codigo,usu_apellido_nombre,usu_nombre_usuario,usu_contrasenia) values(@rol,@ape,@usu,@pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@ape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@usu", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasena);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscar_usuarios(string nombreUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            //String sql = "buscarUsuario";
            SqlCommand cmd = new SqlCommand();
            //SqlCommand cmd = ConnectionDBManager.createCommand(cnn, true, sql);
            cmd.Parameters.AddWithValue("@nombreUsuario", "%" + nombreUsuario + "%");
            return ConnectionDBManager.processQueryAndLoadDataTable(cmd);
        }

        public static void borrar_usuario(int idUsu)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            //String sql = "eliminarUsuario";
            //SqlCommand cmd = ConnectionDBManager.createCommand(cnn, true, sql);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IDUsuario", idUsu);
            //ConnectionDBManager.executeQuery(cnn, cmd);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void modificar_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.agencia);
            String sql = "modificarUsuario";
            SqlCommand cmd = ConnectionDBManager.createCommand(cnn, true, sql);
            cmd.Parameters.AddWithValue("@IDUsuario", user.Usu_ID);
            cmd.Parameters.AddWithValue("@codigoRol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@nombreUsuario", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contraseñaUsuario", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellidoNomnreUsuario", user.Usu_ApellidoNombre);
            try
            {
                ConnectionDBManager.executeQuery(cnn, cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        
    }
}
