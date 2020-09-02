using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BULs;
using DTO;
using System.Data;

namespace BatDongSan.Page
{
    public partial class QLDangTin : System.Web.UI.Page
    {
        LoaiTinBUL loaitin = new LoaiTinBUL();
        ThanhPhoBUL phoBUL = new ThanhPhoBUL();
        QuanBUL quanBUL = new QuanBUL();
        PhuongBUL phuongBUL = new PhuongBUL();
        DangTinBUL DangTin = new DangTinBUL();
        MucTinBUS mucTinBus = new MucTinBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
            DataTable da = new DataTable();
            da = loaitin.getLoaiTin();
            if (!IsPostBack)
            {
                CanBanChoThue.DataSource = da;
                CanBanChoThue.DataTextField = "Name_LT";
                CanBanChoThue.DataValueField = "ID_LT";
                CanBanChoThue.DataBind();

               
            }
            if (!IsPostBack)
            {
                ddLTinh.DataSource = phoBUL.getListThanhPho();
                ddLTinh.DataTextField = "Name_TP";
                ddLTinh.DataValueField = "ID_TP";
                ddLTinh.DataBind();
            }
           


        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                ddlphuong.DataSource = phuongBUL.getListPhuong(ddlhuyen.SelectedValue);
                ddlphuong.DataTextField = "Name_P";
                ddlphuong.DataValueField = "ID_P";
                ddlphuong.DataBind();
            
           
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                ddlhuyen.DataSource = quanBUL.getListQuan(ddLTinh.SelectedValue);
                ddlhuyen.DataTextField = "Name_Q";
                ddlhuyen.DataValueField = "ID_Q";
                ddlhuyen.DataBind();
           

            
        }

        protected void CanBanChoThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMucTinDang.DataSource = mucTinBus.hienThiMucTin(Convert.ToInt32(CanBanChoThue.SelectedValue));
            ddlMucTinDang.DataTextField = "Name_MT";
            ddlMucTinDang.DataValueField = "ID_MT";
            ddlMucTinDang.DataBind();
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
           
        }

        public void savefileupload()
        {
            String strfilePath;
            if (FileUpload1.FileName != "")
            {
                strfilePath = Server.MapPath("../images/products/" + FileUpload1.FileName);
                FileUpload1.PostedFile.SaveAs(strfilePath);
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TinDangDTO tindang = new TinDangDTO();
            BatDongSanDTO BDS = new BatDongSanDTO();
            UserBUS user = new UserBUS();
            userDTO us = new userDTO();
            DangTinBUL dangTin = new DangTinBUL();

            try
            {



                BDS.gia = Convert.ToSingle(txtGia.Text);
                BDS.dienTich = Convert.ToSingle(txtDienTich.Text);
                BDS.rongDuong = Convert.ToSingle(txtChieuRongHem.Text);
                BDS.chieuDai = Convert.ToSingle(txtChieuDai.Text);
                BDS.chieuRong = Convert.ToSingle(txtChieuRong.Text);
                BDS.ketCau = txtKetCau.Text;
                BDS.motaChiTiet = txtChiTiet.Text;



                BDS.id_P = Convert.ToInt32(ddlphuong.SelectedValue);

                BDS.phoTo = "~/Images/Products/" + FileUpload1.FileName;
                if (DangTin.ThemBatDongSan(BDS) == true)
                {
                    savefileupload();
                    tindang.id_BDS = DangTin.LayIdBatDongSan();
                    tindang.idMucTin = Convert.ToInt32(ddlMucTinDang.SelectedValue);
                    tindang.title = txtTitle.Text;
                    tindang.ngayDang = txtNgayDangTin.Text;
                    tindang.ttThanhToan = 1;

                    us.sdt = txtSoDT.Text;
                    us.name = txtTenChinhChu.Text;

                    if (user.ktUser(us.sdt) == true)
                    {
                        user.themuser(us);
                        us.idUser = user.LayIdUser();
                        tindang.userId = us.idUser;
                    }
                    else
                    {
                        us.idUser = user.LayIdUserDaTonTai(us.sdt);
                        tindang.userId = us.idUser;
                    }
                    DangTin.ThemTin(tindang);

                    int id = dangTin.LayIdDangTin();
                    Response.Redirect("ThanhToan.aspx?id="+id);

                }
                else
                {
                    lbThongBao.Visible = true;
                    lbThongBao.Text = "Them tin That Bai Kiem tra lai";
                }
            }
            catch
            {
                lbThongBao.Visible = true;
                lbThongBao.Text = "khong duoc de trong vu long kien tra lai";
            }
        }
    }
}