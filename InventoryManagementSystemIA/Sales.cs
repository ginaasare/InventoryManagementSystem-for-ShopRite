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
            string query = "select prodName as Name, prodPrice as Price from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ProductDGV1.DataSource = dataset.Tables[0];
            Con.Close();

        }

        private void populatebill()
        {
            Con.Open();
            string query = "select prodName as Name, prodPrice as Price from ProductTable";
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
            populatebill();
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
            ProdName.Text = ProductDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProductDGV1.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void Date_Click(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int GrandTotal = 0, n = 0;

        private void button7_Click(object sender, EventArgs e)
        {

            if (BillID.Text == "") 
            {
                MessageBox.Show("Enter Bill ID");


            }

            else
            {
                try
                {
                    Con.Open();

                    string query = "insert into BillTable values(" + BillID.Text + ", " +
                        "  '" + AttendantNameLabel.Text + "' , '" + Datelabel.Text + "' , '"
                        + Amountlabel.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order has been added successfully");
                    Con.Close();
                    populatebill();
                    /* BillID.Text = "";
                     ProdName.Text = "";
                     ProdQty.Text = "";
                     ProdPrice.Text = "";
                     _ = SelectCategory.SelectedValue.ToString() == " ";*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ORDERDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ProdName.Text == " " || ProdQty.Text == "")
            
            
            {
                MessageBox.Show("Product Details are missing");
            
            }
            else {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ORDERDGV);
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = ProdName.Text;
                row.Cells[2].Value = ProdPrice.Text;
                row.Cells[3].Value = ProdQty.Text;
                row.Cells[4].Value = Convert.ToInt32(ProdQty.Text) * Convert.ToInt32(ProdPrice.Text);
                ORDERDGV.Rows.Add(row);
                n++;
                GrandTotal = GrandTotal + total;
                Amountlabel.Text = "GHS" + GrandTotal;
            }
        }
    }
}
