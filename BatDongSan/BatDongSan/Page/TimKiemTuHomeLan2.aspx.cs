using BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class TimKiemTuHomeLan2 : System.Web.UI.Page
    {
        //DangTinBUL dt = new DangTinBUL();
        LoaiTinBUL loaiTinBUL = new LoaiTinBUL();
        MucTinBUL mucTinBUL = new MucTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int iD_tp = int.Parse(Request.QueryString["ID_TP"].ToString());
            int iD_lt = int.Parse(Request.QueryString["ID_L"].ToString());
            if (Request.QueryString["ID_M"].ToString().Equals("B2:Chon Loai BDS"))
            {
                DataList1.DataSource = loaiTinBUL.timKiemTrenLoaiTin(iD_lt, iD_tp);
                DataList1.DataBind();
            }
            else
            {
                if(Request.QueryString["DienTich"].ToString()== "Khoang dien tich" || Request.QueryString["DienTich"].ToString()== "Tat ca")
                {
                    if (Request.QueryString["Gia"].ToString() == "ThoaThuan" || Request.QueryString["Gia"].ToString() == "Khoang Gia")
                    {
                        int iD_mt = int.Parse(Request.QueryString["ID_M"].ToString());
                        //Response.Write(Request.QueryString["ID_M"].ToString());
                        DataList1.DataSource = mucTinBUL.timKiemTrenMucTin(iD_mt, iD_tp);
                        DataList1.DataBind();
                    }
                    else
                    {
                        int iD_mt = int.Parse(Request.QueryString["ID_M"].ToString());
                        //Response.Write(Request.QueryString["ID_M"].ToString());
                        string gia = Request.QueryString["Gia"].ToString();
                        DataList1.DataSource = mucTinBUL.timKiemTrenMucTin_Gia(iD_mt, iD_tp, gia);
                        DataList1.DataBind();
                    }   
                }
                else
                {
                    if (Request.QueryString["Gia"].ToString() == "ThoaThuan" || Request.QueryString["Gia"].ToString() == "Khoang Gia")
                    {
                        int iD_mt = int.Parse(Request.QueryString["ID_M"].ToString());
                        string dientich = Request.QueryString["DienTich"].ToString();
                        //Response.Write(Request.QueryString["ID_M"].ToString());
                        DataList1.DataSource = mucTinBUL.timKiemTrenMucTin_DienTich(iD_mt, iD_tp, dientich);
                        DataList1.DataBind();
                    }
                    else
                    {
                        int iD_mt = int.Parse(Request.QueryString["ID_M"].ToString());
                        string dientich = Request.QueryString["DienTich"].ToString();
                        string gia = Request.QueryString["Gia"].ToString();
                        //Response.Write(Request.QueryString["ID_M"].ToString());
                        DataList1.DataSource = mucTinBUL.timKiemTrenMucTin_DienTich_Gia(iD_mt, iD_tp,gia,dientich);
                        DataList1.DataBind();
                    }
                }
            }
        }
    }
}