using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join Userr on Userr.id=TinDang.userid where ID_TD={0}", ID_TD);
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
        public DataTable TimKiemTrenThanhPho_Quan(int Q)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where Quan.ID_Q={0}", Q);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable TimKiemTrenThanhPho_Quan_Phuong(int P)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where Phuong.ID_P={0}", P);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable DuLieuNangCao()
        {
            DataTable data = new DataTable();
            string query = string.Format("select NgayDang,Name_P,Gia,DienTich,ChieuDai,ChieuRong,RongDuong,KetCau,sdt from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join Userr on Userr.id=TinDang.userid");
            data = provider.ExecuteQuery(query);
            return data;
        }

    }
}
