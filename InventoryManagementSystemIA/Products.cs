using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace InventoryManagementSystemIA
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

             
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
        private void Products_Load(object sender, EventArgs e)
        {
            fillComboBox();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdID.Text == "")
                {
                    MessageBox.Show("Select the product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTable where catID = " + ProdID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product entry has been deleted successfully");
                    Con.Close();
                    populate();
                    ProdID.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    _ = SelectCategory.SelectedValue.ToString() == " ";
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select productID as ID, prodName as Name, prodQty as Quantity, prodPrice as Price, prodCat as Category from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            ProductDGV.DataSource = dataset.Tables[0];
            Con.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "insert into ProductTable values(" + ProdID.Text + ", " +
                    "  '"+ ProdName.Text + "' , '" + ProdQty.Text + "' , '"
                    + ProdPrice.Text + "','" + SelectCategory.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been added successfully");
                Con.Close();
                populate();
                ProdID.Text = "";
                ProdName.Text = "";
                ProdQty.Text = "";
                ProdPrice.Text = "";
                _ = SelectCategory.SelectedValue.ToString() == " ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdID.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            SelectCategory.SelectedValue = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdID.Text == "" || ProdName.Text == ""
                    || ProdQty.Text == "" || ProdPrice.Text == "" )
                //|| SelectCategory.SelectedValue.ToString() == ""

                {
                    MessageBox.Show("Missing Details ");

                }
                else
                {
                    Con.Open();

                    string query = "Update ProductTable set prodName = '" + ProdName.Text + "', " + " prodQty='" + ProdQty.Text + "'," +" prodPrice='" + ProdPrice.Text + "'," + "prodCat ='" + SelectCategory.SelectedValue.ToString()   +  "'where ProductID=" + ProdID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Has Been Updated Successfully");
                    Con.Close();
                    populate();
                    ProdID.Text = "";
                    ProdName.Text = "";
                    ProdQty.Text = "";
                    ProdPrice.Text = "";
                    _ = SelectCategory.SelectedValue.ToString() == " ";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendants attendant = new Attendants();
            attendant.Show();
            this.Hide();
        }
    }
}
