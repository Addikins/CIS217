namespace Stadium_Seating
{
    partial class mainForm
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
            this.ticketsBox = new System.Windows.Forms.GroupBox();
            this.ticketsInput2 = new System.Windows.Forms.NumericUpDown();
            this.ticketsInput1 = new System.Windows.Forms.NumericUpDown();
            this.ticketsInput0 = new System.Windows.Forms.NumericUpDown();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLable1 = new System.Windows.Forms.Label();
            this.inputLabel0 = new System.Windows.Forms.Label();
            this.revenueBox = new System.Windows.Forms.GroupBox();
            this.revenueDisplay3 = new System.Windows.Forms.Label();
            this.revenueDisplay2 = new System.Windows.Forms.Label();
            this.revenueDisplay1 = new System.Windows.Forms.Label();
            this.revenueDisplay0 = new System.Windows.Forms.Label();
            this.revenueLable3 = new System.Windows.Forms.Label();
            this.revenueLable2 = new System.Windows.Forms.Label();
            this.revenueLable1 = new System.Windows.Forms.Label();
            this.revenueLable0 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsInput0)).BeginInit();
            this.revenueBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsBox
            // 
            this.ticketsBox.Controls.Add(this.ticketsInput2);
            this.ticketsBox.Controls.Add(this.ticketsInput1);
            this.ticketsBox.Controls.Add(this.ticketsInput0);
            this.ticketsBox.Controls.Add(this.inputLabel2);
            this.ticketsBox.Controls.Add(this.inputLable1);
            this.ticketsBox.Controls.Add(this.inputLabel0);
            this.ticketsBox.Location = new System.Drawing.Point(26, 27);
            this.ticketsBox.Name = "ticketsBox";
            this.ticketsBox.Size = new System.Drawing.Size(397, 312);
            this.ticketsBox.TabIndex = 0;
            this.ticketsBox.TabStop = false;
            this.ticketsBox.Text = "Tickets Sold";
            // 
            // ticketsInput2
            // 
            this.ticketsInput2.DecimalPlaces = 2;
            this.ticketsInput2.Location = new System.Drawing.Point(186, 180);
            this.ticketsInput2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ticketsInput2.Name = "ticketsInput2";
            this.ticketsInput2.Size = new System.Drawing.Size(149, 22);
            this.ticketsInput2.TabIndex = 8;
            this.ticketsInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticketsInput2.ThousandsSeparator = true;
            // 
            // ticketsInput1
            // 
            this.ticketsInput1.DecimalPlaces = 2;
            this.ticketsInput1.Location = new System.Drawing.Point(186, 135);
            this.ticketsInput1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ticketsInput1.Name = "ticketsInput1";
            this.ticketsInput1.Size = new System.Drawing.Size(149, 22);
            this.ticketsInput1.TabIndex = 7;
            this.ticketsInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticketsInput1.ThousandsSeparator = true;
            // 
            // ticketsInput0
            // 
            this.ticketsInput0.DecimalPlaces = 2;
            this.ticketsInput0.Location = new System.Drawing.Point(186, 89);
            this.ticketsInput0.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ticketsInput0.Name = "ticketsInput0";
            this.ticketsInput0.Size = new System.Drawing.Size(149, 22);
            this.ticketsInput0.TabIndex = 6;
            this.ticketsInput0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticketsInput0.ThousandsSeparator = true;
            this.ticketsInput0.ValueChanged += new System.EventHandler(this.ticketsInput0_ValueChanged);
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(40, 182);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(140, 17);
            this.inputLabel2.TabIndex = 5;
            this.inputLabel2.Text = "Class C Tickets Sold:";
            // 
            // inputLable1
            // 
            this.inputLable1.AutoSize = true;
            this.inputLable1.Location = new System.Drawing.Point(40, 137);
            this.inputLable1.Name = "inputLable1";
            this.inputLable1.Size = new System.Drawing.Size(140, 17);
            this.inputLable1.TabIndex = 4;
            this.inputLable1.Text = "Class B Tickets Sold:";
            // 
            // inputLabel0
            // 
            this.inputLabel0.AutoSize = true;
            this.inputLabel0.Location = new System.Drawing.Point(40, 91);
            this.inputLabel0.Name = "inputLabel0";
            this.inputLabel0.Size = new System.Drawing.Size(140, 17);
            this.inputLabel0.TabIndex = 3;
            this.inputLabel0.Text = "Class A Tickets Sold:";
            // 
            // revenueBox
            // 
            this.revenueBox.Controls.Add(this.revenueDisplay3);
            this.revenueBox.Controls.Add(this.revenueDisplay2);
            this.revenueBox.Controls.Add(this.revenueDisplay1);
            this.revenueBox.Controls.Add(this.revenueDisplay0);
            this.revenueBox.Controls.Add(this.revenueLable3);
            this.revenueBox.Controls.Add(this.revenueLable2);
            this.revenueBox.Controls.Add(this.revenueLable1);
            this.revenueBox.Controls.Add(this.revenueLable0);
            this.revenueBox.Location = new System.Drawing.Point(457, 27);
            this.revenueBox.Name = "revenueBox";
            this.revenueBox.Size = new System.Drawing.Size(316, 312);
            this.revenueBox.TabIndex = 1;
            this.revenueBox.TabStop = false;
            this.revenueBox.Text = "Revenue Generated";
            // 
            // revenueDisplay3
            // 
            this.revenueDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueDisplay3.Location = new System.Drawing.Point(128, 229);
            this.revenueDisplay3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueDisplay3.Name = "revenueDisplay3";
            this.revenueDisplay3.Size = new System.Drawing.Size(133, 28);
            this.revenueDisplay3.TabIndex = 13;
            this.revenueDisplay3.Text = "$0.00";
            this.revenueDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueDisplay2
            // 
            this.revenueDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueDisplay2.Location = new System.Drawing.Point(128, 172);
            this.revenueDisplay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueDisplay2.Name = "revenueDisplay2";
            this.revenueDisplay2.Size = new System.Drawing.Size(133, 28);
            this.revenueDisplay2.TabIndex = 12;
            this.revenueDisplay2.Text = "$0.00";
            this.revenueDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueDisplay1
            // 
            this.revenueDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueDisplay1.Location = new System.Drawing.Point(128, 126);
            this.revenueDisplay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueDisplay1.Name = "revenueDisplay1";
            this.revenueDisplay1.Size = new System.Drawing.Size(133, 28);
            this.revenueDisplay1.TabIndex = 11;
            this.revenueDisplay1.Text = "$0.00";
            this.revenueDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueDisplay0
            // 
            this.revenueDisplay0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueDisplay0.Location = new System.Drawing.Point(128, 83);
            this.revenueDisplay0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueDisplay0.Name = "revenueDisplay0";
            this.revenueDisplay0.Size = new System.Drawing.Size(133, 28);
            this.revenueDisplay0.TabIndex = 10;
            this.revenueDisplay0.Text = "$0.00";
            this.revenueDisplay0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueLable3
            // 
            this.revenueLable3.AutoSize = true;
            this.revenueLable3.Location = new System.Drawing.Point(77, 235);
            this.revenueLable3.Name = "revenueLable3";
            this.revenueLable3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.revenueLable3.Size = new System.Drawing.Size(44, 17);
            this.revenueLable3.TabIndex = 9;
            this.revenueLable3.Text = "Total:";
            // 
            // revenueLable2
            // 
            this.revenueLable2.AutoSize = true;
            this.revenueLable2.Location = new System.Drawing.Point(6, 178);
            this.revenueLable2.Name = "revenueLable2";
            this.revenueLable2.Size = new System.Drawing.Size(120, 17);
            this.revenueLable2.TabIndex = 8;
            this.revenueLable2.Text = "Class C Revenue:";
            this.revenueLable2.Click += new System.EventHandler(this.label1_Click);
            // 
            // revenueLable1
            // 
            this.revenueLable1.AutoSize = true;
            this.revenueLable1.Location = new System.Drawing.Point(6, 132);
            this.revenueLable1.Name = "revenueLable1";
            this.revenueLable1.Size = new System.Drawing.Size(120, 17);
            this.revenueLable1.TabIndex = 7;
            this.revenueLable1.Text = "Class B Revenue:";
            this.revenueLable1.Click += new System.EventHandler(this.label2_Click);
            // 
            // revenueLable0
            // 
            this.revenueLable0.AutoSize = true;
            this.revenueLable0.Location = new System.Drawing.Point(6, 89);
            this.revenueLable0.Name = "revenueLable0";
            this.revenueLable0.Size = new System.Drawing.Size(120, 17);
            this.revenueLable0.TabIndex = 6;
            this.revenueLable0.Text = "Class A Revenue:";
            this.revenueLable0.Click += new System.EventHandler(this.label3_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(141, 365);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(137, 57);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(337, 365);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 57);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(537, 365);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 57);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueBox);
            this.Controls.Add(this.ticketsBox);
            this.Name = "mainForm";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ticketsBox.ResumeLayout(false);
            this.ticketsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsInput0)).EndInit();
            this.revenueBox.ResumeLayout(false);
            this.revenueBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsBox;
        private System.Windows.Forms.GroupBox revenueBox;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label inputLable1;
        private System.Windows.Forms.Label inputLabel0;
        private System.Windows.Forms.Label revenueLable2;
        private System.Windows.Forms.Label revenueLable1;
        private System.Windows.Forms.Label revenueLable0;
        private System.Windows.Forms.Label revenueLable3;
        private System.Windows.Forms.Label revenueDisplay3;
        private System.Windows.Forms.Label revenueDisplay2;
        private System.Windows.Forms.Label revenueDisplay1;
        private System.Windows.Forms.Label revenueDisplay0;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.NumericUpDown ticketsInput2;
        private System.Windows.Forms.NumericUpDown ticketsInput1;
        private System.Windows.Forms.NumericUpDown ticketsInput0;
    }
}

