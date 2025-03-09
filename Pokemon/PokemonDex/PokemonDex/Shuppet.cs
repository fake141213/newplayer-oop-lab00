using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    internal class Shuppet : Pokemon
    {
        public Shuppet()
        {
            this.Species = "Puppet Pokémon";
            this.Type1 = PokemonType.Ghost;
            this.Height = 0.6;
            this.Weight = 2.3;
            this.HP = 44;
            this.Attack = 75;
            this.Defense = 35;
            this.SpecialAttack = 63;
            this.SpecialDefense = 33;
            this.Speed = 45;
            this.Total = 295;
            this.Name = "Shuppet";
            this.imge = Resource1.ResourceManager.GetObject("shuppet") as byte[] ?? Array.Empty<Byte>();

        }
    }
}
