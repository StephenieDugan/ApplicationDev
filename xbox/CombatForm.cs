using GoblinClassLibrary;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ApplicationDev
{
    public partial class CombatForm : Form
    {
        private CombatManager combatManager;
        private Player playerCharacter;
        private Enemy enemyCharacter;

        public CombatForm(Player player, Enemy enemy)
        {
            InitializeComponent();
            playerCharacter = player;
            enemyCharacter = enemy;
            InitializeCombat();
            BindCombatStats();

            if (enemyCharacter.Health <= 0)
            {
                lblWinLose.Text = "You Won!!!!";
            }
            if (playerCharacter.Health <= 0)
            {
                lblWinLose.Text = "You Lost. Better luck next time";
            }
        }

        private void InitializeCombat()
        {
            combatManager = new CombatManager();

        }

        private void BindCombatStats()
        {
            // Bind combat stats to form controls using data binding
            playerCharacter.Health = 6 * playerCharacter.Constitution;
            lblName.Text = playerCharacter.Name;
            lblClass.Text = playerCharacter.Class;
            lblPlayerHealth.Text = playerCharacter.Health.ToString();
            lblStrength.Text = playerCharacter.Strength.ToString();
            lblAgility.Text = playerCharacter.Agility.ToString();
            lblIntel.Text = playerCharacter.Intelligence.ToString();
            lblDex.Text = playerCharacter.Dexterity.ToString();
            lblConst.Text = playerCharacter.Constitution.ToString();
            lblRiz.Text = playerCharacter.Charisma.ToString();
            InitEnemy();
            lblEnemyHealth.Text = enemyCharacter.Health.ToString();
            lblEnemyName.Text = enemyCharacter.Name;
            lblEnemyClass.Text = enemyCharacter.Class;

            if (playerCharacter.hasShield) { lblhasShield.Text = "Shield"; }
            if (playerCharacter.hasSword) { lblhasSword.Text = "Sword"; }
            if (playerCharacter.Class == "Wizard" || playerCharacter.Class == "Sorcerer" || playerCharacter.Class == "Warlock" || playerCharacter.Class == "Druid" || playerCharacter.Class == "Paladin") { btnCastSpell.Visible = true; }

            lblNarrate.Text = "You've found the " + enemyCharacter.Class;
            // Add more bindings as needed
        }

        private void InitEnemy()
        {
            // Save character attributes
            enemyCharacter.Name = "The Big Bad";
            enemyCharacter.Class = enemyCharacter.getType(enemyCharacter.monsterIndex);
            if (enemyCharacter.monsterIndex == 0)
            {
                enemyCharacter.Strength = 8;
                enemyCharacter.Agility = 6;
                enemyCharacter.Intelligence = 4;
                enemyCharacter.Dexterity = 5;
                enemyCharacter.Constitution = 3;
                enemyCharacter.Charisma = 2;
                enemyCharacter.Health = 6 * enemyCharacter.Constitution; //health = 18
            }
            else
            {
                enemyCharacter.Strength = 5;
                enemyCharacter.Agility = 2;
                enemyCharacter.Intelligence = 1;
                enemyCharacter.Dexterity = 3;
                enemyCharacter.Constitution = 7;
                enemyCharacter.Charisma = 1;
                enemyCharacter.Health = 6 * enemyCharacter.Constitution;
            }
        }

        private void AttackEnemy_Click(object sender, EventArgs e)
        {
            combatManager.PlayerAttack(enemyCharacter, playerCharacter);
            lblEnemyHealth.Text = enemyCharacter.Health.ToString();
            lblNarrate.Visible = false;
        }

        private void DefendPlayer_Click(object sender, EventArgs e)
        {
            combatManager.EnemyAttack(enemyCharacter, playerCharacter);
            lblPlayerHealth.Text = playerCharacter.Health.ToString();
            lblNarrate.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combatManager.PlayerCast(enemyCharacter, playerCharacter);
            lblEnemyHealth.Text = enemyCharacter.Health.ToString();
            lblNarrate.Visible = false;
        }
    }
}