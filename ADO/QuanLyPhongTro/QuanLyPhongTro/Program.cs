using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.GUILayer;

namespace QuanLyPhongTro
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HoaDon a = new HoaDon()
            {
                MaSo = "1",
                NgayCuoi = new DateTime(2023, 4, 5),
                NgayDau = new DateTime(2023, 6, 6),
                NgayThanhToan = new DateTime(2023, 5, 5),
                SoNuocTieuThu = 9,
                SoDienTieuThu = 10,
                DaThanhToan = true,
                PhongTro = new PhongTro()
                {
                    TienDien = 3,
                    TienNuoc = 4,
                    TienRac = 6,
                    TienThue = 154
                }
            };
            Application.Run(new FormChiTietHoaDon(a));
        }
    }
}
