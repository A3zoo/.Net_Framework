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
    public partial class FormXacMinh : Form
    {
        BLNguoiDungChuTro blNDungChuTro = new BLNguoiDungChuTro();
        BLNguoiDungNguoiThue blNDungNThue = new BLNguoiDungNguoiThue();

        bool state;

        public FormXacMinh(bool state)
        {
            InitializeComponent();
            this.state = state;
        }

        private void btnXacMinh_Click(object sender, EventArgs e)
        {
            bool tempt;
            if (state)
                tempt = blNDungChuTro.DoiMK(txtCCCD.Text, txtDn.Text, txtMK.Text);
            else
                tempt = blNDungNThue.DoiMK(txtCCCD.Text, txtDn.Text, txtMK.Text); 
            if (tempt == false)
            {
                lblTB.Text = "CCCD hoặc tên đăng nhập bị sai";
            } 
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Hide();
                FormDangKy frmDangKy = new FormDangKy();
                frmDangKy.Show();
            }    
        }
    }
}
