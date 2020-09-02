using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class LoaiTinBUL
    {
        DataProvider provider = new DataProvider();
        
        public DataTable getListLoaiTin()
        {
            DataTable data = new DataTable();
            string query = "select * from LoaiTin";
            data = provider.ExecuteQuery(query);
            return data;
        }
        public DataTable timKiemTrenLoaiTin(int ID_LT,int ID_Tp)
        {
            DataTable data = new DataTable();
            string query =string.Format("select * from TinDang join BatDongSan on BatDongSan.ID_BDS=TinDang.ID_BDS join Phuong on Phuong.ID_P=BatDongSan.ID_P join Quan on Quan.ID_Q=Phuong.ID_Q join ThanhPho on ThanhPho.ID_TP=Quan.ID_TP join MucTin on MucTin.ID_MT=TinDang.ID_MT join LoaiTin on LoaiTin.ID_LT=MucTin.ID_LT where LoaiTin.ID_LT={0} and ThanhPho.ID_TP={1}",ID_LT,ID_Tp);
            data = provider.ExecuteQuery(query);
            return data;
        }
    }
}
