namespace CrackSafeWindNet;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        checkBox1.Text = "cool";

        checkBox1.CheckedChanged += ColorChanger;
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
}
