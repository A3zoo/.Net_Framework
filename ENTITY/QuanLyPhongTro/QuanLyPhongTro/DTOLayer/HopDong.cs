using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class HopDong
    {
        [Key] public string MaSo { get; set; }
        public DateTime NgayTao { get; set; }
        public double TienCoc { get; set; }
        public int ThoiHanCoc { get; set; }
        public bool DaLayTienCoc { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public virtual ChuTro ChuTro { get; set; }
        public virtual NguoiThue NguoiThue { get; set; }
        public virtual PhongTro PhongTro { get; set; }

        public HopDong() { }
        public HopDong(string maSo, DateTime ngayTao, double tienCoc, int thoiHanCoc, bool daLayTienCoc, DateTime? ngayKetThuc, ChuTro chuTro, NguoiThue nguoiThue, PhongTro phongTro)
        {
            MaSo = maSo;
            NgayTao = ngayTao;
            TienCoc = tienCoc;
            ThoiHanCoc = thoiHanCoc;
            DaLayTienCoc = daLayTienCoc;
            NgayKetThuc = ngayKetThuc;
            ChuTro = chuTro;
            NguoiThue = nguoiThue;
            PhongTro = phongTro;
        }
    }
}
