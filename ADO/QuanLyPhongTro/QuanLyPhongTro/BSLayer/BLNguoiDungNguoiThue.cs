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

        private NguoiDungNguoiThue DataRow2User(DataRow record)
        {
            if (record == null)
            {
                return null;
            }

            var fields = record.ItemArray;
            BLNguoiThue blNgThue = new BLNguoiThue();
            NguoiDungNguoiThue user = new NguoiDungNguoiThue
            {
                TenDangNhap = (string)fields[0],
                MatKhau = (string)fields[1],
                NguoiThue = blNgThue.TimTheoMaSo((string)fields[2]),
            };
            return user;
        }

        public override NguoiDung DangNhap(string mk, string tenDN)
        {
            string query = "select top(1) * from NguoiDungNguoiThues " +
                           "where TenDangNhap = '" + tenDN + "' and " +
                           "MatKhau = '" + mk + "'";

            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2User(record);
        }
        public override bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            BLNguoiThue blNgThue = new BLNguoiThue();
            string maSo = (Convert.ToInt16(TimMaSoLonNhat()) + 1).ToString("D4");
            blNgThue.ThemNguoiThue(maSo, hVTen, cCCD, nSinh, qQuan, sDT);

            string query = "insert into NguoiDungNguoiThues values('" +
                           tenDn + "', '" +
                           mK + "', '" +
                           maSo + "')";
            db.MyExecuteNonQuery(query, CommandType.Text);
            return false;
        }

        public override NguoiDung TimTheoTenDangNhap(string tenDN)
        {
            string query = "select * from NguoiDungNguoiThues " +
                           "where TenDangNhap = '" + tenDN + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2User(record);
        }

        public NguoiDungNguoiThue TimTheoMaSo(string maSo)
        {
            string query = "select * from NguoiDungNguoiThues " +
                           "where NguoiThue_MaSo = '" + maSo + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2User(record);
        }

        public override bool DoiMK(string CCCD, string tenDn, string mK)
        {
            string query = "select * from NguoiDungChuTroes, ChuTroes " +
                           "where TenDangNhap = '" + tenDn + "' and " +
                           "CCCD = '" + CCCD + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);

            if (record != null)
            {
                query = "update NguoiDungNguoiThues set MatKhau = '" + mK + "'" +
                        "where TenDangNhap = '" + tenDn + "'";
                db.MyExecuteNonQuery(query, CommandType.Text);
                return true;
            }
            return false;
        }

        public override bool CapNhatThongTin(string id, string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            BLNguoiThue blNgThue = new BLNguoiThue();
            blNgThue.CapNhatThongTin(id, hVTen, cCCD, nSinh, qQuan, sDT);

            string query = "update NguoiDungNguoiThues set " +
                           "MatKhau = '" + mK + "' " +
                           "where TenDangNhap = '" + tenDn + "'";
            return false;
        }

        private string TimMaSoLonNhat()
        {
            string query = "select top(1) NguoiThue_MaSo from NguoiDungNguoiThues order by NguoiThue_MaSo desc";
            DataRow record = db.GetSingleRecord(query, System.Data.CommandType.Text);
            if (record == null)
            {
                return "0000";
            }
            return record.ItemArray[0].ToString();
        }
    }
}
