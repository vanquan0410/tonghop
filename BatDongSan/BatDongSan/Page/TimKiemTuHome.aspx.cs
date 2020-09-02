using BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class TimKiemTuHome : System.Web.UI.Page
    {
        DangTinBUL dangTinBUL = new DangTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString["Name_TP"]);
            //Response.Write(Request.QueryString["ID_TP"]);
            //Response.Write(Request.QueryString["ID_Q"]);
            //Response.Write(Request.QueryString["ID_P"]);

            int ID_TP = int.Parse(Request.QueryString["ID_TP"]);
            if (Request.QueryString["ID_Q"].Equals("Chon Quan,Huyen"))
            {
                DataList1.DataSource = dangTinBUL.TimKiemTrenThanhPho(ID_TP);
                DataList1.DataBind();
            }
            else
            {
                int ID_Q = int.Parse(Request.QueryString["ID_Q"]);
                if (Request.QueryString["ID_P"].Equals("Chon Phuong,Xa"))
                {
                    DataList1.DataSource = dangTinBUL.TimKiemTrenThanhPho_Quan(ID_Q);
                    DataList1.DataBind();
                }
                else
                {
                    int ID_P = int.Parse(Request.QueryString["ID_P"]);
                    DataList1.DataSource = dangTinBUL.TimKiemTrenThanhPho_Quan_Phuong(ID_P);
                    DataList1.DataBind();
                }
            }
        }
    }
}