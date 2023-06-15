using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongTro.BSLayer
{
    public class BLNguoiThue
    {
        readonly QLPhongTroCodeFristModel db;
        public BLNguoiThue()
        {
            db = QLPhongTroCodeFristModel.Instance;
        }

        public void ThemNguoiThue(string hVTen, string cCCD, string sDT, string qQuan, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(db.NguoiThues.Max(x => x.MaSo)) + 1).ToString();
            NguoiThue newNguoiThue = new NguoiThue(maSo, hVTen, cCCD, nSinh, qQuan, sDT, null);

            db.NguoiThues.Add(newNguoiThue);
            db.SaveChanges();
        }

        public void ThemNguoiThue(NguoiThue ngThue)
        {
            db.NguoiThues.Add(ngThue);
            db.SaveChanges();
        }

        public bool DaThuePhong(NguoiThue ngThue)
        {
            return ngThue.PhongTro != null;
        }

        public NguoiThue TimTheoMaSo(string maSo)
        {
            var query = (from ngThue in db.NguoiThues
                         where ngThue.MaSo == maSo
                         select ngThue).FirstOrDefault();
            return query;
        }

        public void ThuePhong(NguoiThue ngThue, PhongTro ph)
        {
            ngThue.PhongTro = ph;
            db.SaveChanges();
        }

        public void RoiTro(NguoiThue ngThue)
        {
            ngThue.PhongTro.NguoiDangThue.Remove(ngThue);
            ngThue.PhongTro = null;
            db.SaveChanges();
        }

        public DataTable TimTheoMaChutro(string machutro)
        {
            var Nguoithue = from c in db.NguoiThues
                            where c.PhongTro != null && c.PhongTro.ChuTro.MaSo == machutro

                            select new
                            {

                                c.MaSo,
                                c.Ten,
                                c.NgaySinh,
                                c.CCCD,
                                c.QueQuan,
                                c.SDT
                            };
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MaSo", typeof(int));
            dataTable.Columns.Add("Ten", typeof(string));
            dataTable.Columns.Add("NgaySinh", typeof(DateTime));
            dataTable.Columns.Add("CCCD", typeof(string));
            dataTable.Columns.Add("QueQuan", typeof(string));
            dataTable.Columns.Add("SDT", typeof(string));

            foreach (var item in Nguoithue)
            {
                dataTable.Rows.Add(item.MaSo, item.Ten, item.NgaySinh, item.CCCD, item.QueQuan, item.SDT);
            }

            return dataTable;
        }

        public void ThemNguoiThueVaoTro(string manguoithue, string maphong)
        {
            NguoiThue ngThue = TimTheoMaSo(manguoithue);
            PhongTro pt = db.PhongTros.Where(P => P.MaSo == maphong).SingleOrDefault();
            ThuePhong(ngThue, pt);
        }

        public bool DaCoPhongTro(string maSo)
        {
            return TimTheoMaSo(maSo).PhongTro != null;
        }

        public void XoaNguoiThueKhoiTro(string nguoithue)
        {
            NguoiThue x = db.NguoiThues.Find(nguoithue);
            PhongTro phong = x.PhongTro;
            phong.NguoiDangThue.Remove(x);
            x.PhongTro = null;
            db.SaveChanges();
        }
    }
}
