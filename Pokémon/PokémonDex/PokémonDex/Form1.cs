using PokémonDex.PokemonDex;

namespace PokémonDex
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
            Celebi celebi = new Celebi();
            Mewtwo mewtwo = new Mewtwo();
            Zygarde zygarde = new Zygarde();
            Giratina giratina = new Giratina();
            Seel seel = new Seel();
            Reshiram reshiram = new Reshiram();

            this.pokemonsList.Add(celebi);
            this.pokemonsList.Add(mewtwo);
            this.pokemonsList.Add(zygarde);
            this.pokemonsList.Add(giratina);
            this.pokemonsList.Add(seel);
            this.pokemonsList.Add(reshiram);
        }
        private void displayPokemon(Pokemon pokemon)
        {
            this.label10.Text = pokemon.getName();
            this.label4.Text = pokemon.getSpecies();
            this.label24.Text = pokemon.gettotal();
            this.label23.Text = pokemon.getspeed();
            this.label22.Text = pokemon.getspdef();
            this.label21.Text = pokemon.getspatk();
            this.label20.Text = pokemon.getdefense();
            this.label8.Text = pokemon.getWeight();
            this.label9.Text = pokemon.getHeight();
            this.label12.Text = pokemon.getattack();
            this.label13.Text = pokemon.getHP();
            this.label2.Text = pokemon.getTypes();
            using (var ms = new MemoryStream(pokemon.getImge()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Celebi celebi = new Celebi();
            this.displayPokemon(celebi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giratina giratina = new Giratina();
            this.displayPokemon(giratina);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zygarde zygarde = new Zygarde();
            this.displayPokemon(zygarde);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mewtwo mewtwo = new Mewtwo();
            this.displayPokemon(mewtwo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Seel seel = new Seel();
            this.displayPokemon(seel);
        }

        private void Reshiram_Click(object sender, EventArgs e)
        {
            Reshiram reshiram = new Reshiram();
            this.displayPokemon(reshiram);
        }
    }
}
