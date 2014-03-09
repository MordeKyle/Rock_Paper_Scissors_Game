using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Program: Rock Paper Scissors Game
  Author: Kyle McBride A02609917
  Date: 03/09/2014
  Description: Application that lets the user play the game of Rock, Paper, Scissors against the computer.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        //declaring variables
        private const int winConstant = 1;
        private const int loseConstant = -1;
        private const int drawConstant = 0;
        private int resultHolder;
        private const int userInputConstant = 2;
        private int computerChoice;
        private string winString = "You Won!";
        private string loseString = "You lost";
        private string drawString = "Draw";
        private string paperString = "Paper";
        private string rockString = "Rock";
        private string scissorsString = "Scissors";

        public Form1()
        {
            InitializeComponent();
        }

        private void assignCompChoice()
        {
            Random rand = new Random();
            computerChoice = rand.Next(3) + 1;
        }

        private void calculateResults()
        {
            resultHolder = userInputConstant - computerChoice;
        }

        private void rockSelected()
        {
            if (resultHolder == 1)
            {
                computerChoiceLabel.Text = scissorsString;
                resultLabel.Text = winString;
            }
            else if (resultHolder == -1)
            {
                computerChoiceLabel.Text = paperString;
                resultLabel.Text = drawString;
            }
            else
            {
                computerChoiceLabel.Text = rockString;
                resultLabel.Text = drawString;
            }
        }

        private void paperSelected()
        {
            if (resultHolder == 1)
            {
                computerChoiceLabel.Text = rockString;
                resultLabel.Text = winString;
            }
            else if (resultHolder == -1)
            {
                computerChoiceLabel.Text = scissorsString;
                resultLabel.Text = loseString;
            }
            else
            {
                computerChoiceLabel.Text = paperString;
                resultLabel.Text = drawString;
            }
        }

        private void scissorsSelected()
        {
            if (resultHolder == 1)
            {
                computerChoiceLabel.Text = paperString;
                resultLabel.Text = winString;
            }
            else if (resultHolder == -1)
            {
                computerChoiceLabel.Text = rockString;
                resultLabel.Text = loseString;
            }
            else
            {
                computerChoiceLabel.Text = scissorsString;
                resultLabel.Text = drawString;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                assignCompChoice();

                calculateResults();

                if (rockRad.Checked)
                {
                    rockSelected();
                }
                else if (paperRad.Checked)
                {
                    paperSelected();
                }
                else
                {
                    scissorsSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
