using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLHopDong
    {
        QuanLyPhongTroContext db;

        public BLHopDong()
        {
            db = new QuanLyPhongTroContext();
        }

        public void ThemHopDong(DateTime ngTao, double coc, int thoiHan, ChuTro chuTro, NguoiThue ngThue, PhongTro ph)
        {
            string maSo = (Convert.ToInt16(LayMaSoLonNhat()) + 1).ToString("D4");
            string query = "insert into HopDongs values('" +
                            maSo + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "', " + coc + ", " +
                            thoiHan + ", 0, NULL, '" + chuTro.MaSo + "', '" +
                            ngThue.MaSo + "', '" + ph.MaSo + "')";
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        private HopDong DataRow2HopDong(DataRow record)
        {
            if (record != null)
            {
                var fields = record.ItemArray;
                BLChuTro blChuTro = new BLChuTro();
                BLNguoiThue blNgThue = new BLNguoiThue();
                BLPhongTro blPhTro = new BLPhongTro();
                HopDong hd = new HopDong()
                {
                    MaSo = (string)fields[0],
                    NgayTao = (DateTime)fields[1],
                    TienCoc = (double)fields[2],
                    ThoiHanCoc = (int)fields[3],
                    DaLayTienCoc = (bool)fields[4],
                    NgayKetThuc = fields[5].GetType() != typeof(DBNull) ? (DateTime?)fields[6] : null,
                    ChuTro = blChuTro.TimTheoMaSo((string)fields[6]),
                    NguoiThue = blNgThue.TimTheoMaSo((string)fields[7]),
                    PhongTro = blPhTro.TimTheoMaSo((string)fields[8])
                };
                return hd;
            }
            return null;
        }

        public HopDong TimHopDongCoHieuLuc(NguoiThue ngThue)
        {
            string query = "select * from HopDongs " +
                           "where NguoiThue_MaSo = '" + ngThue.MaSo + "' and " +
                           "NgayKetThuc is NULL";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return DataRow2HopDong(record);
        }

        public void KetThucHopDong(HopDong hd)
        {
            string query = "update HopDongs set NgayKetThuc = NULL " +
                           "where MaSo = '" + hd.MaSo + "' and " +
                           "NgayKetThuc is NULL";
            hd.NgayKetThuc = DateTime.Today;
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public bool LayTienCoc(HopDong hd)
        {
            if (!hd.DaLayTienCoc && KiemTraHanCoc(hd))
            {
                string query = "update HopDongs set DaLayTienCoc = 1 " +
                           "where MaSo = '" + hd.MaSo;
                hd.DaLayTienCoc = true;
                db.MyExecuteNonQuery(query, CommandType.Text);
                return true;
            }
            return false;
        }

        private bool KiemTraHanCoc(HopDong hd)
        {
            DateTime ngHopLe = hd.NgayTao.AddMonths(hd.ThoiHanCoc);
            return ngHopLe <= DateTime.Today;
        }
        private string LayMaSoLonNhat()
        {
            string query = "select top(1) MaSo from HopDongs order by MaSo desc";
            DataRow record = db.GetSingleRecord(query, System.Data.CommandType.Text);
            if (record == null)
            {
                return "0000";
            }
            return record.ItemArray[0].ToString();
        }
    }
}
