namespace CrackSafeWindNet;

public partial class Form1 : Form
{
    Random random = new Random();
    List<Label> lblResults = new List<Label>();
    List<PictureBox> picResults = new List<PictureBox>();

    int answer = 0;
    int numGuess = 0;
    int intRandomMax = 0;
    public Form1()
    {
        InitializeComponent();
        InitializeGame();
        ResetGame();

        //checkBox1.CheckedChanged += ColorChanger;
    }

    public void ColorChanger(Object sender, EventArgs e)
    {
        checkBox1.ForeColor = Color.DarkRed;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void InitializeGame()
    {
        lblResults.Add(label1);
        lblResults.Add(label2);
        lblResults.Add(label3);
        lblResults.Add(label4);
        lblResults.Add(label5);
        lblResults.Add(label6);

        picResults.Add(pictureBox1);
        picResults.Add(pictureBox2);
        picResults.Add(pictureBox3);
        picResults.Add(pictureBox4);
        picResults.Add(pictureBox5);
    }

    private void ResetGame()
    {
        foreach (Label labels in lblResults)
        {
            labels.Text = "";
        }

        foreach (PictureBox pics in picResults)
        {
            pics.Image = null;
        }

        txtGuess.Enabled = false;
        btnStart.Enabled = true;
        btnStart.Text = "Start";
        numGuess = 0;
    }

    private void StartGame()
    {
        answer = random.Next(1, intRandomMax + 1);
        txtGuess.Enabled = true;
        btnStart.Text = "Reset";
        lblResults[5].Text = " range of 1 to " + intRandomMax.ToString();
    }

    private void GameWon()
    {
        txtGuess.Enabled = false;
        lblResults[5].Text = " You Won!!!!";
    }

    private void GameLost()
    {
        txtGuess.Enabled = false;
        lblResults[5].Text = " you Lost, Try again??";
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        if (btnStart.Text == "Start")
        {
            StartGame();
        }
        else
        {
            ResetGame();
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton rbEasy = (RadioButton)sender;
        if (rbEasy.Checked)
        {
            intRandomMax = 10;
        }
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton rbMedium = (RadioButton)sender;
        if (rbMedium.Checked)
        {
            intRandomMax = 20;
        }
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton rbHard = (RadioButton)sender;
        if (rbHard.Checked)
        {
            intRandomMax = 50;
        }
    }
}
