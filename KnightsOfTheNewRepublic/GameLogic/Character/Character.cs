using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightsOfTheNewRepublic.GameLogic.Character
{
    internal class Character : ICharacter
    {
        // general characteristics
        string name;
        // stats
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int strength { get;set; }
        
        public int charisma { get; set; }
        public int forcePower { get; set; }
        public int midichlorians { get; set; }

        // stateful characteristics/
        int health;
        // position?


        //derived characeristics
        int reflexSave;
        int fortitudeSave;
        int willSave;
        int forceSave;
        int speed;


        public Character()
        {
            strength = 8;
            dexterity = 8;
            intelligence = 8;
            constitution = 8;
            forcePower = 8;
            midichlorians = 8;
            charisma = 8;
        }

        
        // equiped items

        // behavior for equiping items?

        public void move()
        {

        }

        //public virtual bool attemptAttack(int difficulty)
        //{
        //    return false;
        //}

        public int performAttack()
        {
            // does attack stuff
            return strength * 10;
        }

        public void defend(int incomingDamage) 
        {
            health -= incomingDamage - dexterity;
        }
    }
}
