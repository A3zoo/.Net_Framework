using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.GUILayer;
using Microsoft.Reporting.WinForms;
using QuanLyPhongTro.DBLayer;
using QuanLyPhongTro.BSLayer;

namespace QuanLyPhongTro
{
    public partial class FormChuTro : Form
    {
        public FormChuTro()
        {
            InitializeComponent();
        }

        public FormChuTro(NguoiDungChuTroe chutro)
        {
            InitializeComponent();
            txtCMND.Text = chutro.ChuTroe.MaSo;
        }

        private void btn_ThemXoaPhong_Click(object sender, EventArgs e)
        {
           ThemXoaPhong_Form ThemXoaPhongForm = new ThemXoaPhong_Form(txtCMND.Text);
           ThemXoaPhongForm.ShowDialog();
        }
        public string getCMND()
        {
            string res = txtCMND.Text;
            return res;
        }

        private void btn_ThemNguoiThue_Click(object sender, EventArgs e)
        {
            ThemNguoiVaoTro_Form ThemNguoiThue = new ThemNguoiVaoTro_Form(txtCMND.Text);
            ThemNguoiThue.ShowDialog();
        }

        private void btn_roitro_Click(object sender, EventArgs e)
        {
            ThemNguoiVaoTro_Form XoaNguoiThue = new ThemNguoiVaoTro_Form(txtCMND.Text);
            XoaNguoiThue.ShowDialog();
        }

        private void btn_ghihoadon_Click(object sender, EventArgs e)
        {
            Ghihoadon_Form Ghihoadon = new Ghihoadon_Form();
            Ghihoadon.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Find_NguoiThue_Form FindNguoiThue = new Find_NguoiThue_Form();
            FindNguoiThue.ShowDialog();
        }
        private void btnXuatHDon_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "./ReportHoaDon.rdlc";
            ReportDataSource newDataSource;
            if (rdbChuaThanhToan.Checked)
            {
                this.HoaDonsTableAdapter.FillChuạThanhToan(this.QuanLyPhongTroDataSet.HoaDons, txtCMND.Text);
            }
            else
            {
                this.HoaDonsTableAdapter.FillDaThanhToan(this.QuanLyPhongTroDataSet.HoaDons, txtCMND.Text);
            }
            newDataSource = new ReportDataSource("DataSet1", this.HoaDonsBindingSource);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void FormChuTro_Load(object sender, EventArgs e)
        {

        }

        private void btnXuatPT_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "./ReportPhongTro.rdlc";
            ReportDataSource newDataSource;
            if (rdbTatCa.Checked)
            {
                this.PhongTroesTableAdapter.FillByMaSoPhong(this.QuanLyPhongTroDataSet.PhongTroes, txtCMND.Text);
            }
            else
            {
                this.PhongTroesTableAdapter.FillPhongTroConTrong(this.QuanLyPhongTroDataSet.PhongTroes, txtCMND.Text);
            }
            newDataSource = new ReportDataSource("DataSet1", this.PhongTroesBindingSource);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "./ReportHopDong.rdlc";
            ReportDataSource newDataSource;
            if (rdbHd.Checked)
            {
                this.HopDongsTableAdapter.Fill(this.QuanLyPhongTroDataSet.HopDongs);
            }
            else
            {
                this.HopDongsTableAdapter.FillDaLayHopDong(this.QuanLyPhongTroDataSet.HopDongs, txtCMND.Text);
            }
            newDataSource = new ReportDataSource("DataSet1", this.HopDongsBindingSource);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void FormChuTro_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
