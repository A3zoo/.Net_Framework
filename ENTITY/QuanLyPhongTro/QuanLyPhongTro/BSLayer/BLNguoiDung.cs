using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiDung
    {
        protected QLPhongTroCodeFristModel db;

        public BLNguoiDung()
        {
            db = QLPhongTroCodeFristModel.Instance;
        }

        public virtual DataTable LayNguoiDung()
        {
            return null;
        }

        public virtual NguoiDung DangNhap(string mk, string tenDN)
        {
            return null;
        }

        public virtual NguoiDung TaoUserMoi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            return null;
        }

        public virtual bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            return false;
        }

        public virtual NguoiDung CheckTrungTenDangNhap(string tenDN)
        {
            return null;
        }

        public virtual bool DoiMK(string cCCD, string tenDn, string mK)
        {
            return false;
        }

        public virtual bool CapNhatThongTin(string id, string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            return false;
        }
    }
}
