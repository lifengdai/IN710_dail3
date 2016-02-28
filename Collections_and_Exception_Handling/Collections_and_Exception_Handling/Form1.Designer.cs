namespace Collections_and_Exception_Handling
{
    partial class FormMovieDatabase
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.txtAddMovieYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtDeleteMovieYear = new System.Windows.Forms.TextBox();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.lblAddMovieYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDeleteMovieYear = new System.Windows.Forms.Label();
            this.lblSearchYear = new System.Windows.Forms.Label();
            this.lsbxPrintAll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Location = new System.Drawing.Point(34, 44);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(159, 32);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMovie.Location = new System.Drawing.Point(34, 162);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(159, 32);
            this.btnDeleteMovie.TabIndex = 1;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(34, 241);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(159, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Location = new System.Drawing.Point(34, 321);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(159, 32);
            this.btnPrintAll.TabIndex = 3;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // txtAddMovieYear
            // 
            this.txtAddMovieYear.BackColor = System.Drawing.Color.White;
            this.txtAddMovieYear.Location = new System.Drawing.Point(308, 14);
            this.txtAddMovieYear.Name = "txtAddMovieYear";
            this.txtAddMovieYear.Size = new System.Drawing.Size(371, 28);
            this.txtAddMovieYear.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(308, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(371, 28);
            this.txtTitle.TabIndex = 5;
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.White;
            this.txtDirector.Location = new System.Drawing.Point(308, 82);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(371, 28);
            this.txtDirector.TabIndex = 6;
            // 
            // txtDeleteMovieYear
            // 
            this.txtDeleteMovieYear.BackColor = System.Drawing.Color.White;
            this.txtDeleteMovieYear.Location = new System.Drawing.Point(308, 166);
            this.txtDeleteMovieYear.Name = "txtDeleteMovieYear";
            this.txtDeleteMovieYear.Size = new System.Drawing.Size(371, 28);
            this.txtDeleteMovieYear.TabIndex = 7;
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.BackColor = System.Drawing.Color.White;
            this.txtSearchYear.Location = new System.Drawing.Point(308, 245);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(371, 28);
            this.txtSearchYear.TabIndex = 8;
            // 
            // lblAddMovieYear
            // 
            this.lblAddMovieYear.AutoSize = true;
            this.lblAddMovieYear.Location = new System.Drawing.Point(208, 17);
            this.lblAddMovieYear.Name = "lblAddMovieYear";
            this.lblAddMovieYear.Size = new System.Drawing.Size(44, 18);
            this.lblAddMovieYear.TabIndex = 9;
            this.lblAddMovieYear.Text = "Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(208, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 18);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(208, 85);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(80, 18);
            this.lblDirector.TabIndex = 11;
            this.lblDirector.Text = "Director";
            // 
            // lblDeleteMovieYear
            // 
            this.lblDeleteMovieYear.AutoSize = true;
            this.lblDeleteMovieYear.Location = new System.Drawing.Point(208, 169);
            this.lblDeleteMovieYear.Name = "lblDeleteMovieYear";
            this.lblDeleteMovieYear.Size = new System.Drawing.Size(44, 18);
            this.lblDeleteMovieYear.TabIndex = 12;
            this.lblDeleteMovieYear.Text = "Year";
            // 
            // lblSearchYear
            // 
            this.lblSearchYear.AutoSize = true;
            this.lblSearchYear.Location = new System.Drawing.Point(208, 248);
            this.lblSearchYear.Name = "lblSearchYear";
            this.lblSearchYear.Size = new System.Drawing.Size(44, 18);
            this.lblSearchYear.TabIndex = 13;
            this.lblSearchYear.Text = "Year";
            // 
            // lsbxPrintAll
            // 
            this.lsbxPrintAll.BackColor = System.Drawing.SystemColors.Window;
            this.lsbxPrintAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbxPrintAll.FormattingEnabled = true;
            this.lsbxPrintAll.ItemHeight = 18;
            this.lsbxPrintAll.Location = new System.Drawing.Point(211, 321);
            this.lsbxPrintAll.Name = "lsbxPrintAll";
            this.lsbxPrintAll.Size = new System.Drawing.Size(468, 234);
            this.lsbxPrintAll.TabIndex = 14;
            // 
            // FormMovieDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 573);
            this.Controls.Add(this.lsbxPrintAll);
            this.Controls.Add(this.lblSearchYear);
            this.Controls.Add(this.lblDeleteMovieYear);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAddMovieYear);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.txtDeleteMovieYear);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAddMovieYear);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "FormMovieDatabase";
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.TextBox txtAddMovieYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtDeleteMovieYear;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblAddMovieYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDeleteMovieYear;
        private System.Windows.Forms.Label lblSearchYear;
        private System.Windows.Forms.ListBox lsbxPrintAll;
    }
}

