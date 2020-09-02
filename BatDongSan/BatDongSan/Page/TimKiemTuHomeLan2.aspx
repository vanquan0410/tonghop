<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd_1.Master" AutoEventWireup="true" CodeBehind="TimKiemTuHomeLan2.aspx.cs" Inherits="BatDongSan.Page.TimKiemTuHomeLan2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            margin-right: 148px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
    <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" CssClass="auto-style4" Width="715px">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
        <ItemTemplate>
            <table class="auto-style2" border="1">
                <tr>
                    <td rowspan="4">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/cart.jpg"/>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("Title") %>' NavigateUrl='<%# "Products.aspx?ID_TD="+Eval("ID_TD").ToString() %>'></asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("NgayDang") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("MoTaChiTiet") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Gia:"></asp:Label>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("Gia") %>'></asp:Label>
                        <asp:Label ID="Label7" runat="server" Text="Dien tich:"></asp:Label>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("DienTich") %>'></asp:Label>
                        <asp:Label ID="Label9" runat="server" Text="Vi Tri:"></asp:Label>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("Name_TP") %>'></asp:Label>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("Name_Q") %>'></asp:Label>
                        <asp:Label ID="Label12" runat="server" Text='<%# Eval("Name_P") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>
</asp:Content>
