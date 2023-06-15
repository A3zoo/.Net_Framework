namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNgayThanhToanToHoaDons : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "NgayThanhToan", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "NgayThanhToan");
        }
    }
}
