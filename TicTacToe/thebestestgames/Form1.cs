namespace thebestestgames;

public partial class Form1 : Form
{
      PictureBox[] playerpos = { PlayerStart, PlayerImage2, PlayerImage3, PlayerImage4, PlayerImage5 };
      Player player = new Player(playerpos,0);


    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        char keyPressed = Char.ToLower(e.KeyChar);
        switch (e.KeyChar)
        {
            case 'a':
                playerpos++;
                player.move(playerpos);
                break;
            case 'd':
                playerpos--;
                player.move(playerpos);
                break;
            case 's':
                break;
            case 'w':
                break;
        }
    }
}
