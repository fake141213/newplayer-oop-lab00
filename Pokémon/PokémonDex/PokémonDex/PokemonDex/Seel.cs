using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex.PokemonDex
{
    internal class Seel : Pokemon
    {
        public Seel()
        {
            this.Species = "Sea Lion Pokémon";
            this.Type1 = PokemonType.Warer;
            this.Height = 1.1;
            this.Weight = 90.0;
            this.HP = 65;
            this.Attack = 45;
            this.Defense = 55;
            this.SpecialAttack = 45;
            this.SpecialDefense = 70;
            this.Speed = 45;
            this.Total = 325;
            this.Name = "Seel";
            this.imge = Resource1.ResourceManager.GetObject("seel") as byte[] ?? Array.Empty<Byte>();
        }
    }
}
