namespace Personal_Information
{
    partial class personalInfoForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.NumericUpDown();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.currentPerson = new System.Windows.Forms.GroupBox();
            this.submitInfoButton = new System.Windows.Forms.Button();
            this.membersLabel = new System.Windows.Forms.Label();
            this.membersInput = new System.Windows.Forms.NumericUpDown();
            this.membersSubmitButton = new System.Windows.Forms.Button();
            this.invalidText = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.GroupBox();
            this.resultsList = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).BeginInit();
            this.currentPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersInput)).BeginInit();
            this.results.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(87, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(455, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter your information and each household member below";
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(173, 56);
            this.fNameText.MaxLength = 12;
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(132, 30);
            this.fNameText.TabIndex = 2;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(69, 59);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(98, 23);
            this.fNameLabel.TabIndex = 3;
            this.fNameLabel.Text = "First Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(34, 208);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(133, 23);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Street Address";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(335, 59);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(94, 23);
            this.lNameLabel.TabIndex = 5;
            this.lNameLabel.Text = "Last Name";
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(435, 56);
            this.lNameText.MaxLength = 12;
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(132, 30);
            this.lNameText.TabIndex = 6;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(173, 205);
            this.addressInput.MaxLength = 20;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(394, 30);
            this.addressInput.TabIndex = 9;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(127, 131);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 23);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age";
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(173, 129);
            this.ageInput.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(47, 30);
            this.ageInput.TabIndex = 7;
            this.ageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ageInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(309, 131);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(120, 23);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Phone Number";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(435, 128);
            this.phoneText.MaxLength = 10;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(132, 30);
            this.phoneText.TabIndex = 8;
            // 
            // currentPerson
            // 
            this.currentPerson.Controls.Add(this.submitInfoButton);
            this.currentPerson.Controls.Add(this.phoneLabel);
            this.currentPerson.Controls.Add(this.fNameLabel);
            this.currentPerson.Controls.Add(this.phoneText);
            this.currentPerson.Controls.Add(this.ageInput);
            this.currentPerson.Controls.Add(this.fNameText);
            this.currentPerson.Controls.Add(this.ageLabel);
            this.currentPerson.Controls.Add(this.addressLabel);
            this.currentPerson.Controls.Add(this.addressInput);
            this.currentPerson.Controls.Add(this.lNameLabel);
            this.currentPerson.Controls.Add(this.lNameText);
            this.currentPerson.Location = new System.Drawing.Point(12, 224);
            this.currentPerson.Name = "currentPerson";
            this.currentPerson.Size = new System.Drawing.Size(645, 322);
            this.currentPerson.TabIndex = 13;
            this.currentPerson.TabStop = false;
            this.currentPerson.Text = "Your Information";
            this.currentPerson.Visible = false;
            // 
            // submitInfoButton
            // 
            this.submitInfoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitInfoButton.Location = new System.Drawing.Point(214, 254);
            this.submitInfoButton.Name = "submitInfoButton";
            this.submitInfoButton.Size = new System.Drawing.Size(215, 47);
            this.submitInfoButton.TabIndex = 13;
            this.submitInfoButton.Text = "Submit";
            this.submitInfoButton.UseVisualStyleBackColor = false;
            this.submitInfoButton.Click += new System.EventHandler(this.submitInfoButton_Click);
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Location = new System.Drawing.Point(87, 148);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(321, 23);
            this.membersLabel.TabIndex = 14;
            this.membersLabel.Text = "How many people are in your household?";
            // 
            // membersInput
            // 
            this.membersInput.Location = new System.Drawing.Point(414, 146);
            this.membersInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.membersInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.membersInput.Name = "membersInput";
            this.membersInput.Size = new System.Drawing.Size(46, 30);
            this.membersInput.TabIndex = 15;
            this.membersInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.membersInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // membersSubmitButton
            // 
            this.membersSubmitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.membersSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membersSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersSubmitButton.Location = new System.Drawing.Point(477, 146);
            this.membersSubmitButton.Name = "membersSubmitButton";
            this.membersSubmitButton.Size = new System.Drawing.Size(102, 30);
            this.membersSubmitButton.TabIndex = 14;
            this.membersSubmitButton.Text = "Submit";
            this.membersSubmitButton.UseVisualStyleBackColor = false;
            this.membersSubmitButton.Click += new System.EventHandler(this.membersSubmitButton_Click);
            // 
            // invalidText
            // 
            this.invalidText.AutoSize = true;
            this.invalidText.ForeColor = System.Drawing.Color.Red;
            this.invalidText.Location = new System.Drawing.Point(68, 540);
            this.invalidText.Name = "invalidText";
            this.invalidText.Size = new System.Drawing.Size(528, 23);
            this.invalidText.TabIndex = 16;
            this.invalidText.Text = "Invalid Submission. Please enter all information before submitting.";
            this.invalidText.Visible = false;
            // 
            // results
            // 
            this.results.Controls.Add(this.resultsList);
            this.results.Location = new System.Drawing.Point(12, 12);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(645, 551);
            this.results.TabIndex = 17;
            this.results.TabStop = false;
            this.results.Visible = false;
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.ageHeader,
            this.phoneHeader,
            this.addressHeader});
            this.resultsList.HideSelection = false;
            this.resultsList.Location = new System.Drawing.Point(15, 39);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(612, 489);
            this.resultsList.TabIndex = 0;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 175;
            // 
            // ageHeader
            // 
            this.ageHeader.Text = "Age";
            this.ageHeader.Width = 50;
            // 
            // phoneHeader
            // 
            this.phoneHeader.Text = "Phone Number";
            this.phoneHeader.Width = 150;
            // 
            // addressHeader
            // 
            this.addressHeader.Text = "Street Address";
            this.addressHeader.Width = 200;
            // 
            // personalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 572);
            this.Controls.Add(this.membersSubmitButton);
            this.Controls.Add(this.membersInput);
            this.Controls.Add(this.membersLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.currentPerson);
            this.Controls.Add(this.invalidText);
            this.Controls.Add(this.results);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "personalInfoForm";
            this.Text = "Input Personal Info";
            this.Load += new System.EventHandler(this.personalInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).EndInit();
            this.currentPerson.ResumeLayout(false);
            this.currentPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersInput)).EndInit();
            this.results.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.GroupBox currentPerson;
        private System.Windows.Forms.Button submitInfoButton;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.NumericUpDown membersInput;
        private System.Windows.Forms.Button membersSubmitButton;
        private System.Windows.Forms.Label invalidText;
        private System.Windows.Forms.GroupBox results;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader ageHeader;
        private System.Windows.Forms.ColumnHeader phoneHeader;
        private System.Windows.Forms.ColumnHeader addressHeader;
    }
}

