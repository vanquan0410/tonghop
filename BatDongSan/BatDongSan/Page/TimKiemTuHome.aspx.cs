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
            int ID_TP = int.Parse(Request.QueryString["ID_TP"]);
            DataList1.DataSource = dangTinBUL.TimKiemTrenThanhPho(ID_TP);
            DataList1.DataBind();
        }
    }
}