<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd_3.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="BatDongSan.Page.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
    <h1>Nếu là thành viên mới >>> <asp:HyperLink ID="HyperLink1" runat="server">Đăng Ký</asp:HyperLink></h1>
    <p>&nbsp;</p>
    <table class="auto-style3">
        <tr>
            <td>
             <h2 style="color:red"><asp:Label ID="ThongBao" runat="server" Text="Label" Visible="False"></asp:Label> </h2>
                <br />
                <br />
                Số Điện Thoại(nếu là CTV Thì điền số CMND)</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtSDT" runat="server" Height="30px" Width="278px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mật Khẩu</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtMK" runat="server" Height="28px" Width="272px"></asp:TextBox>
                <br />
            </td>
        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Ghi Nhớ" />
                <br />
            </td>
        </tr>

        <tr>
            <td style="text-align:center;">
                <asp:Button ID="Button1" runat="server" Text="Đăng Nhập" Width="332px" Height="41px" BackColor="#ff3399" ForeColor="#ffffcc" OnClick="Button1_Click" />
                <br />
            </td>
        </tr>
    </table>

</asp:Content>
