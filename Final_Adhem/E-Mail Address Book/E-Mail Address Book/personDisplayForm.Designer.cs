namespace E_Mail_Address_Book
{
    partial class PersonDisplayForm
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
            this.personDisplayBox = new System.Windows.Forms.GroupBox();
            this.phoneDisplay = new System.Windows.Forms.Label();
            this.emailDisplay = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.personDisplayBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personDisplayBox
            // 
            this.personDisplayBox.Controls.Add(this.phoneDisplay);
            this.personDisplayBox.Controls.Add(this.emailDisplay);
            this.personDisplayBox.Controls.Add(this.phoneLabel);
            this.personDisplayBox.Controls.Add(this.emailLabel);
            this.personDisplayBox.Location = new System.Drawing.Point(12, 12);
            this.personDisplayBox.Name = "personDisplayBox";
            this.personDisplayBox.Size = new System.Drawing.Size(429, 160);
            this.personDisplayBox.TabIndex = 0;
            this.personDisplayBox.TabStop = false;
            this.personDisplayBox.Text = "firstName lastName";
            // 
            // phoneDisplay
            // 
            this.phoneDisplay.AutoSize = true;
            this.phoneDisplay.Location = new System.Drawing.Point(155, 53);
            this.phoneDisplay.Name = "phoneDisplay";
            this.phoneDisplay.Size = new System.Drawing.Size(148, 18);
            this.phoneDisplay.TabIndex = 3;
            this.phoneDisplay.Text = "(123)-456-7890";
            // 
            // emailDisplay
            // 
            this.emailDisplay.AutoSize = true;
            this.emailDisplay.Location = new System.Drawing.Point(95, 102);
            this.emailDisplay.Name = "emailDisplay";
            this.emailDisplay.Size = new System.Drawing.Size(198, 18);
            this.emailDisplay.TabIndex = 2;
            this.emailDisplay.Text = "example@example.com";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(11, 53);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(138, 18);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 102);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 18);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-Mail:";
            // 
            // PersonDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 184);
            this.Controls.Add(this.personDisplayBox);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PersonDisplayForm";
            this.Text = "E-Mail Address Book";
            this.Load += new System.EventHandler(this.personDisplayForm_Load);
            this.personDisplayBox.ResumeLayout(false);
            this.personDisplayBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personDisplayBox;
        private System.Windows.Forms.Label phoneDisplay;
        private System.Windows.Forms.Label emailDisplay;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}