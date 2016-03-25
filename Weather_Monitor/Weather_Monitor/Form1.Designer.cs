namespace Weather_Monitor
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.lblReadings = new System.Windows.Forms.Label();
            this.lstbReadings = new System.Windows.Forms.ListBox();
            this.lstbAvgReading = new System.Windows.Forms.ListBox();
            this.lblAvgReadings = new System.Windows.Forms.Label();
            this.lblForecast = new System.Windows.Forms.Label();
            this.lstbForecast = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(48, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 43);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Measurements";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(45, 183);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(134, 18);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temperature(C)";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(45, 297);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(107, 18);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity(%)";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(45, 417);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(224, 18);
            this.lblPressure.TabIndex = 3;
            this.lblPressure.Text = "Barometric Pressure(KPa)\r\n";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(48, 204);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(209, 28);
            this.txtTemp.TabIndex = 4;
            this.txtTemp.TextChanged += new System.EventHandler(this.txtTemp_TextChanged);
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(48, 318);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(209, 28);
            this.txtHumidity.TabIndex = 5;
            this.txtHumidity.TextChanged += new System.EventHandler(this.txtHumidity_TextChanged);
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(48, 438);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(209, 28);
            this.txtPressure.TabIndex = 6;
            this.txtPressure.TextChanged += new System.EventHandler(this.txtPressure_TextChanged);
            // 
            // lblReadings
            // 
            this.lblReadings.AutoSize = true;
            this.lblReadings.Location = new System.Drawing.Point(347, 48);
            this.lblReadings.Name = "lblReadings";
            this.lblReadings.Size = new System.Drawing.Size(80, 18);
            this.lblReadings.TabIndex = 1;
            this.lblReadings.Text = "Readings";
            // 
            // lstbReadings
            // 
            this.lstbReadings.FormattingEnabled = true;
            this.lstbReadings.ItemHeight = 18;
            this.lstbReadings.Location = new System.Drawing.Point(350, 69);
            this.lstbReadings.Name = "lstbReadings";
            this.lstbReadings.Size = new System.Drawing.Size(420, 130);
            this.lstbReadings.TabIndex = 7;
            // 
            // lstbAvgReading
            // 
            this.lstbAvgReading.FormattingEnabled = true;
            this.lstbAvgReading.ItemHeight = 18;
            this.lstbAvgReading.Location = new System.Drawing.Point(350, 269);
            this.lstbAvgReading.Name = "lstbAvgReading";
            this.lstbAvgReading.Size = new System.Drawing.Size(420, 130);
            this.lstbAvgReading.TabIndex = 8;
            // 
            // lblAvgReadings
            // 
            this.lblAvgReadings.AutoSize = true;
            this.lblAvgReadings.Location = new System.Drawing.Point(347, 248);
            this.lblAvgReadings.Name = "lblAvgReadings";
            this.lblAvgReadings.Size = new System.Drawing.Size(152, 18);
            this.lblAvgReadings.TabIndex = 9;
            this.lblAvgReadings.Text = "Average Readings";
            // 
            // lblForecast
            // 
            this.lblForecast.AutoSize = true;
            this.lblForecast.Location = new System.Drawing.Point(347, 448);
            this.lblForecast.Name = "lblForecast";
            this.lblForecast.Size = new System.Drawing.Size(80, 18);
            this.lblForecast.TabIndex = 10;
            this.lblForecast.Text = "Forecast";
            // 
            // lstbForecast
            // 
            this.lstbForecast.FormattingEnabled = true;
            this.lstbForecast.ItemHeight = 18;
            this.lstbForecast.Location = new System.Drawing.Point(350, 469);
            this.lstbForecast.Name = "lstbForecast";
            this.lstbForecast.Size = new System.Drawing.Size(420, 130);
            this.lstbForecast.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 618);
            this.Controls.Add(this.lstbForecast);
            this.Controls.Add(this.lblForecast);
            this.Controls.Add(this.lblAvgReadings);
            this.Controls.Add(this.lstbAvgReading);
            this.Controls.Add(this.lstbReadings);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblReadings);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label lblReadings;
        private System.Windows.Forms.ListBox lstbReadings;
        private System.Windows.Forms.ListBox lstbAvgReading;
        private System.Windows.Forms.Label lblAvgReadings;
        private System.Windows.Forms.Label lblForecast;
        private System.Windows.Forms.ListBox lstbForecast;
    }
}

