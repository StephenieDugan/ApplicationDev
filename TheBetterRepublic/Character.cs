using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterRepublic.Utilities
{
    public class Character
    {
        public string Name { get; set; } = "player";
        public string Class { get; set; } = "Wizard";
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }
        public int Health { get; set; }
        // Add other properties as needed

    }
}
