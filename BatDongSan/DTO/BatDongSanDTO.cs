using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BatDongSanDTO
    {
        private int _idBDS;

        public int idBDS
        {
            get { return _idBDS; }
            set { _idBDS = value; }
        }

        private float _gia;

        public float gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        private float _dienTich;

        public float dienTich
        {
            get { return _dienTich; }
            set { _dienTich = value; }
        }

        private float _rongDuong;

        public float rongDuong
        {
            get { return _rongDuong; }
            set { _rongDuong = value; }
        }


        private float _chieuRong;

        public float chieuRong
        {
            get { return _chieuRong; }
            set { _chieuRong = value; }
        }

        private float _chieuDai;

        public float chieuDai
        {
            get { return _chieuDai; }
            set { _chieuDai = value; }
        }



        private String _ketCau;

        public String ketCau
        {
            get { return _ketCau; }
            set { _ketCau = value; }
        }

        private String _moTaChiTiet;

        public String motaChiTiet
        {
            get { return _moTaChiTiet; }
            set { _moTaChiTiet = value; }
        }

        private int _id_P;

        public int id_P
        {
            get { return _id_P; }
            set { _id_P = value; }
        }

        private String _phoTo;

        public String phoTo
        {
            get { return _phoTo; }
            set { _phoTo = value; }
        }


    }
}
