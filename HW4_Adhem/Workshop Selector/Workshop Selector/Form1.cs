using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        int numOfDays;
        int registrationFee;
        int feePerDay;

        public Form1()
        {
            InitializeComponent();
        }

        private void workshopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWorkshop = workshopListBox.SelectedIndex.ToString();
            switch (selectedWorkshop)
            {
                case "0":
                    numOfDays = 3;
                    registrationFee = 1000;
                    break;
                case "1":
                    numOfDays = 3;
                    registrationFee = 800;
                    break;
                case "2":
                    numOfDays = 3;
                    registrationFee = 1500;
                    break;
                case "3":
                    numOfDays = 5;
                    registrationFee = 1300;
                    break;
                case "4":
                    numOfDays = 1;
                    registrationFee = 500;
                    break;
                default:
                    numOfDays = 0;
                    registrationFee = 0;
                    break;
            }

        }

        private void locationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = locationList.SelectedIndex.ToString();
            switch (selectedCity)
            {
                case "0":
                    feePerDay = 150;
                    break;
                case "1":
                    feePerDay = 225;
                    break;
                case "2":
                    feePerDay = 175;
                    break;
                case "3":
                    feePerDay = 300;
                    break;
                case "4":
                    feePerDay = 175;
                    break;
                case "5":
                    feePerDay = 150;
                    break;
                default:
                    feePerDay = 0;
                    break;
            }
            feesPerDay.Text = ("$" + feePerDay);

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int lodging = feePerDay * numOfDays;

            registrationTotal.Text = ("$" + registrationFee);
            lodgingTotal.Text = String.Format("${0}", lodging);
            total.Text = ("$" + (registrationFee + lodging));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
