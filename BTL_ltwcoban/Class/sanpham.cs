using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ltwcoban
{
    public class sanpham
    {
        public string ID { get; set; }
        public string IMG { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Detail { get; set; }
        public string Type { get; set; }
        public int View { get; set; }

        public sanpham()
        {

        }

        public sanpham(string id, string img, string name, string price, string detail, string type, int view)
        {
            this.ID = id;
            this.IMG = img;
            this.Name = name;
            this.Price = price;
            this.Detail = detail;
            this.Type = type;
            this.View = view;
        }
        //public int quantity { get; set; }
        //public int thanhtien
        //{
        //    get
        //    {
        //        return int.Parse(this.Price) * quantity;
        //    }
        //    set
        //    {
        //        thanhtien = value;
        //    }
        //}
    }
}