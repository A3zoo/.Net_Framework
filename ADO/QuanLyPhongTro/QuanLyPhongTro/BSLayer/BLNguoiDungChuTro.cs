using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiDungChuTro: BLNguoiDung
    {
        public BLNguoiDungChuTro() : base() { }

        private NguoiDungChuTro DataRow2User(DataRow record)
        {
            if (record == null)
            {
                return null;
            }

            var fields = record.ItemArray;
            BLChuTro blChuTro = new BLChuTro();
            NguoiDungChuTro user = new NguoiDungChuTro
            {
                TenDangNhap = (string)fields[0],
                MatKhau = (string)fields[1],
                ChuTro = blChuTro.TimTheoMaSo((string)fields[2]),
            };
            return user;
        }

        public override NguoiDung DangNhap(string mk, string tenDN)
        {
            string query = "select top(1) * from NguoiDungChuTroes " +
                           "where TenDangNhap = '" + tenDN + "' and " +
                           "MatKhau = '" + mk + "'";

            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2User(record);
        }

        public override bool DangKi(string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(TimMaSoLonNhat()) + 1).ToString("D4");
            BLChuTro blChuTro = new BLChuTro();
            blChuTro.ThemChuTro(maSo, hVTen, cCCD, nSinh, qQuan, sDT);
            string query = "insert into NguoiDungChuTroes values('" +
                           tenDn + "', '" +
                           mK + "', '" +
                           maSo + "')";
            db.MyExecuteNonQuery(query, CommandType.Text);
            return false;
        }

        public override NguoiDung TimTheoTenDangNhap(string tenDN)
        {
            string query = "select top(1) * from NguoiDungChuTroes " +
                           "where TenDangNhap = '" + tenDN + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2User(record);
        }

        public NguoiDungChuTro TimTheoMaSo(string maSo)
        {
            string query = "select top(1) * from NguoiDungChuTroes " +
                           "where ChuTro_MaSo = '" + maSo + "'";

            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2User(record);
        }

        public override bool DoiMK(string CCCD, string tenDn, string mK)
        {
            string query = "select top(1) * from NguoiDungChuTroes, ChuTroes " +
                           "where TenDangNhap = '" + tenDn + "' and " +
                           "CCCD = '" + CCCD + "'";
            DataRow record = db.GetSingleRecord (query, CommandType.Text);

            if (record != null)
            {
                query = "update NguoiDungChuTroes set MatKhau = '" + mK + "'" +
                        "where TenDangNhap = '" + tenDn + "'";
                db.MyExecuteNonQuery(query, CommandType.Text);
                return true;
            }
            return false;
        }

        public override bool CapNhatThongTin(string id, string hVTen, string cCCD, string sDT, string qQuan, string tenDn, string mK, DateTime nSinh)
        {
            BLChuTro blChuTro = new BLChuTro();
            blChuTro.CapNhatThongTin(id, hVTen, cCCD, nSinh, qQuan,sDT);

            string query = "update NguoiDungChuTroes set " +
                           "MatKhau = '" + mK + "' " +
                           "where TenDangNhap = '" + tenDn + "'";
            return false;
        }

        private string TimMaSoLonNhat()
        {
            string query = "select top(1) ChuTro_MaSo from NguoiDungChuTroes order by ChuTro_MaSo desc";
            DataRow record = db.GetSingleRecord(query, System.Data.CommandType.Text);
            if (record == null)
            {
                return "0000";
            }
            return record.ItemArray[0].ToString();
        }
    }
}
