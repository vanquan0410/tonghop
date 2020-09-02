<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TimKiemBDS.ascx.cs" Inherits="BatDongSan.Page.TimKiem" %>




<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>





<table class="auto-style1">
    <tr>
        <td colspan="3">
            <asp:Label ID="Label2" runat="server" Text="Ban dang tim kiem nha dat,can ho chinh chu tai:"></asp:Label>
            <asp:Label ID="lblDiaChi" runat="server" Text="Label"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BatDongSanConnectionString %>" SelectCommand="SELECT * FROM [LoaiTin]"></asp:SqlDataSource>
            <br />
            <asp:Label ID="Label3" runat="server" Text="*** Xin chon tim mua hoac tim thue theo loai BDS,Dien tich,gia"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" DataSourceID="SqlDataSource1" DataTextField="Name_LT" DataValueField="ID_LT" Width="150px">
                <asp:ListItem Selected="True">B1:ChonTim mua,Thue</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="150px">
                <asp:ListItem>B2:Chon Loai BDS</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server" Width="150px">
                <asp:ListItem>Khoang dien tich</asp:ListItem>
                <asp:ListItem>Tat ca</asp:ListItem>
                <asp:ListItem Value="0 and 50">0-50m</asp:ListItem>
                <asp:ListItem Value="50 and 100">50-100m</asp:ListItem>
                <asp:ListItem Value="100 and 200">100-200m</asp:ListItem>
                <asp:ListItem Value="200 and 300">200-300m</asp:ListItem>
                <asp:ListItem Value="300 and 500">300-500m</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="DropDownList4" runat="server" Width="150px">
                <asp:ListItem>Khoang Gia</asp:ListItem>
                <asp:ListItem>Thoa Thuan</asp:ListItem>
                <asp:ListItem Value="0 and 10">10tr</asp:ListItem>
                <asp:ListItem Value="10 and 50">50tr</asp:ListItem>
                <asp:ListItem Value="50 and 100">100tr</asp:ListItem>
                <asp:ListItem Value="100 and 200">200tr</asp:ListItem>
                <asp:ListItem Value="200 and 500">500tr</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="txtTuKhoa" runat="server" placeholder="Tim theo tu khoa"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Tim Kiem" OnClick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="Label1" runat="server" Text="Meo nho"></asp:Label>
            <asp:Label ID="Label4" runat="server">Tin moi duoc cap nhap lien tuc hay kien tri tim kiem hoac ban co the tham khao goi dich vu du lieu nang cao khong phai tra phi---></asp:Label>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page/XemDuLieuNangCao.aspx">Tai Day</asp:HyperLink>
        </td>
    </tr>
</table>





