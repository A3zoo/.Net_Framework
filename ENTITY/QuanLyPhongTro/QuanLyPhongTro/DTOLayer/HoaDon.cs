using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class HoaDon
    {
        [Key] public string MaSo { get; set; }
        public int SoDienTieuThu { get; set; }
        public int SoNuocTieuThu { get; set; }
        public DateTime NgayDau { get; set; }
        public DateTime NgayCuoi { get; set; }
        public bool DaThanhToan { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public virtual PhongTro PhongTro { get; set; }

        public HoaDon() { }
        public HoaDon(string maSo, int soDienTieuThu, int soNuocTieuThu, DateTime ngayDau, DateTime ngayCuoi, bool daThanhToan, DateTime? ngayThanhToan, PhongTro phongTro)
        {
            MaSo = maSo;
            SoDienTieuThu = soDienTieuThu;
            SoNuocTieuThu = soNuocTieuThu;
            NgayDau = ngayDau;
            NgayCuoi = ngayCuoi;
            DaThanhToan = daThanhToan;
            NgayThanhToan = ngayThanhToan;
            PhongTro = phongTro;
        }
    }
}
