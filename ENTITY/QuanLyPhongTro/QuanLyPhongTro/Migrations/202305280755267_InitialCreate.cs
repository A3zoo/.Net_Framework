namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuTroes",
                c => new
                    {
                        MaSo = c.String(nullable: false, maxLength: 128),
                        Ten = c.String(),
                        CCCD = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(),
                        SDT = c.String(),
                    })
                .PrimaryKey(t => t.MaSo);
            
            CreateTable(
                "dbo.PhongTroes",
                c => new
                    {
                        MaSo = c.String(nullable: false, maxLength: 128),
                        DienTich = c.Double(nullable: false),
                        DiaChi = c.String(),
                        SoNguoiToiDa = c.Int(nullable: false),
                        CoGac = c.Boolean(nullable: false),
                        ChoNuoiThuCung = c.Boolean(nullable: false),
                        TienThue = c.Double(nullable: false),
                        TienDien = c.Double(nullable: false),
                        TienNuoc = c.Double(nullable: false),
                        TienRac = c.Double(nullable: false),
                        ChuTro_MaSo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSo)
                .ForeignKey("dbo.ChuTroes", t => t.ChuTro_MaSo)
                .Index(t => t.ChuTro_MaSo);
            
            CreateTable(
                "dbo.NguoiThues",
                c => new
                    {
                        MaSo = c.String(nullable: false, maxLength: 128),
                        Ten = c.String(),
                        CCCD = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(),
                        SDT = c.String(),
                        PhongTro_MaSo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSo)
                .ForeignKey("dbo.PhongTroes", t => t.PhongTro_MaSo)
                .Index(t => t.PhongTro_MaSo);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaSo = c.String(nullable: false, maxLength: 128),
                        SoDienTieuThu = c.Int(nullable: false),
                        SoNuocTieuThu = c.Int(nullable: false),
                        PhongTro_MaSo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSo)
                .ForeignKey("dbo.PhongTroes", t => t.PhongTro_MaSo)
                .Index(t => t.PhongTro_MaSo);
            
            CreateTable(
                "dbo.HopDongs",
                c => new
                    {
                        MaSo = c.String(nullable: false, maxLength: 128),
                        NgayTao = c.DateTime(nullable: false),
                        TienCoc = c.Double(nullable: false),
                        ThoiHanCoc = c.Int(nullable: false),
                        DaLayTienCoc = c.Boolean(nullable: false),
                        ChuTro_MaSo = c.String(maxLength: 128),
                        NguoiThue_MaSo = c.String(maxLength: 128),
                        PhongTro_MaSo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSo)
                .ForeignKey("dbo.ChuTroes", t => t.ChuTro_MaSo)
                .ForeignKey("dbo.NguoiThues", t => t.NguoiThue_MaSo)
                .ForeignKey("dbo.PhongTroes", t => t.PhongTro_MaSo)
                .Index(t => t.ChuTro_MaSo)
                .Index(t => t.NguoiThue_MaSo)
                .Index(t => t.PhongTro_MaSo);
            
            CreateTable(
                "dbo.NguoiDungChuTroes",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                        ChuTro_MaSo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenDangNhap)
                .ForeignKey("dbo.ChuTroes", t => t.ChuTro_MaSo)
                .Index(t => t.ChuTro_MaSo);
            
            CreateTable(
                "dbo.NguoiDungNguoiThues",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                        NguoiThue_MaSo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenDangNhap)
                .ForeignKey("dbo.NguoiThues", t => t.NguoiThue_MaSo)
                .Index(t => t.NguoiThue_MaSo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NguoiDungNguoiThues", "NguoiThue_MaSo", "dbo.NguoiThues");
            DropForeignKey("dbo.NguoiDungChuTroes", "ChuTro_MaSo", "dbo.ChuTroes");
            DropForeignKey("dbo.HopDongs", "PhongTro_MaSo", "dbo.PhongTroes");
            DropForeignKey("dbo.HopDongs", "NguoiThue_MaSo", "dbo.NguoiThues");
            DropForeignKey("dbo.HopDongs", "ChuTro_MaSo", "dbo.ChuTroes");
            DropForeignKey("dbo.HoaDons", "PhongTro_MaSo", "dbo.PhongTroes");
            DropForeignKey("dbo.NguoiThues", "PhongTro_MaSo", "dbo.PhongTroes");
            DropForeignKey("dbo.PhongTroes", "ChuTro_MaSo", "dbo.ChuTroes");
            DropIndex("dbo.NguoiDungNguoiThues", new[] { "NguoiThue_MaSo" });
            DropIndex("dbo.NguoiDungChuTroes", new[] { "ChuTro_MaSo" });
            DropIndex("dbo.HopDongs", new[] { "PhongTro_MaSo" });
            DropIndex("dbo.HopDongs", new[] { "NguoiThue_MaSo" });
            DropIndex("dbo.HopDongs", new[] { "ChuTro_MaSo" });
            DropIndex("dbo.HoaDons", new[] { "PhongTro_MaSo" });
            DropIndex("dbo.NguoiThues", new[] { "PhongTro_MaSo" });
            DropIndex("dbo.PhongTroes", new[] { "ChuTro_MaSo" });
            DropTable("dbo.NguoiDungNguoiThues");
            DropTable("dbo.NguoiDungChuTroes");
            DropTable("dbo.HopDongs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.NguoiThues");
            DropTable("dbo.PhongTroes");
            DropTable("dbo.ChuTroes");
        }
    }
}
