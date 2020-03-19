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
        //Rock Paper Scissors Game

        //Player plays against the computer, or "Black Cat"

        //As opposed to choosing a random integer on load, I set the enemy selection
        //to when the player hits "Throw!" so that this can be easily replayed

        int playerSelection;
        int enemySelection;
        int playerScore = 0;
        int enemyScore = 0;
        int originalY;

        Random randomNumber;
        Button[] enemyOptions = new Button[3];
        Button[] playerButtons = new Button[3];

        public RPS_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enemyOptions[0] = enemyRock;
            enemyOptions[1] = enemyPaper;
            enemyOptions[2] = enemyScissors;

            playerButtons[0] = button_Rock;
            playerButtons[1] = button_Paper;
            playerButtons[2] = button_Scissors;

            EnableThrowButton(false);

            originalY = playerButtons[0].Location.Y;
        }


        private void button_Rock_Click(object sender, EventArgs e)
        {
            playerSelection = 0;
            MovePlayerButtons(playerSelection);
        }

        private void button_Paper_Click(object sender, EventArgs e)
        {
            playerSelection = 1;
            MovePlayerButtons(playerSelection);
        }

        private void button_Scissors_Click(object sender, EventArgs e)
        {
            playerSelection = 2;
            MovePlayerButtons(playerSelection);
        }

        private void throwButton_Click(object sender, EventArgs e)
        {
            EnableThrowButton(false);

            SetEnemySelection();
            DisplayResult();
        }

        private void MovePlayerButtons(int button)
        {
            //Enable the Throw Button here so that it's only useable after a selection is made
            EnableThrowButton(true);


            //Disable label visibility while selecting a throw
            resultLabel.Visible = false;

            ResetEnemySelections();
            ResetPlayerButtons();

            //Move the position of the current selection up to give the player visual feedback
            playerButtons[button].Location = new Point(playerButtons[button].Location.X, originalY - 80);
        }

        private void SetEnemySelection()
        {
            ResetEnemySelections();
            randomNumber = new Random();
            enemySelection = randomNumber.Next(0, enemyOptions.Length);
            enemyOptions[enemySelection].Visible = true;
        }

        private void ResetEnemySelections()
        {
            foreach (Button enemyThrow in enemyOptions)
            {
                enemyThrow.Visible = false;
            }
        }

        private void DisplayResult()
        {
            resultLabel.Text = "You " + GetResult() + "!";
            resultLabel.Visible = true;

            DisplayScore();
        }

        private void DisplayScore()
        {
            playerScoreLabel.Text = "Wins: " + playerScore;
            enemyScoreLabel.Text = "Wins: " + enemyScore;
        }

        private string GetResult()
        {
            if (playerSelection == enemySelection)
            { return "Tied"; }
            else if (playerSelection > enemySelection && enemySelection != playerSelection - 2)
            {
                playerScore += 1;
                return "Won";
            }
            else
            {
                enemyScore += 1;
                return "Loss";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetPlayerButtons();

            EnableThrowButton(false);
            playerScore = 0;
            enemyScore = 0;

            DisplayScore();
            resultLabel.Visible = false;

            ResetEnemySelections();
        }

        private void EnableThrowButton(bool isEnabled)
        {
            throwButton.Visible = isEnabled;
            throwButton.Enabled = isEnabled;
        }

        private void ResetPlayerButtons()
        {
            //For Each loop would have worked fine here as well
            for (int i = 0; i < playerButtons.Length; i++)
            {
                //Resets all buttons to their original location.
                //As the X axis is never changed, we'll use it's current position to set it.
                playerButtons[i].Location = new Point(playerButtons[i].Location.X, originalY);
            }
        }
    }
}
