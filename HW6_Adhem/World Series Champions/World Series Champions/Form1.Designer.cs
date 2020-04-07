namespace World_Series_Champions
{
    partial class WSCForm
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
            this.TeamsListBox = new System.Windows.Forms.ListBox();
            this.TeamsLabel = new System.Windows.Forms.Label();
            this.WinsLabel = new System.Windows.Forms.Label();
            this.WinsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TeamsListBox
            // 
            this.TeamsListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamsListBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamsListBox.FormattingEnabled = true;
            this.TeamsListBox.ItemHeight = 29;
            this.TeamsListBox.Location = new System.Drawing.Point(40, 88);
            this.TeamsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TeamsListBox.Name = "TeamsListBox";
            this.TeamsListBox.Size = new System.Drawing.Size(335, 236);
            this.TeamsListBox.TabIndex = 0;
            this.TeamsListBox.SelectedIndexChanged += new System.EventHandler(this.TeamsListBox_SelectedIndexChanged);
            // 
            // TeamsLabel
            // 
            this.TeamsLabel.AutoSize = true;
            this.TeamsLabel.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamsLabel.Location = new System.Drawing.Point(83, 51);
            this.TeamsLabel.Name = "TeamsLabel";
            this.TeamsLabel.Size = new System.Drawing.Size(250, 35);
            this.TeamsLabel.TabIndex = 1;
            this.TeamsLabel.Text = "World Series Teams";
            // 
            // WinsLabel
            // 
            this.WinsLabel.AutoSize = true;
            this.WinsLabel.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsLabel.Location = new System.Drawing.Point(521, 51);
            this.WinsLabel.Name = "WinsLabel";
            this.WinsLabel.Size = new System.Drawing.Size(210, 35);
            this.WinsLabel.TabIndex = 2;
            this.WinsLabel.Text = "Number of Wins";
            // 
            // WinsText
            // 
            this.WinsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinsText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WinsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinsText.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsText.ForeColor = System.Drawing.Color.Black;
            this.WinsText.Location = new System.Drawing.Point(503, 88);
            this.WinsText.Multiline = true;
            this.WinsText.Name = "WinsText";
            this.WinsText.Size = new System.Drawing.Size(204, 224);
            this.WinsText.TabIndex = 3;
            this.WinsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WinsText.TextChanged += new System.EventHandler(this.WinsText_TextChanged);
            // 
            // WSCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.WinsText);
            this.Controls.Add(this.WinsLabel);
            this.Controls.Add(this.TeamsLabel);
            this.Controls.Add(this.TeamsListBox);
            this.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WSCForm";
            this.Text = "World Series Champions";
            this.Load += new System.EventHandler(this.WSCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TeamsListBox;
        private System.Windows.Forms.Label TeamsLabel;
        private System.Windows.Forms.Label WinsLabel;
        private System.Windows.Forms.TextBox WinsText;
    }
}

