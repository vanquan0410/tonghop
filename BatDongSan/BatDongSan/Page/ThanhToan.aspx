<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd_3.Master" AutoEventWireup="true" CodeBehind="ThanhToan.aspx.cs" Inherits="BatDongSan.Page.ThanhToan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
    <asp:Image Width="100%" ID="Image1" runat="server" ImageUrl="~/images/anhthanhtoan.png"/>
    <br />
    <br />
    <h3><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page/WebForm1.aspx">>>> Xem Thêm Lý do Tại Sao Đăn gTin Tại Đây Lại Hiệu Quả Cao Và Tốt Như Vậy</asp:HyperLink></h3>
    <br />
    <br />
    <div>
        <p style="text-align:center">
		
                                       * Hiện tại có nhiều dịch vụ giả mạo thương hiệu; để đảm bảo an toàn, xin quý khách <br />chỉ dùng các thông tin & hình thức được cung cấp bên dưới để thanh toán!<br>
									   Cần hỗ trợ khác xin gọi: 0898.013.777 - Sàn TMĐT Duy Nhất Đăng Tin BĐS Chính Chủ <br />được cấp phép và bảo hộ thương hiệu.<br>
                                     </p>   

        <h3><u>Nội Dung Chuyển Khoản:</u></h3>
        <h3 style="color:red"> [Số Điện Thoại _DangTin] Hoặc[Số Điện Thoại Xem Nâng Cao] </h3>
                                         
   </div>
    <div>
                                <div>
                                    <h2>Thong Tin Tài Khoản Trực Tiếp</h2>
                                    <ul  style="margin-left:20px">
                                        <li> + Tài khoản 1: Ngân hàng Vietcombank VCB <br>
										Nguyễn Thiện  - Số TK: 0071000595214 - CN Hồ Chí Minh</li>
                                        <li> + Tài khoản 2: Ngân hàng Vietcombank VCB <br>
										Công ty TNHH Dịch Vụ Bất Động Sản DREAMS - Số TK: 0071001245454 - CN Hồ Chí Minh</li> 
                                    </ul>
                                </div>


        <hr />
        <hr />
        <div>
            <h2>Thanh toán ONLINE ATM/Visa/MasterCard/JCB - Internet Banking với Ngân Hàng của bạn</h2>
            <asp:Label ID="Label1" runat="server" Text="Điền số điện thoại liên hệ"></asp:Label> <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="28px" OnTextChanged="TextBox1_TextChanged" Width="693px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Điền Số Tiền Thanh Toán"></asp:Label>  
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="688px"></asp:TextBox>
            <br />
            <br />
            <p style="text-align:center">  <asp:Button ID="Button1" runat="server" Text="Thanh Toán" OnClick="Button1_Click" /></p>
            
            <br />

        </div>
                            </div>

</asp:Content>
