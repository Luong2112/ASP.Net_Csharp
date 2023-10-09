<%@ Page Title="HMQL - Sản phẩm" Language="C#" MasterPageFile="~/Header-Footer.Master" AutoEventWireup="true" CodeBehind="Sanpham.aspx.cs" Inherits="BTL_ltwcoban.Sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/sanpham.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="trangsanpham">
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
        <h2><asp:Label ID="titleproducts" runat="server" Text="Lable"></asp:Label></h2>
        <form id="formproducts">
            <asp:ListView ID="ListViewProducts" runat="server">
                <ItemTemplate>
                    <div class="colSP">
                        <center>
                            <a href="Chitietsanpham.aspx?id=<%# Eval("id") %>">
                                <img src="<%# Eval("img") %>" alt="" />
                            </a>
                            <div>
                                <strong><%# Eval("name") %></strong><br />
                                <strong style="color:#EF7123 ; font-style:italic">Giá bán:<%# Eval("price") %>đ</strong>
                            </div>                      
                        </center>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </form>
    </div>
</div>    
</asp:Content>
