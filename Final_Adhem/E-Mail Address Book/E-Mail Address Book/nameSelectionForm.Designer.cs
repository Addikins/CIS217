namespace E_Mail_Address_Book
{
    partial class NameSelectionForm
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
            this.personListBox = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameSelectionLabel
            // 
            this.nameSelectionLabel.AutoSize = true;
            this.nameSelectionLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSelectionLabel.Location = new System.Drawing.Point(12, 102);
            this.nameSelectionLabel.Name = "nameSelectionLabel";
            this.nameSelectionLabel.Size = new System.Drawing.Size(472, 21);
            this.nameSelectionLabel.TabIndex = 0;
            this.nameSelectionLabel.Text = "Select a name to view further information:";
            // 
            // personListBox
            // 
            this.personListBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 21;
            this.personListBox.Location = new System.Drawing.Point(505, 102);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(262, 151);
            this.personListBox.Sorted = true;
            this.personListBox.TabIndex = 1;
            this.personListBox.SelectedIndexChanged += new System.EventHandler(this.personListBox_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // nameSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 337);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.nameSelectionLabel);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "nameSelectionForm";
            this.Text = "E-Mail Address Book";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameSelectionLabel;
        private System.Windows.Forms.ListBox personListBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

