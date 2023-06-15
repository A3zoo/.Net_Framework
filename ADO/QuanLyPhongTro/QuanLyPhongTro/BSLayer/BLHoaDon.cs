using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLHoaDon
    {
        QuanLyPhongTroContext db;
        public BLHoaDon() 
        {
            db = new QuanLyPhongTroContext();
        }
        
        public DataTable LayHoaDon()
        {
            string s = "SELECT * FROM HoaDons";

            return db.ExecuteQueryDataSet(s, CommandType.Text).Tables[0];
        }

        public DataTable LayHoaDonTheoNguoiThue(NguoiThue ngThue)
        {
            string query = "select * from HoaDons " +
                           "where PhongTro_MaSo = " +
                           "'" + ngThue.PhongTro.MaSo + "'";
            return db.ExecuteQueryDataSet(query, CommandType.Text).Tables[0];
        }

        public double TinhTienDien(HoaDon hoaDon)
        {
            return hoaDon.SoDienTieuThu * hoaDon.PhongTro.TienDien;
        }

        public double TinhTienNuoc(HoaDon hoaDon)
        {
            return hoaDon.SoNuocTieuThu * hoaDon.PhongTro.TienNuoc;
        }

        public double TinhTongTien(HoaDon hoaDon)
        {
            return TinhTienDien(hoaDon) + TinhTienNuoc(hoaDon) + hoaDon.PhongTro.TienRac + hoaDon.PhongTro.TienThue;
        }

        public HoaDon TimHoaDonTheoMaSo(string maSo)
        {
            string query = "select * from HoaDons " +
               "where MaSo = " +
               "'" + maSo + "'";

            DataRow record =  db.GetSingleRecord(query, CommandType.Text);
            if (record != null)
            {
                var fields = record.ItemArray;
                BLPhongTro blPhTro = new BLPhongTro();
                HoaDon hd = new HoaDon()
                {
                    MaSo = (string)fields[0],
                    SoDienTieuThu = (int)fields[1],
                    SoNuocTieuThu = (int)fields[2],
                    NgayDau = (DateTime)fields[3],
                    NgayCuoi = (DateTime)fields[4],
                    DaThanhToan = (bool)fields[5],
                    NgayThanhToan = (DateTime)fields[6],
                    PhongTro = blPhTro.TimTheoMaSo((string)fields[7]),
                };
                return hd;
            }
            return null;
        }

        public void ThanhToanHoaDon(HoaDon hoaDon)
        {
            string query = "update HoaDons set DaThanhToan = 1, NgayThanhToan = '" + DateTime.Today + "' " + 
                           "where MaSo = " + "'" + hoaDon.MaSo + "'";
            hoaDon.DaThanhToan = true;
            hoaDon.NgayThanhToan = DateTime.Today;
            db.MyExecuteNonQuery(query, CommandType.Text);
        }

        public void ThemHoaDon(string maSo, int soDienTieuThu, int soNuocTieuThu, DateTime ngayDau, DateTime ngayCuoi, bool daThanhToan, DateTime ngayThanhToan, string maPhongTro)
        {
            string sqlString = "Insert Into HoaDons Values(" + "'" +
            maSo + "',N'" +
            soDienTieuThu + "',N'" +
            soNuocTieuThu + "',N'" +
            ngayDau + "',N'" +
            ngayCuoi + "',N'" +
            daThanhToan + "',N'" +
            ngayThanhToan + "',N'" +
            maPhongTro + "')";
            db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public string LayMaPhongTro(string msHD)
        {
            string query = "select PhongTro_MaSo from HoaDons where MaSo = '" + msHD + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            return record.ItemArray[7].ToString();
        }
    }
}
