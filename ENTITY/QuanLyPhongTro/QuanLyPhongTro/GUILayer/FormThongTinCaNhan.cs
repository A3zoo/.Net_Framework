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
using static System.Windows.Forms.AxHost;

namespace QuanLyPhongTro
{
    public partial class FormThongTinCaNhan : Form
    {
        BLNguoiDungNguoiThue blUserNgThue;
        BLNguoiDungChuTro blUserChuTro;
        bool state;//True la o che do nguoi dung chu tro, false la o che do nguoi chung nguoi thue
        ChuTro chuTro;
        NguoiThue ngThue;

        public FormThongTinCaNhan(NguoiDungChuTro user)
        {
            state = true;
            blUserChuTro = new BLNguoiDungChuTro();
            this.chuTro = user.ChuTro;
            InitializeComponent();
            txtMk.Text = user.MatKhau;
            txtTdn.Text = user.TenDangNhap;
            DienThongTinCoBan(user.ChuTro);
        }

        public FormThongTinCaNhan(NguoiDungNguoiThue user)
        {
            state = false;
            blUserNgThue = new BLNguoiDungNguoiThue();
            this.ngThue = user.NguoiThue;
            InitializeComponent();
            txtMk.Text = user.MatKhau;
            txtTdn.Text = user.TenDangNhap;
            DienThongTinCoBan(user.NguoiThue);
        }
        private void DienThongTinCoBan(Nguoi nguoi)
        {
            txtHvt.Text = nguoi.Ten;
            txtCccd.Text = nguoi.CCCD;
            dtNsinh.Value = nguoi.NgaySinh;
            txtQq.Text = nguoi.QueQuan;
            txtSdt.Text = nguoi.SDT;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            plCaNhan.Enabled = true;
            txtTdn.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (state)
                blUserChuTro.CapNhatThongTin(chuTro.MaSo, txtHvt.Text, txtCccd.Text, txtSdt.Text, txtQq.Text, txtTdn.Text, txtMk.Text, dtNsinh.Value);
            else blUserNgThue.CapNhatThongTin(ngThue.MaSo, txtHvt.Text, txtCccd.Text, txtSdt.Text, txtQq.Text, txtTdn.Text, txtMk.Text, dtNsinh.Value);
            plCaNhan.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}
