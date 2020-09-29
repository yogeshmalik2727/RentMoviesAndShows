namespace RentMoviesAndShows
{
    partial class MovieShows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2Cancel = new System.Windows.Forms.Button();
            this.button1Save = new System.Windows.Forms.Button();
            this.textBox2Year = new System.Windows.Forms.TextBox();
            this.textBox1Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1Genre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBox2Rent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2Cancel
            // 
            this.button2Cancel.BackColor = System.Drawing.Color.Coral;
            this.button2Cancel.ForeColor = System.Drawing.Color.White;
            this.button2Cancel.Location = new System.Drawing.Point(198, 535);
            this.button2Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(144, 40);
            this.button2Cancel.TabIndex = 19;
            this.button2Cancel.Text = "Cancel";
            this.button2Cancel.UseVisualStyleBackColor = false;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // button1Save
            // 
            this.button1Save.BackColor = System.Drawing.Color.OrangeRed;
            this.button1Save.ForeColor = System.Drawing.Color.White;
            this.button1Save.Location = new System.Drawing.Point(35, 535);
            this.button1Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(144, 40);
            this.button1Save.TabIndex = 18;
            this.button1Save.Text = "Save";
            this.button1Save.UseVisualStyleBackColor = false;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // textBox2Year
            // 
            this.textBox2Year.Location = new System.Drawing.Point(150, 273);
            this.textBox2Year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2Year.Name = "textBox2Year";
            this.textBox2Year.Size = new System.Drawing.Size(249, 28);
            this.textBox2Year.TabIndex = 16;
            this.textBox2Year.TextChanged += new System.EventHandler(this.textBox2Year_TextChanged);
            // 
            // textBox1Title
            // 
            this.textBox1Title.Location = new System.Drawing.Point(150, 219);
            this.textBox1Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1Title.Name = "textBox1Title";
            this.textBox1Title.Size = new System.Drawing.Size(249, 28);
            this.textBox1Title.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Movies And Shows";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1Genre
            // 
            this.textBox1Genre.Location = new System.Drawing.Point(150, 332);
            this.textBox1Genre.Name = "textBox1Genre";
            this.textBox1Genre.Size = new System.Drawing.Size(249, 28);
            this.textBox1Genre.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rating:";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(150, 387);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(249, 28);
            this.textBoxRating.TabIndex = 22;
            // 
            // textBox2Rent
            // 
            this.textBox2Rent.Location = new System.Drawing.Point(150, 446);
            this.textBox2Rent.Name = "textBox2Rent";
            this.textBox2Rent.ReadOnly = true;
            this.textBox2Rent.Size = new System.Drawing.Size(249, 28);
            this.textBox2Rent.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rent:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMoviesAndShows.Properties.Resources.movie;
            this.pictureBox1.Location = new System.Drawing.Point(35, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MovieShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 606);
            this.Controls.Add(this.textBox2Rent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1Genre);
            this.Controls.Add(this.button2Cancel);
            this.Controls.Add(this.button1Save);
            this.Controls.Add(this.textBox2Year);
            this.Controls.Add(this.textBox1Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MovieShows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies And Shows";
            this.Load += new System.EventHandler(this.MovieShows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2Cancel;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.TextBox textBox2Year;
        private System.Windows.Forms.TextBox textBox1Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1Genre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBox2Rent;
        private System.Windows.Forms.Label label6;
    }
}