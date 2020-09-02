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
    public partial class Products : System.Web.UI.Page
    {
        DangTinBUL dangTinBUL = new DangTinBUL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID_TD = int.Parse(Request.QueryString["ID_TD"].ToString());
            DataList1.DataSource = dangTinBUL.getListDangTin_ID(ID_TD);
            DataList1.DataBind();
        }

        protected void btnHienThiSDT_Click(object sender, EventArgs e)
        {

        }
    }
}