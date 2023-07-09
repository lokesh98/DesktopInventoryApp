using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using InventoryApp.Utility;

namespace InventoryApp
{
    public partial class MasterMDIForm : Form
    {
        public MasterMDIForm()
        {
            InitializeComponent();
        }

        private void contactBroadwayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Process.Start("https://broadwayinfosys.com/");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void MasterMDIForm_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = string.Format("UserName: {0}, Role: {1}, UserID: {2} ", SessionHelper.UserName, SessionHelper.UserRole, SessionHelper.UserID);
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory();
            manageCategory.MdiParent = this;
            manageCategory.Show();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.MdiParent = this;
            manageProducts.Show();
        }
    }
}
