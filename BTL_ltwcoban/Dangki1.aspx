<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangki1.aspx.cs" Inherits="BTL_ltwcoban.Dangki1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HQML - Đăng ký</title>
     <link rel="stylesheet" href="css/hedear-footer.css" />
    <link rel="stylesheet" href="css/dangnhap-dangky.css" />
    <script src="js/Dangki.js" ></script>
</head>
<body>
    <!--Header Chung-->
    <form id="form1" runat="server" method="post" onsubmit ="return valid()">
            <div id="page">
            <div id="gioithieu">
                <table width="100%">
                    <tr>
                        <td>Hotline: 0364922582 - 0365852512</td>
                        <td align="right">
                            <div id="loginaction" runat="server">
					            
				            </div>
                        
                            <div class="logout action" runat="server">
                              
					    	</div>
                       
                            <div class="cart action" id="cartaction" runat="server">
					           
				            </div>
                        </td>
                    </tr>
                </table>                      
            </div>
            <div id="header">
                   <a href="Trangchu.aspx"><img src="image/logo_sach.png" id="logo"/></a>
                   <asp:TextBox ID="txtSearch" runat="server" placeholder="Tìm kiếm..." CssClass="txtSearch"></asp:TextBox>
                   <asp:Button ID="btnSearch" OnClick="Search_Click" runat="server" Text="Tìm" CssClass="btnSearch" />                                
 
               <%-- <input type="search" name="txtSearch" id="txtSearch" value="" placeholder="Nhập tên sách cần tìm..." />
                <input type="button" name="btnSearch" id="btnSearch" value="Tìm kiếm" onclick="Search_Click" />--%>
            </div>
        
            <div id="menu">
                <ul>
                    <li><a href="Trangchu.aspx">TRANG CHỦ</a></li>
                    <li>
                        <a href="#" class="tieude">SGK - SÁCH THAM KHẢO</a>
                        <ul class="menu-sub">
                            <li><a href="Sanpham.aspx?type=4">SÁCH GIÁO KHOA</a></li>
                            <li><a href="Sanpham.aspx?type=5">SÁCH THAM KHẢO</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="#" class="tieude">SÁCH HỌC NGOẠI NGỮ</a>
                        <ul class="menu-sub">
                            <li><a href="Sanpham.aspx?type=6">SÁCH TIẾNG ANH </a></li>  
                            <li><a href="Sanpham.aspx?type=7">SÁCH TIẾNG TRUNG</a></li>
                         </ul>
                    </li>
                    <li>
                        <a href="#" class="tieude">SÁCH VĂN HỌC</a>
                        <ul class="menu-sub">
                            <li><a href="Sanpham.aspx?type=8">TRUYỆN NGẮN</a></li>
                            <li><a href="Sanpham.aspx?type=9">TIỂU THUYẾT</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href="#" class="tieude">HOT DEAL</a>
                        <ul class="menu-sub">
                            <li><a href="Sanpham.aspx?type=1">SÁCH BÁN CHẠY</a></li>
                            <li><a href="Sanpham.aspx?type=2">SÁCH SẮP PHÁT HÀNH</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
       <%-- main --%> 
    <center>
    <div class="container">        
        <div class="register-form" >            
                <div class="title"><h1 >Đăng Ký</h1></div>                
                <div class="thongbao">
                    <label id="loi" style="color:red;"></label>
                    <asp:Label ID="loidangky" style="color:red;" runat="server"></asp:Label>
                </div>
                <div class="input-box">
                    <input class="inputdangky" type="text" id="namedangky" name="namedangky" placeholder="Nhập họ và tên của bạn..." required="required" /> <br /> 
                    <p id="loiName" style="color:red"></p>
                </div>
                <div class="input-box">
                    <input class="inputdangky" type="email" id="emaildangky" name="emaildangky" placeholder="Nhập email của bạn..." required="required" /><br />                      
                    <p id="loiEmail" style="color:red"></p>
                </div>
                <%--<div class="input-box">
                    <input class="inputdangky" type="text" id="dtdangky" name="dtdangky" placeholder="Nhập số điện thoại của bạn..." required="required" /><br />                      
                    <p id="loiSDT" style="color:red"></p>
                </div>--%>
                <div class="input-box">
                    <input class="inputdangky" type="password" id="passdangky" name="passdangky" placeholder="Nhập mật khẩu của bạn..." required="required" /><br />                        
                    <p id="loiPass" style="color:red"></p>
                </div>
                <div class="input-box">
                    <input class="inputdangky" type="password" id="repassdangky" name="repassdangky" placeholder="Hãy xác nhận lại mật khẩu..." required="required" /><br />
                    <p id="loiRepass" style="color:red"></p>
                </div>
                <div class="input-box">
                    <asp:Button ID="ButtonDangky" runat="server" Text="Đăng Ký" CssClass="registerbtn" OnClick="ButtonDangky_Click" /><br /><br />
                </div> 

                <div class="registration">
                    <a href="SignIn.aspx" style="text-decoration:none"><b><i style="color: #EF7123">Nếu đã có tài khoản?Đăng nhập?</i></b></a>
                </div>       
        </div>    
        
    </div>
    </center>

        <!--Footer chung-->
        <footer id="ft">
            <ul style="max-width: 1090px;padding-top: 45px;margin-bottom: 0px;">
                <li>
                    <div class="text" id="text1">
                        <h4>Giới thiệu</h4>
                        <div><hr/>
                            Sách không chỉ là sách, chúng là cuộc sống, là trái tim và hạt nhân của những thời đại đã qua, 
						là lý do mà con người lao động và chết, là cốt lõi và tinh hoa của bao cuộc đời.
                        </div>
                    </div>
                </li>
                <li>
                    <div class="text" id="text2">
                        <h4>Giờ làm việc</h4>
                        <div><hr />
                            Thứ 2 - thứ 6: 8h - 22h
                            <br />Thứ 7 & Chủ nhật: 9h - 23h
                            <br />

                        </div>
                    </div>
                </li>
                <li>
                    <div class="text" id="text3">
                        <h4>Liên hệ</h4>
                        <div><hr />
                            Hotline: 0988868386
                            <br />Email: hmqlbookstore@gmail.com
                            <br />Địa chỉ: 96 Định Công
                        </div>
                    </div>
                </li>
            </ul>
            <a href="Trangchu.aspx"><center> <img src="/image/social-media.png" alt="social network" width="160px"/> </center></a>	
            <div class="footer-bottom" style="text-align:center; color: #EF7123">
					<b>© 2022 HMQL - Book Store</b>
		</div>
        </footer>

        </form>
</body>
</html>
