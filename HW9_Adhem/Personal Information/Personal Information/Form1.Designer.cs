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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.NumericUpDown();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.currentPerson = new System.Windows.Forms.GroupBox();
            this.submitInfoButton = new System.Windows.Forms.Button();
            this.membersLabel = new System.Windows.Forms.Label();
            this.membersInput = new System.Windows.Forms.NumericUpDown();
            this.membersSubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).BeginInit();
            this.currentPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(136, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(379, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter details for each household member below";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
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
            this.fNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(94, 208);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(73, 23);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(335, 59);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(94, 23);
            this.lNameLabel.TabIndex = 5;
            this.lNameLabel.Text = "Last Name";
            this.lNameLabel.Click += new System.EventHandler(this.lNameLabel_Click);
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(435, 56);
            this.lNameText.MaxLength = 12;
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(132, 30);
            this.lNameText.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 205);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 30);
            this.textBox1.TabIndex = 7;
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
            this.ageInput.TabIndex = 10;
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
            this.phoneLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(435, 128);
            this.phoneText.MaxLength = 12;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(132, 30);
            this.phoneText.TabIndex = 11;
            this.phoneText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.currentPerson.Controls.Add(this.textBox1);
            this.currentPerson.Controls.Add(this.lNameLabel);
            this.currentPerson.Controls.Add(this.lNameText);
            this.currentPerson.Location = new System.Drawing.Point(12, 224);
            this.currentPerson.Name = "currentPerson";
            this.currentPerson.Size = new System.Drawing.Size(645, 322);
            this.currentPerson.TabIndex = 13;
            this.currentPerson.TabStop = false;
            this.currentPerson.Text = "Household Member 1";
            this.currentPerson.Visible = false;
            this.currentPerson.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.submitInfoButton.Click += new System.EventHandler(this.submitButton_Click);
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
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "personalInfoForm";
            this.Text = "Input Personal Info";
            this.Load += new System.EventHandler(this.personalInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).EndInit();
            this.currentPerson.ResumeLayout(false);
            this.currentPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersInput)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.GroupBox currentPerson;
        private System.Windows.Forms.Button submitInfoButton;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.NumericUpDown membersInput;
        private System.Windows.Forms.Button membersSubmitButton;
    }
}

