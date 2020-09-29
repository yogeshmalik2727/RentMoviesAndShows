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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        //globaly define conection
        SqlConnection con = new SqlConnection(@"data source=.\SQLExpress; initial catalog=rentmovies; integrated security=true;");
        string Flag = "";
        bool rented=false;
        string SelectedMovieID;
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open(); // open the sql connection on app. start
            BindGridMovieShows(); // Show All Movies on App. start
            
            
            if (rented == false)
            {
                CreateEditBtton(); //method calling to display edit button
                CreateDeleteBtton(); //method calling to display delete button
            }
            CreateRentBtton(); //method calling to display Rent button
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Dispose(); // close the sql connection on app. close
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            con.Dispose(); // close the sql connection on app. close
            Application.Exit();
        }

        //Show All Customers
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                BindGridCustomer(); // method calling to bind customer to data grid

                CreateEditBtton(); //method calling to display edit button
                CreateDeleteBtton(); //method calling to display delete button

            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        //Bind All customers to Data Grid
        public void BindGridCustomer()
        {
            Flag = "customer";
            dataGridView1.Columns.Clear(); // clear previous data

            DataTable dt = GetAllCustomers();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }


        //Bind All -RENTED- Movies And Shows
        public void BindGridRentedMovieShows()
        {
            Flag = "return";
            dataGridView1.Columns.Clear(); // clear previous data

            DataTable dt = GetAllRentedMovies();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        //get All Rented Movies And Shows
        public DataTable GetAllRentedMovies()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_ShowRentedMovies";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            da.Dispose();

            return ds;
            
        }

        //Bind All Movies and Shows to Data Grid
        public void BindGridMovieShows()
        {
            Flag = "movies";
            dataGridView1.Columns.Clear(); // clear previous data

            DataTable dt = GetAllMovieShows();
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        //get All customers
        public DataTable GetAllCustomers()
        {
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from customer";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            da.Dispose();
           
            return ds;
        }

        //get All Movies And Shows
        public DataTable GetAllMovieShows()
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from movies";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
           
            da.Dispose();
            cmd.Dispose();
            return ds;
        }

        public void CreateEditBtton()
        {
            //Create EDIT button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.HeaderText = "Edit Record";
            editButton.Name = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Text = "Edit";
            editButton.Width = 80;

            dataGridView1.Columns.Add(editButton); // add button to grid view
        }

        //Create EDIT button
        public void CreateDeleteBtton()
        {
            
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "Delete Record";
            deleteButton.Name = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            deleteButton.Width = 100;

            dataGridView1.Columns.Add(deleteButton); // add button to grid view
        }

        //Create RETURN button
        public void CreateReturnBtton()
        {

            DataGridViewButtonColumn returnButton = new DataGridViewButtonColumn();
            returnButton.FlatStyle = FlatStyle.Popup;
            returnButton.HeaderText = "Return Movie";
            
            returnButton.Name = "Return";
            returnButton.UseColumnTextForButtonValue = true;
            returnButton.Text = "Return";
            returnButton.Width = 100;

            dataGridView1.Columns.Add(returnButton); // add button to grid view
        }


        //Create RENT button
        public void CreateRentBtton()
        {

            DataGridViewButtonColumn rentButton = new DataGridViewButtonColumn();
            rentButton.FlatStyle = FlatStyle.Popup;
            rentButton.HeaderText = "Rent Movie";

            rentButton.Name = "Rent";
            rentButton.UseColumnTextForButtonValue = true;
            rentButton.Text = "Rent";
            rentButton.Width = 100;

            dataGridView1.Columns.Add(rentButton); // add button to grid view
        }

        //view All rented movies
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                rented = true;
                BindGridRentedMovieShows(); //method calling to get all rented movies and shows
                CreateReturnBtton(); //method calling to display return movie button
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Most popular movies
        private void button4_Click(object sender, EventArgs e)
        {
        try
        {
                dataGridView1.Columns.Clear(); // clear previous data
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_MostPopularMovies";
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                
                dataGridView1.DataSource = ds;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                da.Dispose();
                cmd.Dispose();
               
            }
        catch (Exception ex)
        {
                MessageBox.Show(ex.Message);
        }
        }

        //Customer with Most Movies
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear(); // clear previous data
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_CustomerBorrowMostMovies";
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                
                dataGridView1.DataSource = ds;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                da.Dispose();
                cmd.Dispose();
               
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        //Show All Movies and Shows
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                BindGridMovieShows();
                CreateEditBtton(); //method calling to display edit button
                CreateDeleteBtton(); //method calling to display delete button
                CreateRentBtton(); //method calling to display Rent button
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Flag == "customer")
            {
                try
                {
                    string customerID, Name, address, Mobile;
                    if (e.ColumnIndex == 4) // edit button
                    {
                        customerID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        address = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Mobile = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                        Cutomer cutomer = new Cutomer(customerID, Name, address, Mobile);
                        cutomer.ShowDialog();

                        /******************After Updating customer*************************/
                        BindGridCustomer(); // method calling to bind customer to data grid

                        CreateEditBtton(); //method calling to display edit button
                        CreateDeleteBtton(); //method calling to display delete button
                    }
                    else if (e.ColumnIndex == 5) // delete button
                    {

                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Alert", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            customerID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                            SqlCommand cmd = new SqlCommand();
                            string query = "delete customer where customerId=@customerId";
                            cmd.CommandText = query;
                            cmd.Parameters.Add(new SqlParameter("@customerId", customerID));
                            cmd.Connection = con;
                            bool ans = cmd.ExecuteNonQuery() > 0;
                            if (ans)
                            {
                                BindGridCustomer(); // bind grid customer after deleting the customer
                                CreateEditBtton(); //method calling to display edit button
                                CreateDeleteBtton(); //method calling to display delete button
                                MessageBox.Show("Customer Deleted!", "Alert");

                            }
                            else
                            {
                                MessageBox.Show("Unable to Delete this Customer", "Alert");
                            }
                            cmd.Dispose();
                        }

                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE"))
                    {
                        MessageBox.Show("You Can not delete this Customer as he/she is rented a movie!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else if (Flag == "movies")
            {
                try
                {
                    string MovieID, Title, Year, Genre, WebRating, RentAmount;
                    if (e.ColumnIndex == 6) // edit button
                    {
                        MovieID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Title = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Year = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        RentAmount = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Genre = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        WebRating = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


                        MovieShows ms = new MovieShows(MovieID, Title, Year, Genre, WebRating, RentAmount);
                        ms.ShowDialog();

                        /******************After Updating movie*************************/
                        BindGridMovieShows(); // method calling to bind movies and shows to data grid
                        CreateRentBtton(); // method calling to display RENT button
                        CreateEditBtton(); //method calling to display edit button
                        CreateDeleteBtton(); //method calling to display delete button
                    }
                    else if (e.ColumnIndex == 7) // delete button
                    {

                        DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Alert", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            MovieID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                            SqlCommand cmd = new SqlCommand();
                            string query = "delete movies where MovieID=@MovieID";
                            cmd.CommandText = query;
                            cmd.Parameters.Add(new SqlParameter("@MovieID", MovieID));
                            cmd.Connection = con;
                            bool ans = cmd.ExecuteNonQuery() > 0;
                            if (ans)
                            {
                                BindGridMovieShows(); // bind grid movie and shows after deleting the movie
                                CreateEditBtton(); //method calling to display edit button
                                CreateDeleteBtton(); //method calling to display delete button
                                CreateRentBtton(); // method calling to display RENT button
                                MessageBox.Show("Movie Deleted!", "Alert");

                            }
                            else
                            {
                                MessageBox.Show("Unable to Delete this Movie", "Alert");
                            }
                            cmd.Dispose();
                        }

                    }
                    else if (e.ColumnIndex == 8) // Rent button
                    {
                        gbRentMovie.Visible = true;
                        SelectedMovieID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        BindDdlCustomer(); // method calling to bind comboBox customer
 
                    }
 
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("REFERENCE"))
                    {
                        MessageBox.Show("You Can not delete this Movie / Show as it is rented by a Customer!");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (Flag == "return")
            {
                try
                {
                     string RentID,MovieName,CustomerName;
                    if (e.ColumnIndex == 7) // retrun button
                    {
                        RentID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        MovieName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        CustomerName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        DialogResult result = MessageBox.Show("Do you want to Return the Movie: "+ MovieName +", for the Customer: "+
                            CustomerName+ "?", "Alert", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            
                            SqlCommand cmd = new SqlCommand("delete from moviesonrent where RentID=@RentID", con);

                            cmd.Parameters.AddWithValue("@RentID", RentID);

                            bool ans = cmd.ExecuteNonQuery() > 0;
                            if (ans)
                            {
                                BindGridRentedMovieShows(); //method calling to get all rented movies and shows
                                CreateReturnBtton(); //method calling to display return movie button
                                MessageBox.Show("Movie returned successfully!");
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
        }

        // Get Movie Rent  
        public int GetMovieRent(int MovieID)
        {
            SqlCommand cmd = new SqlCommand("select RentCost from movies where MovieID=@MovieID",con);
            
            cmd.Parameters.AddWithValue("@MovieID", MovieID);
            int Rent = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                Rent = int.Parse(reader[0].ToString());
            }
            reader.Close();
            cmd.Dispose();
            return Rent;
        }

        //Bind ComboBox Customer
        private void BindDdlCustomer()
        {
            SqlCommand cmd = new SqlCommand("select CustomerId,name from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            
            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "Select Customer...";
            ds.Rows.InsertAt(row, 0); // add item at INDEX = 0;

            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.ValueMember = "CustomerID";
            comboBoxCustomer.DataSource = ds;

            da.Dispose();
            cmd.Dispose();
        }

            private void button2_Click(object sender, EventArgs e)
            {
            Cutomer cutomer = new Cutomer();
            cutomer.ShowDialog();

            /******************After adding new customer*************************/
            BindGridCustomer(); // method calling to bind customer to data grid

            CreateEditBtton(); //method calling to display edit button
            CreateDeleteBtton(); //method calling to display delete button

            }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose(); // close the sql connection on app. close
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovieShows ms = new MovieShows();
            ms.ShowDialog();

            /******************After adding new Movie or Show *************************/
            BindGridMovieShows(); // method calling to bind customer to data grid

            CreateEditBtton(); //method calling to display edit button
            CreateDeleteBtton(); //method calling to display delete button
            CreateRentBtton(); // method calling to display RENT button
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            gbRentMovie.Visible = false;
            
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerID, rentDate, ReturnDate, MovieID;
                int TotalDays;
                MovieID = SelectedMovieID;
                CustomerID = comboBoxCustomer.SelectedValue.ToString();
                rentDate = dtIsuue.Value.ToShortDateString();
                ReturnDate = dtReturn.Value.ToShortDateString();

                if (CustomerID == "")
                {
                    // nothing happened here
                }
                else
                {
                    if (rentDate == ReturnDate)
                    {
                        TotalDays = 1;
                    }
                    else
                    {
                        TotalDays = Convert.ToInt32((DateTime.Parse(ReturnDate) - DateTime.Parse(rentDate)).TotalDays);
                    }

                    int RentCost = GetMovieRent(int.Parse(MovieID)); // Getting rental cost for that movie

                    int TotalRent = TotalDays * RentCost; // Calculated the TotalRent

                    SqlCommand cmd = new SqlCommand();
                    string query = "sp_RentMovieShows";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@MovieID", MovieID));
                    cmd.Parameters.Add(new SqlParameter("@CustID", CustomerID));
                    cmd.Parameters.Add(new SqlParameter("@RentDate", rentDate));
                    cmd.Parameters.Add(new SqlParameter("@ReturnDate", ReturnDate));
                    cmd.Parameters.Add(new SqlParameter("@TotalRent", TotalRent));
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    bool ans = cmd.ExecuteNonQuery() > 0;
                    if (ans)
                    {
                        BindGridRentedMovieShows(); // bind grid rented movies after renting a movie
                        CreateEditBtton(); //method calling to display edit button
                        CreateDeleteBtton(); //method calling to display delete button
                        CreateReturnBtton(); // method calling- show return button
                        gbRentMovie.Visible = false;
                        MessageBox.Show("Movie Rented Successfully! Rent Amount is: $" + TotalRent, "Alert");

                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete this Movie", "Alert");
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        
    }
}
