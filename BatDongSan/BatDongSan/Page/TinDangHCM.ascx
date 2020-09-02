<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TinDangHCM.ascx.cs" Inherits="BatDongSan.Page.TinDangHCM" %>
<style type="text/css">
    .auto-style1 {
        width: 25%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Ho Chi Minh"></asp:Label>
            <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="287px">
                <AlternatingItemStyle BackColor="#F7F7F7" />
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("Title") %>' NavigateUrl='<%# "Products.aspx?ID_TD="+Eval("ID_TD").ToString() %>'></asp:HyperLink>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            </asp:DataList>
        </td>
    </tr>
</table>

