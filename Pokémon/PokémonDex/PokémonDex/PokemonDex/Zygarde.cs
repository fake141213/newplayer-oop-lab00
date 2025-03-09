using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex.PokemonDex
{
    internal class Zygarde : Pokemon
    {
        public Zygarde()
        {
            this.Species = "Order Pokémon";
            this.Type1 = PokemonType.Dragon;
            this.Type2 = PokemonType.Ground;
            this.Height = 5.0;
            this.Weight = 305.0;
            this.HP = 108;
            this.Attack = 100;
            this.Defense = 121;
            this.SpecialAttack = 81;
            this.SpecialDefense = 95;
            this.Speed = 95;
            this.Total = 600;
            this.Name = "Zygarde";
            this.imge = Resource1.ResourceManager.GetObject("zygarde") as byte[] ?? Array.Empty<Byte>();
        }
    }
}
