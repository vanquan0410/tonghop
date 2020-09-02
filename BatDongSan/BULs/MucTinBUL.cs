using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class MucTinBUL
    {
        DataProvider provider = new DataProvider();
        public DataTable getlistMucTin(int ID_LT)
        {
            DataTable data = new DataTable();
            string query =string.Format("select * from MucTin where ID_LT={0}",ID_LT);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable timKiemTrenMucTin(int ID_MT, int ID_Tp)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where MucTin.ID_MT={0} and ThanhPho.ID_TP={1}", ID_MT, ID_Tp);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable timKiemTrenMucTin_DienTich(int ID_MT, int ID_Tp,string dt)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where MucTin.ID_MT={0} and ThanhPho.ID_TP={1} and DienTich between {2}", ID_MT, ID_Tp,dt);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable timKiemTrenMucTin_Gia(int ID_MT, int ID_Tp, string gia)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where MucTin.ID_MT={0} and ThanhPho.ID_TP={1} and Gia between {2}", ID_MT, ID_Tp, gia);
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable timKiemTrenMucTin_DienTich_Gia(int ID_MT, int ID_Tp, string gia,string dientich)
        {
            DataTable data = new DataTable();
            string query = string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where MucTin.ID_MT={0} and ThanhPho.ID_TP={1} and Gia between {2} and DienTich between {3}", ID_MT, ID_Tp, gia,dientich);
            data = provider.ExecuteQuery(query);
            return data;
        }
    }
}
