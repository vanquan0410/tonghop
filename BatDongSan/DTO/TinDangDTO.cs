using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinDangDTO
    {
        private int _id_TD;

        public int id_TD
        {
            get { return _id_TD; }
            set { _id_TD = value; }
        }

        public String title { get; set; }

        public int id_BDS { get; set; }

        public int idMucTin { get; set; }

        public String ngayDang { get; set; }

        public int ttThanhToan { get; set; }


        public int userId { get; set; }

    }
}
