using Inventory.Business.Layer.CategoryRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class ManageCategory : Form
    {
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void LoadCategory()
        {
            dataGridView1.DataSource = _categoryRepository.GetCategoryList();
        }
    }
}
