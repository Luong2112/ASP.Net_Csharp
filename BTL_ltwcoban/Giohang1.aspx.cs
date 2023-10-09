using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class Giohang1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                double totalprice = 0;
                              
                    List<sanpham> arr = (List<sanpham>)Session["giohang"];

                    foreach (sanpham sp in arr)
                    {                        
                        double price = Convert.ToDouble(sp.Price);
                        totalprice += price;
                    }
                    DSGiohang.DataSource = arr;
                    DSGiohang.DataBind();
                    TotalProduct.Text = arr.Count.ToString();
                    TotalPriceProduct.Text = totalprice.ToString();

               

                //if(Request.Form["thanhtoan"] == "Thanh toán")
                //{
                //    Response.Write("<script>alert('Thanh toán thành công!');</script>");
                //    date.InnerHtml = DateTime.Now.Date.ToString("dd/MM/yyyy");
                //}

            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }

        }

        protected void xoa()
        {
            List<sanpham> arr = (List<sanpham>)Session["giohang"];
        }

        //idcarts = (List<Cart>) Session["Cart"];
        //var itemToRemove = idcarts.SingleOrDefault(pro => pro.IdProd == Convert.ToInt32(Request.Form["btnXoa"]));
        //            if (itemToRemove != null)
        //            idcarts.Remove(itemToRemove);
        //            Session["Cart"] = idcarts;
        //        Response.Redirect("GioHang.aspx");

        //protected void btnRemoveClick(object sender, EventArgs e)
        //{
        //    List<sanpham> arr = (List<sanpham>)Session["giohang"];
        //    string id = ((Button)sender).CommandArgument.ToString();

        //    foreach (sanpham sp in arr)
        //    {
        //        if (sp.ID == id)
        //        {
        //            arr.RemoveAll(m => m.ID == id);
        //            break;
        //        }
        //    }
        //    Response.Write("<script>alert('Xóa thành công!');</script>");


        //}
    }
}