namespace MinAndMatchCSharp
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
            this.picbxHead = new System.Windows.Forms.PictureBox();
            this.picbxBody = new System.Windows.Forms.PictureBox();
            this.picbxLegs = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.cmbxHead = new System.Windows.Forms.ComboBox();
            this.cmbxBody = new System.Windows.Forms.ComboBox();
            this.cmbxLegs = new System.Windows.Forms.ComboBox();
            this.btnMake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxHead
            // 
            this.picbxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbxHead.Location = new System.Drawing.Point(12, 12);
            this.picbxHead.Name = "picbxHead";
            this.picbxHead.Size = new System.Drawing.Size(360, 360);
            this.picbxHead.TabIndex = 0;
            this.picbxHead.TabStop = false;
            // 
            // picbxBody
            // 
            this.picbxBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbxBody.Location = new System.Drawing.Point(12, 378);
            this.picbxBody.Name = "picbxBody";
            this.picbxBody.Size = new System.Drawing.Size(360, 360);
            this.picbxBody.TabIndex = 1;
            this.picbxBody.TabStop = false;
            // 
            // picbxLegs
            // 
            this.picbxLegs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbxLegs.Location = new System.Drawing.Point(12, 744);
            this.picbxLegs.Name = "picbxLegs";
            this.picbxLegs.Size = new System.Drawing.Size(360, 360);
            this.picbxLegs.TabIndex = 2;
            this.picbxLegs.TabStop = false;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("SimSun", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(378, 147);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(127, 52);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "Head";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("SimSun", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBody.Location = new System.Drawing.Point(378, 534);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(127, 52);
            this.lblBody.TabIndex = 4;
            this.lblBody.Text = "Body";
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Font = new System.Drawing.Font("SimSun", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLegs.Location = new System.Drawing.Point(378, 907);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(127, 52);
            this.lblLegs.TabIndex = 5;
            this.lblLegs.Text = "Legs";
            // 
            // cmbxHead
            // 
            this.cmbxHead.FormattingEnabled = true;
            this.cmbxHead.Location = new System.Drawing.Point(549, 164);
            this.cmbxHead.Name = "cmbxHead";
            this.cmbxHead.Size = new System.Drawing.Size(352, 26);
            this.cmbxHead.TabIndex = 6;
            // 
            // cmbxBody
            // 
            this.cmbxBody.FormattingEnabled = true;
            this.cmbxBody.Location = new System.Drawing.Point(549, 560);
            this.cmbxBody.Name = "cmbxBody";
            this.cmbxBody.Size = new System.Drawing.Size(352, 26);
            this.cmbxBody.TabIndex = 7;
            // 
            // cmbxLegs
            // 
            this.cmbxLegs.FormattingEnabled = true;
            this.cmbxLegs.Location = new System.Drawing.Point(549, 934);
            this.cmbxLegs.Name = "cmbxLegs";
            this.cmbxLegs.Size = new System.Drawing.Size(352, 26);
            this.cmbxLegs.TabIndex = 8;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(692, 1043);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(209, 60);
            this.btnMake.TabIndex = 9;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 1115);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.cmbxLegs);
            this.Controls.Add(this.cmbxBody);
            this.Controls.Add(this.cmbxHead);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.picbxLegs);
            this.Controls.Add(this.picbxBody);
            this.Controls.Add(this.picbxHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLegs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxHead;
        private System.Windows.Forms.PictureBox picbxBody;
        private System.Windows.Forms.PictureBox picbxLegs;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.ComboBox cmbxHead;
        private System.Windows.Forms.ComboBox cmbxBody;
        private System.Windows.Forms.ComboBox cmbxLegs;
        private System.Windows.Forms.Button btnMake;
    }
}

