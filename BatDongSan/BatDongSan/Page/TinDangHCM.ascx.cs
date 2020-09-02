using BULs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BatDongSan.Page
{
    public partial class TinDangHCM : System.Web.UI.UserControl
    {
        DangTinBUL dangTinBUL = new DangTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = dangTinBUL.getListDangTinHCM();
            DataList1.DataBind();
        }
    }
}