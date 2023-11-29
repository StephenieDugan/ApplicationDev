using Rise_of_the_Neu_Republic.Utilities;

namespace ApplicationDev;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Player player = new();
        Enemy enemy = new();
        //DialogueManager manager = new();
        Application.Run(new CharacterCreationForm(player));
        Application.Run(new DialogueForm(player,enemy));
        Application.Run(new CombatForm(player,enemy));

    }    
}