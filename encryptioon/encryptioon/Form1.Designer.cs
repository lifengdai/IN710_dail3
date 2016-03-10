namespace encryptioon
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
            this.gbEncAlg = new System.Windows.Forms.GroupBox();
            this.rbStrReverse = new System.Windows.Forms.RadioButton();
            this.rbROT13 = new System.Windows.Forms.RadioButton();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOuptput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gbEncAlg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncAlg
            // 
            this.gbEncAlg.Controls.Add(this.rbStrReverse);
            this.gbEncAlg.Controls.Add(this.rbROT13);
            this.gbEncAlg.Location = new System.Drawing.Point(51, 33);
            this.gbEncAlg.Name = "gbEncAlg";
            this.gbEncAlg.Size = new System.Drawing.Size(220, 117);
            this.gbEncAlg.TabIndex = 0;
            this.gbEncAlg.TabStop = false;
            this.gbEncAlg.Text = "Encryption Algorithm";
            // 
            // rbStrReverse
            // 
            this.rbStrReverse.AutoSize = true;
            this.rbStrReverse.Location = new System.Drawing.Point(6, 72);
            this.rbStrReverse.Name = "rbStrReverse";
            this.rbStrReverse.Size = new System.Drawing.Size(159, 22);
            this.rbStrReverse.TabIndex = 1;
            this.rbStrReverse.TabStop = true;
            this.rbStrReverse.Text = "String reverse";
            this.rbStrReverse.UseVisualStyleBackColor = true;
            // 
            // rbROT13
            // 
            this.rbROT13.AutoSize = true;
            this.rbROT13.Checked = true;
            this.rbROT13.Location = new System.Drawing.Point(6, 44);
            this.rbROT13.Name = "rbROT13";
            this.rbROT13.Size = new System.Drawing.Size(78, 22);
            this.rbROT13.TabIndex = 0;
            this.rbROT13.TabStop = true;
            this.rbROT13.Text = "ROT13";
            this.rbROT13.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(305, 70);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 51);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(496, 69);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(131, 52);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(48, 283);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(53, 18);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Input";
            // 
            // lblOuptput
            // 
            this.lblOuptput.AutoSize = true;
            this.lblOuptput.Location = new System.Drawing.Point(48, 337);
            this.lblOuptput.Name = "lblOuptput";
            this.lblOuptput.Size = new System.Drawing.Size(62, 18);
            this.lblOuptput.TabIndex = 4;
            this.lblOuptput.Text = "Output";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(116, 280);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(243, 28);
            this.txtInput.TabIndex = 5;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(116, 334);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(243, 28);
            this.txtOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 618);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOuptput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.gbEncAlg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbEncAlg.ResumeLayout(false);
            this.gbEncAlg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncAlg;
        private System.Windows.Forms.RadioButton rbStrReverse;
        private System.Windows.Forms.RadioButton rbROT13;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOuptput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

