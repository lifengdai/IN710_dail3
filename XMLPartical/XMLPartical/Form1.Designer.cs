namespace XMLPartical
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnListHardRock = new System.Windows.Forms.Button();
            this.btnCurrentMonth = new System.Windows.Forms.Button();
            this.btnBandMembers = new System.Windows.Forms.Button();
            this.AnotherDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BandName,
            this.Genre,
            this.Venue,
            this.Date,
            this.Time});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(689, 325);
            this.dataGridView.TabIndex = 0;
            // 
            // BandName
            // 
            this.BandName.HeaderText = "Band Name";
            this.BandName.Name = "BandName";
            this.BandName.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            this.Venue.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(707, 12);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(295, 61);
            this.btnListAll.TabIndex = 1;
            this.btnListAll.Text = "List  all";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnListHardRock
            // 
            this.btnListHardRock.Location = new System.Drawing.Point(707, 135);
            this.btnListHardRock.Name = "btnListHardRock";
            this.btnListHardRock.Size = new System.Drawing.Size(295, 61);
            this.btnListHardRock.TabIndex = 2;
            this.btnListHardRock.Text = "List genre is hard rock";
            this.btnListHardRock.UseVisualStyleBackColor = true;
            this.btnListHardRock.Click += new System.EventHandler(this.btnListHardRock_Click);
            // 
            // btnCurrentMonth
            // 
            this.btnCurrentMonth.Location = new System.Drawing.Point(707, 276);
            this.btnCurrentMonth.Name = "btnCurrentMonth";
            this.btnCurrentMonth.Size = new System.Drawing.Size(295, 61);
            this.btnCurrentMonth.TabIndex = 3;
            this.btnCurrentMonth.Text = "Show gigs on current month";
            this.btnCurrentMonth.UseVisualStyleBackColor = true;
            this.btnCurrentMonth.Click += new System.EventHandler(this.btnCurrentMonth_Click);
            // 
            // btnBandMembers
            // 
            this.btnBandMembers.Location = new System.Drawing.Point(707, 406);
            this.btnBandMembers.Name = "btnBandMembers";
            this.btnBandMembers.Size = new System.Drawing.Size(295, 61);
            this.btnBandMembers.TabIndex = 5;
            this.btnBandMembers.Text = "List band members";
            this.btnBandMembers.UseVisualStyleBackColor = true;
            this.btnBandMembers.Click += new System.EventHandler(this.btnBandMembers_Click);
            // 
            // AnotherDataGridView
            // 
            this.AnotherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnotherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.Instruments,
            this.Roles});
            this.AnotherDataGridView.Location = new System.Drawing.Point(12, 343);
            this.AnotherDataGridView.Name = "AnotherDataGridView";
            this.AnotherDataGridView.RowTemplate.Height = 30;
            this.AnotherDataGridView.Size = new System.Drawing.Size(689, 403);
            this.AnotherDataGridView.TabIndex = 6;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Instruments
            // 
            this.Instruments.HeaderText = "Instruments";
            this.Instruments.Name = "Instruments";
            this.Instruments.ReadOnly = true;
            // 
            // Roles
            // 
            this.Roles.HeaderText = "Roles";
            this.Roles.Name = "Roles";
            this.Roles.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(707, 541);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 61);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add new thing";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 758);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.AnotherDataGridView);
            this.Controls.Add(this.btnBandMembers);
            this.Controls.Add(this.btnCurrentMonth);
            this.Controls.Add(this.btnListHardRock);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnListHardRock;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button btnCurrentMonth;
        private System.Windows.Forms.Button btnBandMembers;
        private System.Windows.Forms.DataGridView AnotherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roles;
        private System.Windows.Forms.Button btnAdd;
    }
}

