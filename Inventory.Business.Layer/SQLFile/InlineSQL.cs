using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Layer.SQLFile
{
    public class InlineSQL
    {
        public const string sql_GetUserByEmail = "SELECT UserID,UserRole,FirstName FROM UserTable WHERE Email = @Email";
    }
}
