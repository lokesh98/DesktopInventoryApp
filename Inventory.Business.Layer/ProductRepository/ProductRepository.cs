using Inventory.Business.Layer.ViewModel;
using Inventory.DataAccess.Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Layer.ProductRepository
{
    public class ProductRepository
    {
        public DataTable GetAllProducts()
        {
            return DAO.GetDataTable("sp_GetAllProducts", CommandType.StoredProcedure);
        }

        public int SaveProduct(ProductViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name",model.Name),
                new SqlParameter("@Quantity",model.Quantity),
                new SqlParameter("@Price",model.Price),
                new SqlParameter("@CategoryID",model.CategoryID),
                new SqlParameter("@CreatedBy",model.CreatedBy),
            };
            return DAO.IDU("sp_SaveProducts", CommandType.StoredProcedure,parameters);
        }
    }
}
