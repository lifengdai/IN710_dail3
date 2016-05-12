namespace ADOSql
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
            this.btnListPapers = new System.Windows.Forms.Button();
            this.btnListDue = new System.Windows.Forms.Button();
            this.btnListAverageMark = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListPapers
            // 
            this.btnListPapers.Location = new System.Drawing.Point(12, 12);
            this.btnListPapers.Name = "btnListPapers";
            this.btnListPapers.Size = new System.Drawing.Size(180, 52);
            this.btnListPapers.TabIndex = 0;
            this.btnListPapers.Text = "List papers";
            this.btnListPapers.UseVisualStyleBackColor = true;
            this.btnListPapers.Click += new System.EventHandler(this.btnListPapers_Click);
            // 
            // btnListDue
            // 
            this.btnListDue.Location = new System.Drawing.Point(12, 70);
            this.btnListDue.Name = "btnListDue";
            this.btnListDue.Size = new System.Drawing.Size(180, 52);
            this.btnListDue.TabIndex = 1;
            this.btnListDue.Text = "Assignment due next two week";
            this.btnListDue.UseVisualStyleBackColor = true;
            this.btnListDue.Click += new System.EventHandler(this.btnListDue_Click);
            // 
            // btnListAverageMark
            // 
            this.btnListAverageMark.Location = new System.Drawing.Point(12, 128);
            this.btnListAverageMark.Name = "btnListAverageMark";
            this.btnListAverageMark.Size = new System.Drawing.Size(180, 52);
            this.btnListAverageMark.TabIndex = 2;
            this.btnListAverageMark.Text = "List average mark";
            this.btnListAverageMark.UseVisualStyleBackColor = true;
            this.btnListAverageMark.Click += new System.EventHandler(this.btnListAverageMark_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(12, 186);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(749, 454);
            this.listBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 645);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnListAverageMark);
            this.Controls.Add(this.btnListDue);
            this.Controls.Add(this.btnListPapers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListPapers;
        private System.Windows.Forms.Button btnListDue;
        private System.Windows.Forms.Button btnListAverageMark;
        private System.Windows.Forms.ListBox listBox;
    }
}

