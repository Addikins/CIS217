namespace Rock_Paper_Scissors
{
    partial class RPS_Form
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
            this.enemyScissors = new System.Windows.Forms.Button();
            this.enemyPaper = new System.Windows.Forms.Button();
            this.enemyRock = new System.Windows.Forms.Button();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.button_Scissors = new System.Windows.Forms.Button();
            this.button_Paper = new System.Windows.Forms.Button();
            this.button_Rock = new System.Windows.Forms.Button();
            this.throwButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyScissors
            // 
            this.enemyScissors.BackColor = System.Drawing.SystemColors.Info;
            this.enemyScissors.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Scissors_Enemy1;
            this.enemyScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyScissors.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyScissors.Enabled = false;
            this.enemyScissors.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.enemyScissors.FlatAppearance.BorderSize = 0;
            this.enemyScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enemyScissors.Location = new System.Drawing.Point(551, 29);
            this.enemyScissors.Name = "enemyScissors";
            this.enemyScissors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enemyScissors.Size = new System.Drawing.Size(112, 212);
            this.enemyScissors.TabIndex = 7;
            this.enemyScissors.UseVisualStyleBackColor = false;
            this.enemyScissors.Visible = false;
            // 
            // enemyPaper
            // 
            this.enemyPaper.BackColor = System.Drawing.SystemColors.Info;
            this.enemyPaper.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Paper_Enemy1;
            this.enemyPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyPaper.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyPaper.Enabled = false;
            this.enemyPaper.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.enemyPaper.FlatAppearance.BorderSize = 0;
            this.enemyPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enemyPaper.Location = new System.Drawing.Point(393, 29);
            this.enemyPaper.Name = "enemyPaper";
            this.enemyPaper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enemyPaper.Size = new System.Drawing.Size(112, 212);
            this.enemyPaper.TabIndex = 6;
            this.enemyPaper.UseVisualStyleBackColor = false;
            this.enemyPaper.Visible = false;
            // 
            // enemyRock
            // 
            this.enemyRock.BackColor = System.Drawing.SystemColors.Info;
            this.enemyRock.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Rock_Enemy1;
            this.enemyRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyRock.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemyRock.Enabled = false;
            this.enemyRock.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.enemyRock.FlatAppearance.BorderSize = 0;
            this.enemyRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enemyRock.Location = new System.Drawing.Point(232, 29);
            this.enemyRock.Name = "enemyRock";
            this.enemyRock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enemyRock.Size = new System.Drawing.Size(112, 212);
            this.enemyRock.TabIndex = 5;
            this.enemyRock.UseVisualStyleBackColor = false;
            this.enemyRock.Visible = false;
            this.enemyRock.Click += new System.EventHandler(this.enemyRock_Click);
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.enemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyPictureBox.Image = global::Rock_Paper_Scissors.Properties.Resources.Enemy_Cat;
            this.enemyPictureBox.Location = new System.Drawing.Point(12, 12);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(182, 229);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 4;
            this.enemyPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.playerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerPictureBox.Image = global::Rock_Paper_Scissors.Properties.Resources.Player_Cat;
            this.playerPictureBox.Location = new System.Drawing.Point(693, 442);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(190, 243);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 3;
            this.playerPictureBox.TabStop = false;
            // 
            // button_Scissors
            // 
            this.button_Scissors.BackColor = System.Drawing.SystemColors.Info;
            this.button_Scissors.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Scissors;
            this.button_Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Scissors.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button_Scissors.FlatAppearance.BorderSize = 0;
            this.button_Scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Scissors.Location = new System.Drawing.Point(551, 473);
            this.button_Scissors.Name = "button_Scissors";
            this.button_Scissors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Scissors.Size = new System.Drawing.Size(112, 212);
            this.button_Scissors.TabIndex = 2;
            this.button_Scissors.UseVisualStyleBackColor = false;
            this.button_Scissors.Click += new System.EventHandler(this.button_Scissors_Click);
            // 
            // button_Paper
            // 
            this.button_Paper.BackColor = System.Drawing.SystemColors.Info;
            this.button_Paper.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Paper;
            this.button_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Paper.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button_Paper.FlatAppearance.BorderSize = 0;
            this.button_Paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Paper.Location = new System.Drawing.Point(393, 473);
            this.button_Paper.Name = "button_Paper";
            this.button_Paper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Paper.Size = new System.Drawing.Size(112, 212);
            this.button_Paper.TabIndex = 1;
            this.button_Paper.UseVisualStyleBackColor = false;
            this.button_Paper.Click += new System.EventHandler(this.button_Paper_Click);
            // 
            // button_Rock
            // 
            this.button_Rock.BackColor = System.Drawing.SystemColors.Info;
            this.button_Rock.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Rock1;
            this.button_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Rock.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.button_Rock.FlatAppearance.BorderSize = 0;
            this.button_Rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_Rock.Location = new System.Drawing.Point(232, 473);
            this.button_Rock.Name = "button_Rock";
            this.button_Rock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Rock.Size = new System.Drawing.Size(112, 212);
            this.button_Rock.TabIndex = 0;
            this.button_Rock.UseVisualStyleBackColor = false;
            this.button_Rock.Click += new System.EventHandler(this.button_Rock_Click);
            // 
            // throwButton
            // 
            this.throwButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.throwButton.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwButton.Location = new System.Drawing.Point(346, 314);
            this.throwButton.Name = "throwButton";
            this.throwButton.Size = new System.Drawing.Size(200, 93);
            this.throwButton.TabIndex = 8;
            this.throwButton.Text = "THROW!";
            this.throwButton.UseVisualStyleBackColor = false;
            // 
            // RPS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(895, 697);
            this.Controls.Add(this.throwButton);
            this.Controls.Add(this.enemyScissors);
            this.Controls.Add(this.enemyPaper);
            this.Controls.Add(this.enemyRock);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.button_Scissors);
            this.Controls.Add(this.button_Paper);
            this.Controls.Add(this.button_Rock);
            this.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RPS_Form";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Rock;
        private System.Windows.Forms.Button button_Paper;
        private System.Windows.Forms.Button button_Scissors;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Button enemyScissors;
        private System.Windows.Forms.Button enemyPaper;
        private System.Windows.Forms.Button enemyRock;
        private System.Windows.Forms.Button throwButton;
    }
}

