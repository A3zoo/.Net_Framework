using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiDungChuTro: BLNguoiDung
    {
        public BLNguoiDungChuTro() : base() 
        {
            db = QLPhongTroCodeFristModel.Instance;
        }

        public override DataTable LayNguoiDung()
        {
            var query = from userChuTro in db.NguoiDungChuTroes
                        select userChuTro;
            return query.ToDataTable();
        }

        public override NguoiDung DangNhap(string mk, string tenDN)
        {
            var query = (from userChuTro in db.NguoiDungChuTroes
                            where tenDN == userChuTro.TenDangNhap &&
                            mk == userChuTro.MatKhau
                            select userChuTro).FirstOrDefault();
            return query;
        }

        public override bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(db.NguoiDungChuTroes.Max(x => x.ChuTro.MaSo) +1)).ToString();
            ChuTro newChuTro = new ChuTro(maSo, hVTen, cCCD, nSinh, qQuan, sDT, null);

            NguoiDungChuTro newUser = new NguoiDungChuTro(tenDn, mK, newChuTro);
            db.NguoiDungChuTroes.Add(newUser);
            db.SaveChanges();
            return false;
        }

        public override NguoiDung CheckTrungTenDangNhap(string tenDN)
        {
            var query = (from userChuTro in db.NguoiDungChuTroes
                            where tenDN == userChuTro.TenDangNhap
                            select userChuTro).FirstOrDefault();
            return query;
        }


        public NguoiDungChuTro TimTheoMaSo(string maSo)
        {
            var query = (from user in db.NguoiDungChuTroes
                         where maSo == user.ChuTro.MaSo
                         select user).FirstOrDefault();
            return query;
        }

        public override bool DoiMK(string CCCD, string TenDn, string mK)
        {
            var query = (from userChuTro in db.NguoiDungChuTroes
                         where TenDn == userChuTro.TenDangNhap && CCCD == userChuTro.ChuTro.CCCD
                         select userChuTro).FirstOrDefault();
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
