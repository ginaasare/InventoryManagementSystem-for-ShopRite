using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearform_Click(object sender, EventArgs e)
        {
            usernameTb.Text = "";
            passwordTb.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Missing details" +
                    "Enter username or password");
            }
            else
            {
                if (SelectRole.SelectedItem.ToString() =="Admin")
                {
                    if (usernameTb.Text == "Admin" && passwordTb.Text == "Admin" )
                    {
                        Products products = new Products();
                        products.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter the correct Username and Password if you are an Admin");
                    }
                }
                else if (SelectRole.SelectedItem.ToString() == "Shop Attendant")
                {
                    MessageBox.Show("You are an Attendant");
                }
                else
                {
                    MessageBox.Show("Select one Role");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
