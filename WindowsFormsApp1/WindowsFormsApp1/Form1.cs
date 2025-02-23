using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int timeElapsed;
        private int score;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }
        private void ResetGame()
        {
            Random rnd = new Random();
            targetNumber = rnd.Next(0, 101);
            timeElapsed = 0;
            score = 100;
            lblPoints.Text = "Point: 100";
            lblTimeRemaining.Text = "Time Remaining: 0";
            lblHint.Text = "";
            txtGuess.Text = "";
            timer1.Stop();
            timer1.Interval = 1000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }

            if (int.TryParse(txtGuess.Text, out int userGuess))
            {
                if (userGuess < targetNumber)
                {
                    lblHint.Text = "Higher!";
                }
                else if (userGuess > targetNumber)
                {
                    lblHint.Text = "Lower!";
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show($"Congratulations! You found the number in {timeElapsed} seconds.\nYour final score: {score}", "You Win!");
                    ResetGame();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Invalid Input");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            lblTimeRemaining.Text = "Time Remaining: " + timeElapsed;


            if (timeElapsed <= 10) score = 100;
            else if (timeElapsed <= 20) score = 90;
            else if (timeElapsed <= 30) score = 80;
            else if (timeElapsed <= 40) score = 70;
            else if (timeElapsed <= 50) score = 60;
            else if (timeElapsed <= 60) score = 50;
            else score = 0;

            lblPoints.Text = "Point: " + score;

            if (score == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up! You lost the game.", "Game Over");
                ResetGame();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try to guess the number between 0 and 100.\nIf your guess is incorrect, you will get hints.\nThe faster you guess, the higher your score!", "How to Play");
        }
    }
}
