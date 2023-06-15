using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiThue
    {
        readonly QuanLyPhongTroContext db;
        public BLNguoiThue()
        {
            db = new QuanLyPhongTroContext();
        }

        public void ThemNguoiThue(string maSo, string ten, string cccd, DateTime ngSinh, string queQuan, string sdt)
        {
            string query = "insert into NguoiThues values ('" +
                           maSo + "', '" +
                           ten + "', '" +
                           cccd + "', '" +
                           ngSinh.ToString("yyyy-MM-dd") + "', '" +
                           queQuan + "', '" +
                           sdt + "'" +
                           ", NULL)";
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public bool DaThuePhong(NguoiThue ngThue)
        {
            return ngThue.PhongTro != null;
        }

        public NguoiThue TimTheoMaSo(string maSo)
        {
            string query = "select * from NguoiThues " +
                           "where MaSo = '" + maSo + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            if (record != null)
            {
                BLPhongTro blPhTro = new BLPhongTro();
                var fields = record.ItemArray;

                NguoiThue ngThue = new NguoiThue
                {
                    MaSo = (string)fields[0],
                    Ten = (string)fields[1],
                    CCCD = (string)fields[2],
                    NgaySinh = (DateTime)fields[3],
                    QueQuan = (string)fields[4],
                    SDT = (string)fields[5],
                    PhongTro = fields[6].GetType() != typeof(DBNull) ? blPhTro.TimTheoMaSo((string)fields[6]) : null
                };
                return ngThue;
            }
            return null;
        }

        public void ThuePhong(NguoiThue ngThue, PhongTro ph)
        {
            string query = "update NguoiThues set PhongTro_MaSo = '" + ph.MaSo + "' " +
                           "where MaSo = '" + ngThue.MaSo + "'";
            ngThue.PhongTro = ph;
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public void RoiTro(NguoiThue ngThue)
        {
            string query = "update NguoiThues set PhongTro_MaSo = NULL";
            ngThue.PhongTro = null;
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public void CapNhatThongTin(string maSo, string ten, string cccd, DateTime ngSinh, string queQuan, string sdt)
        {
            string query = "update NguoiThues set " +
                           "Ten = '" + ten + "', " +
                           "CCCD = '" + cccd + "', " +
                           "NgaySinh = '" + ngSinh.ToString("yyyy-MM-dd") + "'," +
                           "QueQuan = '" + queQuan + "', " +
                           "SDT = '" + sdt + "' " +
                           "where MaSo = '" + maSo + "'";
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public DataTable TimTheoMaChuTro(string maChuTro)
        {
            string s = "SELECT * FROM NguoiThues" +
                " WHERE NguoiThues.PhongTro_MaSo in" +
                "(SELECT PhongTroes.Maso FROM PhongTroes WHERE PhongTroes.ChuTro_MaSo=" + maChuTro + ")";
            return db.ExecuteQueryDataSet(s, CommandType.Text).Tables[0];
        }

        public bool DaCoPhongTro(string maSo)
        {
            return TimTheoMaSo(maSo).PhongTro != null;
        }

        public void XoaNguoiThueKhoiTro(string manguoithue)
        {
            string sqlString = "Update NguoiThues Set NguoiThues.PhongTro_MaSo=NULL"
                 + " Where NguoiThues.MaSo='" + manguoithue + " '";
            db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public void ThemNguoiThueVaoTro(string manguoithue, string maphong)
        {
            string sqlString = "Update NguoiThues Set NguoiThues.PhongTro_MaSo=N'" +
                maphong + "' Where NguoiThues.MaSo='" + manguoithue + "'" + "and NguoiThues.PhongTro_MaSo is NULL";

            db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
