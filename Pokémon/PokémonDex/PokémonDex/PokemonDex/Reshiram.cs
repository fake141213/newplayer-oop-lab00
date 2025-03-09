using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex.PokemonDex
{
    internal class Reshiram : Pokemon
    {
        public Reshiram()
        {
            this.Species = "Vast White Pokémon";
            this.Type1 = PokemonType.Dragon;
            this.Type2 = PokemonType.Fire;
            this.Height = 3.2;
            this.Weight = 330.0;
            this.HP = 100;
            this.Attack = 120;
            this.Defense = 100;
            this.SpecialAttack = 150;
            this.SpecialDefense = 120;
            this.Speed = 90;
            this.Total = 680;
            this.Name = "Reshiram";
            this.imge = Resource1.ResourceManager.GetObject("reshiram") as byte[] ?? Array.Empty<Byte>();
        }
    }
}
