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
            //DropDownList1.DataSource = phoBUL.getListThanhPho();
            //DropDownList1.DataTextField = "Name_TP";
            //DropDownList1.DataValueField = "ID_TP";
            //DropDownList1.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataSource = quanBUL.getListQuan(DropDownList1.SelectedValue);
            DropDownList2.DataTextField = "Name_Q";
            DropDownList2.DataValueField = "ID_Q";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "Chon Quan,Huyen");
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.Text != "Chon Quan,Huyen")
            {
                DropDownList3.DataSource = phuongBUL.getListPhuong(DropDownList2.SelectedValue);
                DropDownList3.DataTextField = "Name_P";
                DropDownList3.DataValueField = "ID_P";
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, "Chon Phuong,Xa");
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string id_tp = DropDownList1.SelectedValue.ToString();
            string id_q = DropDownList2.SelectedValue.ToString();
            string id_p = DropDownList3.SelectedValue.ToString();
            string name_tp = DropDownList1.SelectedItem.ToString();
            Response.Redirect(string.Format("TimKiemTuHome.aspx?ID_TP={0}&ID_Q={1}&ID_P={2}&Name_TP={3}", id_tp, id_q,id_p,name_tp));
            //Response.Redirect(string.Format("TimKiemTuHome.aspx?ID_TP={0}&ID_Q={1}&ID_P={2}&Name_TP={3}", DropDownList1.SelectedValue, DropDownList2.SelectedValue,DropDownList3.SelectedValue,DropDownList1.SelectedItem));
        }
    }
}