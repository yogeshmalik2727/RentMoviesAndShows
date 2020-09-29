using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMoviesAndShows
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
            
        }

        private void button1Launch_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();

            if (user == "admin")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                labelErrorMsg.Text = "!Please enter a valid login name";
                textBox1.Focus();
            }
        }

        private void start_Load(object sender, EventArgs e)
        {
            labelErrorMsg.Text = "";
            textBox1.Focus();
                
        }
    }
}
