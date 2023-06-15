namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNgayThanhToanToHoaDons1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HoaDons", "NgayThanhToan", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HoaDons", "NgayThanhToan", c => c.DateTime(nullable: false));
        }
    }
}
