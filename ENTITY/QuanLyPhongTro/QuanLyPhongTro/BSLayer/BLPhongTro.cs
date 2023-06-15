using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.BSLayer
{
    public class BLPhongTro
    {
        readonly QLPhongTroCodeFristModel db;
        public BLPhongTro()
        {
            db = QLPhongTroCodeFristModel.Instance;
        }
        public DataTable LayTatCaPhongTro()
        {
            var query = from ph in db.PhongTros
                        select ph;
            return query.ToDataTable();
        }

        public DataTable LayPhongTrong()
        {
            var query = from ph in db.PhongTros
                        where ph.NguoiDangThue.Count == 0
                        select ph;
            return query.ToDataTable();
        }

        public object[] LayTatCaDiaChi()
        {
            var query = (from ph in db.PhongTros
                            select ph.DiaChi).Distinct();
            return query.ToArray();
        }

        public DataTable TimKiemPhong(string diaChi, int dienTich, int soNgToiDa, double tienThue, bool gac, bool thuCung)
        {
            var query = from ph in db.PhongTros
                        where diaChi == ph.DiaChi &&
                        Math.Abs(dienTich - ph.DienTich) <= 3 &&
                        Math.Abs(soNgToiDa - ph.SoNguoiToiDa) <= 1 &&
                        Math.Abs(tienThue - ph.TienThue) <= 400000 &&
                        gac == ph.CoGac && thuCung == ph.ChoNuoiThuCung &&
                        ph.NguoiDangThue.Count() == 0
                        select ph;
            return query.ToDataTable();
        }

        public PhongTro TimTheoMaSo(string msPhong)
        {
            var query = (from ph in db.PhongTros
                            where msPhong == ph.MaSo
                            select ph).FirstOrDefault();
            return query;
        }

        public DataTable TimTheoChuTro(string maChuTro)
        {
            var query = from ph in db.PhongTros
                        where ph.ChuTro.MaSo == maChuTro
                        select ph;
            return query.ToDataTable();
        }

        public int DemSoNguoiDangO(string msPhong)
        {
            PhongTro ph = TimTheoMaSo(msPhong);
            return ph.NguoiDangThue.Count();
        }

        public void XoaPhong(string msPhong)
        {
            PhongTro ph = TimTheoMaSo(msPhong);
            db.PhongTros.Remove(ph);
            db.SaveChanges();
        }

        public void ThemPhong(string machutro, string mp, double dt, string dc, int Songuoi, bool cogac, bool thucung, double tienthue, double tiendien, double tiennuoc, double tienrac)
        {
            ChuTro x = db.ChuTroes.Where(p => p.MaSo == machutro).SingleOrDefault();
            PhongTro res = new PhongTro()
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
                ChuTro = x

            };
            db.PhongTros.Add(res);
            db.SaveChanges();
        }

        public bool DatGioiHanNguoiO(string maSo)
        {
            PhongTro ph = TimTheoMaSo(maSo);
            return ph.SoNguoiToiDa >= ph.NguoiDangThue.Count();
        }
    }
}
