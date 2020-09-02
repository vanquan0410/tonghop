using BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class TimKiem : System.Web.UI.UserControl
    {
        LoaiTinBUL loaiTinBUL = new LoaiTinBUL();
        MucTinBUL mucTinBUL = new MucTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDiaChi.Text = Request.QueryString["Name_TP"];
            //Response.Write( Request.QueryString["ID_TP"]);
            //DropDownList1.DataSource = loaiTinBUL.getListLoaiTin();
            //DropDownList1.DataTextField = "Name_LT";
            //DropDownList1.DataValueField = "ID_LT";
            //DropDownList1.DataBind();
            //DropDownList1.Items.Insert(0, "B1:ChonTim mua,Thue");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.Text != "B1:ChonTim mua,Thue")
            {
                DropDownList2.DataSource = mucTinBUL.getlistMucTin(int.Parse(DropDownList1.SelectedValue));
                DropDownList2.DataTextField = "Name_MT";
                DropDownList2.DataValueField = "ID_MT";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, "B2:Chon Loai BDS");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id_tp=int.Parse(Request.QueryString["ID_TP"].ToString());
            string id_l = DropDownList1.SelectedValue.ToString();
            string id_m = DropDownList2.SelectedValue.ToString();
            string dientich = DropDownList3.SelectedValue.ToString();
            string gia = DropDownList4.SelectedValue.ToString();
            string tukhoa = txtTuKhoa.Text;

            Response.Redirect(string.Format("TimKiemTuHomeLan2.aspx?ID_TP={0}&ID_L={1}&ID_M={2}&DienTich={3}&Gia={4}&TuKhoa={5}",id_tp,id_l,id_m,dientich,gia,tukhoa));
        }
    }
}