namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDaThanhToanToHoaDon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "DaThanhToan", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "DaThanhToan");
        }
    }
}
