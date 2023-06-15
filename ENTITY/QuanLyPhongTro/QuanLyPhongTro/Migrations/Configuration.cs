namespace QuanLyPhongTro.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyPhongTro.QLPhongTroCodeFristModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "QuanLyPhongTro.QLPhongTroCodeFristModel";
        }

        protected override void Seed(QuanLyPhongTro.QLPhongTroCodeFristModel context)
        {
        }
    }
}
