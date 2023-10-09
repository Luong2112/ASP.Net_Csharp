<%@ Page Title="HMQL - Trang chủ" Language="C#" MasterPageFile="~/Header-Footer.Master" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="BTL_ltwcoban.Trangchu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/trangchu.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="trangchu">
    <div class="menuphu">
        <div class="title">
            <h2><a href="#" class="giamgia">Giảm giá đặc biệt</a></h2>
        </div>
        <div class="book-menuphu-box">
            <div class="box">
                <a href="chitietsanpham.aspx?id=13">
                    <div class="book-item">
                        <img src="image/sachgiamgia/giamgia1.jpg" />
                        <div class="book-name">Tháng năm những quyển sách nào tái bản</div>
                        <div class="book-price">Giá: 123.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="Sanpham.aspx?type=3">
                    <div class="book-item">
                        <img src="image/sachgiamgia/giamgia2.jpg" />
                        <div class="book-name">Những cuốn sách nên đọc khi bạn còn trẻ</div>
                        <div class="book-price">Giá: 123.000đ</div>
                    </div>
                </a>
            </div>
        </div>
    </div>

    <div class="menuchinh">
        <div class="title">
            <h2><a href="Sanpham.aspx?type=1">Sách bán chạy</a></h2>
        </div>
        <div class="book-menuchinh-box">
            <div class="box">
                <a href="chitietsanpham.aspx?id=1">
                    <div class="book-item">
                        <img src="image/sachbanchay/1.jpg" />
                        <div class="book-name">25 Chuyên Đề Tiếng Anh Ngữ Pháp Trọng Tâm - Tập 1</div>
                        <div class="book-price">Giá: 88.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=2">
                    <div class="book-item">
                        <img src="image/sachbanchay/2.jpg" />
                        <div class="book-name">Lai lịch</div>
                        <div class="book-price">Giá: 75.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=3">
                    <div class="book-item">
                        <img src="image/sachbanchay/3.jpg" />
                        <div class="book-name">Chuyện đời thường</div>
                        <div class="book-price">Giá: 95.000đ</div>
                    </div>
                </a>
            </div>
        </div>

        <div class="book-menuchinh-box">
            <div class="box">
                <a href="chitietsanpham.aspx?id=4">
                    <div class="book-item">
                        <img src="image/sachbanchay/4.jpg" />
                        <div class="book-name">Lạc rừng ngược chiều cái chết</div>
                        <div class="book-price">Giá: 100.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=5">
                    <div class="book-item">
                        <img src="image/sachbanchay/5.jpg" />
                        <div class="book-name">Tứ trấn huyền linh</div>
                        <div class="book-price">Giá: 120.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=6">
                    <div class="book-item">
                        <img src="image/sachbanchay/6.jpg" />
                        <div class="book-name">Sài gòn một thuở "Dân ông tạ đó"</div>
                        <div class="book-price">Giá: 50.000đ</div>
                    </div>
                </a>
            </div>
        </div>


        <div class="title">
            <h2><a href="Sanpham.aspx?type=1">Sách bán chạy nhất năm 2021</a></h2>
        </div>
        <div class="book-menuchinh-box">
            <div class="box">
                <a href="chitietsanpham.aspx?id=7">
                    <div class="book-item">
                        <img src="image/sachbanchaynhat2021/7.jpg" />
                        <div class="book-name">Sổ tay kiến thức toán</div>
                        <div class="book-price">Giá: 70.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=8">
                    <div class="book-item">
                        <img src="image/sachbanchaynhat2021/8.jpg" />
                        <div class="book-name">Chinh phục đề thi toán 10</div>
                        <div class="book-price">Giá: 110.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=9">
                    <div class="book-item">
                        <img src="image/sachbanchaynhat2021/9.jpg" />
                        <div class="book-name">Atlat địa lý Việt Nam</div>
                        <div class="book-price">Giá: 35.000đ</div>
                    </div>
                </a>
            </div>
        </div>

        <div class="title">
            <h2><a href="Sanpham.aspx?type=2">Sách bán sắp phát hành</a></h2>
        </div>
        <div class="book-menuchinh-box">
            <div class="box">
                <a href="chitietsanpham.aspx?id=10">
                    <div class="book-item">
                        <img src="image/sachbansapphathanh/10.jpg" />
                        <div class="book-name">500 bài tập vật lý chuyên</div>
                        <div class="book-price">Giá: 100.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=11">
                    <div class="book-item">
                        <img src="image/sachbansapphathanh/11.jpg" />
                        <div class="book-name">Sổ tay kiến thức và dạng bài Hóa học</div>
                        <div class="book-price">Giá: 95.000đ</div>
                    </div>
                </a>
            </div>
            <div class="box">
                <a href="chitietsanpham.aspx?id=12">
                    <div class="book-item">
                        <img src="image/sachbansapphathanh/12.jpg" />
                        <div class="book-name">Sổ tay kiến thức Tiếng Anh</div>
                        <div class="book-price">Giá: 75.000đ</div>
                    </div>
                </a>
            </div>
        </div>
    </div>
</div>
</asp:Content>
