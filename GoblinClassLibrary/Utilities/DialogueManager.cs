using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Place this class in the Rise_of_the_Neu_Republic.Utilities namespace
namespace GoblinClassLibrary
{
    internal class DialogueManager
    {
        public Dialogue CurrentDialogue { get; private set; }

        public void LoadDialogue(Dialogue dialogue)
        {
            CurrentDialogue = dialogue;
        }
    }
}

