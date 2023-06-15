using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro
{
    public class NguoiThue: Nguoi
    {

        public virtual PhongTro PhongTro { get; set; }

        public NguoiThue() { }

        public NguoiThue(string maSo, string ten, string cCCD, DateTime ngaySinh, string queQuan, string sDT, PhongTro phongTro) : base(maSo, ten, cCCD, ngaySinh, queQuan, sDT)
        {
            PhongTro =  phongTro;
        }

    }
}
