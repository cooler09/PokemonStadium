using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStadium
{
    class Program
    {
        static void Main(string[] args)
        {

            Stadium pokemonStadium = new Stadium();
            Pokemon mew = new Pokemon
            {
                Health = 121,
                Strength = 10,
                Name = "Mew"
            };
            Pokemon mewTwo = new Pokemon
            {
                Health = 100,
                Strength = 12,
                Name = "MewTwo"
            };
            pokemonStadium.PokemonOne = mew;
            pokemonStadium.PokemonTwo = mewTwo;

            Pokemon winner = pokemonStadium.Battle();

            if (winner == null)
                Console.WriteLine("Stalemate");
            else
                Console.WriteLine($"{winner.Name} is the victor!");


            Console.ReadLine();
        }
    }
}
