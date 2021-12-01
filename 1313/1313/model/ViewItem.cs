using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313.model
{
    class ViewItem
    {
        private string company;         // 회사명
        private string kinds;            // 종류
        private string division;          // 구분
        private List<PriceItem> itemlist;  // 두께
        private List<PriceItem> itemlist2;  // 컬러
        private int Totalprice;              // 총견적

        public ViewItem()
        {
        }

        public ViewItem(string company, string kinds, string division, List<PriceItem> itemlist,
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
