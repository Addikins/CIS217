using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class mainForm : Form
    {
        int _classATicketCost = 15;
        int _classBTicketCost = 12;
        int _classCTicketCost = 9;

        decimal _classARevenue = 0;
        decimal _classBRevenue = 0;
        decimal _classCRevenue = 0;
        decimal _totalRevenue = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ticketsInput0_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            _classARevenue = ticketsInput0.Value * _classATicketCost;
            _classBRevenue = ticketsInput1.Value * _classBTicketCost;
            _classCRevenue = ticketsInput2.Value * _classCTicketCost;
            _totalRevenue = _classARevenue + _classBRevenue + _classCRevenue;

            DisplayRevenue();

        }

        private void DisplayRevenue()
        {
            revenueDisplay0.Text = "$" + (_classARevenue).ToString() + ".00";
            revenueDisplay1.Text = "$" + (_classBRevenue).ToString() + ".00";
            revenueDisplay2.Text = "$" + (_classCRevenue).ToString() + ".00";
            revenueDisplay3.Text = "$" + (_totalRevenue).ToString() + ".00";

            if (_totalRevenue > 0)
            {
                revenueDisplay3.ForeColor = Color.Green;
            }
            else
            {
                revenueDisplay3.ForeColor = Color.Black;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _classARevenue = 0;
            _classBRevenue = 0;
            _classCRevenue = 0;
            _totalRevenue = 0;

            DisplayRevenue();
            ticketsInput0.Value = 0;
            ticketsInput1.Value = 0;
            ticketsInput2.Value = 0;
        }
    }
}
