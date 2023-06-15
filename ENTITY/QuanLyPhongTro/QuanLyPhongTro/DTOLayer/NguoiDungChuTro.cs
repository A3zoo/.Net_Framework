using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class NguoiDungChuTro: NguoiDung
    {
        public virtual ChuTro ChuTro { get; set; }

        public NguoiDungChuTro() { }

        public NguoiDungChuTro(string tenDangNhap, string matKhau, ChuTro chuTro): base(tenDangNhap, matKhau)
        {
            ChuTro = chuTro;
        }
    }
}
