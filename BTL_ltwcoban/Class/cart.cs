using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ltwcoban.Class
{
    public class cart
    {
        public string ID;
        public string Name;
        public string Price;
        public string IMG;
        public int quantity;
        public cart(string id, string img, string name, string price , int quantity)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.IMG = img;
            this.quantity = quantity;
            
        }
    }
}