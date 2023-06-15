using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLHopDong
    {
        QLPhongTroCodeFristModel db;

        public BLHopDong()
        {
            db = QLPhongTroCodeFristModel.Instance;
        }

        public void ThemHopDong(DateTime ngTao, double coc, int thoiHan, ChuTro chuTro, NguoiThue ngThue, PhongTro ph)
        {
            string maSo = (Convert.ToInt16(db.HopDongs.Max(x => x.MaSo)) + 1).ToString("D4");
            HopDong hd = new HopDong(maSo, ngTao, coc, thoiHan, false, null, chuTro, ngThue, ph);
            db.HopDongs.Add(hd);
        }

        public HopDong TimHopDongCoHieuLuc(NguoiThue ngThue)
        {
            var query = (from hd in db.HopDongs
                         where ngThue.MaSo == hd.NguoiThue.MaSo &&
                         hd.NgayKetThuc == null
                         select hd).FirstOrDefault();
            return query;
        }

        public void KetThucHopDong(HopDong hd)
        {
            if (hd.NgayKetThuc == null)
            {
                hd.NgayKetThuc = DateTime.Today;
                db.SaveChanges();
            }
        }

        public bool LayTienCoc(HopDong hd)
        {
            if (!hd.DaLayTienCoc && KiemTraHanCoc(hd))
            {
                hd.DaLayTienCoc = true;
                db.SaveChanges();
            }
            return false;
        }

        private bool KiemTraHanCoc(HopDong hd)
        {
            DateTime ngHopLe = hd.NgayTao.AddMonths(hd.ThoiHanCoc);
            return ngHopLe >= DateTime.Today;
        }
    }
}
