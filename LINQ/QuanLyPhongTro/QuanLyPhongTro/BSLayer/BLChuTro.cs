using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLChuTro
    {
        readonly QuanLyPhongTroDataContext db;
        public BLChuTro()
        {
            db = QuanLyPhongTroDataContext.Instance;
        }

        public void ThemChuTro(ChuTroe chuTro)
        {
            db.ChuTroes.InsertOnSubmit(chuTro);
            db.SubmitChanges();
        }

        public bool SoHuuPhongTro(string msChuTro, string msPhong)
        {
            PhongTroe ph = db.PhongTroes.Where(x => x.MaSo == msPhong).FirstOrDefault();
            return ph.ChuTroe.MaSo == msChuTro;
        }
    }
}
