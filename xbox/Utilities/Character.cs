using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_of_the_Neu_Republic.Utilities
{
    internal class Character : ICharacter
    {
        //general characteristics
        string name;
        int intelligence;
        int dexterity;
        int strength;
        int constitution;
        int charisma;
        int forcePower;
        int midichlorians;

        //stateful characteristic/derived characteristics
        int health;
        int reflexSave;
        int fortitudeSave;
        int willSave;
        int forceSave;

        //equiped items

        //behavior for equiping items

        public Character()
        {
            name = "";
            strength = 8;
            dexterity = 7;
            intelligence = 9;
            constitution = 5;
            forcePower = 5;
            midichlorians = 6;
            health = 6;
            charisma = 7;
        }

        public void move()
        {

        }

        private int attack()
        {
            return strength * 10;
        }

        public void defend(int damage)
        {
            health -= damage - dexterity;
        }

        //public virtual bool attemptAttack(int difficulty)
        //{
        //  //rng
        //  //return forcePower > difficulty;
        //}
    }
}
