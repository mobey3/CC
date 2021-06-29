using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313.model
{
    class Styrofoam
    {
        private string company;
        private string kinds;
        private string division;
        private List<PriceItem> itemlist;
        private List<PriceItem> itemlist2;
        private int Totalprice;


        public Styrofoam(string company, string kinds, string division, List<PriceItem> itemlist,
            List<PriceItem> itemlist2, int Totalprice)
        {
            this.company = company;      
            this.kinds = kinds;            
            this.division = division;
            this.itemlist = itemlist;
            this.itemlist2 = itemlist2;
            this.Totalprice = Totalprice;
        }

        public string Company { get => company; set => company = value; }
        public string Kinds { get => kinds; set => kinds = value; }
        public string Division { get => division; set => division = value; }
        public int TotalPrice { get => Totalprice; set => Totalprice = value; }
        internal List<PriceItem> Itemlist { get => itemlist; set => itemlist = value; }
        internal List<PriceItem> Itemlist2 { get => itemlist2; set => itemlist2 = value; }
    }
}
