namespace QuizNight
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.grpbxTeamType = new System.Windows.Forms.GroupBox();
            this.rdobtnAdult = new System.Windows.Forms.RadioButton();
            this.rdobtnChild = new System.Windows.Forms.RadioButton();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblIncorrectAnswer = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtIncorrectAnswer = new System.Windows.Forms.TextBox();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.grpbxTeamType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(12, 107);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(168, 49);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute Score";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // grpbxTeamType
            // 
            this.grpbxTeamType.Controls.Add(this.rdobtnChild);
            this.grpbxTeamType.Controls.Add(this.rdobtnAdult);
            this.grpbxTeamType.Location = new System.Drawing.Point(12, 12);
            this.grpbxTeamType.Name = "grpbxTeamType";
            this.grpbxTeamType.Size = new System.Drawing.Size(168, 89);
            this.grpbxTeamType.TabIndex = 1;
            this.grpbxTeamType.TabStop = false;
            this.grpbxTeamType.Text = "Team Type";
            // 
            // rdobtnAdult
            // 
            this.rdobtnAdult.AutoSize = true;
            this.rdobtnAdult.Checked = true;
            this.rdobtnAdult.Location = new System.Drawing.Point(6, 27);
            this.rdobtnAdult.Name = "rdobtnAdult";
            this.rdobtnAdult.Size = new System.Drawing.Size(78, 22);
            this.rdobtnAdult.TabIndex = 0;
            this.rdobtnAdult.TabStop = true;
            this.rdobtnAdult.Text = "Adult";
            this.rdobtnAdult.UseVisualStyleBackColor = true;
            // 
            // rdobtnChild
            // 
            this.rdobtnChild.AutoSize = true;
            this.rdobtnChild.Location = new System.Drawing.Point(6, 55);
            this.rdobtnChild.Name = "rdobtnChild";
            this.rdobtnChild.Size = new System.Drawing.Size(78, 22);
            this.rdobtnChild.TabIndex = 1;
            this.rdobtnChild.TabStop = true;
            this.rdobtnChild.Text = "Child";
            this.rdobtnChild.UseVisualStyleBackColor = true;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(210, 12);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(223, 30);
            this.lblCorrectAnswer.TabIndex = 2;
            this.lblCorrectAnswer.Text = "Correct Answer";
            // 
            // lblIncorrectAnswer
            // 
            this.lblIncorrectAnswer.AutoSize = true;
            this.lblIncorrectAnswer.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIncorrectAnswer.Location = new System.Drawing.Point(210, 71);
            this.lblIncorrectAnswer.Name = "lblIncorrectAnswer";
            this.lblIncorrectAnswer.Size = new System.Drawing.Size(253, 30);
            this.lblIncorrectAnswer.TabIndex = 3;
            this.lblIncorrectAnswer.Text = "Incorrect Answer";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(498, 14);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(264, 28);
            this.txtCorrectAnswer.TabIndex = 4;
            this.txtCorrectAnswer.Text = "5";
            // 
            // txtIncorrectAnswer
            // 
            this.txtIncorrectAnswer.Location = new System.Drawing.Point(498, 73);
            this.txtIncorrectAnswer.Name = "txtIncorrectAnswer";
            this.txtIncorrectAnswer.Size = new System.Drawing.Size(264, 28);
            this.txtIncorrectAnswer.TabIndex = 5;
            this.txtIncorrectAnswer.Text = "2";
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblScoreText.Location = new System.Drawing.Point(210, 126);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(70, 24);
            this.lblScoreText.TabIndex = 6;
            this.lblScoreText.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblScore.Location = new System.Drawing.Point(286, 126);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(22, 24);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 174);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.txtIncorrectAnswer);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.lblIncorrectAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.grpbxTeamType);
            this.Controls.Add(this.btnCompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbxTeamType.ResumeLayout(false);
            this.grpbxTeamType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.GroupBox grpbxTeamType;
        private System.Windows.Forms.RadioButton rdobtnChild;
        private System.Windows.Forms.RadioButton rdobtnAdult;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblIncorrectAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtIncorrectAnswer;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblScore;
    }
}

