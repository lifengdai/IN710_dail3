namespace BuildSql
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
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDropConstraint = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(12, 12);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(166, 48);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build Sql";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDropConstraint
            // 
            this.btnDropConstraint.Location = new System.Drawing.Point(184, 12);
            this.btnDropConstraint.Name = "btnDropConstraint";
            this.btnDropConstraint.Size = new System.Drawing.Size(166, 48);
            this.btnDropConstraint.TabIndex = 2;
            this.btnDropConstraint.Text = "Drop Constraint";
            this.btnDropConstraint.UseVisualStyleBackColor = true;
            this.btnDropConstraint.Click += new System.EventHandler(this.btnDropConstraint_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(184, 67);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(165, 47);
            this.btnopen.TabIndex = 3;
            this.btnopen.Text = "Open Connection";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 125);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnDropConstraint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBuild);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDropConstraint;
        private System.Windows.Forms.Button btnopen;
    }
}

