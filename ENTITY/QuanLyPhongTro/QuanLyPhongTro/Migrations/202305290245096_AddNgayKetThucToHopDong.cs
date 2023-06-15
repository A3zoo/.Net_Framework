namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNgayKetThucToHopDong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HopDongs", "NgayKetThuc", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HopDongs", "NgayKetThuc");
        }
    }
}
