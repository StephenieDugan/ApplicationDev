using GoblinClassLibrary;
using System.Xml.Linq;

namespace GoblinClassLibrary.Utilities
{
    public class GameLogic
    {
        public void CreateCharacter(Player player, string name, string characterClass, int strength, int agility, int intelligence)
        {
            // Bind properties to form controls using data binding
           /* name.DataBindings.Add("Text", player, "Name");
            cmbCharacterClass.DataBindings.Add("Text", newCharacter, "Class");
            strInput.DataBindings.Add("Text", newCharacter, "Strength");
            constInput.DataBindings.Add("Text", newCharacter, "Constitution");
            rizInput.DataBindings.Add("Text", newCharacter, "Charisma");
            dexInput.DataBindings.Add("Text", newCharacter, "Dexterity");
            agilityInput.DataBindings.Add("Text", newCharacter, "Agility");
            intelInput.DataBindings.Add("Text", newCharacter, "Intelligence");*/


        }

        public Dialogue GetNextDialogue()
        {
            // Logic for fetching the next dialogue
            return new Dialogue();
        }

        public void HandleCombatAction()
        {
            // Logic for turn-based combat
        }

        // Other game logic methods...
    }
}