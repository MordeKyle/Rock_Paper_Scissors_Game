namespace Rock_Paper_Scissors_Game
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
            this.inputGroubBox = new System.Windows.Forms.GroupBox();
            this.rockRad = new System.Windows.Forms.RadioButton();
            this.paperRad = new System.Windows.Forms.RadioButton();
            this.scissorsRad = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.inputGroubBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroubBox
            // 
            this.inputGroubBox.Controls.Add(this.rockRad);
            this.inputGroubBox.Controls.Add(this.paperRad);
            this.inputGroubBox.Controls.Add(this.scissorsRad);
            this.inputGroubBox.Location = new System.Drawing.Point(5, 5);
            this.inputGroubBox.Name = "inputGroubBox";
            this.inputGroubBox.Size = new System.Drawing.Size(148, 100);
            this.inputGroubBox.TabIndex = 0;
            this.inputGroubBox.TabStop = false;
            this.inputGroubBox.Text = "Rock, Paper, or Scissors?";
            // 
            // rockRad
            // 
            this.rockRad.AutoSize = true;
            this.rockRad.Location = new System.Drawing.Point(6, 31);
            this.rockRad.Name = "rockRad";
            this.rockRad.Size = new System.Drawing.Size(51, 17);
            this.rockRad.TabIndex = 1;
            this.rockRad.Text = "Rock";
            this.rockRad.UseVisualStyleBackColor = true;
            // 
            // paperRad
            // 
            this.paperRad.AutoSize = true;
            this.paperRad.Location = new System.Drawing.Point(6, 54);
            this.paperRad.Name = "paperRad";
            this.paperRad.Size = new System.Drawing.Size(53, 17);
            this.paperRad.TabIndex = 2;
            this.paperRad.Text = "Paper";
            this.paperRad.UseVisualStyleBackColor = true;
            // 
            // scissorsRad
            // 
            this.scissorsRad.AutoSize = true;
            this.scissorsRad.Location = new System.Drawing.Point(6, 77);
            this.scissorsRad.Name = "scissorsRad";
            this.scissorsRad.Size = new System.Drawing.Size(64, 17);
            this.scissorsRad.TabIndex = 3;
            this.scissorsRad.Text = "Scissors";
            this.scissorsRad.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(179, 128);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "The Computer\'s Choice:";
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceLabel.Location = new System.Drawing.Point(322, 33);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(100, 23);
            this.computerChoiceLabel.TabIndex = 6;
            this.computerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results:";
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(322, 77);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 23);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 163);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.inputGroubBox);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.inputGroubBox.ResumeLayout(false);
            this.inputGroubBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroubBox;
        private System.Windows.Forms.RadioButton rockRad;
        private System.Windows.Forms.RadioButton paperRad;
        private System.Windows.Forms.RadioButton scissorsRad;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
    }
}

