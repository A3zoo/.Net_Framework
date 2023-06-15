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
    public partial class FormDangKy : Form
    {
        BLNguoiDungChuTro blNDungChuTro = new BLNguoiDungChuTro();
        BLNguoiDungNguoiThue blNDungNguoiThue = new BLNguoiDungNguoiThue();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTdn.Text == "")
                txtTdn.Text = "";
            if (blNDungChuTro.CheckTrungTenDangNhap(txtTdn.Text) != null || blNDungNguoiThue.CheckTrungTenDangNhap(txtTdn.Text) != null)
            {
                lblTrunTen.ForeColor = Color.Red;
                lblTrunTen.Text = "Tên đăng nhập này đã tồn tại";
            }    
            else
            {
                lblTrunTen.ForeColor = Color.Green;
                lblTrunTen.Text = "Chấp nhận tên đăng nhập";
            }    
        }

        private void DangKiNguoiThue()
        {
            try
            {
                blNDungNguoiThue.DangKi(txtHvt.Text, txtCccd.Text, txtSdt.Text, txtQq.Text, txtTdn.Text, txtMk.Text, dtNsinh.Value);
                MessageBox.Show("Đăng kí thành công");
            }
            catch
            {
                MessageBox.Show("Đăng kí không thành công");
            }
        }

        private void DangKiNguoiChoThue()
        {
            try
            {
                blNDungChuTro.DangKi(txtHvt.Text, txtCccd.Text, txtSdt.Text, txtQq.Text, txtTdn.Text, txtMk.Text, dtNsinh.Value);
                MessageBox.Show("Đăng kí thành công");
            }
            catch
            {
                MessageBox.Show("Đăng kí không thành công");
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (rdoNguoiThue.Checked) DangKiNguoiThue();
            else DangKiNguoiChoThue();
        }
    }
}
