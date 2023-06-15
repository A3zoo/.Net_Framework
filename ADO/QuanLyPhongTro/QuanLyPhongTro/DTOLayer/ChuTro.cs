using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class ChuTro: Nguoi
    {
        public virtual List<PhongTro> PhongTroSoHuu { get; set; }

        public ChuTro() { }

        public ChuTro(string maSo, string ten, string cCCD, DateTime ngaySinh, string queQuan, string sDT, List<PhongTro> phongTroSoHuu) : base(maSo, ten, cCCD, ngaySinh, queQuan, sDT)
        {
            PhongTroSoHuu = phongTroSoHuu;
        }
    }
}
