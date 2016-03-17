namespace biont_world
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
            this.lstbxdisplaybox = new System.Windows.Forms.ListBox();
            this.btnAsia = new System.Windows.Forms.Button();
            this.btnNewZealand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxdisplaybox
            // 
            this.lstbxdisplaybox.FormattingEnabled = true;
            this.lstbxdisplaybox.ItemHeight = 18;
            this.lstbxdisplaybox.Location = new System.Drawing.Point(279, 12);
            this.lstbxdisplaybox.Name = "lstbxdisplaybox";
            this.lstbxdisplaybox.Size = new System.Drawing.Size(651, 904);
            this.lstbxdisplaybox.TabIndex = 0;
            // 
            // btnAsia
            // 
            this.btnAsia.Location = new System.Drawing.Point(783, 933);
            this.btnAsia.Name = "btnAsia";
            this.btnAsia.Size = new System.Drawing.Size(147, 49);
            this.btnAsia.TabIndex = 1;
            this.btnAsia.Text = "Asia";
            this.btnAsia.UseVisualStyleBackColor = true;
            this.btnAsia.Click += new System.EventHandler(this.btnAsia_Click);
            // 
            // btnNewZealand
            // 
            this.btnNewZealand.Location = new System.Drawing.Point(279, 933);
            this.btnNewZealand.Name = "btnNewZealand";
            this.btnNewZealand.Size = new System.Drawing.Size(147, 49);
            this.btnNewZealand.TabIndex = 2;
            this.btnNewZealand.Text = "New Zealand";
            this.btnNewZealand.UseVisualStyleBackColor = true;
            this.btnNewZealand.Click += new System.EventHandler(this.btnNewZealand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 994);
            this.Controls.Add(this.btnNewZealand);
            this.Controls.Add(this.btnAsia);
            this.Controls.Add(this.lstbxdisplaybox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxdisplaybox;
        private System.Windows.Forms.Button btnAsia;
        private System.Windows.Forms.Button btnNewZealand;
    }
}

