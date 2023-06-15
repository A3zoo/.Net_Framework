using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLHopDong
    {
        QuanLyPhongTroDataContext db;

        public BLHopDong()
        {
            db = QuanLyPhongTroDataContext.Instance;
        }

        public void ThemHopDong(DateTime ngTao, double coc, int thoiHan, ChuTroe chuTro, NguoiThue ngThue, PhongTroe ph)
        {
            string maSo = (Convert.ToInt16(db.HopDongs.Max(x => x.MaSo)) + 1).ToString("D4");
            HopDong hd = new HopDong
            {
                MaSo = maSo,
                NgayTao = ngTao,
                TienCoc = coc,
                ThoiHanCoc = thoiHan,
                DaLayTienCoc = false,
                NgayKetThuc = null,
                ChuTroe = chuTro,
                NguoiThue = ngThue,
                PhongTroe = ph
            };
            db.HopDongs.InsertOnSubmit(hd);
            db.SubmitChanges();
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
                db.SubmitChanges();
            }
        }

        public bool LayTienCoc(HopDong hd)
        {
            if (!hd.DaLayTienCoc && KiemTraHanCoc(hd))
            {
                hd.DaLayTienCoc = true;
                db.SubmitChanges();
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
