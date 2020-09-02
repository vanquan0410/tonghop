<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd_3.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BatDongSan.Page.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
     <h3  style="color:forestgreen">Dịch Vụ Đăng Tin Bán / Cho Thuê Nhà Đất, Căn Hộ Hiệu Quả Số 1 Việt Nam.</h3>
    <p>19/3/2019</p>
    <u> <a>Hãy Xem Người Tìm Mua / Tìm Thuê Phản Hồi Như Thế Nào Vê Website Của Chúng Tôi</a></u>
    <br />
    <br />
     <asp:Image ID="Image1" runat="server" ImageUrl="~/images/anhdangtin.png"/>
    
    <asp:Image ID="Image2" runat="server"  ImageUrl="~/images/anhdangtin2.png"/>
     <asp:Image ID="Image3" runat="server"  ImageUrl="~/images/anhdangtin3.png"/>
     <br />
<br />

    <p style="text-align:center;color:red ;font-size:50px">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="QLDangTin.aspx">Click>>>Đăng Tin Tại Đây</asp:HyperLink>
    </p>
    

<br />
     <asp:Image ID="Image4" runat="server" ImageUrl="~/images/anhdangtin4.png"/>
<br />
<br />
<br />
<br />
<br />
</asp:Content>
