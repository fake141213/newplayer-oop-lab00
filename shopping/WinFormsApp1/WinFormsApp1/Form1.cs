using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security.Policy;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsApp1
{
    public partial class POS : Form
    {
        item coffeeitem = new item();
        item greenteaitem = new item();
        item Noodleitem = new item();
        item Pizzaitem = new item();
        discountitem Discountitem = new discountitem();
        public POS()
        {
            InitializeComponent();
            //add data to object
            coffeeitem.name = "coffee";
            coffeeitem.price = 25;
            coffeeitem.quantity = 0;
            coffeeitem.check = chkCoffee.Checked;

            greenteaitem.name = "greentea";
            greenteaitem.price = 25;
            greenteaitem.quantity = 0;
            greenteaitem.check = chkGreentea.Checked;

            Noodleitem.name = "noodle";
            Noodleitem.price = 35;
            Noodleitem.quantity = 0;
            Noodleitem.check = chkNooble.Checked;

            Pizzaitem.name = "pizza";
            Pizzaitem.price = 35;
            Pizzaitem.quantity = 0;
            Pizzaitem.check = chkpizza.Checked;

            Discountitem.namedis = "(tbbeverage";
            Discountitem.per = 0;
            Discountitem.checkdis = chkBeverage.Checked;

            Discountitem.namedis = "TbFood";
            Discountitem.per = 0;
            Discountitem.checkdis = chkFood.Checked;

            Discountitem.namedis = "chkAll";
            Discountitem.per = 0;
            Discountitem.checkdis = chkall.Checked;

            CoffeePrice.Text = coffeeitem.price.ToString();
            CoffeePrice.ReadOnly = true;

            GreenTeaPrice.Text = greenteaitem.price.ToString();
            GreenTeaPrice.ReadOnly = true;

            NoodlePrice.Text = Noodleitem.price.ToString();
            NoodlePrice.ReadOnly = true;

            PizzaPrice.Text = Pizzaitem.price.ToString();
            PizzaPrice.ReadOnly = true;
        }
        public double item(TextBox CoffeePrice, TextBox CoffeeQuantity, TextBox GreenTeaPrice, TextBox GreeTeaQuantity)
        {
            string inputcoffeep = CoffeePrice.Text;
            string inputcoffeeq = CoffeeQuantity.Text;
            string inputgreenteap = GreenTeaPrice.Text;
            string inputgreenteaq = GreeTeaQuantity.Text;

            double coffeeprice = 0;
            double coffeequantity = 0;
            double greenteaprice = 0;
            double greenteaquantity = 0;


            try
            {
                if (chkCoffee.Checked)
                    coffeeprice = double.Parse(inputcoffeep);
                coffeequantity = double.Parse(inputgreenteaq);
            }
            catch (FormatException) { }
            try
            {
                if (chkGreentea.Checked)
                    greenteaprice = double.Parse(inputgreenteap);
                greenteaquantity = double.Parse(inputgreenteaq);
            }
            catch (FormatException)
            {

            }
            double sum1 = coffeeprice * coffeequantity;
            double sum2 = greenteaprice * greenteaquantity;
            double sum = sum1 + sum2;
            return sum;

        }
        public double chkAll(double Beverage, double Food)
        {
            double sum1 = 0;
            if (chkall.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = double.Parse(tball.Text);
                    double all = Beverage + Food;
                    all = all - (all * discountvalue / 100);
                    sum1 += all;


                }
                catch (FormatException)
                {
                    double all = Beverage + Food;
                    sum1 += all;
                }


            }
            return sum1;
        }
        public double DiscountBeverage(double Beverage)
        {
            if (chkBeverage.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = double.Parse(tbbeverage.Text);
                    Beverage = Beverage - (Beverage * discountvalue / 100);

                }
                catch (FormatException)
                {
                    Beverage = Beverage - (Beverage * discountvalue / 100);
                }
            }
            return Beverage;
        }
        public double DiscountFood(double Food)
        {
            if (!chkFood.Checked)
            {
                double discountvalue = 0;
                try
                {
                    discountvalue = double.Parse(tbfood.Text);
                    Food = Food - (Food * discountvalue / 100);
                }
                catch (FormatException)
                {
                    Food = Food * discountvalue / 100;
                }
            }
            return Food;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double Beverage = item(CoffeePrice, CoffeeQuantity, GreenTeaPrice, GreeTeaQuantity, chkCoffee, chkGreentea);
            double Food = item(NoodlePrice, NoodleQuantity, PizzaPrice, PizzaQuantity, chkNooble, chkpizza);
            double sum1 = 0;
            if (chkall.Checked)
            {
                sum1 += tbfood(Beverage + Food);
            }
            else if (chkBeverage.Checked)
            {
                Beverage = DiscountBeverage(Beverage);
                sum1 += Beverage + Food;
            }
            else if (chkFood.Checked)
            {

                sum1 += Food + Beverage;

            }
            else
            {
                sum1 += Beverage;
            }
            tbtotal.Text = sum1.ToString();
        }

        private void chkall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tball_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}