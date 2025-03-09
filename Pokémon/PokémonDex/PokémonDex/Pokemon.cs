using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonDex
{
    public enum PokemonType
    {
        Ghost,
        Psychic,
        Grass,
        Fairy,
        Dragon,
        Ground,
        Warer,
        Fire
    }
    public enum PokemonSpecies
    {
        CreamPokémon,
    }
    public class Pokemon
    {
        protected string Name;
        protected string Species;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int SpecialAttack;
        protected int SpecialDefense;
        protected int Speed;
        protected int Total;
        protected double Height;
        protected double Weight;
        protected PokemonType Type1;
        protected PokemonType Type2;
        protected byte[] imge;

        public Pokemon() { }
        public string getName()
        {
            return this.Name;

        }
        public string getHP()
        {
            return this.HP.ToString();
        }
        public string getattack()
        {
            return this.Attack.ToString();
        }
        public string getdefense()
        {
            return this.Defense.ToString();
        }
        public string getspdef()
        {
            return this.SpecialDefense.ToString();
        }
        public string getspatk()
        {
            return this.SpecialAttack.ToString();
        }
        public string getHeight()
        {
            return this.Height.ToString("0.0");
        }
        public string getWeight()
        {
            return this.Weight.ToString("0.0");
        }
        public byte[] getImge()
        {
            return this.imge;
        }
        public string getTypes()
        {
            if (this.Type2 != 0)
            {
                return this.Type1.ToString() + " / " + this.Type2.ToString();
            }
            else
            {
                return this.Type1.ToString();
            }
        }

        public string getspeed()
        {
            return this.Speed.ToString();
        }
        public string gettotal()
        {
            return this.Total.ToString();
        }
        public string getSpecies()
        {
            return this.Species;
        }
    }
}
