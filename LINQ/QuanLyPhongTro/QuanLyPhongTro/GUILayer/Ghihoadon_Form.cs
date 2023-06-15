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

namespace QuanLyPhongTro
{
    public partial class Ghihoadon_Form : Form
    {
        BLHoaDon blhoadon = new BLHoaDon();
        public Ghihoadon_Form()
        {
            InitializeComponent();
            ShowHoaDon();
        }
        public void ShowHoaDon()
        {
            dgvHoadon.DataSource = blhoadon.LayHoaDon();
        }

        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                string maSo = (txt_mahoadon.Text);
                int soDienTieuThu = int.Parse(txt_sodien.Text);
                int soNuocTieuThu = int.Parse(txt_sonuoc.Text);
                DateTime ngayDau = DateTime.Parse(txt_ngaydau.Text);
                DateTime ngayCuoi = DateTime.Parse(text_ngaycuoi.Text);
                bool daThanhToan = cbb_thanhtoan.SelectedItem.ToString() == "Rồi" ? true : false;
                DateTime ngayThanhToan = DateTime.Parse(txt_ngaythanhtoan.Text);
                string maphongtro = txt_maphong.Text;
                if (blhoadon.TimHoaDonTheoMaSo(maSo) != null)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                blhoadon.ThemHoaDon(maSo, soDienTieuThu, soNuocTieuThu, ngayDau, ngayCuoi, daThanhToan, ngayThanhToan, maphongtro);
                ShowHoaDon();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvHoadon.CurrentCell.RowIndex;
            txt_mahoadon.Text = dgvHoadon.Rows[r].Cells[0].Value.ToString();
            txt_sodien.Text = dgvHoadon.Rows[r].Cells[1].Value.ToString();
            txt_sonuoc.Text = dgvHoadon.Rows[r].Cells[2].Value.ToString();
            txt_ngaydau.Text = dgvHoadon.Rows[r].Cells[3].Value.ToString();
            text_ngaycuoi.Text = dgvHoadon.Rows[r].Cells[4].Value.ToString();
            txt_ngaythanhtoan.Text = dgvHoadon.Rows[r].Cells[6].Value.ToString();
            txt_maphong.Text = blhoadon.LayMaPhongTro(txt_mahoadon.Text);
        }
    }
}
