using BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class TinDangHN : System.Web.UI.UserControl
    {
        DangTinBUL dangTinBUL = new DangTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = dangTinBUL.getListDangTinHN();
            DataList1.DataBind();
        }
    }
}