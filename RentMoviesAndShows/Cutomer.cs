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

namespace RentMoviesAndShows
{
    public partial class Cutomer : Form
    {
        string customerID, CustName, address, Mobile;
        public Cutomer()
        {
            InitializeComponent();
            button1.Text = "Save";
            button2.Text = "Cancel";
        }
        public Cutomer(string customerID,string Name, string address, string Mobile)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.CustName = Name;
            this.address = address;
            this.Mobile = Mobile;
            button1.Text = "Update";
            button2.Text = "Close";
        }
            
        //globaly define conection
        SqlConnection con = new SqlConnection(@"data source=.\SQLExpress; initial catalog=rentmovies; integrated security=true;");
       
        //Close Customer Form
        private void button2_Click(object sender, EventArgs e)
        {
            con.Dispose();
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name, address, mobile;
                name = textBox1Name.Text.Trim();
                address = textBox3Addr.Text.Trim();
                mobile = textBox2Mobile.Text.Trim();

                if (button1.Text == "Update")
                {
                    if (name.Equals(""))
                    {
                        MessageBox.Show("Customer name is required!");

                    }
                    else if (address.Equals(""))
                    {
                        MessageBox.Show("Address is required!");

                    }
                    else if (mobile.Equals(""))
                    {
                        MessageBox.Show("Customer phone number is required!");

                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand();
                        string sp = "update customer set name=@name, address=@address, Mobile=@Mobile where customerId=@customerId";
                        cmd.CommandText = sp;
                        cmd.Connection = con;
                       
                        cmd.Parameters.Add(new SqlParameter("@customerId", customerID));
                        cmd.Parameters.Add(new SqlParameter("@name", name));
                        cmd.Parameters.Add(new SqlParameter("@address", address));
                        cmd.Parameters.Add(new SqlParameter("@Mobile", mobile));

                        bool result = cmd.ExecuteNonQuery() > 0;
                        if (result)
                        {

                            MessageBox.Show("Customer Updated!", "Alert");
                            

                        }
                        else
                        {
                            MessageBox.Show("Customer Data NOT Updated!", "Alert");
                        }
                        cmd.Dispose();

                    }
                }
                else if (button1.Text == "Save")
                {
                    
                    if (name.Equals(""))
                    {
                        MessageBox.Show("Customer name is required!");

                    }
                    else if (address.Equals(""))
                    {
                        MessageBox.Show("Address is required!");

                    }
                    else if (mobile.Equals(""))
                    {
                        MessageBox.Show("Customer phone number is required!");

                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand();
                        string sp = "sp_InsertCustomer";
                        cmd.CommandText = sp;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@name", name));
                        cmd.Parameters.Add(new SqlParameter("@address", address));
                        cmd.Parameters.Add(new SqlParameter("@Mobile", mobile));

                        bool result = cmd.ExecuteNonQuery() > 0;
                        if (result)
                        {

                            MessageBox.Show("New Customer Saved!", "Alert");
                            textBox1Name.Text = "";
                            textBox3Addr.Text = "";
                            textBox2Mobile.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Customer Data NOT Saved!", "Alert");
                        }
                        cmd.Dispose();

                    }
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void Cutomer_Load(object sender, EventArgs e)
        {
            con.Open();
            textBox1Name.Text = CustName;
            textBox2Mobile.Text = Mobile;
            textBox3Addr.Text = address;
        }
    }
}
