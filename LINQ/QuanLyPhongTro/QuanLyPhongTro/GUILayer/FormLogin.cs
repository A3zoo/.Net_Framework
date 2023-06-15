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
    public partial class FormLogin : Form
    {
        BLNguoiDungChuTro blNDungChuTro = new BLNguoiDungChuTro();
        BLNguoiDungNguoiThue blNDungNThue = new BLNguoiDungNguoiThue();
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void picTenDangNhap_MouseHover(object sender, EventArgs e)
        {
            tipTenDangNhap.Show("Tên Đăng Nhập", picTenDangNhap);
        }

        private void picMatKhau_MouseHover(object sender, EventArgs e)
        {
            tipMatKhau.Show("Mật Khẩu", picMatKhau);
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (btnShowPass.Tag.ToString() == "hide")
            {
                txtMatKhau.PasswordChar = '\0';
                btnShowPass.Tag = "show";
                btnShowPass.BackgroundImage = Properties.Resources.hide_pass;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                btnShowPass.Tag = "hide";
                btnShowPass.BackgroundImage = Properties.Resources.show_pass;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;

            if (tenDN.Length == 0)
            {
                MessageBox.Show("Chưa điền tên đăng nhập!", "Đăng Nhập Thất Bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mk.Length == 0)
            {
                MessageBox.Show("Chưa điền mật khẩu!", "Đăng Nhập Thất Bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool loginSucces = true;

            if (rdoNChoThue.Checked)
            {
                NguoiDungChuTroe user = (NguoiDungChuTroe)blNDungChuTro.DangNhap(mk, tenDN);
                
                if (user != null)
                {
                    FormChuTro frmNThue = new FormChuTro(user);
                    this.Visible = false;
                    frmNThue.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    loginSucces = false;
                }
            }
            else
            {
                NguoiDungNguoiThue user = (NguoiDungNguoiThue)blNDungNThue.DangNhap(mk, tenDN);
                if (user != null)
                {
                    FormNguoiThue frmNThue = new FormNguoiThue(user.NguoiThue);
                    this.Visible = false;
                    frmNThue.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    loginSucces = false;
                }
            }

            if (!loginSucces)
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Xác!", "Đăng Nhập Thất Bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy frmDangKy = new FormDangKy();
            this.Visible = false;
            frmDangKy.ShowDialog();
            this.Visible = true;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            if (rdoNChoThue.Checked)
            {
                FormXacMinh frm = new FormXacMinh(false);
                frm.Show();
            }
            else
            {
                FormXacMinh frm = new FormXacMinh(true);
                frm.Show();
            }
            this.Hide();
        }
    }
}
