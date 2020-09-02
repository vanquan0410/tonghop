using BULs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class Search : System.Web.UI.UserControl
    {
        ThanhPhoBUL phoBUL = new ThanhPhoBUL();
        QuanBUL quanBUL = new QuanBUL();
        PhuongBUL phuongBUL = new PhuongBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = phoBUL.getListThanhPho();
            DropDownList1.DataTextField = "Name_TP";
            DropDownList1.DataValueField = "ID_TP";
            DropDownList1.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataSource = quanBUL.getListQuan(DropDownList1.SelectedValue);
            DropDownList2.DataTextField = "Name_Q";
            DropDownList2.DataValueField = "ID_Q";
            DropDownList2.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.DataSource = phuongBUL.getListPhuong(DropDownList2.SelectedValue);
            DropDownList3.DataTextField = "Name_P";
            DropDownList3.DataValueField = "ID_P";
            DropDownList3.DataBind();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            Response.Redirect("TimKiemTuHome.aspx?ID_TP=" + int.Parse(DropDownList1.SelectedValue) + "");
        }
    }
}