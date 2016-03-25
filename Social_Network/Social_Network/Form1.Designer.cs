namespace Social_Network
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
            this.tabconPeople = new System.Windows.Forms.TabControl();
            this.tabpMe = new System.Windows.Forms.TabPage();
            this.tabpFriend1 = new System.Windows.Forms.TabPage();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tabpFriend2 = new System.Windows.Forms.TabPage();
            this.tabpFriend3 = new System.Windows.Forms.TabPage();
            this.tabpFriend4 = new System.Windows.Forms.TabPage();
            this.lstbxMe = new System.Windows.Forms.ListBox();
            this.lstbxFriend1 = new System.Windows.Forms.ListBox();
            this.lstbxFriend2 = new System.Windows.Forms.ListBox();
            this.lstbxFriend3 = new System.Windows.Forms.ListBox();
            this.lstbxFriend4 = new System.Windows.Forms.ListBox();
            this.tabconPeople.SuspendLayout();
            this.tabpMe.SuspendLayout();
            this.tabpFriend1.SuspendLayout();
            this.tabpFriend2.SuspendLayout();
            this.tabpFriend3.SuspendLayout();
            this.tabpFriend4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabconPeople
            // 
            this.tabconPeople.Controls.Add(this.tabpMe);
            this.tabconPeople.Controls.Add(this.tabpFriend1);
            this.tabconPeople.Controls.Add(this.tabpFriend2);
            this.tabconPeople.Controls.Add(this.tabpFriend3);
            this.tabconPeople.Controls.Add(this.tabpFriend4);
            this.tabconPeople.Location = new System.Drawing.Point(12, 12);
            this.tabconPeople.Name = "tabconPeople";
            this.tabconPeople.SelectedIndex = 0;
            this.tabconPeople.Size = new System.Drawing.Size(623, 460);
            this.tabconPeople.TabIndex = 0;
            // 
            // tabpMe
            // 
            this.tabpMe.Controls.Add(this.lstbxMe);
            this.tabpMe.Location = new System.Drawing.Point(4, 28);
            this.tabpMe.Name = "tabpMe";
            this.tabpMe.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabpMe.Size = new System.Drawing.Size(615, 428);
            this.tabpMe.TabIndex = 0;
            this.tabpMe.Text = "  Me";
            this.tabpMe.UseVisualStyleBackColor = true;
            // 
            // tabpFriend1
            // 
            this.tabpFriend1.Controls.Add(this.lstbxFriend1);
            this.tabpFriend1.Location = new System.Drawing.Point(4, 28);
            this.tabpFriend1.Name = "tabpFriend1";
            this.tabpFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpFriend1.Size = new System.Drawing.Size(615, 428);
            this.tabpFriend1.TabIndex = 1;
            this.tabpFriend1.Text = "Friend1";
            this.tabpFriend1.UseVisualStyleBackColor = true;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(12, 500);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(133, 42);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push Status";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(151, 509);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(480, 28);
            this.txtStatus.TabIndex = 2;
            // 
            // tabpFriend2
            // 
            this.tabpFriend2.Controls.Add(this.lstbxFriend2);
            this.tabpFriend2.Location = new System.Drawing.Point(4, 28);
            this.tabpFriend2.Name = "tabpFriend2";
            this.tabpFriend2.Size = new System.Drawing.Size(615, 428);
            this.tabpFriend2.TabIndex = 2;
            this.tabpFriend2.Text = "Friend2";
            this.tabpFriend2.UseVisualStyleBackColor = true;
            // 
            // tabpFriend3
            // 
            this.tabpFriend3.Controls.Add(this.lstbxFriend3);
            this.tabpFriend3.Location = new System.Drawing.Point(4, 28);
            this.tabpFriend3.Name = "tabpFriend3";
            this.tabpFriend3.Size = new System.Drawing.Size(615, 428);
            this.tabpFriend3.TabIndex = 3;
            this.tabpFriend3.Text = "Friend3";
            this.tabpFriend3.UseVisualStyleBackColor = true;
            // 
            // tabpFriend4
            // 
            this.tabpFriend4.Controls.Add(this.lstbxFriend4);
            this.tabpFriend4.Location = new System.Drawing.Point(4, 28);
            this.tabpFriend4.Name = "tabpFriend4";
            this.tabpFriend4.Size = new System.Drawing.Size(615, 428);
            this.tabpFriend4.TabIndex = 4;
            this.tabpFriend4.Text = "Friend4";
            this.tabpFriend4.UseVisualStyleBackColor = true;
            // 
            // lstbxMe
            // 
            this.lstbxMe.FormattingEnabled = true;
            this.lstbxMe.ItemHeight = 18;
            this.lstbxMe.Location = new System.Drawing.Point(3, 3);
            this.lstbxMe.Name = "lstbxMe";
            this.lstbxMe.Size = new System.Drawing.Size(609, 436);
            this.lstbxMe.TabIndex = 0;
            // 
            // lstbxFriend1
            // 
            this.lstbxFriend1.FormattingEnabled = true;
            this.lstbxFriend1.ItemHeight = 18;
            this.lstbxFriend1.Location = new System.Drawing.Point(3, 3);
            this.lstbxFriend1.Name = "lstbxFriend1";
            this.lstbxFriend1.Size = new System.Drawing.Size(609, 418);
            this.lstbxFriend1.TabIndex = 0;
            // 
            // lstbxFriend2
            // 
            this.lstbxFriend2.FormattingEnabled = true;
            this.lstbxFriend2.ItemHeight = 18;
            this.lstbxFriend2.Location = new System.Drawing.Point(3, 3);
            this.lstbxFriend2.Name = "lstbxFriend2";
            this.lstbxFriend2.Size = new System.Drawing.Size(609, 418);
            this.lstbxFriend2.TabIndex = 0;
            // 
            // lstbxFriend3
            // 
            this.lstbxFriend3.FormattingEnabled = true;
            this.lstbxFriend3.ItemHeight = 18;
            this.lstbxFriend3.Location = new System.Drawing.Point(3, 3);
            this.lstbxFriend3.Name = "lstbxFriend3";
            this.lstbxFriend3.Size = new System.Drawing.Size(609, 418);
            this.lstbxFriend3.TabIndex = 0;
            // 
            // lstbxFriend4
            // 
            this.lstbxFriend4.FormattingEnabled = true;
            this.lstbxFriend4.ItemHeight = 18;
            this.lstbxFriend4.Location = new System.Drawing.Point(3, 3);
            this.lstbxFriend4.Name = "lstbxFriend4";
            this.lstbxFriend4.Size = new System.Drawing.Size(609, 418);
            this.lstbxFriend4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 554);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.tabconPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabconPeople.ResumeLayout(false);
            this.tabpMe.ResumeLayout(false);
            this.tabpFriend1.ResumeLayout(false);
            this.tabpFriend2.ResumeLayout(false);
            this.tabpFriend3.ResumeLayout(false);
            this.tabpFriend4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabconPeople;
        private System.Windows.Forms.TabPage tabpMe;
        private System.Windows.Forms.TabPage tabpFriend1;
        private System.Windows.Forms.TabPage tabpFriend2;
        private System.Windows.Forms.TabPage tabpFriend3;
        private System.Windows.Forms.TabPage tabpFriend4;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ListBox lstbxMe;
        private System.Windows.Forms.ListBox lstbxFriend1;
        private System.Windows.Forms.ListBox lstbxFriend2;
        private System.Windows.Forms.ListBox lstbxFriend3;
        private System.Windows.Forms.ListBox lstbxFriend4;
    }
}

