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
    public partial class ThemXoaPhong_Form : Form
    {
        BLPhongTro blphongtro;
        BLChuTro blchuTro;
        public ThemXoaPhong_Form(string ma)
        {
            blphongtro = new BLPhongTro();
            blchuTro = new BLChuTro();
            InitializeComponent();
            txtmachutro.Text = ma;
        }
        public void ShowPhongTro()
        {
            dgvPhongTro.DataSource = blphongtro.TimTheoChuTro(txtmachutro.Text);
            dgvPhongTro.Columns["ChuTro"].Visible = false;
        }
        
        private void btn_XoaPhong_Click(object sender, EventArgs e)
        {
            string msPhong = txtMaphong.Text;
            if (blphongtro.DemSoNguoiDangO(msPhong) > 0)
            {
                MessageBox.Show("Phòng có người đang ở, không thể xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blphongtro.TimTheoMaSo(msPhong) == null || blchuTro.SoHuuPhongTro(txtmachutro.Text, txtMaphong.Text) == false)
            {
                MessageBox.Show("Không có phòng trọ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            blphongtro.XoaPhong(msPhong);
            ShowPhongTro();
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            string mp = txtMaphong.Text;
            double dt = Convert.ToDouble(txtDienTich.Text);
            string dc = txtDiachi.Text;
            int Songuoi = Convert.ToInt32(txtSoNguoiMax.Text);
            bool cogac = cbb_gac.Text == "Không" ? false : true;
            bool thucung = cbb_thucung.Text == "Không" ? false : true;
            double tienthue = Convert.ToInt32(txt_tienthue.Text);
            double tiendien = Convert.ToInt32(txt_tiendien.Text);
            double tiennuoc = Convert.ToInt32(txt_tiennuoc.Text);
            double tienrac = Convert.ToInt32(txt_tienrac.Text);

            if (blphongtro.TimTheoMaSo(mp) != null)
            {
                MessageBox.Show("Mã phòng đã tồn tại!"); return;
            }
            blphongtro.ThemPhong(txtmachutro.Text,mp,dt,dc,Songuoi,cogac,thucung,tienthue,tiendien,tiennuoc,tienrac);
            ShowPhongTro();
            
        }

        private void ThemXoaPhong_Form_Load(object sender, EventArgs e)
        {
            ShowPhongTro();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ShowPhongTro();
        }

        private void dgvPhongTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvPhongTro.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            string mp = dgvPhongTro.Rows[r].Cells[0].Value.ToString();
            txtMaphong.Text = mp;
            txtDienTich.Text = dgvPhongTro.Rows[r].Cells[1].Value.ToString();
            txtDiachi.Text = dgvPhongTro.Rows[r].Cells[2].Value.ToString();
            txtSoNguoiMax.Text =dgvPhongTro.Rows[r].Cells[3].Value.ToString();
            txt_tienthue.Text = dgvPhongTro.Rows[r].Cells[5].Value.ToString();
            txt_tiendien.Text = dgvPhongTro.Rows[r].Cells[6].Value.ToString();
            txt_tiennuoc.Text = dgvPhongTro.Rows[r].Cells[7].Value.ToString();
            txt_tienrac.Text = dgvPhongTro.Rows[r].Cells[8].Value.ToString();
        }
    }
}
