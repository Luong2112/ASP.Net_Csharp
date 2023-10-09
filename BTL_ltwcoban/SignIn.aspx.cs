using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class SignIn : System.Web.UI.Page
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

            if (Request.Form["emaildangnhap"] != null)
            {
                string email = Request.Form["emaildangnhap"];
                string pass = Request.Form["passworddangnhap"];
                List<Users> arr = (List<Users>)Application["user"];
                int tg = 0;
                if (arr.Count == 0)
                {
                    loidangnhap.Text = "Tài khoản không tồn tại. Vui lòng kiểm tra lại!";
                }
                else
                {
                    foreach (Users x in arr)
                    {
                        if (x.email == email && x.password == pass)
                        {
                            tg = 1;
                            Session["login"] = 1;
                            Session["name"] = x.name;
                            Session["email"] = x.email;
                            break;
                        }
                    }
                    if (tg == 1)
                    {
                        Response.Write("<script> alert('Đăng nhập thành công!');</script>)");
                        Response.Redirect("Trangchu.aspx");
                    }
                    else
                    {
                        loidangnhap.Text = "Tài khoản hoặc mật khẩu không chính xác!";
                    }
                }
            }
            if (Session.Contents["login"].ToString() == "1")
            {
                string tk = Request.Form["emaildangky"];
                string mk = Request.Form["passworddangky"];
            }
        }
    

        protected void Search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            Response.Redirect("Timkiem.aspx?search=" + search);
        }
    }
}