using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ltwcoban.Class
{
    public class cartN
    {
        public string ID;
        public string Name;
        public string Price;
        public string IMG;
        public int quantity;
        public cartN(string id, string img, string name, string price, int quantity)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.IMG = img;
            this.quantity = quantity;

        }
    }
}