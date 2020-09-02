<%@ Page Title="" Language="C#" MasterPageFile="~/Page/FrontEnd_3.Master" AutoEventWireup="true" CodeBehind="QLDangTin.aspx.cs" Inherits="BatDongSan.Page.QLDangTin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 423px;
        }
        .auto-style5 {
            width: 423px;
            height: 47px;
        }
        .auto-style6 {
            height: 47px;
        }
        #TextArea1 {
            width: 646px;
            height: 179px;
        }
        .auto-style7 {
            width: 349px;
        }
        .auto-style8 {
            width: 524px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main_body" runat="server">
     <div style="background-color:#d57972; height:200px;padding-top:50px">
       <p style="text-align:center"> Muabanchinhchu.net là website duy nhất Việt Nam CHỈ đăng tin Chính Chủ, gọi là gặp ngay chủ nhà. Vì chỉ đăng tin chính chủ </p>
    <p style="text-align:center"> nên được người mua, nhà đầu tư và cả môi giới yêu thích và xem tin rất nhiêu. </p>
    <p style="text-align:center">..............</p>
    <p style="text-align:center">Sau khi hoàn thành nội dung đăng tin bên dướ. Bạn sẽ chọn các goisnthanh toán rẻ+ Hiệu quqr cao ở bưới tiếp theo </p>
    <p  style="text-align:center">...........</p>
    <p style="text-align:center"> tích hợp thanh toán online với các ngân hàng vô cùng tiện lợi</p>
    <p  style="text-align:center">Ban chưa Đăng nhập <span>Bạn Có thể <a style="color:red" href="#">Đăng Nhập</a> or <a href="#" style="color:red">Đăng Ký tài khoản</a> để quản lý chỉnh sửa tin đăng</span></p>
    <p style="text-align:center"> * Lưu ý: Chỉ đăng tin chính chủ + Số điện thoại chính chủ </p>

    </div>

     <asp:Image ID="Image2" runat="server"  ImageUrl="~/images/anhdangtin.png"/>
     <h2  style="background-color:deeppink;color:white;width:200px">Thông tin vị trí</h2>
     <hr style="background-color:blue"/>
     <br />
     <table class="auto-style3">
         <tr>
            <td class="auto-style4">
                <asp:Label ID="Label10" runat="server" Text="Cần Bán Cho Thuê" Font-Size="18px"></asp:Label>
                <br />
            </td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Mục Đăng Tin"  Font-Size="18px"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:DropDownList ID="CanBanChoThue" runat="server" Height="30px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="CanBanChoThue_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
            </td>
            <td class="auto-style6">&nbsp;<asp:DropDownList ID="ddlMucTinDang" runat="server" Height="30px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                </asp:DropDownList>
                &nbsp;<br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label11" runat="server" Text="Tỉnh Thành"  Font-Size="18px"></asp:Label>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:DropDownList ID="ddLTinh" runat="server" Height="30px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label12" runat="server" Text="Quận,Huyện"  Font-Size="18px"></asp:Label>
                <br />
            </td>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Phường Xã"  Font-Size="18px"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlhuyen" runat="server" Height="30px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
            </td>
            <td>
                <asp:DropDownList ID="ddlphuong" runat="server" Height="30px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label13" runat="server" Text="Số Nhà Đầy Đủ"  Font-Size="18px"></asp:Label>
                <br />
            </td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Tên đường"  Font-Size="18px"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:TextBox ID="txtsonha" runat="server" Height="30px" Width="200px"></asp:TextBox>
                <br />
            </td>
            <td>
                <asp:TextBox ID="txtTenDong" runat="server" Height="25px" Width="252px"></asp:TextBox>
                <br />
            </td>
        </tr>
     </table>

     <br />
    <br />
    <h2  style="background-color:deeppink;color:white;width:345px">Thong Tin Nhà đất căn hộ</h2>
    <hr />
     <table class="auto-style3">
          <tr>
            <td class="auto-style8">
                <asp:Label ID="Label17" runat="server" Text="Giá*" Font-Size="20px"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label18" runat="server" Text="Chọn mệnh giá"  Font-Size="20px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:TextBox ID="txtGia" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="ddlMenhGia" runat="server" Height="30px" Width="200px">
                    <asp:ListItem>ty</asp:ListItem>
                    <asp:ListItem>Trieu/Thang</asp:ListItem>
                    <asp:ListItem>Thoa Thuan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label19" runat="server" Text="Chiều Rộng " Font-Size="20px"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Chiều Dài" Font-Size="20px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:TextBox ID="txtChieuRong" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtChieuDai" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label20" runat="server" Text="Diện Tích(m2)" Font-Size="20px"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label24" runat="server" Text="Chiều rộng hẻm / đường *" Font-Size="20px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:TextBox ID="txtDienTich" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtChieuRongHem" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label21" runat="server" Text="Kết Cấu" Font-Size="20px"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:TextBox ID="txtKetCau" runat="server" Height="30px" Width="200px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label22" runat="server" Text="Số Phòng Ngủ*" Font-Size="20px"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label25" runat="server" Text="NGày Đăng Tin" Font-Size="20px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:DropDownList ID="ddlSoPhongNgu" runat="server" Height="30px" Width="200px">
                    <asp:ListItem>- Số Phòng Ngủ-</asp:ListItem>
                    <asp:ListItem>Khong Xác Định</asp:ListItem>
                    <asp:ListItem>1+</asp:ListItem>
                    <asp:ListItem>2+</asp:ListItem>
                    <asp:ListItem>3+</asp:ListItem>
                    <asp:ListItem>4+</asp:ListItem>
                    <asp:ListItem>5+</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="txtNgayDangTin" runat="server" Width="200px" Height="30px"></asp:TextBox>
                <br />
            </td>
        </tr>
     </table>
    <br />
    <br />
    <br />
     <h2  style="background-color:deeppink;color:white;width:244px">Thong Tin Lien He</h2>
         <hr style="background-color:blue"/>
     <br />
     <table class="auto-style3">
         <tr>
             <td>
                 <asp:Label ID="Label26" runat="server" Text="Tên Chính Chủ"></asp:Label>
             </td>
             <td>
                 <asp:Label ID="Label27" runat="server" Text="Số Điện Thoại Chính Chủ"></asp:Label>
             </td>
         </tr>
         <tr>
             <td>
                 <asp:TextBox ID="txtTenChinhChu" runat="server" Height="30px" Width="200px"></asp:TextBox>
             </td>
             <td>
                 <asp:TextBox ID="txtSoDT" runat="server" Height="30px" Width="200px"></asp:TextBox>
             </td>
         </tr>
     </table>
    <br />
    <br />
    <br />
     <h2  style="background-color:deeppink;color:white;width:484px">Mô Tả Chi Tiết Người Xem Dễ Nhìn Hơn</h2>
       <hr style="background-color:blue"/>
         Tiêu Đề Đăng Tin<br />
     <asp:TextBox ID="txtTitle" runat="server" Width="651px" Height="23px"></asp:TextBox>
     <br />
     <br />
     <br />
     Chi Tiết<br />
     <asp:TextBox ID="txtChiTiet" runat="server" Height="263px" Width="692px" Rows="10" TextMode="MultiLine"></asp:TextBox>
     <br />
     Hình ảnh Thực Tế*<br />
    <p style="color:brown;background-color:deepskyblue; height: 25px;">* up ảnh thực tế để thu hút nhiều người xem hơn, Giới hạn 3 ảnh</p>
     <asp:FileUpload ID="FileUpload1" runat="server" />
     <br />
     <asp:Image ID="Image3" runat="server" />
     <br />
     <br />
    <h2 style="color:red"><asp:Label ID="lbThongBao" runat="server" Text="Label" Visible="False"></asp:Label></h2>
     
     <br />
     <asp:Button ID="btnThem" runat="server" Height="73px" Text="Để Hoàn Thành Đăng Tin >> Tiếp Tục THanh Toán" Width="392px" BackColor="#ff3300" ForeColor="#ffffcc" OnClick="Button1_Click1" />
    <br />
<br />
    <br />
     
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page/WebForm1.aspx">>>> Xem Thêm Lý do Tại Sao Đăng Tin Tại Đây Lại Hiệu Quả Và Tốt Nhất Hiện Nay</asp:HyperLink>
<br />
<br />
<br />
<br />
</asp:Content>
