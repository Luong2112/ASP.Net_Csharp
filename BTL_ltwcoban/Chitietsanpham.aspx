<%@ Page Title="HMQL - Chi tiết sản phẩm" Language="C#" MasterPageFile="~/Header-Footer.Master" AutoEventWireup="true" CodeBehind="Chitietsanpham.aspx.cs" Inherits="BTL_ltwcoban.Chitietsanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link rel="stylesheet" href="css/Chitietsanpham.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="trangchitiet">
    <div class="book-detail">
        <div>
            <h1 class="book-title"><asp:Label ID="name" runat="server" ForeColor="#EF7123" Text="Lable"></asp:Label></h1>
        </div>
        <div class="info">
			<div class="book-info">
				<div class="book-cover">
					<asp:Image ID="Image1" runat="server" Width="300px" CssClass="imgdetails" />
				</div>
				<div class="book-attributes">
					<ul>
						<li>Tác giả: ADCH BOOKS</li>
						<li>Nhà xuất bản: ADCH</li>
						<li>Số trang: 354</li>
						<li>Kích thước: 14 x 20.5cm</li>
						<li>Ngày phát hành: 08-02-2021</li>
						<li>Đánh giá: ⭐⭐⭐⭐⭐</li>
						<li style="color:#EF7123">Giá bán: 
							<asp:Label ID="Label1" runat="server" Text="" ForeColor="#EF7123"></asp:Label>đ
						</li>
						<form class="submit">
						<div class="add_to_cart">
							<p class="Themgio" name="Themgio" value="themgio" runat="server" id="Themgio" style="color:red"></p>
							<asp:Button ID="btnthem" CommandArgument="" runat="server" CssClass="btnadd" Text="Thêm vào giỏ" OnClick="btnthemClick" ForeColor="#ffffff" BackColor="#EF7123" BorderStyle="None" Font-Size="25px"/>     
						</div>
					</form>
					</ul>
									
				</div>
			</div>
         </div>
		</div>
            <div class="box-container" align="center">
				<center style="color:#EF7123"><h3>SẢN PHẨM LIÊN QUAN</h3></center>
				<div class="book-box">
					<div class="box">
						<a href="chitietsanpham.aspx?id=2">
							<div class="book-item">
								<img src="/image/sachbanchay/2.jpg" alt="" height="170px">
							</div>
						</a>
					</div>
				</div>
				<div class="book-box">
					<div class="box">
						<a href="chitietsanpham.aspx?id=2">
							<div class="book-item">
								<img src="/image/sachbanchay/2.jpg" alt="" height="170px">
							</div>
						</a>
					</div>
				</div>
			</div>
        </div>

	<div class="book-intro">
		<h3 class="book-title">Giới thiệu sách</h3>
		<p>Sách không chỉ là sách, chúng là cuộc sống, là trái tim và hạt nhân của những thời đại đã qua, là lý do mà con người lao động và chết, là cốt lõi và tinh hoa của bao cuộc đời.</p>
		<p>For books are more than books, they are the life, the very heart and core of ages past, the reason why men worked and died, the essence and quintessence of their lives.</p>
		<h3 class="book-title">Giới thiệu sách</h3>
		<p>Sách không chỉ là sách, chúng là cuộc sống, là trái tim và hạt nhân của những thời đại đã qua, là lý do mà con người lao động và chết, là cốt lõi và tinh hoa của bao cuộc đời.</p>
		<p>For books are more than books, they are the life, the very heart and core of ages past, the reason why men worked and died, the essence and quintessence of their lives.</p>			
	</div>

</asp:Content>
