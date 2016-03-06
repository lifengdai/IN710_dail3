namespace Stack
{
    partial class StackForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbShowAdded = new System.Windows.Forms.TextBox();
            this.btnPeek = new System.Windows.Forms.Button();
            this.tbShowLastValue = new System.Windows.Forms.TextBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.tbShowLastValueRemove = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnIsEmpty = new System.Windows.Forms.Button();
            this.tbIsEmpty = new System.Windows.Forms.TextBox();
            this.btnTestIEmu = new System.Windows.Forms.Button();
            this.lbTestIEmu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbShowAdded
            // 
            this.tbShowAdded.Location = new System.Drawing.Point(244, 50);
            this.tbShowAdded.Name = "tbShowAdded";
            this.tbShowAdded.ReadOnly = true;
            this.tbShowAdded.Size = new System.Drawing.Size(405, 28);
            this.tbShowAdded.TabIndex = 1;
            this.tbShowAdded.Text = "Show the thing that added when you click Add";
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(71, 147);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(123, 44);
            this.btnPeek.TabIndex = 2;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // tbShowLastValue
            // 
            this.tbShowLastValue.Location = new System.Drawing.Point(244, 157);
            this.tbShowLastValue.Name = "tbShowLastValue";
            this.tbShowLastValue.ReadOnly = true;
            this.tbShowLastValue.Size = new System.Drawing.Size(405, 28);
            this.tbShowLastValue.TabIndex = 3;
            this.tbShowLastValue.Text = "Show last value when click Peek";
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(71, 267);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(123, 44);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // tbShowLastValueRemove
            // 
            this.tbShowLastValueRemove.Location = new System.Drawing.Point(244, 277);
            this.tbShowLastValueRemove.Name = "tbShowLastValueRemove";
            this.tbShowLastValueRemove.ReadOnly = true;
            this.tbShowLastValueRemove.Size = new System.Drawing.Size(405, 28);
            this.tbShowLastValueRemove.TabIndex = 5;
            this.tbShowLastValueRemove.Text = "Show last value and delete it when click Pop";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(71, 394);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(123, 44);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(244, 404);
            this.tbCount.Name = "tbCount";
            this.tbCount.ReadOnly = true;
            this.tbCount.Size = new System.Drawing.Size(405, 28);
            this.tbCount.TabIndex = 7;
            this.tbCount.Text = "Show how mant element in it when click Count";
            // 
            // btnIsEmpty
            // 
            this.btnIsEmpty.Location = new System.Drawing.Point(71, 522);
            this.btnIsEmpty.Name = "btnIsEmpty";
            this.btnIsEmpty.Size = new System.Drawing.Size(123, 44);
            this.btnIsEmpty.TabIndex = 8;
            this.btnIsEmpty.Text = "IsEmpty";
            this.btnIsEmpty.UseVisualStyleBackColor = true;
            this.btnIsEmpty.Click += new System.EventHandler(this.btnIsEmpty_Click);
            // 
            // tbIsEmpty
            // 
            this.tbIsEmpty.Location = new System.Drawing.Point(244, 532);
            this.tbIsEmpty.Name = "tbIsEmpty";
            this.tbIsEmpty.ReadOnly = true;
            this.tbIsEmpty.Size = new System.Drawing.Size(405, 28);
            this.tbIsEmpty.TabIndex = 9;
            this.tbIsEmpty.Text = "Show is empty or not";
            // 
            // btnTestIEmu
            // 
            this.btnTestIEmu.Location = new System.Drawing.Point(71, 647);
            this.btnTestIEmu.Name = "btnTestIEmu";
            this.btnTestIEmu.Size = new System.Drawing.Size(123, 44);
            this.btnTestIEmu.TabIndex = 10;
            this.btnTestIEmu.Text = "Test IEmu";
            this.btnTestIEmu.UseVisualStyleBackColor = true;
            this.btnTestIEmu.Click += new System.EventHandler(this.btnTestIEmu_Click);
            // 
            // lbTestIEmu
            // 
            this.lbTestIEmu.FormattingEnabled = true;
            this.lbTestIEmu.ItemHeight = 18;
            this.lbTestIEmu.Location = new System.Drawing.Point(244, 627);
            this.lbTestIEmu.Name = "lbTestIEmu";
            this.lbTestIEmu.Size = new System.Drawing.Size(405, 94);
            this.lbTestIEmu.TabIndex = 11;
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 747);
            this.Controls.Add(this.lbTestIEmu);
            this.Controls.Add(this.btnTestIEmu);
            this.Controls.Add(this.tbIsEmpty);
            this.Controls.Add(this.btnIsEmpty);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.tbShowLastValueRemove);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.tbShowLastValue);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.tbShowAdded);
            this.Controls.Add(this.btnAdd);
            this.Name = "StackForm";
            this.Text = "Stack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbShowAdded;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.TextBox tbShowLastValue;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox tbShowLastValueRemove;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnIsEmpty;
        private System.Windows.Forms.TextBox tbIsEmpty;
        private System.Windows.Forms.Button btnTestIEmu;
        private System.Windows.Forms.ListBox lbTestIEmu;
    }
}

