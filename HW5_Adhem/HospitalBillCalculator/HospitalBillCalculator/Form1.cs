using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalBillCalculator
{
    public partial class BillCalculator : Form
    {
        public BillCalculator()
        {
            InitializeComponent();
        }

        private void BillCalculator_Load(object sender, EventArgs e)
        {

        }

        private void NightCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void NightCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void medicalLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalLabel.Visible = true;
            totalDisplay.Visible = true;

            decimal stayTotal = CalcStayCharges(nightCount.Value);
            decimal miscTotal = CalcMiscCharges(numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value);
            decimal overallTotal = CalcTotalCharges(stayTotal, miscTotal);

            totalDisplay.Text = "$" + overallTotal.ToString();
        }

        private decimal CalcTotalCharges(decimal stayTotal, decimal miscTotal)
        {
            return stayTotal + miscTotal;
        }

        private decimal CalcStayCharges(decimal value)
        {
            return value * 350;
        }

        private decimal CalcMiscCharges(decimal value1, decimal value2, decimal value3, decimal value4)
        {
            return value1 + value2 + value3 + value4;
        }
    }
}
