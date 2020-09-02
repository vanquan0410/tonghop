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
    public partial class Home : System.Web.UI.Page
    {
        DangTinBUL dt = new DangTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = dt.getListDangTin();
            DataList1.DataBind();
        }
    }
}