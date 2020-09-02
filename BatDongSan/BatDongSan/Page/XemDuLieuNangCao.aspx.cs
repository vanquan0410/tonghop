using BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class XemDuLieuNangCao : System.Web.UI.Page
    {
        DangTinBUL dangTinBUL = new DangTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = dangTinBUL.DuLieuNangCao();
            GridView1.DataBind();
        }
    }
}