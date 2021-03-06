using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313.model
{
    class PriceItem
    {
        private int idx;
        private string pp;
        private int price;

        public PriceItem(int idx, int price )
        {
            this.idx = idx;
            this.price = price;
        }

        public PriceItem(string pp)
        {
            this.pp = pp ;
        }

        public int Idx { get => idx; set => idx = value; }
        public int Price { get => price; set => price = value; }
    }
}
