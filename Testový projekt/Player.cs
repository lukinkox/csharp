using ClassApp;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Player
    {
        private const int MaxHP =100;
        private const int MinHP = 0;
        private int CurrentHP = MaxHP;
        private int Playerdamage = 20;
        private List<string> inventory = new List<string>();
        private string Name;

        public bool DealDamage(Monster opponent)
        {
            opponent.TakeDamage(Playerdamage);
            return true;
        }

        internal void SetName(string? name)
        {
            Name = name;
        }


        internal void TakeDamage(int monsterDamage)
        {
         CurrentHP -= monsterDamage;
        }
    }
}
