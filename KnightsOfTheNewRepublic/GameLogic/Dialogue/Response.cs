using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfTheNewRepublic.GameLogic.Dialogue
{
    internal class Response
    {
        public string responseText {get;set;}
        public Dictionary<string, Response> dialogueOptions { get; set; }
    }
}
