using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLChuTro
    {
        readonly QLPhongTroCodeFristModel db;
        public BLChuTro()
        {
            db = QLPhongTroCodeFristModel.Instance;
        }

        public void ThemChuTro(ChuTro chuTro)
        {
            db.ChuTroes.Add(chuTro);
            db.SaveChanges();
        }

        public bool SoHuuPhongTro(string msChuTro, string msPhong)
        {
            PhongTro ph = db.PhongTros.Where(x => x.MaSo == msPhong).FirstOrDefault();
            return ph.ChuTro.MaSo == msChuTro;
        }
    }
}
