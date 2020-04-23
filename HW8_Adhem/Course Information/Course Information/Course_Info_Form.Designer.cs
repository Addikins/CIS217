namespace Course_Information
{
    partial class courseInfoForm
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
            this.courseLookupLabel = new System.Windows.Forms.Label();
            this.courseNumberInput = new System.Windows.Forms.TextBox();
            this.enterCourseLabel = new System.Windows.Forms.Label();
            this.courseInfoGroup = new System.Windows.Forms.GroupBox();
            this.courseInfoLabel1 = new System.Windows.Forms.Label();
            this.courseInfoLabel2 = new System.Windows.Forms.Label();
            this.courseInfoLabel3 = new System.Windows.Forms.Label();
            this.courseInfoLabel4 = new System.Windows.Forms.Label();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.courseNumberLabel = new System.Windows.Forms.Label();
            this.courseLookupButton = new System.Windows.Forms.Button();
            this.invalidText = new System.Windows.Forms.Label();
            this.courseInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseLookupLabel
            // 
            this.courseLookupLabel.AutoSize = true;
            this.courseLookupLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLookupLabel.Location = new System.Drawing.Point(316, 48);
            this.courseLookupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseLookupLabel.Name = "courseLookupLabel";
            this.courseLookupLabel.Size = new System.Drawing.Size(194, 27);
            this.courseLookupLabel.TabIndex = 0;
            this.courseLookupLabel.Text = "Course Lookup";
            // 
            // courseNumberInput
            // 
            this.courseNumberInput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumberInput.Location = new System.Drawing.Point(367, 182);
            this.courseNumberInput.MaxLength = 5;
            this.courseNumberInput.Name = "courseNumberInput";
            this.courseNumberInput.Size = new System.Drawing.Size(79, 22);
            this.courseNumberInput.TabIndex = 1;
            this.courseNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseNumberInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enterCourseLabel
            // 
            this.enterCourseLabel.AutoSize = true;
            this.enterCourseLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCourseLabel.Location = new System.Drawing.Point(184, 185);
            this.enterCourseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterCourseLabel.Name = "enterCourseLabel";
            this.enterCourseLabel.Size = new System.Drawing.Size(176, 16);
            this.enterCourseLabel.TabIndex = 2;
            this.enterCourseLabel.Text = "Enter a course number";
            this.enterCourseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseInfoGroup
            // 
            this.courseInfoGroup.Controls.Add(this.meetingTimeLabel);
            this.courseInfoGroup.Controls.Add(this.roomNumberLabel);
            this.courseInfoGroup.Controls.Add(this.instructorLabel);
            this.courseInfoGroup.Controls.Add(this.courseNumberLabel);
            this.courseInfoGroup.Controls.Add(this.courseInfoLabel4);
            this.courseInfoGroup.Controls.Add(this.courseInfoLabel3);
            this.courseInfoGroup.Controls.Add(this.courseInfoLabel2);
            this.courseInfoGroup.Controls.Add(this.courseInfoLabel1);
            this.courseInfoGroup.Location = new System.Drawing.Point(171, 270);
            this.courseInfoGroup.Name = "courseInfoGroup";
            this.courseInfoGroup.Size = new System.Drawing.Size(500, 279);
            this.courseInfoGroup.TabIndex = 3;
            this.courseInfoGroup.TabStop = false;
            this.courseInfoGroup.Text = "Course Information";
            this.courseInfoGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // courseInfoLabel1
            // 
            this.courseInfoLabel1.AutoSize = true;
            this.courseInfoLabel1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfoLabel1.Location = new System.Drawing.Point(157, 47);
            this.courseInfoLabel1.Name = "courseInfoLabel1";
            this.courseInfoLabel1.Size = new System.Drawing.Size(76, 21);
            this.courseInfoLabel1.TabIndex = 0;
            this.courseInfoLabel1.Text = "Course";
            this.courseInfoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseInfoLabel2
            // 
            this.courseInfoLabel2.AutoSize = true;
            this.courseInfoLabel2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfoLabel2.Location = new System.Drawing.Point(107, 170);
            this.courseInfoLabel2.Name = "courseInfoLabel2";
            this.courseInfoLabel2.Size = new System.Drawing.Size(131, 21);
            this.courseInfoLabel2.TabIndex = 1;
            this.courseInfoLabel2.Text = "Room Number";
            this.courseInfoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseInfoLabel3
            // 
            this.courseInfoLabel3.AutoSize = true;
            this.courseInfoLabel3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfoLabel3.Location = new System.Drawing.Point(117, 109);
            this.courseInfoLabel3.Name = "courseInfoLabel3";
            this.courseInfoLabel3.Size = new System.Drawing.Size(120, 21);
            this.courseInfoLabel3.TabIndex = 2;
            this.courseInfoLabel3.Text = "Instructor";
            this.courseInfoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseInfoLabel4
            // 
            this.courseInfoLabel4.AutoSize = true;
            this.courseInfoLabel4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseInfoLabel4.Location = new System.Drawing.Point(97, 228);
            this.courseInfoLabel4.Name = "courseInfoLabel4";
            this.courseInfoLabel4.Size = new System.Drawing.Size(142, 21);
            this.courseInfoLabel4.TabIndex = 3;
            this.courseInfoLabel4.Text = "Meeting Time";
            this.courseInfoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.AutoSize = true;
            this.meetingTimeLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingTimeLabel.Location = new System.Drawing.Point(276, 229);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(0, 22);
            this.meetingTimeLabel.TabIndex = 7;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(276, 171);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(0, 22);
            this.roomNumberLabel.TabIndex = 6;
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorLabel.Location = new System.Drawing.Point(276, 110);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(0, 22);
            this.instructorLabel.TabIndex = 5;
            // 
            // courseNumberLabel
            // 
            this.courseNumberLabel.AutoSize = true;
            this.courseNumberLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumberLabel.Location = new System.Drawing.Point(276, 48);
            this.courseNumberLabel.Name = "courseNumberLabel";
            this.courseNumberLabel.Size = new System.Drawing.Size(0, 22);
            this.courseNumberLabel.TabIndex = 4;
            this.courseNumberLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // courseLookupButton
            // 
            this.courseLookupButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseLookupButton.FlatAppearance.BorderSize = 2;
            this.courseLookupButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.courseLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.courseLookupButton.Location = new System.Drawing.Point(512, 172);
            this.courseLookupButton.Name = "courseLookupButton";
            this.courseLookupButton.Size = new System.Drawing.Size(159, 43);
            this.courseLookupButton.TabIndex = 4;
            this.courseLookupButton.Text = "Lookup Course";
            this.courseLookupButton.UseVisualStyleBackColor = false;
            this.courseLookupButton.Click += new System.EventHandler(this.courseLookupButton_Click);
            // 
            // invalidText
            // 
            this.invalidText.AutoSize = true;
            this.invalidText.ForeColor = System.Drawing.Color.Red;
            this.invalidText.Location = new System.Drawing.Point(123, 236);
            this.invalidText.Name = "invalidText";
            this.invalidText.Size = new System.Drawing.Size(600, 16);
            this.invalidText.TabIndex = 5;
            this.invalidText.Text = "Invalid course number, please enter a valid course number such as \"CS101\".";
            this.invalidText.Visible = false;
            // 
            // courseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 561);
            this.Controls.Add(this.invalidText);
            this.Controls.Add(this.courseLookupButton);
            this.Controls.Add(this.courseInfoGroup);
            this.Controls.Add(this.enterCourseLabel);
            this.Controls.Add(this.courseNumberInput);
            this.Controls.Add(this.courseLookupLabel);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "courseInfoForm";
            this.Text = "Course Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.courseInfoGroup.ResumeLayout(false);
            this.courseInfoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseLookupLabel;
        private System.Windows.Forms.TextBox courseNumberInput;
        private System.Windows.Forms.Label enterCourseLabel;
        private System.Windows.Forms.GroupBox courseInfoGroup;
        private System.Windows.Forms.Label courseInfoLabel4;
        private System.Windows.Forms.Label courseInfoLabel3;
        private System.Windows.Forms.Label courseInfoLabel2;
        private System.Windows.Forms.Label courseInfoLabel1;
        private System.Windows.Forms.Label meetingTimeLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Label courseNumberLabel;
        private System.Windows.Forms.Button courseLookupButton;
        private System.Windows.Forms.Label invalidText;
    }
}

