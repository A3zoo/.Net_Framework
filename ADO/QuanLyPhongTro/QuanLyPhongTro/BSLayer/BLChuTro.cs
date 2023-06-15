using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace QuanLyPhongTro.BSLayer
{
    public class BLChuTro
    {
        QuanLyPhongTroContext db;
        public BLChuTro()
        {
            db = new QuanLyPhongTroContext();
        }

        public void ThemChuTro(string maSo, string ten, string cccd, DateTime ngSinh, string queQuan, string sdt)
        {
            string query = "insert into ChuTroes values ('" +
                           maSo + "', '" +
                           ten + "', '" +
                           cccd + "', '" +
                           ngSinh.ToString("yyyy-MM-dd") + "', '" +
                           queQuan + "', '" +
                           sdt + "')";
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public void CapNhatThongTin(string maSo, string ten, string cccd, DateTime ngSinh, string queQuan, string sdt)
        {
            string query = "update ChuTroes set " +
                           "Ten = '" + ten + "', " +
                           "CCCD = '" + cccd + "', " +
                           "NgaySinh = '" + ngSinh.ToString("yyyy-MM-dd") + "'," +
                           "QueQuan = '" + queQuan + "', " +
                           "SDT = '" + sdt + "' " +
                           "where MaSo = '" + maSo + "'";
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public ChuTro TimTheoMaSo(string maSo)
        {
            string query = "select * from ChuTroes " +
                           "where MaSo = '" + maSo + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            if (record != null) 
            {
                var fields = record.ItemArray;
                ChuTro chuTro = new ChuTro
                {
                    MaSo = (string)fields[0],
                    Ten = (string)fields[1],
                    CCCD = (string)fields[2],
                    NgaySinh = (DateTime)fields[3],
                    QueQuan = (string)fields[4],
                    SDT = (string)fields[5],
                };
                return chuTro;
            }
            return null;
        }

        public bool SoHuuPhongTro(string msChuTro, string msPhong)
        {
            BLPhongTro blPhTro = new BLPhongTro();
            PhongTro ph = blPhTro.TimTheoMaSo(msPhong);
            return ph.ChuTro.MaSo == msChuTro;
        }
    }
}
