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
using QuanLyPhongTro.DBLayer;
using static System.Windows.Forms.AxHost;

namespace QuanLyPhongTro
{
    public partial class FormThongTinCaNhan : Form
    {
        BLNguoiDungChuTro blNguoiDungChuTro;
        BLNguoiDungNguoiThue blNguoiDungNguoiThue;

        bool state;//True la o che do nguoi dung chu tro, false la o che do nguoi chung nguoi thue
        ChuTroe chuTro;
        NguoiThue ngThue;

        public FormThongTinCaNhan(NguoiDungChuTroe user)
        {
            state = true;
            blNguoiDungChuTro = new BLNguoiDungChuTro();
            chuTro = user.ChuTroe;
            InitializeComponent();
            txtMk.Text = user.MatKhau;
            txtTdn.Text = user.TenDangNhap;
            DienThongTinCoBan(chuTro.Ten, chuTro.CCCD, chuTro.NgaySinh, chuTro.QueQuan, chuTro.SDT);
        }

        public FormThongTinCaNhan(NguoiDungNguoiThue user)
        {
            state = false;
            blNguoiDungNguoiThue = new BLNguoiDungNguoiThue();
            ngThue = user.NguoiThue;
            InitializeComponent();
            txtMk.Text = user.MatKhau;
            txtTdn.Text = user.TenDangNhap;
            DienThongTinCoBan(ngThue.Ten, ngThue.CCCD, ngThue.NgaySinh, ngThue.QueQuan, ngThue.SDT);
        }

        private void DienThongTinCoBan(string ten, string cccd, DateTime ngSinh, string qQuan, string sdt)
        {
            txtHvt.Text = ten;
            txtCccd.Text = cccd;
            dtNsinh.Value = ngSinh;
            txtQq.Text = qQuan;
            txtSdt.Text = sdt;
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
                blNguoiDungChuTro.CapNhatThongTin(chuTro.MaSo, txtHvt.Text, txtCccd.Text, txtSdt.Text, txtQq.Text, txtTdn.Text, txtMk.Text, dtNsinh.Value);
            else blNguoiDungNguoiThue.CapNhatThongTin(ngThue.MaSo, txtHvt.Text, txtCccd.Text, txtSdt.Text, txtQq.Text, txtTdn.Text, txtMk.Text, dtNsinh.Value);
            plCaNhan.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}
