using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    internal class Spheal : Pokemon
    {
        public Spheal()
        {
            this.Species = "Clap Pokémon";
            this.Type1 = PokemonType.Ice;
            this.Type2 = PokemonType.Water;
            this.Height = 0.8;
            this.Weight = 39.5;
            this.HP = 70;
            this.Attack = 40;
            this.Defense = 50;
            this.SpecialAttack = 55;
            this.SpecialDefense = 50;
            this.Speed = 25;
            this.Total = 290;
            this.Name = "Spheal";
            this.imge = Resource1.ResourceManager.GetObject("spheal") as byte[] ?? Array.Empty<Byte>();
        }
    }
}
