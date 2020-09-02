using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BULs;
namespace BatDongSan.Page
{
    public partial class DangNhap : System.Web.UI.Page
    {
        UserBUS user = new UserBUS();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.ktUser(txtSDT.Text) == false)
            {
                int id = user.LayIdUserDaTonTai(txtSDT.Text);
                Response.Redirect("QLTaiKhoan.aspx?id=" + id);
            }
            else
            {
                ThongBao.Visible = true;
                ThongBao.Text = "sai SDT hoac Mat Khau Vui long kt lai";
            }
        }
    }
}