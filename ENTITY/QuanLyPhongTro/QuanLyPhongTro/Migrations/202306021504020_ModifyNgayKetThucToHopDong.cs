namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyNgayKetThucToHopDong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HopDongs", "NgayKetThuc", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HopDongs", "NgayKetThuc", c => c.DateTime(nullable: false));
        }
    }
}
