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
    public partial class ThemNguoiVaoTro_Form : Form
    {
        BLNguoiThue blnguoithue = new BLNguoiThue();
        BLPhongTro blPhongTro = new BLPhongTro();
        BLChuTro blChuTro = new BLChuTro();
        public ThemNguoiVaoTro_Form(string ma)
        {
            InitializeComponent();
            txt_machuTro1.Text = ma;
        }
        public void ShowNguoiThue()
        {
            DataTable x = blnguoithue.TimTheoMaChuTro(txt_machuTro1.Text);
            dgvNguoiThue.DataSource = x;
        }

        private void btn_show1_Click(object sender, EventArgs e)
        {
            ShowNguoiThue();
        }

        private void btn_themnguoithue_Click(object sender, EventArgs e)
        {
            if (blPhongTro.TimTheoMaSo(txt_maphongtro1.Text) == null)
            {
                MessageBox.Show("Không tồn tại phòng trọ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blChuTro.SoHuuPhongTro(txt_machuTro1.Text, txt_maphongtro1.Text) == false)
            {
                MessageBox.Show("Bạn không sở hữu phòng trọ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blPhongTro.DemSoNguoiDangO(txt_maphongtro1.Text) == 0)
            {
                MessageBox.Show("Bạn không thể thêm vào phòng trọ chưa có hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blnguoithue.TimTheoMaSo(txt_manguoithue.Text) == null)
            {
                MessageBox.Show("Không tồn tại người thuê này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blnguoithue.DaCoPhongTro(txt_manguoithue.Text))
            {
                MessageBox.Show("Người này đã có phòng rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blPhongTro.DatGioiHanNguoiO(txt_maphongtro1.Text))
            {
                MessageBox.Show("Phòng này đã đạt giới hạn người ở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            blnguoithue.ThemNguoiThueVaoTro(txt_manguoithue.Text, txt_maphongtro1.Text);
            ShowNguoiThue();
        }
        private void btn_xoanguoithue_Click(object sender, EventArgs e)
        {
            if (blPhongTro.TimTheoMaSo(txt_maphongtro1.Text) == null)
            {
                MessageBox.Show("Không tồn tại phòng trọ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blChuTro.SoHuuPhongTro(txt_machuTro1.Text, txt_maphongtro1.Text) == false)
            {
                MessageBox.Show("Bạn không sở hữu phòng trọ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (blnguoithue.TimTheoMaSo(txt_manguoithue.Text) == null)
            {
                MessageBox.Show("Không tồn tại người thuê này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            blnguoithue.XoaNguoiThueKhoiTro(txt_manguoithue.Text);
            ShowNguoiThue();
        }

        private void dgvNguoiThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNguoiThue.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            string m = dgvNguoiThue.Rows[r].Cells[0].Value.ToString();
            txt_manguoithue.Text = m;
        }
    }
}
