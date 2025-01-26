using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class item
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public bool check { get; set; }
    }

    public class discountitem
    {
        public string namedis { get; set; }
        public double per { get; set; }
        public bool checkdis { get; set; }
    }
}
