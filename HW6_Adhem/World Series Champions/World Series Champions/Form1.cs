using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace World_Series_Champions
{
    public partial class WSCForm : Form
    {
        public string path = @"C:\Classes\CIS217\HW6_Adhem\World Series Champions\World Series Champions";
        string[] teams;
        string[] winners;
        int[] wins;

        public WSCForm()
        {
            InitializeComponent();
        }

        private void WSCForm_Load(object sender, EventArgs e)
        {
            ReadFiles();

            DisplayTeams();
        }

        private void DisplayTeams()
        {
            for (int i = 0; i < teams.Length; i++)
            {
                TeamsListBox.Items.Add(teams[i]);

                foreach (string winner in winners)
                {
                    if (winner == teams[i])
                    {
                        wins[i] += 1;
                    }
                }
            }
        }

        void ReadFiles()
        {
            teams = File.ReadAllLines(path + @"\Teams.txt");
            winners = File.ReadAllLines(path + @"\WorldSeriesWinners.txt");
            wins = new int[teams.Length];
        }

        private void TeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = TeamsListBox.SelectedIndex;
            WinsText.Text = wins[selection].ToString();
        }

        private void WinsText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
