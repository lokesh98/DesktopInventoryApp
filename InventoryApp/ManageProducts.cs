using Inventory.Business.Layer.CategoryRepository;
using Inventory.Business.Layer.ProductRepository;
using Inventory.Business.Layer.ViewModel;
using InventoryApp.Utility;
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
    public partial class ManageProducts : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public string CategoryId
        {
            get
            {
                return ddlCategory.SelectedValue.ToString();
            }
            set
            {
                ddlCategory.SelectedValue = value;
            }
        }
        public string ProdName
        {
            get
            {
                return txtProductName.Text;
            }
            set
            {
                txtProductName.Text = value;
            }
        }
        public string Qty
        {
            get
            {
                return txtQty.Text;
            }
            set
            {
                txtQty.Text = value;
            }
        }
        public string Price
        {
            get
            {
                return txtPrice.Text;
            }
            set
            {
                txtPrice.Text = value;
            }
        }


        public ManageProducts()
        {
            InitializeComponent();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategory();
        }
        private void LoadCategory()
        {
            var categories = _categoryRepository.GetCategoryList();
            categories = categories.Where(x => x.CategoryName != "T-shirts").ToList();

            ddlCategory.DataSource = categories;
            ddlCategory.ValueMember = "CategoryID";
            ddlCategory.DisplayMember = "CategoryName";
        }
        private void LoadProducts()
        {
            gvProducts.DataSource = _productRepository.GetAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProductViewModel model = new ProductViewModel()
                {
                    CategoryID = Convert.ToInt32(CategoryId),
                    Name = ProdName,
                    Price = Convert.ToDecimal(Price),
                    Quantity = Convert.ToInt32(Qty),
                    CreatedBy = SessionHelper.UserID
                };

                int i = _productRepository.SaveProduct(model);
                if (i > 0)
                {
                    MessageBox.Show("Product saved successfully.", "Information");
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Failed to save products", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
           
        }
    }
}
