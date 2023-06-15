namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNgayDauToHoaDons : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "NgayDau", c => c.DateTime(nullable: false));
            AddColumn("dbo.HoaDons", "NgayCuoi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "NgayCuoi");
            DropColumn("dbo.HoaDons", "NgayDau");
        }
    }
}
