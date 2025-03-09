using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex.PokemonDex
{
    internal class Giratina : Pokemon
    {
        public Giratina()
        {
            this.Species = "Renegade Pokémon";
            this.Type1 = PokemonType.Ghost;
            this.Type2 = PokemonType.Dragon;
            this.Height = 4.5;
            this.Weight = 750.0;
            this.HP = 150;
            this.Attack = 100;
            this.Defense = 120;
            this.SpecialAttack = 100;
            this.SpecialDefense = 120;
            this.Speed = 90;
            this.Total = 680;
            this.Name = "Giratina";
            this.imge = Resource1.ResourceManager.GetObject("giratina") as byte[] ?? Array.Empty<Byte>();
        }
    }
    
}
