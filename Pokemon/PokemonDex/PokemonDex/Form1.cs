using PokemonDex.PokemonDex;

namespace PokemonDex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Spheal spheal = new Spheal();
            Gible gible = new Gible();
            Shuppet shuppet = new Shuppet();
            Mew mew = new Mew();
            Celebi celebi = new Celebi();
            Alcremie alcremie = new Alcremie();
            this.pokemonsList.Add(alcremie);
            this.pokemonsList.Add(shuppet);
            this.pokemonsList.Add(celebi);
            this.pokemonsList.Add(mew);
            this.pokemonsList.Add(gible);
            this.pokemonsList.Add(spheal);
        }
        private void displayPokemon(Pokemon pokemon)
        {
            this.label26.Text = pokemon.getSpecies();
            this.label12.Text = pokemon.gettotal();
            this.label11.Text = pokemon.getspeed();
            this.label10.Text = pokemon.getspdef();
            this.label9.Text = pokemon.getspatk();
            this.label8.Text = pokemon.getdefense();
            this.label4.Text = pokemon.getWeight();
            this.label6.Text = pokemon.getHeight();
            this.label7.Text = pokemon.getattack();
            this.label3.Text = pokemon.getHP();
            this.label2.Text = pokemon.getTypes();
            this.label1.Text = pokemon.getName();
            using (var ms = new MemoryStream(pokemon.getImge()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);

            }


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void shuppet_Click(object sender, EventArgs e)
        {
            Shuppet shuppet = new Shuppet();
            this.pokemonsList.Add(shuppet);
            this.displayPokemon(shuppet);

        }

        private void celebii_Click(object sender, EventArgs e)
        {
            Celebi celebi = new Celebi();
            this.pokemonsList.Add(celebi);
            this.displayPokemon(celebi);
        }

        private void mew_Click(object sender, EventArgs e)
        {
            Mew mew = new Mew();
            this.pokemonsList.Add(mew);
            this.displayPokemon(mew);
        }

        private void spheal_Click(object sender, EventArgs e)
        {
            Spheal spheal = new Spheal();
            this.displayPokemon(spheal);
        }

        private void alcremie_Click(object sender, EventArgs e)
        {
            Alcremie alcremie = new Alcremie();
            this.displayPokemon(alcremie);
        }

        private void gible_Click(object sender, EventArgs e)
        {
            Gible gible = new Gible();
            this.displayPokemon(gible);
        }
    }
}
