using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class RPS_Form : Form
    {
        int playerSelection;
        int enemySelection;
        int[] enemyOptions;

        public RPS_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_Rock_Click(object sender, EventArgs e)
        {
            playerSelection = 1;
        }

        private void button_Paper_Click(object sender, EventArgs e)
        {
            playerSelection = 2;
        }

        private void button_Scissors_Click(object sender, EventArgs e)
        {
            playerSelection = 3;
        }


    }
}
