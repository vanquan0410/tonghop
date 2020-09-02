using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BULs;
namespace BatDongSan.Page
{
    public partial class QLDangNhap : System.Web.UI.Page
    {
        QLTincs qlTin = new QLTincs();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(Request.QueryString["id"].ToString());
            GridView1.DataSource = qlTin.TinDangHienThi(id);
            GridView1.DataBind();
            GridView1.Columns[0].Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            GridView1.DataSource = qlTin.TinDangChoDuyet(id);
            GridView1.DataBind();
            GridView1.Columns[0].Visible = true;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            GridView1.DataSource = qlTin.spBan(id);
            GridView1.DataBind();
            GridView1.Columns[0].Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            Response.Redirect("ThanhToan.aspx?id=" + id);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            GridView1.DataSource = qlTin.spThue(id);
            GridView1.DataBind();
            GridView1.Columns[0].Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QLDangTin.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = GridView1.SelectedIndex;
            int id = Convert.ToInt32(GridView1.Rows[dong].Cells[1].Text);
            Response.Redirect("ThanhToan.aspx?id=" + id);
        }
    }
}