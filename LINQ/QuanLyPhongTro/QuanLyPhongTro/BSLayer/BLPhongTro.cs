using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLPhongTro
    {
        readonly QuanLyPhongTroDataContext db;
        public BLPhongTro()
        {
            db = QuanLyPhongTroDataContext.Instance;
        }
        public DataTable LayTatCaPhongTro()
        {
            var query = from ph in db.PhongTroes
                        select ph;
            return query.ToDataTable();
        }

        public DataTable LayPhongTrong()
        {
            var query = from ph in db.PhongTroes
                        where ph.NguoiThues.Count == 0
                        select ph;
            return query.ToDataTable();
        }

        public object[] LayTatCaDiaChi()
        {
            var query = (from ph in db.PhongTroes
                            select ph.DiaChi).Distinct();
            return query.ToArray();
        }

        public DataTable TimKiemPhong(string diaChi, int dienTich, int soNgToiDa, double tienThue, bool gac, bool thuCung)
        {
            var query = from ph in db.PhongTroes
                        where diaChi == ph.DiaChi &&
                        Math.Abs(dienTich - ph.DienTich) <= 3 &&
                        Math.Abs(soNgToiDa - ph.SoNguoiToiDa) <= 1 &&
                        Math.Abs(tienThue - ph.TienThue) <= 400000 &&
                        gac == ph.CoGac && thuCung == ph.ChoNuoiThuCung &&
                        ph.NguoiThues.Count() == 0
                        select ph;
            return query.ToDataTable();
        }

        public PhongTroe TimTheoMaSo(string msPhong)
        {
            var query = (from ph in db.PhongTroes
                            where msPhong == ph.MaSo
                            select ph).FirstOrDefault();
            return query;
        }

        public int DemSoNguoiDangO(string msPhong)
        {
            PhongTroe ph = TimTheoMaSo(msPhong);
            return ph.NguoiThues.Count();
        }

        public void XoaPhong(string msPhong)
        {
            PhongTroe ph = TimTheoMaSo(msPhong);
            db.PhongTroes.DeleteOnSubmit(ph);
            db.SubmitChanges();
        }

        public void ThemPhong(string machutro, string mp, double dt, string dc, int Songuoi, bool cogac, bool thucung, double tienthue, double tiendien, double tiennuoc, double tienrac)
        {
            ChuTroe x = db.ChuTroes.Where(p => p.MaSo == machutro).SingleOrDefault();
            PhongTroe res = new PhongTroe()
            {
                MaSo = mp,
                DienTich = dt,
                DiaChi = dc,
                SoNguoiToiDa = Songuoi,
                CoGac = cogac,
                ChoNuoiThuCung = thucung,
                TienThue = tienthue,
                TienDien = tiendien,
                TienNuoc = tiennuoc,
                TienRac = tienrac,
                ChuTroe = x

            };
            db.PhongTroes.InsertOnSubmit(res);
            db.SubmitChanges();
        }

        public bool DatGioiHanNguoiO(string maSo)
        {
            PhongTroe ph = TimTheoMaSo(maSo);
            return ph.SoNguoiToiDa >= ph.NguoiThues.Count();
        }

        public DataTable TimTheoChuTro(string maChuTro)
        {
            var query = from ph in db.PhongTroes
                        where ph.ChuTroe.MaSo == maChuTro
                        select ph;
            return query.ToDataTable();
        }
    }
}
