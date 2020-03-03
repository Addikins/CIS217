namespace HospitalBillCalculator
{
    partial class BillCalculator
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
            this.nightCount = new System.Windows.Forms.NumericUpDown();
            this.nightCountLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.medicalLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nightCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // nightCount
            // 
            this.nightCount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nightCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nightCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nightCount.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nightCount.Location = new System.Drawing.Point(615, 187);
            this.nightCount.Name = "nightCount";
            this.nightCount.Size = new System.Drawing.Size(64, 32);
            this.nightCount.TabIndex = 4;
            this.nightCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nightCount.ValueChanged += new System.EventHandler(this.NightCount_ValueChanged);
            // 
            // nightCountLabel
            // 
            this.nightCountLabel.AutoSize = true;
            this.nightCountLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightCountLabel.Location = new System.Drawing.Point(489, 189);
            this.nightCountLabel.Name = "nightCountLabel";
            this.nightCountLabel.Size = new System.Drawing.Size(116, 24);
            this.nightCountLabel.TabIndex = 1;
            this.nightCountLabel.Text = "Nights Stayed";
            this.nightCountLabel.Click += new System.EventHandler(this.NightCountLabel_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(421, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(412, 36);
            this.title.TabIndex = 2;
            this.title.Text = "Enter Information for Patient Visit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medical Charges";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown1.Location = new System.Drawing.Point(191, 81);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 32);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown2.Location = new System.Drawing.Point(482, 81);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(96, 32);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surgical Charges";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown3.Location = new System.Drawing.Point(699, 81);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(96, 32);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lab Fees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown4.Location = new System.Drawing.Point(1070, 81);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(96, 32);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medicalLabel
            // 
            this.medicalLabel.AutoSize = true;
            this.medicalLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalLabel.Location = new System.Drawing.Point(838, 83);
            this.medicalLabel.Name = "medicalLabel";
            this.medicalLabel.Size = new System.Drawing.Size(210, 24);
            this.medicalLabel.TabIndex = 9;
            this.medicalLabel.Text = "Phyiscal Therapy Charges";
            this.medicalLabel.Click += new System.EventHandler(this.medicalLabel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(471, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Total Charges";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(368, 485);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(237, 48);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Your Total Bill:";
            this.totalLabel.Visible = false;
            // 
            // totalDisplay
            // 
            this.totalDisplay.AutoSize = true;
            this.totalDisplay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDisplay.Location = new System.Drawing.Point(607, 485);
            this.totalDisplay.Name = "totalDisplay";
            this.totalDisplay.Size = new System.Drawing.Size(58, 48);
            this.totalDisplay.TabIndex = 12;
            this.totalDisplay.Text = "$0";
            this.totalDisplay.Visible = false;
            // 
            // BillCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1214, 641);
            this.Controls.Add(this.totalDisplay);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.medicalLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.nightCount);
            this.Controls.Add(this.nightCountLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "BillCalculator";
            this.Text = "Bill Calculator";
            this.Load += new System.EventHandler(this.BillCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nightCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nightCount;
        private System.Windows.Forms.Label nightCountLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label medicalLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalDisplay;
    }
}

