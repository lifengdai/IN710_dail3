namespace Bicycle_DashBoard_CSharp
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
            this.btnStart = new System.Windows.Forms.Button();
            this.grpbxRPM = new System.Windows.Forms.GroupBox();
            this.grpbxCPH = new System.Windows.Forms.GroupBox();
            this.grpbxKPH = new System.Windows.Forms.GroupBox();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblCPH = new System.Windows.Forms.Label();
            this.lblKPH = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.grpbxRPM.SuspendLayout();
            this.grpbxCPH.SuspendLayout();
            this.grpbxKPH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpbxRPM
            // 
            this.grpbxRPM.Controls.Add(this.lblRPM);
            this.grpbxRPM.Location = new System.Drawing.Point(200, 128);
            this.grpbxRPM.Name = "grpbxRPM";
            this.grpbxRPM.Size = new System.Drawing.Size(264, 220);
            this.grpbxRPM.TabIndex = 1;
            this.grpbxRPM.TabStop = false;
            this.grpbxRPM.Text = "PRM";
            // 
            // grpbxCPH
            // 
            this.grpbxCPH.Controls.Add(this.lblCPH);
            this.grpbxCPH.Location = new System.Drawing.Point(200, 354);
            this.grpbxCPH.Name = "grpbxCPH";
            this.grpbxCPH.Size = new System.Drawing.Size(264, 220);
            this.grpbxCPH.TabIndex = 2;
            this.grpbxCPH.TabStop = false;
            this.grpbxCPH.Text = "CPH";
            // 
            // grpbxKPH
            // 
            this.grpbxKPH.Controls.Add(this.lblKPH);
            this.grpbxKPH.Location = new System.Drawing.Point(200, 580);
            this.grpbxKPH.Name = "grpbxKPH";
            this.grpbxKPH.Size = new System.Drawing.Size(264, 220);
            this.grpbxKPH.TabIndex = 3;
            this.grpbxKPH.TabStop = false;
            this.grpbxKPH.Text = "KPH";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("SimSun", 42F);
            this.lblRPM.Location = new System.Drawing.Point(51, 73);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(161, 84);
            this.lblRPM.TabIndex = 0;
            this.lblRPM.Text = "0.0";
            // 
            // lblCPH
            // 
            this.lblCPH.AutoSize = true;
            this.lblCPH.Font = new System.Drawing.Font("SimSun", 42F);
            this.lblCPH.Location = new System.Drawing.Point(51, 74);
            this.lblCPH.Name = "lblCPH";
            this.lblCPH.Size = new System.Drawing.Size(161, 84);
            this.lblCPH.TabIndex = 0;
            this.lblCPH.Text = "0.0";
            // 
            // lblKPH
            // 
            this.lblKPH.AutoSize = true;
            this.lblKPH.Font = new System.Drawing.Font("SimSun", 42F);
            this.lblKPH.Location = new System.Drawing.Point(51, 74);
            this.lblKPH.Name = "lblKPH";
            this.lblKPH.Size = new System.Drawing.Size(161, 84);
            this.lblKPH.TabIndex = 0;
            this.lblKPH.Text = "0.0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(256, 33);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(53, 18);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Speed";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(315, 30);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(345, 28);
            this.txtSpeed.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 843);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.grpbxKPH);
            this.Controls.Add(this.grpbxCPH);
            this.Controls.Add(this.grpbxRPM);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxRPM.ResumeLayout(false);
            this.grpbxRPM.PerformLayout();
            this.grpbxCPH.ResumeLayout(false);
            this.grpbxCPH.PerformLayout();
            this.grpbxKPH.ResumeLayout(false);
            this.grpbxKPH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpbxRPM;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.GroupBox grpbxCPH;
        private System.Windows.Forms.Label lblCPH;
        private System.Windows.Forms.GroupBox grpbxKPH;
        private System.Windows.Forms.Label lblKPH;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}

