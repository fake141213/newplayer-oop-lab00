using System.Security.Policy;

namespace Newproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!tbccoffee.Checked)
            {
                CoffeePrice.Enabled = false;
                CoffeeQuantity.Enabled = false;
            }
            if (!tbgreentea.Checked)
            {
                GreenTeaPrice.Enabled = false;
                GreeTeaQuantity.Enabled = false;
            }
            //CoffeePrice.Text = "0";
            //CoffeeQuantity.Text = "0";
            //GreenTeaPrice.Text = "0";
            //GreeTeaQuantity.Text = "0";
            total.Text = "0";
            cash.Text = "0";
            change.Text = "0";
            textBox1000.Text = "0";
            textBox500.Text = "0";
            textBox100.Text = "0";
            textBox50.Text = "0";
            textBox20.Text = "0";
            textBox10.Text = "0";
            textBox5.Text = "0";
            textBox1.Text = "0";    

        }

        private void Check_out_Click(object sender, EventArgs e)
        {
            string strcoffeep = CoffeePrice.Text;
            string strcoffeeq = CoffeeQuantity.Text;
            string strgreenteap = GreenTeaPrice.Text;
            string strgreenteaq = GreeTeaQuantity.Text;
            string strcash = cash.Text;
            string strchange = change.Text;

            int icoffeep = 0;
            int icoffeeq = 0;
            int greeteap = 0;
            int greeteaq = 0;
            int cashh = 0;
            int changee = 0;
            try
            {
                if (tbccoffee.Checked)
                {
                    icoffeep = int.Parse(strcoffeep);
                    icoffeeq = int.Parse(strcoffeeq);
                }
                if (tbgreentea.Checked)
                {
                    greeteap = int.Parse(strgreenteap);
                    greeteaq = int.Parse(strgreenteaq);
                }
                if (cash.Created)
                {
                    cashh = int.Parse(strcash);
                }
                if (change.Created)
                {
                    changee = int.Parse(strchange);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                icoffeep = 0;
                icoffeeq = 0;
                greeteap = 0;
                greeteaq = 0;
                cashh = 0;
                changee = 0;

            }

            int coff = icoffeep * icoffeeq;
            int greetea = greeteaq * greeteap;
            int sum = coff + greetea;
            total.Text = sum.ToString();
            int chage = cashh - sum;
            change.Text = chage.ToString();

            int thousand = 0;
            int five_hundred = 0;
            int one_hunred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;

            if (chage >= 1000)
            {
                thousand = chage / 1000;
                chage = chage % 1000;
                textBox1000.Text = thousand.ToString();
            }
            if (chage >= 500)
            {
                five_hundred = chage / 500;
                chage = chage % 500;
                textBox500.Text = five_hundred.ToString();
            }
            if (chage >= 100)
            {
                one_hunred = chage / 100;
                chage = chage % 100;
                textBox100.Text = one_hunred.ToString();
            }
            if (chage >= 50)
            {
                fifty = chage / 50;
                chage = chage % 50;
                textBox50.Text = fifty.ToString();
            }
            if (chage >= 20)
            {
                twenty = chage / 20;
                chage = chage % 20;
                textBox20.Text = twenty.ToString();
            }
            if (chage >= 10)
            {
                ten = chage / 10;
                chage = chage % 10;
                textBox10.Text = ten.ToString();
            }
            if (chage >= 5)
            {
                five = chage / 5;
                chage = chage % 5;
                textBox5.Text = five.ToString();
            }
            if (chage >= 1)
            {
                one = chage / 1;
                chage = chage % 1;
                textBox1.Text = one.ToString();
            }

        }

        private void tbccoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (tbccoffee.Checked)
            {
                CoffeePrice.Enabled = true;
                CoffeeQuantity.Enabled = true;
            }
            if (tbgreentea.Checked)
            {
                GreenTeaPrice.Enabled = true;
                GreeTeaQuantity.Enabled = true;
            }
        }
    }
}
