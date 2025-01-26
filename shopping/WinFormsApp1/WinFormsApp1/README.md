namespace Newproject
{
    public partial class Form1 : Form
    {
        item coffeeitem = new item();
        item greenteaitem = new item();
        item Noodleitem = new item();
        item Pizzaitem = new item();
        discountitem Discountitem = new discountitem();

        public Form1()
        {
            InitializeComponent();
            coffeeitem.name = "coffee";
            coffeeitem.price = 35;
            coffeeitem.quantity = 0;
            coffeeitem.check = tbccoffee.Checked;

            greenteaitem.name = "Green Tea";
            greenteaitem.price = 30;
            greenteaitem.quantity = 0;
            greenteaitem.check = tbgreentea.Checked;

            Noodleitem.name = "Noodle";
            Noodleitem.price = 50;
            Noodleitem.quantity = 0;
            Noodleitem.check = tbNoodie.Checked;

            Pizzaitem.name = "Pizza";
            Pizzaitem.price = 80;
            Pizzaitem.quantity = 0;
            Pizzaitem.check = tbPizza.Checked;

            Discountitem.namedis = "Tb_DisDrink";
            Discountitem.per = 0;
            Discountitem.checkdis = tbbeverge.Checked;

            Discountitem.namedis = "Discount_Food";
            Discountitem.per = 0;
            Discountitem.checkdis = tbfood.Checked;

            Discountitem.namedis = "Discount_All";
            Discountitem.per = 0;
            Discountitem.checkdis = All_Discount.Checked;

            CoffeePrice.Text = coffeeitem.price.ToString();
            CoffeePrice.ReadOnly = true;

            GreenTeaPrice.Text = greenteaitem.price.ToString();
            GreenTeaPrice.ReadOnly = true;

            NoodiePrice.Text = Noodleitem.price.ToString();
            NoodiePrice.ReadOnly = true;

            PizzaPrice.Text = Pizzaitem.price.ToString();
            PizzaPrice.ReadOnly = true;
        }
        public double Item(TextBox item1, TextBox itemamount1, TextBox item2, TextBox itemamount2, CheckBox item_check1, CheckBox item_check2)
        {


            string inputCoffeep = item1.Text;
            string inputCoffeeq = itemamount1.Text;
            string inputgreenteap = item2.Text;
            string inputgreenteaq = itemamount2.Text;

            double Coffeep = 0;
            double Coffeeq = 0;
            double greenteap = 0;
            double greenteaq = 0;

            try
            {
                if (item_check1.Checked)
                    Coffeep = double.Parse(inputCoffeep);
                Coffeeq = double.Parse(inputCoffeeq);

            }
            catch (FormatException) { }
            try
            {
                if (item_check2.Checked)
                    greenteap = double.Parse(inputgreenteap);
                greenteaq = double.Parse(inputgreenteaq);
            }
            catch (FormatException)
            {

            }
            double sum1 = Coffeep * Coffeeq;
            double sum2 = greenteap * greenteaq;
            double sum = sum1 + sum2;
            return sum;
        }

        public double DiscountAll(double Bevergee, double Food)
        {
            double sum1 = 0;
            if (All_Discount.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = double.Parse(All.Text);
                    double all = Bevergee + Food;
                    all = all - (all * discountvalue / 100);
                    sum1 += all;

                }
                catch (FormatException)
                {
                    double all = Bevergee + Food;
                    sum1 += all;
                }


            }
            return sum1;
        }
        public double DiscountBeverge(double Bevergee)
        {
            if (tbbeverge.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = double.Parse(Beverge.Text);
                    Bevergee = Bevergee - (Bevergee * discountvalue / 100);

                }
                catch (FormatException)
                { Bevergee = Bevergee - (Bevergee * discountvalue / 100); }

            }
            return Bevergee;
        }

        public double DiscountFood(double Food)
        {
            if (tbfood.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = double.Parse(this.Food.Text);
                    Food = Food - (Food * discountvalue / 100);

                }
                catch (FormatException)
                {
                    Food = Food - (Food * discountvalue / 100);

                }
            }

            return Food;
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
            double Beverge = Item(CoffeePrice, CoffeeQuantity, GreenTeaPrice, GreeTeaQuantity, tbccoffee, tbgreentea);
            double Food = Item(NoodiePrice, NoodleQuantity, PizzaPrice, PizzaQuantity, tbNoodie, tbPizza);
            double sum1 = 0;
            if (All_Discount.Checked)
            {
                sum1 += DiscountAll(Beverge, Food);

            }
            else if (tbbeverge.Checked)
            {
                Beverge = DiscountBeverge(Beverge);
                sum1 += Beverge + Food;

            }

            else if (tbfood.Checked)
            {
                Food = DiscountFood(Food);
                sum1 += Food + Beverge;



            }
            else
            {
                sum1 += Beverge + Food;
            }
            total.Text = sum1.ToString();
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Change_money_Click(object sender, EventArgs e)
        {
            double total = 0;
            double cash = 0;
            try
            {
                cash = double.Parse(this.cash.Text);
            }
            catch (FormatException) { }

            try
            {
                total = double.Parse(this.total.Text);
            }
            catch (FormatException) { }

            double change = cash - total;
            this.change.Text = change.ToString();

            double thousand = 0;
            double five_hundred = 0;
            double one_hundred = 0;
            double fifty = 0;
            double twenty = 0;
            double ten = 0;
            double five = 0;
            double one = 0;
            double fiftyStang = 0;
            double twentyFiveStang = 0;
            while (change >= 0.01)
            {
                if (change >= 1000)
                {
                    thousand = Math.Floor(change / 1000);
                    change = change % 1000;
                }
                else if (change >= 500)
                {
                    five_hundred = Math.Floor(change / 500);
                    change = change % 500;
                }
                else if (change >= 100)
                {
                    one_hundred = Math.Floor(change / 100);
                    change = change % 100;
                }
                else if (change >= 50)
                {
                    fifty = Math.Floor(change / 50);
                    change = change % 50;
                }
                else if (change >= 20)
                {
                    twenty = Math.Floor(change / 20);
                    change = change % 20;
                }
                else if (change >= 10)
                {
                    ten = Math.Floor(change / 10);
                    change = change % 10;
                }
                else if (change >= 5)
                {
                    five = Math.Floor(change / 5);
                    change = change % 5;
                }
                else if (change >= 1)
                {
                    one = Math.Floor(change / 1);
                    change = change % 1;
                }
                else if (change >= 0.50)
                {
                    fiftyStang = Math.Floor(change / 0.50);
                    change = change % 0.50;
                }
                else if (change >= 0.25)
                {
                    twentyFiveStang = Math.Floor(change / 0.25);
                    change = change % 0.25;
                }
            }
            textBox1000.Text = thousand.ToString();
            textBox500.Text = five_hundred.ToString();
            textBox100.Text = one_hundred.ToString();
            textBox50.Text = fifty.ToString();
            textBox20.Text = twenty.ToString();
            textBox10.Text = ten.ToString();
            textBox5.Text = five.ToString();
            textBox1.Text = one.ToString();
            textBox0_50.Text = fiftyStang.ToString();
            textBox0_25.Text = twentyFiveStang.ToString();
        }

            




        

        private void CoffeePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}