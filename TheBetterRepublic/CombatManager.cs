using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterRepublic.Utilities
{
    internal class CombatManager
    {
        public void StartCombat(Character player, Character enemy)
        {
            // Logic to initiate combat
        }

        public void PlayerAttack(Enemy enemy, Player player)
        {
            //int attack;
            // Logic for player's attack
            if (player.items.Count != 0)
            {
                //attack = player.Strength + player.items.Find(List<Inventory>("Sword", 5, "Strength")).Modifier;
            }
            enemy.Health -=  player.Strength;
        }

        public void EnemyAttack(Enemy enemy, Player player)
        {
            // Logic for enemy's attack
            player.Health -= enemy.Strength - player.Dexterity;
        }

        // Add more methods for other actions
    }
}
