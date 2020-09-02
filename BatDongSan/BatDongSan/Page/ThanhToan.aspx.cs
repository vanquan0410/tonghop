using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BULs;
namespace BatDongSan.Page
{
    public partial class ThanhToan : System.Web.UI.Page
    {

        ThanhToanBUL thanhToanBUL = new ThanhToanBUL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void CheckBoxList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                thanhToanBUL.updateTinDang(id);
                Response.Redirect("ThongBaoThanhToan.aspx");
            }
            catch
            {
                Response.Redirect("DangNhap.aspx");
            }
            
        }
    }
}