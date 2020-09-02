using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using System.Data;

namespace BULs
{
    public class QLTincs
    {
        DataProvider data = new DataProvider();
        public DataTable TinDangHienThi(int id)
        {
            DataTable dt = new DataTable();
            // String sql = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where TTThanhToan=0";
            String sql = "select *from TinDang where TTThanhToan=0 and ID_TD=" + id;
            dt = data.ExecuteQuery(sql);
            return dt;
        }

        public DataTable TinDangChoDuyet(int id)
        {
            DataTable dt = new DataTable();
            // String sql = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where TTThanhToan=0";
            String sql = "select *from TinDang where TTThanhToan=1 and ID_TD=" + id;
            dt = data.ExecuteQuery(sql);
            return dt;
        }


        public DataTable spBan(int id)
        {
            DataTable dt = new DataTable();
            // String sql = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where TTThanhToan=0";
            String sql = "   select TinDang.ID_TD,TinDang.Title,TinDang.ID_BDS,TinDang.ID_MT,NgayDang,TTThanhToan,userid from TinDang join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where LoaiTin.ID_LT=1 and ID_TD="+id;
            dt = data.ExecuteQuery(sql);
            return dt;
        }

        public DataTable spThue(int id)
        {
            DataTable dt = new DataTable();
            // String sql = "select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP where TTThanhToan=0";
            String sql = "   select TinDang.ID_TD,TinDang.Title,TinDang.ID_BDS,TinDang.ID_MT,NgayDang,TTThanhToan,userid from TinDang join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where LoaiTin.ID_LT=2 and ID_TD="+id;
            dt = data.ExecuteQuery(sql);
            return dt;
        }
    }
}
