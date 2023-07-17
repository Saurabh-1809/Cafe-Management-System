using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeShopManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SidePanel.Height = guna2GradientButton1.Height;
        }
        public Dashboard( string user )
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnRemoveItems.Hide();
                btnUpdateItems.Hide();
            }
            else if(user == "Admin")
            { 
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();


            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible= false;
            uC_PlaceOrder1.Visible= false;
            uC_UpdateItems1.Visible= false;
            uC_RemoveItems1.Visible= false;
            mainDash1.Visible=true;
        }

        private void btnAddItems_Click_1(object sender, EventArgs e)
        {
            mainDash1.SendToBack();
            guna2Transition1.ShowSync(uC_AddItems1);
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
            SidePanel.Height = btnAddItems.Height;
            SidePanel.Top= btnAddItems.Top;
        }

        private void btnUpdateItems_Click_1(object sender, EventArgs e)
        {
            mainDash1.SendToBack();
            guna2Transition1.ShowSync(uC_UpdateItems1);
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
            SidePanel.Height= btnUpdateItems.Height;
            SidePanel.Top= btnUpdateItems.Top;
        }

        private void btnRemoveItems_Click_1(object sender, EventArgs e)
        {
            mainDash1.SendToBack();
            guna2Transition1.ShowSync(uC_RemoveItems1);
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();
            SidePanel.Height= btnRemoveItems.Height;
            SidePanel.Top= btnRemoveItems.Top;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            mainDash1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            mainDash1.SendToBack();
            SidePanel.Height= btnPlaceOrder.Height;
            SidePanel.Top= btnPlaceOrder.Top;
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Coming Soon");
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(mainDash1);
            mainDash1.Visible = true;
            mainDash1.BringToFront();
            SidePanel.Height= guna2GradientButton1.Height;
            SidePanel.Top = guna2GradientButton1.Top;

        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Coming Soon");
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Coming Soon");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Coming Soon");
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is Coming Soon");
        }
    }
}
