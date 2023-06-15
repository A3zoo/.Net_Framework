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
        QuanLyPhongTroDataContext db;
        public BLNguoiThue()
        {
            db = QuanLyPhongTroDataContext.Instance;
        }

        public void ThemNguoiThue(string hVTen, string cCCD, string sDT, string qQuan, DateTime nSinh)
        {
            string maSo = (Convert.ToInt16(db.NguoiThues.Max(x => x.MaSo)) + 1).ToString();
            NguoiThue newNguoiThue = new NguoiThue
            {
                MaSo = maSo,
                Ten = hVTen,
                CCCD = cCCD,
                SDT = sDT,
                NgaySinh = nSinh,
                QueQuan = qQuan,
            };

            db.NguoiThues.InsertOnSubmit(newNguoiThue);
            db.SubmitChanges();
        }

        public DataTable TimTheoMaChuTro(string machutro)
        {
            var Nguoithue = from c in db.NguoiThues
                            where c.PhongTroe != null && c.PhongTroe.ChuTroe.MaSo == machutro

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

        public void ThemNguoiThue(NguoiThue ngThue)
        {
            db.NguoiThues.InsertOnSubmit(ngThue);
            db.SubmitChanges();
        }

        public bool DaThuePhong(NguoiThue ngThue)
        {
            return ngThue.PhongTroe != null;
        }

        public NguoiThue TimTheoMaSo(string maSo)
        {
            var query = (from ngThue in db.NguoiThues
                            where ngThue.MaSo == maSo
                            select ngThue).FirstOrDefault();
            return query;
        }

        public void ThuePhong(NguoiThue ngThue, PhongTroe ph)
        {
            ngThue.PhongTroe = ph;
            db.SubmitChanges();
        }

        public void RoiTro(NguoiThue ngThue)
        {
            ngThue.PhongTroe = null;
            db.SubmitChanges();
        }

        public bool DaCoPhongTro(string maSo)
        {
            return TimTheoMaSo(maSo).PhongTroe != null;
        }

        public void ThemNguoiThueVaoTro(string manguoithue, string maphong)
        {
            NguoiThue ngThue = TimTheoMaSo(manguoithue);
            PhongTroe pt = db.PhongTroes.Where(P => P.MaSo == maphong).SingleOrDefault();
            ThuePhong(ngThue, pt);
        }

        public void XoaNguoiThueKhoiTro(string nguoithue)
        {
            NguoiThue x = TimTheoMaSo(nguoithue);
            PhongTroe phong = x.PhongTroe;
            phong.NguoiThues.Remove(x);
            x.PhongTroe = null;
            db.SubmitChanges();
        }
    }
}
