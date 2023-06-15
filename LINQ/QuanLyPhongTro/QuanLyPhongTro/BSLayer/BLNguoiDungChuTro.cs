using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiDungChuTro
    {
        QuanLyPhongTroDataContext db;
        public BLNguoiDungChuTro() 
        {
            db = QuanLyPhongTroDataContext.Instance;
        }

        public DataTable LayNguoiDung()
        {
            var query = from userChuTro in db.NguoiDungChuTroes
                        select userChuTro;
            return query.ToDataTable();
        }

        public NguoiDungChuTroe DangNhap(string mk, string tenDN)
        {
            var query = (from userChuTro in db.NguoiDungChuTroes
                            where tenDN == userChuTro.TenDangNhap &&
                            mk == userChuTro.MatKhau
                            select userChuTro).FirstOrDefault();
            return query;
        }

        public bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(db.NguoiDungChuTroes.Max(x => x.ChuTroe.MaSo)) + 1).ToString();
            ChuTroe newChuTro = new ChuTroe
            {
                MaSo = maSo,
                Ten = hVTen,
                CCCD = cCCD,
                SDT = sDT,
                NgaySinh = nSinh,
                QueQuan = qQuan
            };


            NguoiDungChuTroe newUser = new NguoiDungChuTroe
            {
                TenDangNhap = tenDn,
                MatKhau = mK,
                ChuTroe = newChuTro
            };

            db.NguoiDungChuTroes.InsertOnSubmit(newUser);
            db.SubmitChanges();
            return false;
        }

        public NguoiDungChuTroe CheckTrungTenDangNhap(string tenDN)
        {
            var query = (from userChuTro in db.NguoiDungChuTroes
                            where tenDN == userChuTro.TenDangNhap
                            select userChuTro).FirstOrDefault();
            return query;
        }


        public NguoiDungChuTroe TimTheoMaSo(string maSo)
        {
            var query = (from user in db.NguoiDungChuTroes
                         where maSo == user.ChuTroe.MaSo
                         select user).FirstOrDefault();
            return query;
        }

        public bool DoiMK(string CCCD, string TenDn, string mK)
        {
            var query = (from userChuTro in db.NguoiDungChuTroes
                         where TenDn == userChuTro.TenDangNhap && CCCD == userChuTro.ChuTroe.CCCD
                         select userChuTro).FirstOrDefault();
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
