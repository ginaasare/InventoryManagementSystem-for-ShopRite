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
            fillComboBox();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gina\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillComboBox()
        //populates the combobox with the databse categories
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select catName from CategoryTable", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("catName", typeof(string));
            dataTable.Load(reader);
            SelectCategory.ValueMember = "CatName";
            SelectCategory.DataSource = dataTable;
            Con.Close();
        }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProductDGV1.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProductDGV1.SelectedRows[0].Cells[2].Value.ToString();

        }
    }
}
