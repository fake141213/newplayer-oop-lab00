using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex.PokemonDex
{
    internal class Celebi : Pokemon
    {
        public Celebi()
        {
            this.Species = "Time Travel Pokémon";
            this.Type1 = PokemonType.Psychic;
            this.Type2 = PokemonType.Grass;
            this.Height = 0.6;
            this.Weight = 5.0;
            this.HP = 100;
            this.Attack = 100;
            this.Defense = 100;
            this.SpecialAttack = 100;
            this.SpecialDefense = 100;
            this.Speed = 100;
            this.Total = 600;
            this.Name = "Celebi";
            this.imge = Resource1.ResourceManager.GetObject("celebi") as byte[] ?? Array.Empty<Byte>();
        }
    }
}
