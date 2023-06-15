using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Reflection.Emit;

namespace QuanLyPhongTro
{
    public class QLPhongTroCodeFristModel : DbContext
    {
        private static QLPhongTroCodeFristModel instance;

        public static QLPhongTroCodeFristModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QLPhongTroCodeFristModel();
                }
                return instance;
            }
        }

        public QLPhongTroCodeFristModel()
            : base("name=QLPhongTroCodeFristModel")
        {
        }
        public DbSet<NguoiDungChuTro> NguoiDungChuTroes { get; set; }
        public DbSet<NguoiDungNguoiThue> NguoiDungNguoiThues { get; set; }
        public DbSet<ChuTro> ChuTroes { get; set; }
        public DbSet<NguoiThue> NguoiThues { get; set; }
        public DbSet<PhongTro> PhongTros { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
    }
}