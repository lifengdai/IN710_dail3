namespace Clock
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
            this.components = new System.ComponentModel.Container();
            this.analogClock = new AnalogClockControl.AnalogClock();
            this.btnStartClock = new System.Windows.Forms.Button();
            this.btnStopClock = new System.Windows.Forms.Button();
            this.gbCLockType = new System.Windows.Forms.GroupBox();
            this.rbAnalogue = new System.Windows.Forms.RadioButton();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.lblDigitalClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCLockType.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock
            // 
            this.analogClock.Draw1MinuteTicks = true;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock.Location = new System.Drawing.Point(101, 260);
            this.analogClock.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock.Name = "analogClock";
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(363, 363);
            this.analogClock.TabIndex = 0;
            this.analogClock.TicksColor = System.Drawing.Color.Black;
            // 
            // btnStartClock
            // 
            this.btnStartClock.Location = new System.Drawing.Point(34, 23);
            this.btnStartClock.Name = "btnStartClock";
            this.btnStartClock.Size = new System.Drawing.Size(160, 53);
            this.btnStartClock.TabIndex = 1;
            this.btnStartClock.Text = "Start Clock";
            this.btnStartClock.UseVisualStyleBackColor = true;
            this.btnStartClock.Click += new System.EventHandler(this.btnStartClock_Click);
            // 
            // btnStopClock
            // 
            this.btnStopClock.Location = new System.Drawing.Point(34, 107);
            this.btnStopClock.Name = "btnStopClock";
            this.btnStopClock.Size = new System.Drawing.Size(160, 53);
            this.btnStopClock.TabIndex = 2;
            this.btnStopClock.Text = "Stop Clock";
            this.btnStopClock.UseVisualStyleBackColor = true;
            this.btnStopClock.Click += new System.EventHandler(this.btnStopClock_Click);
            // 
            // gbCLockType
            // 
            this.gbCLockType.Controls.Add(this.rbAnalogue);
            this.gbCLockType.Controls.Add(this.rbDigital);
            this.gbCLockType.Location = new System.Drawing.Point(278, 23);
            this.gbCLockType.Name = "gbCLockType";
            this.gbCLockType.Size = new System.Drawing.Size(282, 137);
            this.gbCLockType.TabIndex = 3;
            this.gbCLockType.TabStop = false;
            this.gbCLockType.Text = "Clock Type";
            // 
            // rbAnalogue
            // 
            this.rbAnalogue.AutoSize = true;
            this.rbAnalogue.Checked = true;
            this.rbAnalogue.Location = new System.Drawing.Point(6, 84);
            this.rbAnalogue.Name = "rbAnalogue";
            this.rbAnalogue.Size = new System.Drawing.Size(105, 22);
            this.rbAnalogue.TabIndex = 1;
            this.rbAnalogue.TabStop = true;
            this.rbAnalogue.Text = "Analogue";
            this.rbAnalogue.UseVisualStyleBackColor = true;
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Location = new System.Drawing.Point(6, 43);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(96, 22);
            this.rbDigital.TabIndex = 0;
            this.rbDigital.Text = "Digital";
            this.rbDigital.UseVisualStyleBackColor = true;
            this.rbDigital.CheckedChanged += new System.EventHandler(this.rbDigital_CheckedChanged);
            // 
            // lblDigitalClock
            // 
            this.lblDigitalClock.AutoSize = true;
            this.lblDigitalClock.Font = new System.Drawing.Font("SimSun", 50F);
            this.lblDigitalClock.Location = new System.Drawing.Point(72, 384);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(442, 100);
            this.lblDigitalClock.TabIndex = 4;
            this.lblDigitalClock.Text = "00:00:00";
            this.lblDigitalClock.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 635);
            this.Controls.Add(this.lblDigitalClock);
            this.Controls.Add(this.gbCLockType);
            this.Controls.Add(this.btnStopClock);
            this.Controls.Add(this.btnStartClock);
            this.Controls.Add(this.analogClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCLockType.ResumeLayout(false);
            this.gbCLockType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock;
        private System.Windows.Forms.Button btnStartClock;
        private System.Windows.Forms.Button btnStopClock;
        private System.Windows.Forms.GroupBox gbCLockType;
        private System.Windows.Forms.RadioButton rbAnalogue;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.Windows.Forms.Label lblDigitalClock;
        private System.Windows.Forms.Timer timer1;
    }
}

