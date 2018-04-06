using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStadium
{
    public class Stadium
    {
        public Pokemon PokemonOne;
        public Pokemon PokemonTwo;

        public Pokemon Battle()
        {
            while(PokemonOne.Health > 0 && PokemonTwo.Health > 0)
            {
                PokemonOne.Attack(PokemonTwo);
                //Add break if one faints
                PokemonTwo.Attack(PokemonOne);
            }

            if (PokemonOne.Health <= 0 && PokemonTwo.Health <= 0)
                return null;
            else if (PokemonOne.Health <= 0)
                return PokemonTwo;
            else if (PokemonTwo.Health <= 0)
                return PokemonOne;
            else
                return null;
        }
    }
}
