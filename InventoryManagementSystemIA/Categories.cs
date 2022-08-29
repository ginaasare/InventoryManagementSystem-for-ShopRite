using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystemIA
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (catIDTb.Text == "")
                {
                    MessageBox.Show("Select the category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTable where catID = " + catIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been deleted");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gina\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "insert into CategoryTable values(" + catIDTb.Text + ", '" + catNameTb.Text + "' , '" + catDescriptionTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category has been added successfully");
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CategoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catIDTb.Text = CategoryDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            catNameTb.Text = CategoryDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            catDescriptionTb.Text = CategoryDataGrid.SelectedRows[0].Cells[2].Value.ToString();



        }

        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            CategoryDataGrid.DataSource = dataset.Tables[0];
            Con.Close();

        }
        private void Categories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (catIDTb.Text == "" || catNameTb.Text == ""
                    || catDescriptionTb.Text == "")

                {
                    MessageBox.Show("Missing Details ");

                }
                else
                {
                    Con.Open();

                    string query = "Update CategoryTable set catName = '" + catNameTb.Text + "'," +
                        " catDescription='" + catDescriptionTb.Text + "'where catID=" + catIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully");
                    Con.Close();
                    populate();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
