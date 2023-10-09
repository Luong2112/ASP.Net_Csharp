using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class Header_Footer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["login"].ToString() == "1")
            {
                loginaction.InnerHtml =
                    "Chào, " + Session["name"].ToString() +
                    " <span>|</span><a href=\"DangXuat.aspx\"style=\"padding-left:10px; text-align: right;color: #326d7f;\">Đăng xuất</a><span>|</span>" +
                    "<a href=\"Giohang1.aspx\" style=\"padding-left:10px; text-align: right;color: #326d7f;\">Giỏ Hàng</a><span>|</span>";
                Session["url"] = Page.Request.Url.ToString();

            }
            else
            {
                loginaction.InnerHtml = "<a href=\"SignIn.aspx\" style=\"padding-left:10px;text-align: right; color: #326d7f;\">Đăng nhập</a><span>|</span>" +
                           "<a href=\"Dangki1.aspx\" style=\"padding-left:10px; text-align: right;color: #326d7f\">Đăng ký</a><span>|</span>" +
                           "<a href=\"Giohang1.aspx\" style=\"padding-left:10px; text-align: right;color: #326d7f;\">Giỏ Hàng</a><span>|</span>";

            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            Response.Redirect("Timkiem.aspx?search=" + search);
        }
    }
}