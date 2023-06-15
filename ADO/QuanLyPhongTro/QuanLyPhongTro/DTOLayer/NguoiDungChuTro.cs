using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class NguoiDungChuTro: NguoiDung
    {
        public virtual string ChuTro_MaSo { get; set; }
        public virtual ChuTro ChuTro { get; set; }
    }
}
