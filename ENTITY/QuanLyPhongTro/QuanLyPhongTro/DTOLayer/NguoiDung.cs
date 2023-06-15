using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class NguoiDung
    {
        [Key] public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public NguoiDung() { }

        public NguoiDung(string tenDangNhap, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }
    }
}
