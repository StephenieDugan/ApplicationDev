using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_of_the_Neu_Republic.Utilities
{
    public class Enemy: Character
    {
        protected List<String> enemyTypes = new List<String>{"Skeleton","Slime"};
        public int monsterIndex { get; set; } = 1;

        public string getType(int index)
        {
            return enemyTypes[index];
        }
    }
}
