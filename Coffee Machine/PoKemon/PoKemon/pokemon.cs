using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoKemon
{
    public enum PokemonType
    {
        normal,
        flying,
        electric,
    }
    public class pokemon
    {
        protected int HP; //ข้อมูลของโปรเกม่อน
        protected int Attack;
        protected int Defense;
        protected int SpAtk;
        protected int SpDef;
        protected int Speed;
        protected int total;
        protected double Height;
        protected double Weight;
        protected string Spcies;
        protected PokemonType Type;
        //constructor
        public pokemon() { }
    }
}
