namespace Predicate
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSelectEven = new System.Windows.Forms.Button();
            this.btnSelectLessTen = new System.Windows.Forms.Button();
            this.lstbxRandomNumber = new System.Windows.Forms.ListBox();
            this.lstbxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(189, 50);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Random Number";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSelectEven
            // 
            this.btnSelectEven.Location = new System.Drawing.Point(238, 12);
            this.btnSelectEven.Name = "btnSelectEven";
            this.btnSelectEven.Size = new System.Drawing.Size(189, 50);
            this.btnSelectEven.TabIndex = 1;
            this.btnSelectEven.Text = "Select Even Number";
            this.btnSelectEven.UseVisualStyleBackColor = true;
            this.btnSelectEven.Click += new System.EventHandler(this.btnSelectEven_Click);
            // 
            // btnSelectLessTen
            // 
            this.btnSelectLessTen.Location = new System.Drawing.Point(238, 68);
            this.btnSelectLessTen.Name = "btnSelectLessTen";
            this.btnSelectLessTen.Size = new System.Drawing.Size(189, 50);
            this.btnSelectLessTen.TabIndex = 2;
            this.btnSelectLessTen.Text = "Select Less Then Ten";
            this.btnSelectLessTen.UseVisualStyleBackColor = true;
            this.btnSelectLessTen.Click += new System.EventHandler(this.btnSelectLessTen_Click);
            // 
            // lstbxRandomNumber
            // 
            this.lstbxRandomNumber.FormattingEnabled = true;
            this.lstbxRandomNumber.ItemHeight = 18;
            this.lstbxRandomNumber.Location = new System.Drawing.Point(12, 173);
            this.lstbxRandomNumber.Name = "lstbxRandomNumber";
            this.lstbxRandomNumber.Size = new System.Drawing.Size(189, 742);
            this.lstbxRandomNumber.TabIndex = 3;
            // 
            // lstbxResult
            // 
            this.lstbxResult.FormattingEnabled = true;
            this.lstbxResult.ItemHeight = 18;
            this.lstbxResult.Location = new System.Drawing.Point(238, 173);
            this.lstbxResult.Name = "lstbxResult";
            this.lstbxResult.Size = new System.Drawing.Size(189, 742);
            this.lstbxResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 921);
            this.Controls.Add(this.lstbxResult);
            this.Controls.Add(this.lstbxRandomNumber);
            this.Controls.Add(this.btnSelectLessTen);
            this.Controls.Add(this.btnSelectEven);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectEven;
        private System.Windows.Forms.Button btnSelectLessTen;
        private System.Windows.Forms.ListBox lstbxRandomNumber;
        private System.Windows.Forms.ListBox lstbxResult;
    }
}

