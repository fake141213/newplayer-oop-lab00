using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex.PokemonDex
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            this.Species = "Genetic Pokémon";
            this.Type1 = PokemonType.Psychic;
            this.Height = 2.0;
            this.Weight = 122.0;
            this.HP = 106;
            this.Attack = 110;
            this.Defense = 90;
            this.SpecialAttack = 154;
            this.SpecialDefense = 90;
            this.Speed = 130;
            this.Total = 680;
            this.Name = "Mewtwo";
            this.imge = Resource1.ResourceManager.GetObject("mewtwo") as byte[] ?? Array.Empty<Byte>();
        }   
    }
}
