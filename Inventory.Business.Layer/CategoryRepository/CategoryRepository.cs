using Inventory.Business.Layer.ViewModel;
using Inventory.DataAccess.Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Layer.CategoryRepository
{
    public class CategoryRepository
    {
        private DataTable GetCategoryTable()
        {
            string sql = "SELECT *FROM Category";
            return DAO.GetDataTable(sql, CommandType.Text);
        }

        public List<CategoryViewModel> GetCategoryList()
        {
            List<CategoryViewModel> list = new List<CategoryViewModel>();
            DataTable dt = GetCategoryTable();

            if (dt.Rows.Count>0)
            {
                CategoryViewModel model;
                foreach (DataRow dr in dt.Rows)
                {
                    model=new CategoryViewModel();
                    model.CategoryID = Convert.ToInt32(dr["CategoryID"].ToString());
                    model.CategoryName = dr["CategoryName"].ToString();
                    model.CategoryDesc = dr["CategoryDesc"].ToString();

                    list.Add(model);
                }
            }
            return list;
        }
    }
}
