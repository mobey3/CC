using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313.model
{
    class Glasswool
    {
        private string company;
        private string kinds;
        private string division;
        private string thickness;
        private string color;
        private int price;

        public Glasswool(string company, string kinds, string division, string thickness, string color, int price)
        {
            this.company = company;
            this.kinds = kinds;
            this.division = division;
            this.thickness = thickness;
            this.color = color;
            this.price = price;
        }

        public string Company { get => company; set => company = value; }
        public string Kinds { get => kinds; set => kinds = value; }
        public string Division { get => division; set => division = value; }
        public string Thickness { get => thickness; set => thickness = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }
    }
}
