namespace Rock_Paper_Scissors
{
    partial class RPS_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_scissors = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.button_rock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Rock_Paper_Scissors.Properties.Resources.Player_Cat;
            this.pictureBox1.Location = new System.Drawing.Point(977, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_scissors
            // 
            this.button_scissors.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_scissors.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Scissors;
            this.button_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_scissors.Location = new System.Drawing.Point(785, 261);
            this.button_scissors.Name = "button_scissors";
            this.button_scissors.Size = new System.Drawing.Size(131, 237);
            this.button_scissors.TabIndex = 2;
            this.button_scissors.UseVisualStyleBackColor = false;
            // 
            // button_paper
            // 
            this.button_paper.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_paper.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Paper;
            this.button_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_paper.Location = new System.Drawing.Point(495, 261);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(131, 237);
            this.button_paper.TabIndex = 1;
            this.button_paper.UseVisualStyleBackColor = false;
            // 
            // button_rock
            // 
            this.button_rock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_rock.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.Rock1;
            this.button_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_rock.Location = new System.Drawing.Point(211, 261);
            this.button_rock.Name = "button_rock";
            this.button_rock.Size = new System.Drawing.Size(131, 237);
            this.button_rock.TabIndex = 0;
            this.button_rock.UseVisualStyleBackColor = false;
            // 
            // RPS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1152, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_scissors);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_rock);
            this.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RPS_Form";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_rock;
        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.Button button_scissors;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

