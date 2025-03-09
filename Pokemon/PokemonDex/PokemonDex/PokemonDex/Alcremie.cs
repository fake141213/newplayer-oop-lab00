namespace PokemonDex.PokemonDex
{
    internal class Alcremie : Pokemon
    {
        public Alcremie()
        {
            Species = "Cream Pokémon";
            Type1 = PokemonType.Fairy;
            Height = 0.3;
            Weight = 0.5;
            HP = 65;
            Attack = 60;
            Defense = 75;
            SpecialAttack = 110;
            SpecialDefense = 121;
            Speed = 64;
            Total = 495;
            Name = "Alcremie";
            imge = Resource1.ResourceManager.GetObject("alcremie") as byte[] ?? Array.Empty<byte>();

        }

    }
}
