using QuanLyPhongTro.BSLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiDungNguoiThue:BLNguoiDung
    {
        public BLNguoiDungNguoiThue(): base() { }

        public override DataTable LayNguoiDung()
        {
            var query = from userNguoiThue in db.NguoiDungNguoiThues
                        select userNguoiThue;
            return query.ToDataTable();
        }

        public override NguoiDung DangNhap(string mk, string tenDN)
        {
            var query = (from userNgThue in db.NguoiDungNguoiThues
                         where tenDN == userNgThue.TenDangNhap &&
                         mk == userNgThue.MatKhau
                         select userNgThue).FirstOrDefault();
            return query;
        }
        public override bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(db.NguoiDungNguoiThues.Max(x => x.NguoiThue.MaSo)) + 1).ToString("D4");
            NguoiThue newNguoiThue = new NguoiThue(maSo, hVTen, cCCD, nSinh, qQuan, sDT, null);

            NguoiDungNguoiThue newUser = new NguoiDungNguoiThue(tenDn, mK, newNguoiThue);
            db.NguoiDungNguoiThues.Add(newUser);
            db.SaveChanges(); 
            return false;
        }

        public override NguoiDung CheckTrungTenDangNhap(string tenDN)
        {
            var query = (from userNthue in db.NguoiDungNguoiThues
                         where tenDN == userNthue.TenDangNhap
                         select userNthue).FirstOrDefault();
            return query;
        }

        public NguoiDungNguoiThue TimTheoMaSo(string maSo)
        {
            var query = (from user in db.NguoiDungNguoiThues
                         where maSo == user.NguoiThue.MaSo
                         select user).FirstOrDefault();
            return query;
        }

        public override bool DoiMK(string CCCD, string TenDn, string mK)
        {
            var query = (from userNguoiThue in db.NguoiDungNguoiThues
                         where TenDn == userNguoiThue.TenDangNhap && CCCD == userNguoiThue.NguoiThue.CCCD
                         select userNguoiThue).FirstOrDefault();
            if (query != null)
            {
                query.MatKhau = mK;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public override bool CapNhatThongTin(string id, string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            var nguoi = (from nguoithue in db.NguoiDungNguoiThues
                         where nguoithue.NguoiThue.MaSo == id
                         select nguoithue).FirstOrDefault();

            if (nguoi != null)
            {
                nguoi.TenDangNhap = tenDn;
                nguoi.MatKhau = mK;
                nguoi.NguoiThue.CCCD = cCCD;
                nguoi.NguoiThue.NgaySinh = nSinh;
                nguoi.NguoiThue.QueQuan = qQuan;
                nguoi.NguoiThue.SDT = sDT;
                nguoi.NguoiThue.Ten = hVTen;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
