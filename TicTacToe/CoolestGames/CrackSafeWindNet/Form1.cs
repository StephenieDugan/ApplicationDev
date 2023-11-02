using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CrackSafeWindNet;

public partial class Form1 : Form
{
    private Random random = new Random();
    private List<Label> lblResults = new List<Label>();
    List<string> guessHistory = new List<string>();
    private int[] safeNumbers = new int[3];
    private int numTurn = 0;
    private int maxTurns = 10;
    public Form1()
    {
        InitializeComponent();
        pictureBoxCorrect.Image = Properties.Resources.open_lock;
        pictureBoxClose.Image = Properties.Resources.Working_on_lock;
        pictureBoxFail.Image = Properties.Resources.Locked_lock;
        InitializeGame();
        ResetGame();

    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void InitializeGame()
    {
        lblResults.Add(label1);
        lblResults.Add(label2);
        lblResults.Add(label3);
        lblResults.Add(label4);

        pictureBoxCorrect.Visible = false;
        pictureBoxClose.Visible = false;
        pictureBoxFail.Visible = true;

        safeNumbers[0] = random.Next(10);
        safeNumbers[1] = random.Next(10);
        safeNumbers[2] = random.Next(10);
    }

    private void ResetGame()
    {
        foreach (Label label in lblResults)
        {
            label.Text = "";
            label.ForeColor = Color.Black;
        }
        pictureBoxCorrect.Visible = false;
        pictureBoxClose.Visible = false;
        pictureBoxFail.Visible = true;
        guessHistory.Clear();
        numTurn = 0;
        UpdateLog("New game started.");
        txtGuess1.Text = txtGuess2.Text = txtGuess3.Text = "";
        btnCheat.Enabled = true;
        btnStart.Text = "Start";
        safeNumbers[0] = random.Next(10);
        safeNumbers[1] = random.Next(10);
        safeNumbers[2] = random.Next(10);
    }
    private void UpdateLog(string message)
    {
        lblResults[3].Text = lblResults[1].Text;
        lblResults[3].Text = message;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        if (btnStart.Text == "Start")
        {
            ResetGame();
            txtGuess1.Enabled = txtGuess2.Enabled = txtGuess3.Enabled = true;
            btnStart.Text = "Reset";
            btnCheat.Enabled = true;
        }
        else
        {
            ResetGame();
        }
    }


    private void SubmitGuess()
    {
        int guess1, guess2, guess3;

        if (int.TryParse(txtGuess1.Text, out guess1) &&
            int.TryParse(txtGuess2.Text, out guess2) &&
            int.TryParse(txtGuess3.Text, out guess3))
        {
            int correctCount = 0;
            bool[] close = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                if (safeNumbers[i] - guess1 == 1 || safeNumbers[i] - guess1 == -1
                    || safeNumbers[i] - guess2 == 1 || safeNumbers[i] - guess2 == -1
                    || safeNumbers[i] - guess3 == 1 || safeNumbers[i] - guess3 == 1)
                {
                    close[i] = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (safeNumbers[i] == guess1 || safeNumbers[i] == guess2 || safeNumbers[i] == guess3)
                {
                    correctCount++;
                    lblResults[i].Text = "Correct!";
                    lblResults[i].ForeColor = Color.Green;
                    pictureBoxCorrect.Visible = true;
                    pictureBoxClose.Visible = false;
                    pictureBoxFail.Visible = false;
                }
                else if (close[i])
                {
                    lblResults[i].Text = "Close";
                    lblResults[i].ForeColor = Color.Blue;
                    pictureBoxCorrect.Visible = false;
                    pictureBoxClose.Visible = true;
                    pictureBoxFail.Visible = false;
                }
                else
                {
                    lblResults[i].Text = "Not close";
                    lblResults[i].ForeColor = Color.Red;
                    pictureBoxCorrect.Visible = false;
                    pictureBoxClose.Visible = false;
                    pictureBoxFail.Visible = true;
                }

            }

            string guessStatus = $"{txtGuess1.Text.PadLeft(2)} - {lblResults[0].Text} {txtGuess2.Text.PadLeft(2)} - {lblResults[1].Text} {txtGuess3.Text.PadLeft(2)} - {lblResults[2].Text}";
            guessHistory.Insert(0, guessStatus); // Insert the guess status at the beginning of the list

            // Clear existing controls from the TableLayoutPanel
            tableLayoutPanel1.Controls.Clear();

            // Add the guess history to the TableLayoutPanel
            for (int i = 0; i < guessHistory.Count; i++)
            {
                Label lblGuessInfo = new Label
                {
                    Text = guessHistory[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true
                };
                tableLayoutPanel1.Controls.Add(lblGuessInfo, 0, i);
            }

            numTurn++;
            if (correctCount == 3)
            {
                UpdateLog("Congratulations! You Won! Play Again?");
                txtGuess1.Enabled = txtGuess2.Enabled = txtGuess3.Enabled = false;
                btnStart.Text = "Start";
            }
            else if (numTurn >= maxTurns)
            {
                UpdateLog("You're out of turns. Game over. Play Again?");
                txtGuess1.Enabled = txtGuess2.Enabled = txtGuess3.Enabled = false;
                btnStart.Text = "Start";
            }
            else
            {
                UpdateLog("Turn " + numTurn + " completed.");
            }
        }
        else
        {
            MessageBox.Show("Please enter valid numbers in all three boxes.");
        }
    }
    private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            SubmitGuess();
        }
    }

    private void btnCheat_Click(object sender, EventArgs e)
    {
        lblResults[0].Text = "Cheat: " + safeNumbers[0];
        lblResults[1].Text = "Cheat: " + safeNumbers[1];
        lblResults[2].Text = "Cheat: " + safeNumbers[2];
        btnCheat.Enabled = false;
    }

    private void btnGuess_Click(object sender, EventArgs e)
    {
        SubmitGuess();
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Dispose();
    }


}
