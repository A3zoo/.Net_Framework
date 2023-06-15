using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class NguoiDungNguoiThue : NguoiDung
    {
        public string NguoiThue_MaSo { get; set; }
        public virtual NguoiThue NguoiThue { get; set; }
    }
}
