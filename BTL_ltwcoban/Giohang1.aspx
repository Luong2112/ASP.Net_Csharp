<%@ Page Title="" Language="C#" MasterPageFile="~/Header-Footer.Master" AutoEventWireup="true" CodeBehind="Giohang1.aspx.cs" Inherits="BTL_ltwcoban.Giohang1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #banner{
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="margin-top:10px;">Giỏ hàng của bạn: 
        <small class="pull-right">
            <asp:Label ID="TotalProduct" runat="server" Text="Label"></asp:Label>
            sản phẩm
        </small>
    </h2>
    <center>
        <hr />
        <table style="margin:10px 0 150px 0;">
            <thead>
                <tr>
                   
                    <td style="font-weight:bold">Sản phẩm</td>
                    <td style="width:230px;font-weight:bold">Tên sản phẩm</td>
                    <td style="width:67px;font-weight:bold">Mô tả</td>
                    <td style="width:90px;font-weight:bold">Giá</td>
                    <td style="width:100px;font-weight:bold">Thành tiền</td>
                    <%--<td style="width:100px;font-weight:bold">Xóa</td>--%>
                    
                </tr>
            </thead>

            <tbody>
                <asp:ListView ID="DSGiohang" runat="server" >
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td class="td1">
                                <img src="<%# Eval("img") %>" class="anh" style="width:120px ; height:120px"></img>
                            </td>
                            <td ><p><%# Eval("name") %></p></td>
                            <td ><a href="Chitietsanpham.aspx?id=<%#Eval("id")  %>">Chi tiết</a></td>
                            <td ><p><%# Eval("price") %>đ</p></td>
                            <td ><p><%# Eval("price") %>đ</p></td>
                            <td>
                                    <%--<input type ="button" id="btn" ten="btnXoa" value="Xóa" onclick="xoa()"/>--%>
                            </td>
                            <%--<td><a href="Xoagiohang.aspx?id=<%#Eval("id") %>" class="xoa"><button class="xoa" name="btnxoa" id="btnxoa">Xóa</button></a></td>--%>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
                <tr>
                    <td colspan="4" align="right" class="alignR" style="color:#EF7123; font-size: 25px"><b>Tổng tiền:   </b></td>
                    <td style="color:#EF7123; font-size: 25px" align="right"><asp:Label ID="TotalPriceProduct" runat="server" Text="Label"></asp:Label>đ</td>
                </tr>
                <tr>
                    <td colspan="5" align="right"> 
                        <input type="submit" name="thanhtoan" value="Thanh toán" style="border:none; font-size: 22px; background: linear-gradient(to right, #994f00 0%, #EF7123 100%); color:#ffffff" />
                        <%--<p id="date" name="date" runat="server"></p>--%>
                    </td>
                </tr>
            </tbody>
        </table>        
    </center>
    


</asp:Content>
