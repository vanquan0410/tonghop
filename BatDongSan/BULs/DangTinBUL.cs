using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BULs
{
    public class DangTinBUL
    {
        DataProvider provider = new DataProvider();
        public DataTable getListDangTin()
        {
            DataTable data = new DataTable();
            string query = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP";
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable getListDangTin_ID(int ID_TD)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where ID_TD={0}",ID_TD);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable getListDangTinHN()
        {
            DataTable data = new DataTable();
            string query = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where ThanhPho.ID_TP=2";
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable getListDangTinHCM()
        {
            DataTable data = new DataTable();
            string query = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where ThanhPho.ID_TP=1";
            data = provider.ExecuteQuery(query);
            return data;
        }

        public DataTable TimKiemTrenThanhPho(int ID_TP)
        {
            DataTable data = new DataTable();
            string query =string.Format( "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where ThanhPho.ID_TP={0}",ID_TP);
            data = provider.ExecuteQuery(query);
            return data;
        }

        public DataTable DuLieuNangCao()
        {
            DataTable data = new DataTable();
            string query = string.Format("select NgayDang,Name_P,Gia,DienTich,RongDuong,TaiKhoan.ID_SDT from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join TaiKhoan on TaiKhoan.ID_SDT=TinDang.ID_SDT");
            data = provider.ExecuteQuery(query);
            return data;
        }

        public Boolean ThemBatDongSan(BatDongSanDTO BDSDTO)
        {
            String sql = String.Format("insert into BatDongSan values({0},{1},{2},{3},'{4}','{5}','{6}',{7},'{8}')", BDSDTO.gia,BDSDTO.dienTich,BDSDTO.rongDuong,BDSDTO.chieuRong,BDSDTO.chieuDai,BDSDTO.ketCau,BDSDTO.motaChiTiet,BDSDTO.id_P,BDSDTO.phoTo);
            try
            {
                provider.excutenonquery(sql);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public int LayIdBatDongSan()
        {
            String sql = "select top 1 ID_BDS from BatDongSan order by ID_BDS desc";
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public void ThemTin(TinDangDTO tinDang)
        {
            String sql = String.Format("insert into TinDang values('{0}',{1},{2},'{3}',{4},{5})", tinDang.title,tinDang.id_BDS,tinDang.idMucTin,tinDang.ngayDang,tinDang.ttThanhToan,tinDang.userId);
            provider.excutenonquery(sql);
        }

        public int LayIdDangTin()
        {
            String sql = "select top 1 ID_TD from TinDang order by ID_TD desc";
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }


    }
}
