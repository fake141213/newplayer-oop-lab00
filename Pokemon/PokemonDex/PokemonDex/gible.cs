using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    internal class Gible : Pokemon
    {
        public Gible()
        {
            this.Species = "Land Shark Pokémon";
            this.Type1 = PokemonType.Dragon;
            this.Type2 = PokemonType.Ground;
            this.Height = 0.7;
            this.Weight = 20.5;
            this.HP = 58;
            this.Attack = 70;
            this.Defense = 45;
            this.SpecialAttack = 40;
            this.SpecialDefense = 42;
            this.Speed = 42;
            this.Total = 300;
            this.Name = "Gible";
            this.imge = Resource1.ResourceManager.GetObject("gible") as byte[] ?? Array.Empty<Byte>();

        }
    }
}
