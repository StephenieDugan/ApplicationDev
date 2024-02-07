
using GoblinClassLibrary;
using Microsoft.Maui.Controls;

namespace MauiAppGobs;

    public partial class CharacterCreationPage : ContentPage
    {
        private Player newCharacter;

        public CharacterCreationPage()
        {
            InitializeComponent();
            newCharacter = new Player();
            BindingContext = newCharacter;
        }

        private void OnCreateCharacterClicked(object sender, EventArgs e)
        {
            // Save character attributes
            newCharacter.Name = txtName.Text;
           // newCharacter.Class = cmbCharacterClass.SelectedItem?.ToString();
           // newCharacter.Strength = int.Parse(strInput.Text);
           // newCharacter.Agility = int.Parse(agilityInput.Text);
            // ... other properties ...

            // Optionally validate input

            // Close the page or perform other actions
            // Navigation.PopAsync(); // Use this if you're navigating back
        }
    }
