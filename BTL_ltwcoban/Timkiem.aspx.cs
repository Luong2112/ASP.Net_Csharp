using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class Timkiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<sanpham> danhsach = (List<sanpham>)Application["sanpham"];
            danhsach = danhsach.OrderByDescending(s => s.View).ToList();

            List<sanpham> sach = new List<sanpham>();
            //List<sanpham> hotnew = new List<sanpham>();
            if (!string.IsNullOrEmpty(Request.QueryString["search"]))
            {
                string search = (Request.QueryString["search"]).ToLower();
                foreach (sanpham Sach in danhsach)
                {
                    if ((Sach.Name).ToLower().Contains(search)){
                        sach.Add(Sach);
                    }
                }

                //foreach(sanpham Sach in danhsach)
                //{
                //    hotnew.Add(Sach);

                //    if(hotnew.Count > 10)
                //    {
                //        break;
                //    }
                //}
                if(sach.Count > 0)
                {
                    ViewBooks.DataSource = sach;
                    ViewBooks.DataBind();
                }
                else
                { 
                    main_center.InnerHtml = "<div> <p style ='text-align:center;'>Không tìm thấy sản phẩm nào chứa từ khóa của bạn.</p></div>";
                }
            }
            else
            {
                Response.Redirect("Trangchu.aspx");
            }
        }
    }
}