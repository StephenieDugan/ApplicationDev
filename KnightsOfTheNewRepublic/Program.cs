using KnightsOfTheNewRepublic.GameLogic.Character;
using KnightsOfTheNewRepublic.GameLogic.Dialogue;

namespace KnightsOfTheNewRepublic;

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
        Application.Run(FormManager.Current);

        Character myCharacter = new Character();
        NonPlayerCharacter generalGrevious = new NonPlayerCharacter();
        generalGrevious.dialogue = new Dialogue();

        // violence start response
        Response violenceStart = new Response();
        violenceStart.responseText = "VIOLENCE!!!";

        // romance continuation
        Response romanceContinuation = new Response();

        // romance start response
        Response romanceStart = new Response();
        romanceStart.responseText = "Oh Obi, I didn't know you cared so...";
        romanceStart.dialogueOptions.Add(
            "I've always cared.",
            romanceContinuation
            );
        romanceStart.dialogueOptions.Add(
            "PSYCH!!",
            violenceStart
            );

        // dialogue start response
        Response startOfDialogue = new Response();
        startOfDialogue.responseText = "General Kenobi!";
        startOfDialogue.dialogueOptions.Add(
            "How've you been",
            romanceStart
            );
        startOfDialogue.dialogueOptions.Add(
            "SARCASM!!!",
            violenceStart
            );

        generalGrevious.dialogue.dialogueStart = startOfDialogue;


        // show the player dialoge
        Response currentReponse = generalGrevious.dialogue.dialogueStart;

        // player has chosen romance
        currentReponse = currentReponse.dialogueOptions["How've you been"];
        // show the player the next set of dialog options
        string[] playerOptions = currentReponse.dialogueOptions.Keys.ToArray();
        // the player chooses violence
        currentReponse = currentReponse.dialogueOptions["PSYCH!!!"];
        playerOptions = currentReponse.dialogueOptions.Keys.ToArray();
        if ( playerOptions.Length == 0 )
        {
            // dialogue has ended
        }

    }    
}