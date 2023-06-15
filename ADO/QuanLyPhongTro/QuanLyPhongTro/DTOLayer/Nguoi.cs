using System;

namespace QuanLyPhongTro
{
    public class Nguoi
    {
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public string CCCD { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string SDT { get; set; }

        public Nguoi() { }

        public Nguoi(string maSo, string ten, string cCCD, DateTime ngaySinh, string queQuan, string sDT)
        {
            MaSo = maSo;
            Ten = ten;
            CCCD = cCCD;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            SDT = sDT;
        }
    }
}
