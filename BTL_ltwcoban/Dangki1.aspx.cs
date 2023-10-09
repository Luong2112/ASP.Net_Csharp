using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ltwcoban
{
    public partial class Dangki1 : System.Web.UI.Page
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

            loidangky.Text = "";
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            Response.Redirect("Timkiem.aspx?search=" + search);
        }
        protected void ButtonDangky_Click(object sender, EventArgs e)
        {
            if(Request.Form["namedangky"] != null)
            {
                string name = Request.Form["namedangky"];
                string email = Request.Form["emaildangky"];
                string dt = Request.Form["dtdangky"];
                string password = Request.Form["passdangky"];
                string repassword = Request.Form["repassdangky"];
                Users user = new Users(name, email, password, repassword);
                List<Users> arr = (List<Users>)Application["user"];
                if(password != repassword)
                {
                    loidangky.Text = "Mật khẩu và xác nhận mật khẩu không giống nhau!";
                    return;
                }
                int tg = 0;
                if(arr.Count == 0)
                {
                    arr = new List<Users>();
                }    
                else
                {
                    foreach (Users x in arr)
                    {
                        if (x.email == email)
                        {
                            loidangky.Text = "Email đã tồn tại. Bạn vui lòng nhập email khác!";
                            tg = 1;  
                        }                       
                        //else
                        //{
                        //    if(x.dt == dt)
                        //    {
                        //        loidangky.Text = "SĐT đã tồn tại. Bạn vui long nhập SĐT khác!";
                        //        tg = 1;
                        //    }
                        //}    

                    }    
                }  
                
                if (tg == 1)
                {

                } 
                else
                {
                    arr.Add(user);
                    Application["user"] = arr;
                    Session["login"] = 1;
                    Session["name"] = name;
                    Session["email"] = email;
                    //Session["dt"] = dt;
                    loidangky.Text = "Đăng ký thành công";
                    Response.Redirect("SignIn.aspx");
                }    
            }    
        }
    }
}