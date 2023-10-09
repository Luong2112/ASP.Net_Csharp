using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class Chitietsanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] == null)
            {
                Response.Redirect("/Trangchu.aspx", true);
            }
            else
            {
                List<sanpham> arr = (List<sanpham>)Application["sanpham"];
                
                foreach(sanpham x in arr)
                {
                    if(x.ID == Request.QueryString["id"])
                    {
                        name.Text = x.Name;
                        Label1.Text = x.Price;
                        Image1.ImageUrl = x.IMG;
                        btnthem.CommandArgument = x.ID;
                    }
                }
            }
        }

        protected void btnthemClick (object sender, EventArgs e)
        {
            if(Session["email"] != null)
            {
                string id = ((Button)sender).CommandArgument.ToString();
                List<sanpham> arr = (List<sanpham>)Session["giohang"];
                List<sanpham> arrsp = (List<sanpham>)Application["sanpham"];
                if (arr.Count == 0)
                {
                    arr = new List<sanpham>();
                }

                foreach (sanpham sp in arrsp)
                {
                    if (sp.ID == id)
                    {
                        arr.Add(sp);
                        break;
                    }
                }
                Session["giohang"] = arr;
                //Page.Response.Redirect(Page.Request.Url.ToString(), true);
                //Themgio.InnerHtml = "Thêm giỏ hàng thành công!";

            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }
            
        }        
    }
}