using QuanLyPhongTro.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUILayer
{
    public partial class FormChiTietHoaDon : Form
    {
        BLHoaDon blHoaDon;
        HoaDon hoaDon;
        public FormChiTietHoaDon(HoaDon hoaDon)
        {
            this.hoaDon = hoaDon;
            blHoaDon = new BLHoaDon();
            InitializeComponent();
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongTroDataSet.HoaDonChiTiet' table. You can move, or remove it, as needed.
            this.hoaDonChiTietTableAdapter.Fill(this.quanLyPhongTroDataSet.HoaDonChiTiet);
            this.hoaDonChiTietTableAdapter.FillBy(this.quanLyPhongTroDataSet.HoaDonChiTiet, hoaDon.MaSo);
            this.reportViewer1.RefreshReport();
            double a = blHoaDon.TinhTongTien(hoaDon);
            lblTongThanhToan.Text = a.ToString() + "000";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
