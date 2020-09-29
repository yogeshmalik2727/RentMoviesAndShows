namespace RentMoviesAndShows
{
    partial class start
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
            this.button1Launch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Launch
            // 
            this.button1Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Launch.Location = new System.Drawing.Point(591, 264);
            this.button1Launch.Name = "button1Launch";
            this.button1Launch.Size = new System.Drawing.Size(101, 44);
            this.button1Launch.TabIndex = 0;
            this.button1Launch.Text = "Launch";
            this.button1Launch.UseVisualStyleBackColor = true;
            this.button1Launch.Click += new System.EventHandler(this.button1Launch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(353, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // labelErrorMsg
            // 
            this.labelErrorMsg.AutoSize = true;
            this.labelErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMsg.ForeColor = System.Drawing.Color.White;
            this.labelErrorMsg.Location = new System.Drawing.Point(82, 347);
            this.labelErrorMsg.Name = "labelErrorMsg";
            this.labelErrorMsg.Size = new System.Drawing.Size(0, 24);
            this.labelErrorMsg.TabIndex = 2;
            // 
            // start
            // 
            this.AcceptButton = this.button1Launch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentMoviesAndShows.Properties.Resources.DesktopLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 562);
            this.Controls.Add(this.labelErrorMsg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1Launch);
            this.MaximizeBox = false;
            this.Name = "start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Movies And Shows";
            this.Load += new System.EventHandler(this.start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Launch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelErrorMsg;
    }
}