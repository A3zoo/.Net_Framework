using QuanLyPhongTro.BSLayer;
using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiDungNguoiThue
    {
        QuanLyPhongTroDataContext db;
        public BLNguoiDungNguoiThue()
        {
            db = QuanLyPhongTroDataContext.Instance;
        }

        public DataTable LayNguoiDung()
        {
            var query = from userNguoiThue in db.NguoiDungNguoiThues
                        select userNguoiThue;
            return query.ToDataTable();
        }

        public NguoiDungNguoiThue DangNhap(string mk, string tenDN)
        {
            var query = (from userNgThue in db.NguoiDungNguoiThues
                         where tenDN == userNgThue.TenDangNhap &&
                         mk == userNgThue.MatKhau
                         select userNgThue).FirstOrDefault();
            return query;
        }
        public bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(db.NguoiDungNguoiThues.Max(x => x.NguoiThue.MaSo)) + 1).ToString("D4");
            NguoiThue newNguoiThue = new NguoiThue
            {
                MaSo = maSo,
                Ten = hVTen,
                CCCD = cCCD,
                NgaySinh = nSinh,
                QueQuan = qQuan,
                SDT = sDT,
            };

            NguoiDungNguoiThue newUser = new NguoiDungNguoiThue
            {
                TenDangNhap = tenDn,
                MatKhau = mK,
                NguoiThue = newNguoiThue
            };
            db.NguoiDungNguoiThues.InsertOnSubmit(newUser);
            db.SubmitChanges();
            return false;
        }

        public NguoiDungNguoiThue CheckTrungTenDangNhap(string tenDN)
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

        public bool DoiMK(string CCCD, string TenDn, string mK)
        {
            var query = (from userNguoiThue in db.NguoiDungNguoiThues
                         where TenDn == userNguoiThue.TenDangNhap && CCCD == userNguoiThue.NguoiThue.CCCD
                         select userNguoiThue).FirstOrDefault();
            if (query != null)
            {
                query.MatKhau = mK;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool CapNhatThongTin(string id, string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
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
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
