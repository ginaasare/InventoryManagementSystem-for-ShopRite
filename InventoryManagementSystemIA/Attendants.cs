using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemIA
{
    public partial class Attendants : Form
    {
        public Attendants()
        {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Attendants_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            AttendantID.Text = AttendantDGV.SelectedRows[0].Cells[0].Value.ToString();
            AttendantName.Text = AttendantDGV.SelectedRows[0].Cells[1].Value.ToString();
           AttendantAge.Text = AttendantDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttendantPhone.Text = AttendantDGV.SelectedRows[0].Cells[3].Value.ToString();
           AttendantPW.Text= AttendantDGV.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Populate()
        {
            Con.Open();
            string query = "select * from AttendantTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder buider = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
             AttendantDGV.DataSource = dataset.Tables[0];
            Con.Close();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gina\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                  Con.Open();
                string query = "insert into AttendantTable values ( "  + AttendantID.Text + ", '" + AttendantName.Text + "' , '" + AttendantAge.Text + "','" + AttendantPhone.Text + "','" + AttendantPW.Text + "')";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendant has been added successfully");
                Con.Close();
                Populate();
                AttendantID.Text = "";
                AttendantName.Text = "";
                AttendantAge.Text = "";
                AttendantPhone.Text = "";
                AttendantPW.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendantID.Text == "")
                {
                    MessageBox.Show("Select the Attendant to Delete");
                }
                else 
                {
                    Con.Open();
                    string query = "delete from AttendantTable where attendantID = " + AttendantID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant has been deleted");
                    Con.Close();
                    Populate();
                    AttendantID.Text = "";
                    AttendantName.Text = "";
                    AttendantAge.Text = "";
                    AttendantPhone.Text = "";
                    AttendantPW.Text = "";



                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendantID.Text == "" || AttendantName.Text == ""
                    || AttendantAge.Text == "" || AttendantPhone.Text == "" 
                    || AttendantPW.Text == "")

                {
                    MessageBox.Show("Missing Details ");

                }
                else
                {
                    Con.Open(); 

                    string query = "Update AttendantTable set attendantName = '" + AttendantName.Text + "', attendantAge= '" + 
                        AttendantAge.Text + "', attendantPhone = '" + AttendantPhone.Text + "', attendantPW= '"
                        + AttendantPW.Text + "' where attendantID = '" + AttendantID.Text + "'" ;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Updated");
                    Con.Close();
                    Populate();
                    AttendantID.Text = "";
                    AttendantName.Text = "";
                    AttendantAge.Text = "";
                    AttendantPhone.Text = "";
                    AttendantPW.Text = "";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

