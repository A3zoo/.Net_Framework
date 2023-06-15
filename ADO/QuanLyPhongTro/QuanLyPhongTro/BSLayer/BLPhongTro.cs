using QuanLyPhongTro.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.BSLayer
{
    public class BLPhongTro
    {
        QuanLyPhongTroContext db;
        public BLPhongTro()
        {
            db = new QuanLyPhongTroContext();
        }

        public DataTable TimTheoChuTro(string msChuTro)
        {
            string s = "SELECT PhongTroes.MaSo, PhongTroes.DienTich, PhongTroes.DiaChi, PhongTroes.SoNguoiToiDa, PhongTroes.CoGac, PhongTroes.ChoNuoiThuCung, PhongTroes.TienThue, PhongTroes.TienDien,PhongTroes.TienNuoc, PhongTroes.TienRac FROM PhongTroes" +
                " WHERE PhongTroes.ChuTro_MaSo =" + msChuTro;
            return db.ExecuteQueryDataSet(s, CommandType.Text).Tables[0];
        }
        public DataTable LayPhongTrong()
        {
            string query = "select * " +
                           "from PhongTroes " +
                           "where MaSo in (select PhongTroes.MaSo " +
                                           "from PhongTroes left join NguoiThues " +
                                               "on PhongTro_MaSo = PhongTroes.MaSo " +
                                           "group by PhongTroes.MaSo " +
                                           "having count(NguoiThues.MaSo) = 0)";
            return db.ExecuteQueryDataSet(query, CommandType.Text).Tables[0];
        }

        public object[] LayTatCaDiaChi()
        {
            string query = "select distinct DiaChi from PhongTroes";
            DataTable dt = db.ExecuteQueryDataSet(query, CommandType.Text).Tables[0];
            object[] tp = new object[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tp[i] = dt.Rows[i]["DiaChi"].ToString();
            }
            return tp;
        }

        public DataTable TimKiemPhong(string diaChi, int dienTich, int soNgToiDa, double tienThue, bool gac, bool thuCung)
        {
            string query = "select * from PhongTroes " +
                           "where DiaChi = '" + diaChi + "' and '" +
                                  "abs(DienTich - " + dienTich + ") <= 3 and " +
                                  "abs(SoNguoiToiDa - " + soNgToiDa + ") <= 1 and " +
                                  "abs(TienThue - " + tienThue + ") <= 400000 and " +
                                  "Gac = " + gac + " and " +
                                  "ChoNuoiThuCung = " + thuCung + " and " + 
                                  "MaSo in MaSo in (select PhongTroes.MaSo " +
                                           "from PhongTroes left join NguoiThues " +
                                               "on PhongTro_MaSo = PhongTroes.MaSo " +
                                           "group by PhongTroes.MaSo " +
                                           "having count(NguoiThues.MaSo) = 0)";

            return db.ExecuteQueryDataSet(query, CommandType.Text).Tables[0];
        }

        public PhongTro TimTheoMaSo(string msPhong)
        {
            string query = "select * from PhongTroes " +
                           "where MaSo = '" + msPhong + "'";
            DataRow record = db.GetSingleRecord(query, CommandType.Text);
            if (record != null)
            {
                BLChuTro bLChuTro = new BLChuTro();
                var fields = record.ItemArray;
                PhongTro ph = new PhongTro
                {
                    MaSo = (string)fields[0],
                    DienTich = (double)fields[1],
                    DiaChi = (string)fields[2],
                    SoNguoiToiDa = (int)fields[3],
                    CoGac = (bool)fields[4],
                    ChoNuoiThuCung = (bool)fields[5],
                    TienThue = (double)fields[6],
                    TienDien = (double)fields[7],
                    TienNuoc = (double)fields[8],
                    TienRac = (double)fields[9],
                    ChuTro = bLChuTro.TimTheoMaSo((string)fields[10])
                };
                return ph;
            }
            return null;
        }

        public int DemSoNguoiDangO(string maSo)
        {
            string query = "select count(NguoiThues.MaSo) " +
                           "from PhongTroes left join NguoiThues " +
                                "on PhongTro_MaSo = PhongTroes.MaSo " +
                           "group by PhongTroes.MaSo ";
            DataRow result = db.GetSingleRecord(query, CommandType.Text);
            return (int)result.ItemArray[0];
        }

        public bool DatGioiHanNguoiO(string maSo)
        {
            PhongTro ph = TimTheoMaSo(maSo);
            return ph.SoNguoiToiDa <= DemSoNguoiDangO(maSo);
        }

        public void XoaPhong(string maSo)
        {
            string sqlString = "Delete From PhongTroes Where PhongTroes.MaSo='" + maSo + "'";
            db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public void ThemPhong(string maSo, double dienTich, string diaChi, int soNguoiToiDa, bool coGac, bool choNuoiThuCung, double tienThue, double tienDien, double tienNuoc, double tienRac, string machutro)
        {
            string sqlString = "Insert Into PhongTroes Values(" + "'" +
            maSo + "',N'" +
            dienTich + "',N'" +
            diaChi + "',N'" +
            soNguoiToiDa + "',N'" +
            coGac + "',N'" +
            choNuoiThuCung + "',N'" +
            tienThue + "',N'" +
            tienDien + "',N'" +
            tienNuoc + "',N'" +
            tienRac + "',N'" +
            machutro + "')";
            db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
