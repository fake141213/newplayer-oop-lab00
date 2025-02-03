using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Coffee_Machine
{
    internal class Menu
    {
        public string Name { get; private set; }

        public Menu(string name)
        {
            Name = name;
        }
    }

    internal class IngredientItem
    {
        private int _water;
        private int _coffee;
        private int _milk;
        private int _chocolate;

        public string Name { get; private set; }
        public int Water => _water;
        public int Coffee => _coffee;
        public int Milk => _milk;
        public int Chocolate => _chocolate;
        public IngredientItem(string name, int water, int coffee, int milk, int chocolate)
        {
            Name = name;
            _water = water;
            _coffee = coffee;
            _milk = milk;
            _chocolate = chocolate;
        }
    }

    internal class Stock
    {
        private int _water = 1000;
        private int _coffee = 1000;
        private int _milk = 1000;
        private int _chocolate = 1000;

        public int Water => _water;
        public int Coffee => _coffee;
        public int Milk => _milk;
        public int Chocolate => _chocolate;

        public bool CheckStock(IngredientItem recipe)
        {
            return _water >= recipe.Water &&
                   _coffee >= recipe.Coffee &&
                   _milk >= recipe.Milk &&
                   _chocolate >= recipe.Chocolate;
        }
        public void UseIngredients(IngredientItem recipe)
        {
            if (CheckStock(recipe))
            {
                _water -= recipe.Water;
                _coffee -= recipe.Coffee;
                _milk -= recipe.Milk;
                _chocolate -= recipe.Chocolate;
            }
        }
        public void RefillStock()
        {
            _water = 1000;
            _coffee = 1000;
            _milk = 1000;
            _chocolate = 1000;
        }

        public string GetStockStatus()
        {
            return $"🔄 สถานะของวัตถุดิบคงเหลือ\n\n" +
                   $"น้ำเหลือ: {_water} ml\n" +
                   $"กาแฟเหลือ: {_coffee} g\n" +
                   $"นมเหลือ: {_milk} ml\n" +
                   $"ช็อกโกแลตเหลือ: {_chocolate} g";
        }

    }
}


