using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class Sanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Get("type") != null)
            {
                string type = Request.QueryString.Get("type");
                if(type == "1") { titleproducts.Text = "Sách bán chạy"; }
                else if(type == "2") { titleproducts.Text = "Sách sắp phát hành"; }
                else if (type == "3") { titleproducts.Text = "Sách giảm giá"; }
                else if (type == "4") { titleproducts.Text = "Sách giáo khoa"; }
                else if (type == "5") { titleproducts.Text = "Sách tham khảo"; }
                else if (type == "6") { titleproducts.Text = "Sách tiếng anh"; }
                else if (type == "7") { titleproducts.Text = "Sách tiếng trung"; }
                else if (type == "8") { titleproducts.Text = "Truyện Ngắn"; }
                else if (type == "9") { titleproducts.Text = "Tiểu Thuyết"; }

                List<sanpham> arr = (List<sanpham>)Application["sanpham"];
                List<sanpham> arrtype = new List<sanpham>();

                foreach(sanpham sp in arr)
                {
                    if(sp.Type == type)
                    {
                        arrtype.Add(sp);
                    }
                }
                ListViewProducts.DataSource = arrtype;
                ListViewProducts.DataBind();
            }
        }
    }
}