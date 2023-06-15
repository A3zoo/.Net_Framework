using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class NguoiDungNguoiThue: NguoiDung
    {
        public virtual NguoiThue NguoiThue { get; set; }

        public NguoiDungNguoiThue() { }

        public NguoiDungNguoiThue(string tenDangNhap, string matKhau, NguoiThue nguoiThue): base(tenDangNhap, matKhau)
        {
            NguoiThue = nguoiThue;
        }
    }
}
