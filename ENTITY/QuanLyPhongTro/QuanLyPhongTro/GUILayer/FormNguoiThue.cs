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
    public partial class FormNguoiThue : Form
    {
        NguoiThue ngThue;
        BLHopDong blHopDong;
        BLNguoiThue blNgThue;
        public FormNguoiThue(NguoiThue ngThue)
        {
            this.ngThue = ngThue;
            blHopDong = new BLHopDong();
            blNgThue = new BLNguoiThue();
            InitializeComponent();
            TaiDuLieu();
        }

        public void TaiDuLieu()
        {
            lblLoiChao.Text = "Xin chào,\n" + ngThue.Ten;
            TaiPhong();
        }

        public void TaiPhong()
        {
            PhongTro ph = ngThue.PhongTro;
            if (ph != null)
            {
                txtMSPhong.Text = ph.MaSo;
                txtDiaChi.Text = ph.DiaChi;
                txtDienTich.Text = ph.DienTich + " m\u00B2";
                txtTienThue.Text = ph.TienThue + "VND";
                txtSoNThue.Text = ph.NguoiDangThue.Count.ToString();
                lblMSPhong.Show();
                lblDiaChi.Show();
                lblDienTich.Show();
                lblTienThue.Show();
                lblSoNThue.Show();
                txtMSPhong.Show();
                txtDiaChi.Show();
                txtDienTich.Show();
                txtTienThue.Show();
                txtSoNThue.Show();
                btnTraPhong.Show();
                btnLayCoc.Show();
                lblKhongCoPhong.Hide();
            }
            else
            {
                lblMSPhong.Hide();
                lblDiaChi.Hide();
                lblDienTich.Hide();
                lblTienThue.Hide();
                lblSoNThue.Hide();
                txtMSPhong.Hide();
                txtDiaChi.Hide();
                txtDienTich.Hide();
                txtTienThue.Hide();
                txtSoNThue.Hide();
                btnTraPhong.Hide();
                btnLayCoc.Hide();
                lblKhongCoPhong.Show();
            }
        }

        private void FormNguoiThue_Load(object sender, EventArgs e)
        {
            txtMSPhong.BackColor = SystemColors.Window;
            txtDiaChi.BackColor = SystemColors.Window;
            txtDienTich.BackColor = SystemColors.Window;
            txtTienThue.BackColor = SystemColors.Window;
            txtSoNThue.BackColor = SystemColors.Window;
        }

        private void tsbtnTimNhaTro_Click(object sender, EventArgs e)
        {
            Hide();
            FormNguoiThueTimPhong frmTimNhaTro = new FormNguoiThueTimPhong(ngThue);
            frmTimNhaTro.ShowDialog();
            TaiDuLieu();
            Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNguoiThue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void tsbtnXemHoaDon_Click(object sender, EventArgs e)
        {
            if (ngThue.PhongTro == null)
            {
                MessageBox.Show("Bạn chưa thuê phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormHoaDonNguoiThue frmHD = new FormHoaDonNguoiThue(ngThue);
            Hide();
            frmHD.ShowDialog();
            Show();
        }

        private void tsbtnTTCaNhan_Click(object sender, EventArgs e)
        {
            Hide();
            BLNguoiDungNguoiThue blUserNgThue = new BLNguoiDungNguoiThue();
            NguoiDungNguoiThue userNgThue = blUserNgThue.TimTheoMaSo(ngThue.MaSo);
            FormThongTinCaNhan frmTTCaNhan = new FormThongTinCaNhan(userNgThue);
            frmTTCaNhan.ShowDialog();
            Show();
        }

        private void tsbtnXemHopDong_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (ngThue.PhongTro.NguoiDangThue.Count > 1)
            {
                MessageBox.Show("Bạn phải thay đổi người đứng tên trong hợp đồng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            try
            {
                HopDong hd = blHopDong.TimHopDongCoHieuLuc(ngThue);
                blHopDong.KetThucHopDong(hd);
                blNgThue.RoiTro(ngThue);
                MessageBox.Show("Trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLayCoc_Click(object sender, EventArgs e)
        {
            try
            {
                HopDong hd = blHopDong.TimHopDongCoHieuLuc(ngThue);
                if (hd == null)
                {
                    MessageBox.Show("Bạn chưa thuê phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (blHopDong.LayTienCoc(hd))
                {
                    MessageBox.Show("Lấy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tiền cọc đã được lấy trước đó hoặc chưa tới thời hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Lấy thất bại. Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
