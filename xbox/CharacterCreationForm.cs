
using Rise_of_the_Neu_Republic.Utilities;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ApplicationDev
{

    public partial class CharacterCreationForm : Form
    {
        private Player newCharacter;

        public CharacterCreationForm(Player player)
        {
            InitializeComponent();
            InitializeCharacter(player);
            BindCharacterProperties();

        }

        private void InitializeCharacter(Player player)
        {
            newCharacter = player;
        }
        private void BindCharacterProperties()
        {
            // Bind properties to form controls using data binding
            txtName.DataBindings.Add("Text", newCharacter, "Name");
            cmbCharacterClass.DataBindings.Add("Text", newCharacter, "Class");
            strInput.DataBindings.Add("Text", newCharacter, "Strength");
            constInput.DataBindings.Add("Text", newCharacter, "Constitution");
            rizInput.DataBindings.Add("Text", newCharacter, "Charisma");
            dexInput.DataBindings.Add("Text", newCharacter, "Dexterity");
            agilityInput.DataBindings.Add("Text", newCharacter, "Agility");
            intelInput.DataBindings.Add("Text", newCharacter, "Intelligence");

            // newCharacter.items.Add(new Inventory("Sword", 5, "Strength"));
            // Bind other properties as needed
        }

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            // Save character attributes
            newCharacter.Name = txtName.Text;
            newCharacter.Class = cmbCharacterClass.SelectedItem?.ToString();
            newCharacter.Strength = int.Parse(strInput.Text);
            newCharacter.Agility = int.Parse(agilityInput.Text);
            newCharacter.Intelligence = int.Parse(intelInput.Text);
            newCharacter.Dexterity = int.Parse(dexInput.Text);
            newCharacter.Constitution = int.Parse(constInput.Text);
            newCharacter.Charisma = int.Parse(rizInput.Text);
            newCharacter.Health = 6 * newCharacter.Constitution;

            // Optionally validate input

            // Close the form or perform other actions
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }



}