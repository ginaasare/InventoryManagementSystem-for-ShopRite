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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            SplashProgressBar.Value = startpoint;
            if (SplashProgressBar.Value == 100 )
            {
                SplashProgressBar.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SplashProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
