using Inventory.Business.Layer.SQLFile;
using Inventory.DataAccess.Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Layer.UserRepository
{
    public class UserRepository
    {
        public bool IfExists(string email, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };
            DataTable dt =  DAO.GetDataTable(InlineSQL.sql_GetUserByEmail, CommandType.Text, parameters);
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetUserByEmail(string email)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };
            return DAO.GetDataTable(InlineSQL.sql_GetUserByEmail, CommandType.Text, parameters);
        }
    }
}
