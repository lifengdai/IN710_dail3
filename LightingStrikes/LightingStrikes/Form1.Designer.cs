namespace LightingStrikes
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
            this.btnDisplayIntensity = new System.Windows.Forms.Button();
            this.btnListRecords = new System.Windows.Forms.Button();
            this.btnDisplayLatLongFilename = new System.Windows.Forms.Button();
            this.btnStrikeCausedFire = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplayIntensity
            // 
            this.btnDisplayIntensity.Location = new System.Drawing.Point(24, 18);
            this.btnDisplayIntensity.Name = "btnDisplayIntensity";
            this.btnDisplayIntensity.Size = new System.Drawing.Size(472, 44);
            this.btnDisplayIntensity.TabIndex = 0;
            this.btnDisplayIntensity.Text = "Display the average intensity";
            this.btnDisplayIntensity.UseVisualStyleBackColor = true;
            this.btnDisplayIntensity.Click += new System.EventHandler(this.btnDisplayIntensity_Click);
            // 
            // btnListRecords
            // 
            this.btnListRecords.Location = new System.Drawing.Point(24, 68);
            this.btnListRecords.Name = "btnListRecords";
            this.btnListRecords.Size = new System.Drawing.Size(472, 44);
            this.btnListRecords.TabIndex = 0;
            this.btnListRecords.Text = "List the complete records of lagest three fires";
            this.btnListRecords.UseVisualStyleBackColor = true;
            this.btnListRecords.Click += new System.EventHandler(this.btnListRecords_Click);
            // 
            // btnDisplayLatLongFilename
            // 
            this.btnDisplayLatLongFilename.Location = new System.Drawing.Point(511, 18);
            this.btnDisplayLatLongFilename.Name = "btnDisplayLatLongFilename";
            this.btnDisplayLatLongFilename.Size = new System.Drawing.Size(472, 44);
            this.btnDisplayLatLongFilename.TabIndex = 0;
            this.btnDisplayLatLongFilename.Text = "Display latitude, longitude and filename\r\n";
            this.btnDisplayLatLongFilename.UseVisualStyleBackColor = true;
            this.btnDisplayLatLongFilename.Click += new System.EventHandler(this.btnDisplayLatLongFilename_Click);
            // 
            // btnStrikeCausedFire
            // 
            this.btnStrikeCausedFire.Location = new System.Drawing.Point(511, 68);
            this.btnStrikeCausedFire.Name = "btnStrikeCausedFire";
            this.btnStrikeCausedFire.Size = new System.Drawing.Size(472, 44);
            this.btnStrikeCausedFire.TabIndex = 0;
            this.btnStrikeCausedFire.Text = "List all fires caused by a lightning strike";
            this.btnStrikeCausedFire.UseVisualStyleBackColor = true;
            this.btnStrikeCausedFire.Click += new System.EventHandler(this.btnStrikeCausedFire_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(24, 118);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(959, 436);
            this.listBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 571);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnStrikeCausedFire);
            this.Controls.Add(this.btnDisplayLatLongFilename);
            this.Controls.Add(this.btnListRecords);
            this.Controls.Add(this.btnDisplayIntensity);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayIntensity;
        private System.Windows.Forms.Button btnListRecords;
        private System.Windows.Forms.Button btnDisplayLatLongFilename;
        private System.Windows.Forms.Button btnStrikeCausedFire;
        private System.Windows.Forms.ListBox listBox;
    }
}

