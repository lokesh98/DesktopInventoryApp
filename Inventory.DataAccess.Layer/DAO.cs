using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Inventory.DataAccess.Layer
{
    public static class DAO
    {
        public static SqlConnection GetSqlConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["BrodwayJulyConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(conn);

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }

        //IDU: Insert, Delete, Update

        public static int IDU(string sql, CommandType commandType, SqlParameter[] sqlParameters)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = commandType;
                    cmd.CommandText = sql;

                    //check if param is not null and add args
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetDataTable(string sql, CommandType commandType, SqlParameter[] sqlParameters = null)
        {
            using (SqlConnection connection = GetSqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = sql;
                    cmd.CommandType = commandType;

                    if (sqlParameters!=null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
