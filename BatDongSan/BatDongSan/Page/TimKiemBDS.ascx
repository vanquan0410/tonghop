<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TimKiemBDS.ascx.cs" Inherits="BatDongSan.Page.TimKiem" %>




<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>





<table class="auto-style1">
    <tr>
        <td colspan="3">
            <asp:Label ID="Label2" runat="server" Text="Ban dang tim kiem nha dat,can ho chinh chu"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="*** Xin chon tim mua hoac tim thue theo loai BDS,Dien tich,gia"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>B1:ChonTim mua,Thue</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>B2:Chon Loai BDS</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>Khoang dien tich</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="DropDownList4" runat="server">
                <asp:ListItem>Khoang Gia</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server">Tim theo tu khoa</asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Tim Kiem" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="Label1" runat="server" Text="Meo nho"></asp:Label>
        </td>
    </tr>
</table>





