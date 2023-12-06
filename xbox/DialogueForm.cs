using GoblinClassLibrary;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ApplicationDev
{

    public partial class DialogueForm : Form
    {
        Player playerCharacter;
        Enemy enemyCharacter;

        public DialogueForm(Player player, Enemy enemy)
        {
            playerCharacter = player;
            enemyCharacter = enemy;
            InitializeComponent();
            lblStrength.Text = playerCharacter.Strength.ToString();
            lblAgility.Text = playerCharacter.Agility.ToString();
            lblIntel.Text = playerCharacter.Intelligence.ToString();
            lblDex.Text = playerCharacter.Dexterity.ToString();
            lblConst.Text = playerCharacter.Constitution.ToString();
            lblRiz.Text = playerCharacter.Charisma.ToString();
            lblDialogue.Text = "Hello " + playerCharacter.Name;

        }
        private void btnOption1_Click(object sender, EventArgs e)
        {
            //Handle option 1
            if (btnOption1.Text == "Hi!")
            {
                playerCharacter.Charisma += 2;
                lblDialogue.Text = "It's been so long since we've seen you pass through.\nWhat's been happening?";
                btnOption1.Text = "Oh, nothing much really.";
                btnOption2.Text = "I've been taking odd jobs mostly";
            }
            else if (btnOption1.Text == "Oh, nothing much really.")
            {
                playerCharacter.Charisma += 2;
                lblDialogue.Text = "Hmmmm, well there is always something happening in NeuCountry, I'm sure you'll find something to do. :)";
                btnOption1.Text = "Thanks, any recommendations?";
                btnOption2.Text = "Absolutely, I best be going now.";
            }
            else if (btnOption1.Text == "Nothing really.")
            {
                lblDialogue.Text = "Not much of a talker this time, I see. that's alright, could i trouble you for some help though?";
                btnOption1.Text = "Sure";
                btnOption2.Text = "Nah, bye";
            }
            else if (btnOption1.Text == "Thanks, any recommendations?")
            {
                lblDialogue.Text = "Of course! Have this Sword as gratitude. " +
                    "\nFirst up is a skeleton making some noise god awful at night and we'd really appreciate" + 
                    "\nthe finally peaceful night. Last is a slime gooing up and destroying our crops. What'll it be?";
                playerCharacter.hasSword = true;
                btnOption1.Text = "Skeleton";
                btnOption2.Text = "Slime";
            }
            else if (btnOption1.Text == "Sure")
            {
                lblDialogue.Text = "Amazing! Have this sheild for protection." +
                    "\nFirst up is a skeleton making some noise god awful at night and we'd really appreciate" + 
                    "\nthe finally peaceful night. Last is a slime gooing up and destroying our crops. What'll it be?";
                playerCharacter.hasShield = true;
                playerCharacter.hasSword = true;
                btnOption1.Text = "Skeleton";
                btnOption2.Visible = true;
                btnOption2.Text = "Slime";
            }
            else if (btnOption1.Text == "Skeleton")
            {
                enemyCharacter.monsterIndex = 0;
                this.Close();
            }
        }
        private void btnOption2_Click(object sender, EventArgs e)
        {
            //handle option 2
            if (btnOption2.Text == "Go Away")
            {
                playerCharacter.Charisma -= 1;
                lblDialogue.Text = "Oh,................\nIt's been so long since we've seen you still.\nWhat's been happening?";
                btnOption1.Text = "Nothing really.";
                btnOption2.Text = "Do you have any jobs for me?";
            }
            else if (btnOption2.Text == "I've been taking odd jobs mostly")
            {
                lblDialogue.Text = "Is that so? well your in luck it seems cause we have some pesky monsters in the area." +
                    "\nFirst up is a skeleton making some noise god awful at night and we'd really appreciate the finally peaceful night." +
                    "\nlast is a slime gooing up and destroying our crops. What'll it be?";
                btnOption1.Text = "Skeleton";
                btnOption2.Text = "Slime";
            }
            else if (btnOption2.Text == "Do you have any jobs for me?")
            {
                playerCharacter.Charisma -= 4;
                lblDialogue.Text = "Jeez, busy I see. We have a skeleton roaming around that keeps making a racket" +
                    "\nat night, or we have a slime that's destroying our crops too." +
                    "\ntake your pick.";
                btnOption1.Text = "Skeleton";
                btnOption2.Text = "Slime";
            }
            else if (btnOption2.Text == "Absolutely, I best be going now.")
            {
                lblDialogue.Text = "Wait! I have some tasks for you.  We have a skeleton roaming around that keeps making a racket" +
                    "\nat night, and we have a slime that's destroying our crops too. we're offering to keep this sword to fight one of these monsters." +
                    "\nWill you? ";
                btnOption1.Text = "Sure";
                if (playerCharacter.Dexterity > 8)
                {
                    btnOption2.Text = "(Steal sword and run)";
                    playerCharacter.hasSword = true;
                    this.Close();
                }
                else
                {
                    btnOption2.Visible = false;
                }
            }
            else if (btnOption2.Text == "Nah, bye")
            {
                this.Close();
            }
            else if (btnOption2.Text == "Slime")
            {
                enemyCharacter.monsterIndex = 1;
                this.Close();
            }





        }

        // Add more event handlers as needed
    }
}