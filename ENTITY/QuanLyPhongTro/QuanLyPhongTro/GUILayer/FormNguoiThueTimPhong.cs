using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.BSLayer;

namespace QuanLyPhongTro.GUILayer
{
    public partial class FormNguoiThueTimPhong : Form
    {
        BLPhongTro blPhongTro;
        BLNguoiThue blNgThue;
        NguoiThue ngThue;
        public FormNguoiThueTimPhong(NguoiThue ngThue)
        {
            blPhongTro = new BLPhongTro();
            blNgThue = new BLNguoiThue();
            this.ngThue = ngThue;
            InitializeComponent();
            TaiDuLieu();
        }

        public void TaiDuLieu()
        {
            DataTable dt = blPhongTro.LayPhongTrong();
            TaiDuLieuVaoDGV(dt);
            cboDiaChi.Items.AddRange(blPhongTro.LayTatCaDiaChi());
        }

        private void TaiDuLieuVaoDGV(DataTable dt)
        {
            for (int i = 0; i < dgvDSPhongTro.ColumnCount; i++)
            {
                dt.Columns[i].ColumnName = dgvDSPhongTro.Columns[i].HeaderText;
            }
            dgvDSPhongTro.Columns.Clear();
            dgvDSPhongTro.DataSource = dt;
            dgvDSPhongTro.Columns["Chủ Trọ"].Visible = false;
        }

        private void trbTienThue_ValueChanged(object sender, EventArgs e)
        {
            lblTienThue.Text = string.Format("{0:n0}", trbTienThue.Value * 100000);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string diaChi = cboDiaChi.Text.Trim();
            if (string.IsNullOrEmpty(diaChi) )
            {
                MessageBox.Show("Địa chỉ không được phép bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            int dienTich = (int)nudDienTich.Value;
            int soNgToiDa = (int)nudSoNToiDa.Value;
            double tienThue = trbTienThue.Value * 100000;
            bool gac = chkCoGac.Checked;
            bool thucung = chkThuCung.Checked;
            DataTable dt = blPhongTro.TimKiemPhong(diaChi, dienTich, soNgToiDa, tienThue, gac, thucung);
            TaiDuLieuVaoDGV(dt);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboDiaChi.Text = "";
            nudDienTich.Value = nudDienTich.Minimum;
            nudSoNToiDa.Value = nudSoNToiDa.Minimum;
            trbTienThue.Value = 0;
            chkCoGac.Checked = chkThuCung.Checked = true;
            DataTable dt = blPhongTro.LayPhongTrong();
            TaiDuLieuVaoDGV(dt);
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (blNgThue.DaThuePhong(ngThue))
            {
                MessageBox.Show("Bạn đã có phòng trọ rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dgvDSPhongTro.Rows.Count == 0)
                {
                    MessageBox.Show("Khong có phòng trọ để thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string msPhong = dgvDSPhongTro.CurrentRow.Cells["Mã Số"].Value.ToString();
                    PhongTro ph = blPhongTro.TimTheoMaSo(msPhong);
                    FormThuePhong frmThuePhong = new FormThuePhong(ngThue, ph);
                    Hide();
                    frmThuePhong.ShowDialog();
                    Show();
                }


            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnXemHoaDon_Click(object sender, EventArgs e)
        {
            Hide();
            FormHoaDonNguoiThue frmHD = new FormHoaDonNguoiThue(ngThue);
            frmHD.ShowDialog();
            Close();
        }

        private void tsbtnTTCaNhan_Click(object sender, EventArgs e)
        {
            Hide();
            BLNguoiDungNguoiThue blUserNgThue = new BLNguoiDungNguoiThue();
            NguoiDungNguoiThue userNgThue = blUserNgThue.TimTheoMaSo(ngThue.MaSo);
            FormThongTinCaNhan frmTTCaNhan = new FormThongTinCaNhan(userNgThue);
            frmTTCaNhan.ShowDialog();
            Close();
        }
    }
}
