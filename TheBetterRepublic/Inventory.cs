using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterRepublic.Utilities
{
    public class Inventory
    {
        public string Item;
        public string ModType;
        public int Modifier;
        public Inventory(string itemName, int modifier, string modType) 
        {
            Item = itemName;
            ModType = modType;
            Modifier = modifier;
        }
    }
}
