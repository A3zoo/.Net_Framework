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

namespace QuanLyPhongTro.GUILayer
{
    public partial class FormHopDong : Form
    {
        BLHopDong blHopDong = new BLHopDong();
        HopDong hopdong;

        public FormHopDong(NguoiThue ngth)
        {
            InitializeComponent();
            hopdong = blHopDong.TimHopDongCoHieuLuc(ngth);
        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            DienThongTin();
        }

        private void DienThongTin()
        {
            txtMaHopDong.Text = hopdong.MaSo;
            txtTenChuTro.Text = hopdong.ChuTroe.Ten;
            txtThoiHanCoc.Text = hopdong.ThoiHanCoc.ToString();
            txtTienCoc.Text = (hopdong.TienCoc).ToString();
            dtNgayTao.Value = hopdong.NgayTao;
            if (hopdong.NgayKetThuc != null)
            {
                dtNgayKetThuc.Visible = true;
                dtNgayKetThuc.Value = Convert.ToDateTime(hopdong.NgayKetThuc);
            }
            else
                dtNgayKetThuc.Visible = false;
        }
    }
}
