using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class PhongTro
    {
        public string MaSo { get; set; }
        public double DienTich { get; set; }
        public string DiaChi { get; set; }
        public int SoNguoiToiDa { get; set; }
        public bool CoGac { get; set; }
        public bool ChoNuoiThuCung { get; set; }
        public double TienThue { get; set; }
        public double TienDien { get; set; }
        public double TienNuoc { get; set; }
        public double TienRac { get; set; }

        public virtual ChuTro ChuTro { get; set; }
        public virtual List<NguoiThue> NguoiDangThue { get; set; }

        public PhongTro() { }

        public PhongTro(string maSo, double dienTich, string diaChi, int soNguoiToiDa, bool coGac, bool choNuoiThuCung, double tienThue, double tienDien, double tienNuoc, double tienRac, ChuTro chuTro, List<NguoiThue> nguoiDangThue)
        {
            MaSo = maSo;
            DienTich = dienTich;
            DiaChi = diaChi;
            SoNguoiToiDa = soNguoiToiDa;
            CoGac = coGac;
            ChoNuoiThuCung = choNuoiThuCung;
            TienThue = tienThue;
            TienDien = tienDien;
            TienNuoc = tienNuoc;
            TienRac = tienRac;
            ChuTro = chuTro;
            NguoiDangThue = nguoiDangThue;
        }
    }
}
