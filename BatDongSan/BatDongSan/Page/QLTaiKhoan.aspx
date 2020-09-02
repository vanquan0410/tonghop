<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd_3.Master" AutoEventWireup="true" CodeBehind="QLTaiKhoan.aspx.cs" Inherits="BatDongSan.Page.QLDangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 240px;
        }
        .auto-style6 {
            height: 17px;
            width: 240px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
   
    <table class="auto-style3">
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Tạo Tin Đăng Mới" Height="50px" Width="230px" OnClick="Button1_Click" />
            </td>
            <td>
                <h2>
                     <asp:Label ID="Label10" runat="server" Text="Quản Lý Tin"></asp:Label>
                </h2>
               
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button2" runat="server" Text="Tin Đang Hiển Thị" Height="50px" OnClick="Button2_Click" Width="230px" />
            </td>
            <td rowspan="6">
                <asp:GridView ID="GridView1" runat="server" Height="300px" Width="474px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" Visible="False" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button3" runat="server" Text="Tin Chờ Duyệt" Height="50px" OnClick="Button3_Click" Width="230px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button4" runat="server" Text="SP Bán - MuaBanChinhChu" Height="50px" OnClick="Button4_Click" Width="230px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="Button5" runat="server" Text="Sp Thuê - MuaBanChinhChu" Height="50px" OnClick="Button5_Click" Width="230px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button6" runat="server" Text="Thanh Toan" Height="50px" OnClick="Button6_Click" Width="230px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
        </tr>
    </table>
   
</asp:Content>
