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
    public partial class FormThuePhong : Form
    {
        NguoiThue nguoiThue;
        PhongTro ph;
        BLHopDong blHopDong;
        BLNguoiThue blNgThue;

        public FormThuePhong(NguoiThue ngThue, PhongTro ph)
        {
            this.nguoiThue = ngThue;
            this.ph = ph;
            blHopDong = new BLHopDong();
            blNgThue = new BLNguoiThue();
            InitializeComponent();
        }

        private void FormThuePhong_Load(object sender, EventArgs e)
        {
            txtNgThue.Text = nguoiThue.Ten;
            txtChuTro.Text = ph.ChuTro.Ten;
            txtPhong.Text = ph.MaSo;
            txtTienThue.Text = ph.TienThue.ToString();
            txtNgayThue.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            double coc = (double)nudTienCoc.Value;
            int thHan = (int)nudThoiHan.Value;
            try
            {
                blHopDong.ThemHopDong(DateTime.Today, coc, thHan, ph.ChuTro, nguoiThue, ph);
                blNgThue.ThuePhong(nguoiThue, ph);
                MessageBox.Show("Thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra. Thuê thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
