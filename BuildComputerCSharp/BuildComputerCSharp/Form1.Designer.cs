namespace BuildComputerCSharp
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpbxMachineType = new System.Windows.Forms.GroupBox();
            this.rdobtnMultimedia = new System.Windows.Forms.RadioButton();
            this.rdobtnBusiness = new System.Windows.Forms.RadioButton();
            this.rdobtnGame = new System.Windows.Forms.RadioButton();
            this.lstbxShow = new System.Windows.Forms.ListBox();
            this.grpbxMachineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(34, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Spec";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpbxMachineType
            // 
            this.grpbxMachineType.Controls.Add(this.rdobtnMultimedia);
            this.grpbxMachineType.Controls.Add(this.rdobtnBusiness);
            this.grpbxMachineType.Controls.Add(this.rdobtnGame);
            this.grpbxMachineType.Location = new System.Drawing.Point(34, 110);
            this.grpbxMachineType.Name = "grpbxMachineType";
            this.grpbxMachineType.Size = new System.Drawing.Size(163, 121);
            this.grpbxMachineType.TabIndex = 1;
            this.grpbxMachineType.TabStop = false;
            this.grpbxMachineType.Text = "Machine Type";
            // 
            // rdobtnMultimedia
            // 
            this.rdobtnMultimedia.AutoSize = true;
            this.rdobtnMultimedia.Location = new System.Drawing.Point(6, 83);
            this.rdobtnMultimedia.Name = "rdobtnMultimedia";
            this.rdobtnMultimedia.Size = new System.Drawing.Size(123, 22);
            this.rdobtnMultimedia.TabIndex = 2;
            this.rdobtnMultimedia.TabStop = true;
            this.rdobtnMultimedia.Text = "Multimedia";
            this.rdobtnMultimedia.UseVisualStyleBackColor = true;
            // 
            // rdobtnBusiness
            // 
            this.rdobtnBusiness.AutoSize = true;
            this.rdobtnBusiness.Location = new System.Drawing.Point(6, 55);
            this.rdobtnBusiness.Name = "rdobtnBusiness";
            this.rdobtnBusiness.Size = new System.Drawing.Size(105, 22);
            this.rdobtnBusiness.TabIndex = 1;
            this.rdobtnBusiness.TabStop = true;
            this.rdobtnBusiness.Text = "Business";
            this.rdobtnBusiness.UseVisualStyleBackColor = true;
            // 
            // rdobtnGame
            // 
            this.rdobtnGame.AutoSize = true;
            this.rdobtnGame.Location = new System.Drawing.Point(6, 27);
            this.rdobtnGame.Name = "rdobtnGame";
            this.rdobtnGame.Size = new System.Drawing.Size(69, 22);
            this.rdobtnGame.TabIndex = 0;
            this.rdobtnGame.TabStop = true;
            this.rdobtnGame.Text = "Game";
            this.rdobtnGame.UseVisualStyleBackColor = true;
            // 
            // lstbxShow
            // 
            this.lstbxShow.FormattingEnabled = true;
            this.lstbxShow.ItemHeight = 18;
            this.lstbxShow.Location = new System.Drawing.Point(203, 23);
            this.lstbxShow.Name = "lstbxShow";
            this.lstbxShow.Size = new System.Drawing.Size(538, 202);
            this.lstbxShow.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 247);
            this.Controls.Add(this.lstbxShow);
            this.Controls.Add(this.grpbxMachineType);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxMachineType.ResumeLayout(false);
            this.grpbxMachineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpbxMachineType;
        private System.Windows.Forms.RadioButton rdobtnMultimedia;
        private System.Windows.Forms.RadioButton rdobtnBusiness;
        private System.Windows.Forms.RadioButton rdobtnGame;
        private System.Windows.Forms.ListBox lstbxShow;
    }
}

