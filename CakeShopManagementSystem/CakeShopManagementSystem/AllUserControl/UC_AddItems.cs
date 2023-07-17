using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeShopManagementSystem.AllUserControl
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('"+txtItemName.Text+"', '"+txtCategory.Text+"', "+txtPrice.Text+")";
            fn.setData(query);


        }

        public void clearAll()
        {
            txtItemName.Clear();
            txtCategory.SelectedIndex = -1;
            txtPrice.Clear();
        }
    }
}
