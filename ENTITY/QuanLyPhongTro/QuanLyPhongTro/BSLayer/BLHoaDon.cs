using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLHoaDon
    {
        QLPhongTroCodeFristModel db;
        public BLHoaDon() 
        {
            db = QLPhongTroCodeFristModel.Instance;
        }

        public DataTable LayHoaDon()
        {
            var res = from c in db.HoaDons
                      select new
                      {
                          c.MaSo,
                          c.SoDienTieuThu,
                          c.SoNuocTieuThu,
                          c.NgayDau,
                          c.NgayCuoi,
                          c.DaThanhToan,
                          c.NgayThanhToan

                      };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaSo", typeof(string));
            dataTable.Columns.Add("SoDienTieuThu", typeof(int));
            dataTable.Columns.Add("SoNuocTieuThu", typeof(int));
            dataTable.Columns.Add("NgayDau", typeof(DateTime));
            dataTable.Columns.Add("NgayCuoi", typeof(DateTime));
            dataTable.Columns.Add("DaThanhToan", typeof(bool));
            dataTable.Columns.Add("NgayThanhToan", typeof(DateTime));

            foreach (var item in res)
            {
                dataTable.Rows.Add(
                    item.MaSo,
                    item.SoDienTieuThu,
                    item.SoNuocTieuThu,
                    item.NgayDau,
                    item.NgayCuoi,
                    item.DaThanhToan,
                    item.NgayThanhToan
                );
            }

            return dataTable;
        }

        public DataTable LayHoaDonTheoNguoiThue(NguoiThue ngThue)
        {
            var query = from hd in db.HoaDons
                        where hd.PhongTro.MaSo == ngThue.PhongTro.MaSo
                        select hd;
            return query.ToDataTable();
        }

        public double TinhTienDien(HoaDon hoaDon)
        {
            return hoaDon.SoDienTieuThu * hoaDon.PhongTro.TienDien;
        }

        public double TinhTienNuoc(HoaDon hoaDon)
        {
            return hoaDon.SoNuocTieuThu * hoaDon.PhongTro.TienNuoc;
        }

        public double TinhTongTien(HoaDon hoaDon)
        {
            return TinhTienDien(hoaDon) + TinhTienNuoc(hoaDon) + hoaDon.PhongTro.TienRac + hoaDon.PhongTro.TienThue;
        }

        public HoaDon TimHoaDonTheoMaSo(string maSo)
        {
            var query = (from hd in db.HoaDons
                            where hd.MaSo == maSo
                            select hd).FirstOrDefault();
            return query;
        }

        public void ThanhToanHoaDon(HoaDon hoaDon)
        {
            hoaDon.DaThanhToan = true;
            hoaDon.NgayThanhToan = DateTime.Today;
            db.SaveChanges();
        }

        public void ThemHoaDon(string maSo, int soDienTieuThu, int soNuocTieuThu, DateTime ngayDau, DateTime ngayCuoi, bool daThanhToan, DateTime ngayThanhToan, string maphongtro)
        {
            PhongTro x = db.PhongTros.Where(p => p.MaSo == maphongtro).SingleOrDefault();
            HoaDon res = new HoaDon()
            {
                MaSo = maSo,
                SoDienTieuThu = soDienTieuThu,
                SoNuocTieuThu = soNuocTieuThu,
                NgayDau = ngayDau,
                NgayCuoi = ngayCuoi,
                DaThanhToan = daThanhToan,
                NgayThanhToan = ngayThanhToan,
                PhongTro = x
            };

            db.HoaDons.Add(res);
            db.SaveChanges();
        }

        public string LayMaPhongTro(string mahoadon)
        {
            HoaDon x = db.HoaDons.Where(p => p.MaSo == mahoadon).SingleOrDefault();
            return x.PhongTro.MaSo;
        }
    }
}
