using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinClassLibrary
{
    public class CombatManager
    {
        public void PlayerAttack(Enemy enemy, Player player)
        {
            if (player.hasSword) { enemy.Health -=  player.Strength + 6;}
            else { enemy.Health -= player.Strength; }
           
        }
        public void PlayerCast(Enemy enemy, Player player)
        {
            enemy.Health -= player.Strength * 2; 
        }

        public void EnemyAttack(Enemy enemy, Player player)
        {
            // Logic for enemy's attack
            if(player.hasShield) { player.Health -= enemy.Strength - (player.Dexterity - 5); }
            else { player.Health -= enemy.Strength - player.Dexterity; }
           
        }

        // Add more methods for other actions
    }
}
