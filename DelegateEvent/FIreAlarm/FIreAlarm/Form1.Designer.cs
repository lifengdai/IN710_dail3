namespace FireAlarm
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
            this.btnAlarm = new System.Windows.Forms.Button();
            this.grpbxFires = new System.Windows.Forms.GroupBox();
            this.rdobtnMinor = new System.Windows.Forms.RadioButton();
            this.rdobtnSerious = new System.Windows.Forms.RadioButton();
            this.rdobtnInferno = new System.Windows.Forms.RadioButton();
            this.grpbxFires.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(12, 12);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(175, 43);
            this.btnAlarm.TabIndex = 0;
            this.btnAlarm.Text = "Fire Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // grpbxFires
            // 
            this.grpbxFires.Controls.Add(this.rdobtnInferno);
            this.grpbxFires.Controls.Add(this.rdobtnSerious);
            this.grpbxFires.Controls.Add(this.rdobtnMinor);
            this.grpbxFires.Location = new System.Drawing.Point(12, 61);
            this.grpbxFires.Name = "grpbxFires";
            this.grpbxFires.Size = new System.Drawing.Size(175, 117);
            this.grpbxFires.TabIndex = 1;
            this.grpbxFires.TabStop = false;
            this.grpbxFires.Text = "Fire";
            // 
            // rdobtnMinor
            // 
            this.rdobtnMinor.AutoSize = true;
            this.rdobtnMinor.Checked = true;
            this.rdobtnMinor.Location = new System.Drawing.Point(6, 27);
            this.rdobtnMinor.Name = "rdobtnMinor";
            this.rdobtnMinor.Size = new System.Drawing.Size(78, 22);
            this.rdobtnMinor.TabIndex = 0;
            this.rdobtnMinor.TabStop = true;
            this.rdobtnMinor.Text = "Minor";
            this.rdobtnMinor.UseVisualStyleBackColor = true;
            // 
            // rdobtnSerious
            // 
            this.rdobtnSerious.AutoSize = true;
            this.rdobtnSerious.Location = new System.Drawing.Point(6, 55);
            this.rdobtnSerious.Name = "rdobtnSerious";
            this.rdobtnSerious.Size = new System.Drawing.Size(96, 22);
            this.rdobtnSerious.TabIndex = 1;
            this.rdobtnSerious.Text = "Serious";
            this.rdobtnSerious.UseVisualStyleBackColor = true;
            // 
            // rdobtnInferno
            // 
            this.rdobtnInferno.AutoSize = true;
            this.rdobtnInferno.Location = new System.Drawing.Point(6, 83);
            this.rdobtnInferno.Name = "rdobtnInferno";
            this.rdobtnInferno.Size = new System.Drawing.Size(96, 22);
            this.rdobtnInferno.TabIndex = 2;
            this.rdobtnInferno.Text = "Inferno";
            this.rdobtnInferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 195);
            this.Controls.Add(this.grpbxFires);
            this.Controls.Add(this.btnAlarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxFires.ResumeLayout(false);
            this.grpbxFires.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.GroupBox grpbxFires;
        private System.Windows.Forms.RadioButton rdobtnInferno;
        private System.Windows.Forms.RadioButton rdobtnSerious;
        private System.Windows.Forms.RadioButton rdobtnMinor;
    }
}

