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
    public partial class MovieShows : Form
    {
        string MovieID, Title, Year, Genre, WebRating, RentAmt;
        public MovieShows()
        {
            InitializeComponent();
            button1Save.Text = "Save";
            button2Cancel.Text = "Cancel";
        }

        public MovieShows(string MovieID, string Title, string Year, string Genre, string WebRating, string RentAmount)
        {
            InitializeComponent();
            this.MovieID = MovieID;
            this.Title = Title;
            this.Year = Year;
            this.Genre = Genre;
            this.WebRating = WebRating;
            this.RentAmt = RentAmount;
            button1Save.Text = "Update";
            button2Cancel.Text = "Close";
        }

        //globaly define conection
        SqlConnection con = new SqlConnection(@"data source=.\SQLExpress; initial catalog=rentmovies; integrated security=true;");

        private void button1Save_Click(object sender, EventArgs e)
        {
            try
            {
                string Title, RentCost, Year, Rating, Genre;
                Title = textBox1Title.Text.Trim();
                RentCost = textBox2Rent.Text.Trim();
                Rating = textBoxRating.Text.Trim();
                Year = textBox2Year.Text.Trim();
                Genre = textBox1Genre.Text.Trim();

                if (button1Save.Text == "Save")
                {
                    if (Title == "")
                    {
                        MessageBox.Show("Title is required!");
                    }
                    else if (Year == "")
                    {
                        MessageBox.Show("Released year is required!");
                    }

                    else if (Genre == "")
                    {
                        MessageBox.Show("Genre is required!");
                    }

                    else if (Rating == "")
                    {
                        MessageBox.Show("Rating is required!");
                    }

                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "spInsertMovie";
                        cmd.CommandType = CommandType.StoredProcedure; // store procedure
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Year", Year);
                        cmd.Parameters.AddWithValue("@RentCost", RentCost);
                        cmd.Parameters.AddWithValue("@Genre", Genre);
                        cmd.Parameters.AddWithValue("@Rating", Rating);

                        bool ans = cmd.ExecuteNonQuery() > 0;

                        if (ans)
                        {

                            MessageBox.Show("Movie Saved!", "Alert");


                        }
                        else
                        {
                            MessageBox.Show("Movie Not Saved!", "Alert");
                        }
                        cmd.Dispose();


                        textBox1Title.Clear();
                        textBox2Year.Clear();
                        textBoxRating.Clear();
                        textBox1Genre.Clear();
                        textBox2Rent.Clear();


                    }
                }
                else if (button1Save.Text == "Update")
                {
                    if (Title == "")
                    {
                        MessageBox.Show("Title is required!");
                    }
                    else if (Year == "")
                    {
                        MessageBox.Show("Released year is required!");
                    }

                    else if (Genre == "")
                    {
                        MessageBox.Show("Genre is required!");
                    }

                    else if (Rating == "")
                    {
                        MessageBox.Show("Rating is required!");
                    }

                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "sp_cUpdateMovieOrShow"; // store procedure
                        cmd.CommandType = CommandType.StoredProcedure; 
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@MovieID", MovieID);
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Year", Year);
                        cmd.Parameters.AddWithValue("@RentCost", RentCost);
                        cmd.Parameters.AddWithValue("@Genre", Genre);
                        cmd.Parameters.AddWithValue("@Rating", Rating);

                        bool ans = cmd.ExecuteNonQuery() > 0;

                        if (ans)
                        {

                            MessageBox.Show("Movie / Show Updated!", "Alert");


                        }
                        else
                        {
                            MessageBox.Show("Movie / Show Not Updated!", "Alert");
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

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            con.Dispose(); // close db connection
            this.Close();
        }

        private void MovieShows_Load(object sender, EventArgs e)
        {
            con.Open(); // Open Sql Connection on form Load

            //Bind value to textboxes
            textBox1Genre.Text = Genre;
            textBox1Title.Text = Title;
            textBox2Rent.Text = RentAmt;
            textBox2Year.Text = Year;
            textBoxRating.Text = WebRating;
        }

        //Calculate the Rent for movie or web-show
        private void textBox2Year_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ReleasedYear = textBox2Year.Text.Trim();
                string PresentYear = DateTime.Now.Year.ToString();
                if (ReleasedYear=="")
                {
                    textBox2Rent.Text = "";
                }

                else
                {
                    int older = int.Parse(PresentYear) - int.Parse(ReleasedYear);
                    //if videos are older than 5 years (Release Date) then they cost $2 otherwise they cost $5
                    if (older > 5)
                    {
                        textBox2Rent.Text = "2";
                    }
                    else
                    {
                        textBox2Rent.Text = "5";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

