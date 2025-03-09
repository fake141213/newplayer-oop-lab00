using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    internal class Mew : Pokemon
    {
        public Mew()
        {
            this.Species = "New Species Pokémon";
            this.Type1 = PokemonType.Psychic;
            this.Height = 0.4;
            this.Weight = 4.0;
            this.HP = 100;
            this.Attack = 100;
            this.Defense = 100;
            this.SpecialAttack = 100;
            this.SpecialDefense = 100;
            this.Speed = 100;
            this.Total = 600;
            this.Name = "Mew";
            this.imge = Resource1.ResourceManager.GetObject("mew") as byte[] ?? Array.Empty<Byte>();

        }
    }
}
