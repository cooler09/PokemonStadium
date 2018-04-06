using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStadium
{
    public class Pokemon
    {
        public string Name;
        public int Health;
        public int Strength;

        public void Attack(Pokemon enemy)
        {
            enemy.TakeDamage(Strength);
        }

        public void TakeDamage(int damage)
        {
            Health -=damage;
        }

    }
}
