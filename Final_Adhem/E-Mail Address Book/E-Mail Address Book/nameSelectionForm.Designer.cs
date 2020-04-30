namespace E_Mail_Address_Book
{
    partial class nameSelectionForm
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
            this.nameSelectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameSelectionLabel
            // 
            this.nameSelectionLabel.AutoSize = true;
            this.nameSelectionLabel.Location = new System.Drawing.Point(144, 53);
            this.nameSelectionLabel.Name = "nameSelectionLabel";
            this.nameSelectionLabel.Size = new System.Drawing.Size(338, 18);
            this.nameSelectionLabel.TabIndex = 0;
            this.nameSelectionLabel.Text = "Select a name to view information";
            // 
            // nameSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 455);
            this.Controls.Add(this.nameSelectionLabel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "nameSelectionForm";
            this.Text = "E-Mail Address Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameSelectionLabel;
    }
}

