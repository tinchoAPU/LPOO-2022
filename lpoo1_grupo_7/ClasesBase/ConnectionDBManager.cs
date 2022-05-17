using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    class ConnectionDBManager
    {
        public static SqlConnection createConnection()
        {
            return new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
        }

        public static SqlCommand createCommand(SqlConnection connection, bool flagIsStoredProcedure, String sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            if (flagIsStoredProcedure)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }

            cmd.CommandText = sql;

            return cmd;
        }


        public static void executeQuery(SqlConnection connection, SqlCommand command)
        {
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable processQueryAndLoadDataTable(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
