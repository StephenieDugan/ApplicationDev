

namespace KnightsOfTheNewRepublic;

public partial class Form1 : Form
{
    UI.Character playerCharacter;
    public Form1()
    {
        InitializeComponent();
        GameLogic.Character.Character gameCharacter = new GameLogic.Character.Character();
        playerCharacter = new UI.Character();
        playerCharacter.Strength = gameCharacter.strength;
        playerCharacter.Charisma = gameCharacter.charisma;

        initializeCharacterComponents();
    }

    private void initializeCharacterComponents()
    {
        strengthDisplay.DataBindings.Add("Text", playerCharacter, "strength", false, DataSourceUpdateMode.OnPropertyChanged);
        
        dexterityDisplay.DataBindings.Add("Text", playerCharacter, "dexterity", false, DataSourceUpdateMode.OnPropertyChanged);
        intelligenceDisplay.DataBindings.Add("Text", playerCharacter, "intelligence", false, DataSourceUpdateMode.OnPropertyChanged);
        constitutionDisplay.DataBindings.Add("Text", playerCharacter, "constitution", false, DataSourceUpdateMode.OnPropertyChanged);
        forcePowerDisplay.DataBindings.Add("Text", playerCharacter, "ForcePower", false, DataSourceUpdateMode.OnPropertyChanged);
        charismaDisplay.DataBindings.Add("Text", playerCharacter, "charisma", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    private void strengthInput_ValueChanged(object sender, EventArgs e)
    {
        int strengthToAdd = (int)strengthInput.Value;
        playerCharacter.Strength += strengthToAdd;
    }
}
