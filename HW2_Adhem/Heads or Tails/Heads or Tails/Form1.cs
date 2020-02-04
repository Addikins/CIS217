using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class HeadsOrTails : Form
    {
        public HeadsOrTails()
        {
            InitializeComponent();
        }


        private void showHeadsButton_Click(object sender, EventArgs e)
        {
            coinHeads.Visible = true;
            coinTails.Visible = false;
        }

        private void showTailsButton_Click(object sender, EventArgs e)
        {
            coinHeads.Visible = false;
            coinTails.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
