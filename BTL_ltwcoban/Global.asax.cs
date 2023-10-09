using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_ltwcoban
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["user"] = new List<Users>();
            Application["user"] = new List<Users>()
            { new Users{ name = "HMQL admin1", email = "diemquynh@gmail.com", password="diemquynh", repassword="diemquynh"},
               new Users{ name = "HMQL admin2", email = "nguyenhoa@gmail.com", password="nguyenhoa", repassword="nguyenhoa"}
            };

            //Application["giohang"] = new List<sanpham>();
            Application["sanpham"] = new List<sanpham>();
            
            List<sanpham> arr = new List<sanpham>();

            //trang chủ
            //sách bán chạy1
            arr.Add(new sanpham() { ID = "1", IMG = "/image/sachbanchay/1.jpg" , Name="25 Chuyên Đề Ngữ Pháp Tiếng Anh Trọng Tâm" , Price="88.000", Detail="", Type="1", View=10});
            arr.Add(new sanpham() { ID = "2", IMG = "/image/sachbanchay/2.jpg", Name = "Lai Lịch", Price = "75.000", Detail = "", Type = "1", View = 20 });
            arr.Add(new sanpham() { ID = "3", IMG = "/image/sachbanchay/3.jpg", Name = "Chuyện Đời Thường", Price = "95.000", Detail = "", Type = "1", View = 30 });
            arr.Add(new sanpham() { ID = "4", IMG = "/image/sachbanchay/4.jpg", Name = "Lạc rừng ngược chiều cái chết", Price = "100.000", Detail = "", Type = "1", View = 41 });
            arr.Add(new sanpham() { ID = "5", IMG = "/image/sachbanchay/5.jpg", Name = "Tứ trấn huyền linh", Price = "120.000", Detail = "", Type = "1", View = 123 });
            arr.Add(new sanpham() { ID = "6", IMG = "/image/sachbanchay/6.jpg", Name = "Sài gòn một thuở 'Dân ông tạ đó'", Price = "50.000", Detail = "", Type = "1", View = 1345 });

            //sách bán chạy nhất năm 2021 1
            arr.Add(new sanpham() { ID = "7", IMG = "/image/sachbanchaynhat2021/7.jpg", Name = "Sổ Tay Kiến Thức Toán", Price = "70.000", Detail = "", Type = "1", View = 123 });
            arr.Add(new sanpham() { ID = "8", IMG = "/image/sachbanchaynhat2021/8.jpg", Name = "Chinh Phục Đề Thi Toán 10", Price = "110.000", Detail = "", Type = "1", View = 41 });
            arr.Add(new sanpham() { ID = "9", IMG = "/image/sachbanchaynhat2021/9.jpg", Name = "Atlat Địa Lý Việt Nam", Price = "35.000", Detail = "", Type = "1", View = 20 });

            //sách bán sắp phát hành2
            arr.Add(new sanpham() { ID = "10", IMG = "/image/sachbansapphathanh/10.jpg", Name = "500 Bài Tập Vật Lý Chuyên", Price = "100.000", Detail = "", Type = "2", View = 1345 });
            arr.Add(new sanpham() { ID = "11", IMG = "/image/sachbansapphathanh/11.jpg", Name = "Sổ Tay Kiến Thức & Dạng Bài Hóa Học", Price = "95.000", Detail = "", Type = "2", View = 10 });
            arr.Add(new sanpham() { ID = "12", IMG = "/image/sachbansapphathanh/12.jpg", Name = "Sổ Tay Kiến Thức Tiếng Anh", Price = "75.000", Detail = "", Type = "2", View = 20 });
            
            //sách giảm giá3
            arr.Add(new sanpham() { ID = "13", IMG = "/image/sachgiamgia/giamgia1.jpg", Name = "Chuyện Con Mèo Dạy Hải Âu Bay", Price = "123.000", Detail = "", Type = "3", View = 145 });


            //sách giáo khoa4
            arr.Add(new sanpham() { ID = "14", IMG = "/image/sgk/dia-ly-8.jpg", Name = "Địa lý 8", Price = "20.000", Detail = "", Type = "4", View = 134 });
            arr.Add(new sanpham() { ID = "15", IMG = "/image/sgk/hoa-11nc.jpg", Name = "Hóa 11 nâng cao", Price = "25.000", Detail = "", Type = "4", View = 2178 });
            arr.Add(new sanpham() { ID = "16", IMG = "/image/sgk/ta-6.jpg", Name = "Tiếng Anh 6", Price = "30.000", Detail = "", Type = "4", View = 1256 });
            arr.Add(new sanpham() { ID = "16", IMG = "/image/sgk/toan-3.jpg", Name = "Toán 3", Price = "20.000", Detail = "", Type = "4", View = 35 });
            arr.Add(new sanpham() { ID = "17", IMG = "/image/sgk/toan-4.jpg", Name = "Toán 4", Price = "20.000", Detail = "", Type = "4", View = 1578 });
            arr.Add(new sanpham() { ID = "18", IMG = "/image/sgk/tv-2.jpg", Name = "Tiếng Việt 2", Price = "25.000", Detail = "", Type = "4", View = 20 });
            arr.Add(new sanpham() { ID = "19", IMG = "/image/sgk/tv-3.jpg", Name = "Tiếng Việt 3", Price = "20.000", Detail = "", Type = "4", View = 20 });
            arr.Add(new sanpham() { ID = "20", IMG = "/image/sgk/tv-4.jpg", Name = "Tiếng Việt 4", Price = "30.000", Detail = "", Type = "4", View = 20 });
            arr.Add(new sanpham() { ID = "21", IMG = "/image/sgk/van-9-t2.jpg", Name = "Ngữ Văn 9 - tập 2", Price = "20.000", Detail = "", Type = "4", View = 10 });

            //sách tham khảo5
            arr.Add(new sanpham() { ID = "22", IMG = "/image/sachthamkhao/35dethitavao10.jpg", Name = "35 Đề Thi Tiếng Anh Vào 10", Price = "70.000", Detail = "", Type = "5", View = 20 });
            arr.Add(new sanpham() { ID = "23", IMG = "/image/sachthamkhao/luyenthivao10monvan.jpg", Name = "Luyện Thi Vào 10 Môn Văn", Price = "90.000", Detail = "", Type = "5", View = 17 });
            arr.Add(new sanpham() { ID = "24", IMG = "/image/sachthamkhao/mega2021-sieuluyende.jpg", Name = "Mega 2021", Price = "100.000", Detail = "", Type = "5", View = 156 });
            arr.Add(new sanpham() { ID = "25", IMG = "/image/sachthamkhao/so-tay-kien-thuc-toan-thcs.jpg", Name = "Sổ Tay Kiến Thức Toán THCS", Price = "85.000", Detail = "", Type = "5", View = 1567 });

            //sách tiếng anh6
            arr.Add(new sanpham() { ID = "26", IMG = "/image/sachtienganh/5500tuthongdung.jpg", Name = "5500 Từ Tiếng Anh Thông Dụng", Price = "70.000", Detail = "", Type = "6", View = 20 });
            arr.Add(new sanpham() { ID = "27", IMG = "/image/sachtienganh/hacker-ielts-reading-01.jpg", Name = "Hacker Ielts Reading 01", Price = "150.000", Detail = "", Type = "6", View = 20 });
            arr.Add(new sanpham() { ID = "28", IMG = "/image/sachtienganh/hackerieltswriting.jpg", Name = "Hacker Ielts Writing", Price = "150.000", Detail = "", Type = "6", View = 10 });
            arr.Add(new sanpham() { ID = "29", IMG = "/image/sachtienganh/hackspeaking.jpg", Name = "Hacker Ielts Speaking", Price = "150.000", Detail = "", Type = "6", View = 50 });
            arr.Add(new sanpham() { ID = "30", IMG = "/image/sachtienganh/hoc-2000tuvungtienganh.jpg", Name = "Học 2000 Từ Vựng Tiếng Anh", Price = "170.000", Detail = "", Type = "6", View = 80 });

            //sách tiếng trung7
            arr.Add(new sanpham() { ID = "31", IMG = "/image/tiengtrung/301caudamthoaitienghoa40k.jpg", Name = "301 Câu Đàm Thoại Tiếng Hoa", Price = "40.000", Detail = "", Type = "7", View = 90 });
            arr.Add(new sanpham() { ID = "32", IMG = "/image/tiengtrung/tuhoctiengtrungchonguoimoibatdau85k.jpg", Name = "Tự Học Tiếng Trung Cho Người Mới Bắt Đầu", Price = "85.000", Detail = "", Type = "7", View = 20 });

            //truyện ngắn8
            arr.Add(new sanpham() { ID = "33", IMG = "/image/truyenngan/caphecungtony90k.jpg", Name = "Cà Phê Cùng Tony", Price = "90.000", Detail = "", Type = "8", View = 356 });
            arr.Add(new sanpham() { ID = "34", IMG = "/image/truyenngan/homnayemcoonkhong88k.jpg", Name = "Hôm Nay Em Có Ổn Không", Price = "88.000", Detail = "", Type = "8", View = 15246 });
            arr.Add(new sanpham() { ID = "35", IMG = "/image/truyenngan/phailongcodon86k.jpg", Name = "Phải Lòng Với Cô Đơn", Price = "86.000", Detail = "", Type = "8", View = 6246 });
            arr.Add(new sanpham() { ID = "36", IMG = "/image/truyenngan/tudientiengem69k.jpg", Name = "Tự Điển Tiếng Em", Price = "69.000", Detail = "", Type = "8", View = 134 });

            //tiểu thuyết9
            arr.Add(new sanpham() { ID = "37", IMG = "/image/tieuthuyet/caycamngotcuatoi108k.jpg", Name = "Cây Cam Ngọt Của Tôi", Price = "108.000", Detail = "", Type = "9", View = 2350 });
            arr.Add(new sanpham() { ID = "38", IMG = "/image/tieuthuyet/dauchantrencat148k.jpg", Name = "Dấu Chân Trên Cát", Price = "148.000", Detail = "", Type = "9", View = 20 });
            arr.Add(new sanpham() { ID = "39", IMG = "/image/tieuthuyet/toithayhoavang125k.jpg", Name = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", Price = "125.000", Detail = "", Type = "9", View = 70 });
            arr.Add(new sanpham() { ID = "40", IMG = "/image/tieuthuyet/thuongduong108k.jpg", Name = "Thượng Dương", Price = "108.000", Detail = "", Type = "9", View = 15236 });




            Application["sanpham"] = arr;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
            Session["giohang"] = new List<sanpham>();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}