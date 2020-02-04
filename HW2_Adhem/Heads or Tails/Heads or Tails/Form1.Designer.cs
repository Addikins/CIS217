namespace Heads_or_Tails
{
    partial class HeadsOrTails
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
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.coinHeads = new System.Windows.Forms.PictureBox();
            this.coinTails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coinHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinTails)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(12, 316);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(107, 37);
            this.showHeadsButton.TabIndex = 0;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(197, 316);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(107, 37);
            this.showTailsButton.TabIndex = 1;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(378, 316);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // coinHeads
            // 
            this.coinHeads.Image = global::Heads_or_Tails.Properties.Resources.Heads2;
            this.coinHeads.Location = new System.Drawing.Point(12, 70);
            this.coinHeads.Name = "coinHeads";
            this.coinHeads.Size = new System.Drawing.Size(190, 190);
            this.coinHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinHeads.TabIndex = 3;
            this.coinHeads.TabStop = false;
            // 
            // coinTails
            // 
            this.coinTails.Image = global::Heads_or_Tails.Properties.Resources.Tails2;
            this.coinTails.Location = new System.Drawing.Point(295, 70);
            this.coinTails.Name = "coinTails";
            this.coinTails.Size = new System.Drawing.Size(190, 190);
            this.coinTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinTails.TabIndex = 4;
            this.coinTails.TabStop = false;
            this.coinTails.Visible = false;
            // 
            // HeadsOrTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 365);
            this.Controls.Add(this.coinTails);
            this.Controls.Add(this.coinHeads);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Name = "HeadsOrTails";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.coinHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox coinHeads;
        private System.Windows.Forms.PictureBox coinTails;
    }
}

