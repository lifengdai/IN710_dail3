namespace PrograssIndicator
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
            this.grpbxChose = new System.Windows.Forms.GroupBox();
            this.rdobtnSpinBox = new System.Windows.Forms.RadioButton();
            this.rdobtnProgressBar = new System.Windows.Forms.RadioButton();
            this.rdobtnTrackBar = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.grpbxChose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpbxChose
            // 
            this.grpbxChose.Controls.Add(this.rdobtnTrackBar);
            this.grpbxChose.Controls.Add(this.rdobtnProgressBar);
            this.grpbxChose.Controls.Add(this.rdobtnSpinBox);
            this.grpbxChose.Location = new System.Drawing.Point(12, 101);
            this.grpbxChose.Name = "grpbxChose";
            this.grpbxChose.Size = new System.Drawing.Size(169, 112);
            this.grpbxChose.TabIndex = 1;
            this.grpbxChose.TabStop = false;
            this.grpbxChose.Text = "Feedback";
            // 
            // rdobtnSpinBox
            // 
            this.rdobtnSpinBox.AutoSize = true;
            this.rdobtnSpinBox.Location = new System.Drawing.Point(6, 27);
            this.rdobtnSpinBox.Name = "rdobtnSpinBox";
            this.rdobtnSpinBox.Size = new System.Drawing.Size(105, 22);
            this.rdobtnSpinBox.TabIndex = 0;
            this.rdobtnSpinBox.TabStop = true;
            this.rdobtnSpinBox.Text = "Spin Box";
            this.rdobtnSpinBox.UseVisualStyleBackColor = true;
            // 
            // rdobtnProgressBar
            // 
            this.rdobtnProgressBar.AutoSize = true;
            this.rdobtnProgressBar.Location = new System.Drawing.Point(6, 55);
            this.rdobtnProgressBar.Name = "rdobtnProgressBar";
            this.rdobtnProgressBar.Size = new System.Drawing.Size(141, 22);
            this.rdobtnProgressBar.TabIndex = 1;
            this.rdobtnProgressBar.TabStop = true;
            this.rdobtnProgressBar.Text = "Progress Bar";
            this.rdobtnProgressBar.UseVisualStyleBackColor = true;
            // 
            // rdobtnTrackBar
            // 
            this.rdobtnTrackBar.AutoSize = true;
            this.rdobtnTrackBar.Location = new System.Drawing.Point(6, 83);
            this.rdobtnTrackBar.Name = "rdobtnTrackBar";
            this.rdobtnTrackBar.Size = new System.Drawing.Size(114, 22);
            this.rdobtnTrackBar.TabIndex = 2;
            this.rdobtnTrackBar.TabStop = true;
            this.rdobtnTrackBar.Text = "Track Bar";
            this.rdobtnTrackBar.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(187, 85);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(569, 49);
            this.progressBar.TabIndex = 2;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(187, 156);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(569, 69);
            this.trackBar.TabIndex = 3;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(187, 42);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 233);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grpbxChose);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxChose.ResumeLayout(false);
            this.grpbxChose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpbxChose;
        private System.Windows.Forms.RadioButton rdobtnTrackBar;
        private System.Windows.Forms.RadioButton rdobtnProgressBar;
        private System.Windows.Forms.RadioButton rdobtnSpinBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

