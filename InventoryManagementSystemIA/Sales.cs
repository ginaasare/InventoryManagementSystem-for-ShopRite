using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystemIA
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gina\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select prodName as Name, prodQty as Quantity from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ProductDGV1.DataSource = dataset.Tables[0];
            Con.Close();

        }

        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProdPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
