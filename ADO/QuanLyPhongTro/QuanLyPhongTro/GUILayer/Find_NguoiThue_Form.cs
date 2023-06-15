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
    public partial class Find_NguoiThue_Form : Form
    {
        BLNguoiThue bLNguoiThue = new BLNguoiThue();
        public Find_NguoiThue_Form()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            NguoiThue ngThue = bLNguoiThue.TimTheoMaSo(txt_manguoithue1.Text);
            if (ngThue==null)
            {
                MessageBox.Show("Người thuê không tồn tại");
                return;
            }    
            txt_ten.Text = ngThue.Ten;
            txt_ngaysinh.Text = ngThue.NgaySinh.ToString();
            txt_cccd.Text = ngThue.CCCD;
            txt_quequan.Text = ngThue.QueQuan;
            txt_sdt.Text = ngThue.SDT;
            txt_maphongtro2.Text = ngThue.PhongTro.MaSo;
        }
    }
}
