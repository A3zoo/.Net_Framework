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
using QuanLyPhongTro.DBLayer;

namespace QuanLyPhongTro.GUILayer
{
    public partial class FormHoaDonNguoiThue : Form
    {
        BLHoaDon blHoaDon;
        NguoiThue ngThue;
        public FormHoaDonNguoiThue(NguoiThue ngThue)
        {
            blHoaDon = new BLHoaDon();

            this.ngThue = ngThue;
            InitializeComponent();
            TaiDuLieu();
        }

        public void TaiDuLieuVaoDGV(DataTable dt)
        {
            for (int i = 0; i < dgvHoaDon.ColumnCount; i++)
            {
                dt.Columns[i].ColumnName = dgvHoaDon.Columns[i].HeaderText;
            }
            dgvHoaDon.Columns.Clear();
            dgvHoaDon.DataSource = dt;
            dgvHoaDon.Columns["Phòng"].Visible = false;
        }

        public void TaiDuLieu()
        {
            DataTable dt = blHoaDon.LayHoaDonTheoNguoiThue(ngThue);
            TaiDuLieuVaoDGV(dt);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Bạn không có hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            string maSo = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            HoaDon hd = blHoaDon.TimHoaDonTheoMaSo(maSo);
            if (hd == null)
            {
                MessageBox.Show("Chưa có hóa đơn nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            FormChiTietHoaDon frmCTHoaDon = new FormChiTietHoaDon(hd);
            this.Hide();
            frmCTHoaDon.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Bạn không có hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            string maSo = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            HoaDon hd = blHoaDon.TimHoaDonTheoMaSo(maSo);

            if (hd.DaThanhToan == true)
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            else
            {
                try
                {
                    blHoaDon.ThanhToanHoaDon(hd);
                    TaiDuLieu();
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra. Thanh toán thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnTimNhaTro_Click(object sender, EventArgs e)
        {
            Hide();
            FormNguoiThueTimPhong frmTimPhong = new FormNguoiThueTimPhong(ngThue);
            frmTimPhong.ShowDialog();
            Close();
        }

        private void tsbtnTTCaNhan_Click(object sender, EventArgs e)
        {
            Hide();
            BLNguoiDungNguoiThue blUserNgThue = new BLNguoiDungNguoiThue();
            NguoiDungNguoiThue userNgThue = blUserNgThue.TimTheoMaSo(ngThue.MaSo);
            FormThongTinCaNhan frmTTCaNhan = new FormThongTinCaNhan(userNgThue);
            frmTTCaNhan.ShowDialog();
            Hide();
        }
    }
}
