
using ConsoleApp1;
using System.Transactions;

namespace ClassApp
{
    public class Monster
    {
        private const int maxHP = 200;
        private const int minHP = 0;
        private int CurrentHP;
        private int monsterDamage = 1;

        internal void DealDamage(Player player)
        {
            player.TakeDamage(monsterDamage);
        }

        internal void TakeDamage(int damage)
        {
            CurrentHP -= damage;
        }

    }
}