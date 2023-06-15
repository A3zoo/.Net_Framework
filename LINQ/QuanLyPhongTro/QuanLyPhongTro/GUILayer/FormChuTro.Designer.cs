namespace QuanLyPhongTro
{
    partial class FormChuTro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HoaDonChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyPhongTroDataSet = new QuanLyPhongTro.QuanLyPhongTroDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThemXoaPhong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btn_ThemNguoiThue = new System.Windows.Forms.Button();
            this.btn_ghihoadon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.btnXuatHDon = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rdbHd = new System.Windows.Forms.RadioButton();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbTatCa = new System.Windows.Forms.RadioButton();
            this.btnXuatPT = new System.Windows.Forms.Button();
            this.HoaDonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonsTableAdapter = new QuanLyPhongTro.QuanLyPhongTroDataSetTableAdapters.HoaDonsTableAdapter();
            this.HopDongsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HopDongsTableAdapter = new QuanLyPhongTro.QuanLyPhongTroDataSetTableAdapters.HopDongsTableAdapter();
            this.PhongTroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhongTroesTableAdapter = new QuanLyPhongTro.QuanLyPhongTroDataSetTableAdapters.PhongTroesTableAdapter();
            this.HoaDonchiTietTableAdapter = new QuanLyPhongTro.QuanLyPhongTroDataSetTableAdapters.HoaDonchiTietTableAdapter();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonChiTietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyPhongTroDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HopDongsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhongTroesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonChiTietBindingSource
            // 
            this.HoaDonChiTietBindingSource.DataMember = "HoaDonChiTiet";
            this.HoaDonChiTietBindingSource.DataSource = this.QuanLyPhongTroDataSet;
            // 
            // QuanLyPhongTroDataSet
            // 
            this.QuanLyPhongTroDataSet.DataSetName = "QuanLyPhongTroDataSet";
            this.QuanLyPhongTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các tính năng của chủ trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ThemXoaPhong
            // 
            this.btn_ThemXoaPhong.Location = new System.Drawing.Point(60, 110);
            this.btn_ThemXoaPhong.Name = "btn_ThemXoaPhong";
            this.btn_ThemXoaPhong.Size = new System.Drawing.Size(308, 36);
            this.btn_ThemXoaPhong.TabIndex = 1;
            this.btn_ThemXoaPhong.Text = "Thêm và xóa phòng trọ";
            this.btn_ThemXoaPhong.UseVisualStyleBackColor = true;
            this.btn_ThemXoaPhong.Click += new System.EventHandler(this.btn_ThemXoaPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chủ trọ";
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(266, 57);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(212, 22);
            this.txtCMND.TabIndex = 3;
            // 
            // btn_ThemNguoiThue
            // 
            this.btn_ThemNguoiThue.Location = new System.Drawing.Point(60, 175);
            this.btn_ThemNguoiThue.Name = "btn_ThemNguoiThue";
            this.btn_ThemNguoiThue.Size = new System.Drawing.Size(308, 36);
            this.btn_ThemNguoiThue.TabIndex = 4;
            this.btn_ThemNguoiThue.Text = "Cho vào hay xóa người thuê khỏi phòng trọ";
            this.btn_ThemNguoiThue.UseVisualStyleBackColor = true;
            this.btn_ThemNguoiThue.Click += new System.EventHandler(this.btn_ThemNguoiThue_Click);
            // 
            // btn_ghihoadon
            // 
            this.btn_ghihoadon.Location = new System.Drawing.Point(412, 175);
            this.btn_ghihoadon.Name = "btn_ghihoadon";
            this.btn_ghihoadon.Size = new System.Drawing.Size(308, 34);
            this.btn_ghihoadon.TabIndex = 5;
            this.btn_ghihoadon.Text = "Ghi hóa đơn";
            this.btn_ghihoadon.UseVisualStyleBackColor = true;
            this.btn_ghihoadon.Click += new System.EventHandler(this.btn_ghihoadon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm người thuê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reportViewer1);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(2, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 533);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xem Thống Kê";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.HoaDonChiTietBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro.ReportHoaDonChiTiet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 167);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(831, 360);
            this.reportViewer1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdbChuaThanhToan);
            this.groupBox1.Controls.Add(this.btnXuatHDon);
            this.groupBox1.Location = new System.Drawing.Point(19, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Đã thanh toán";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbChuaThanhToan
            // 
            this.rdbChuaThanhToan.AutoSize = true;
            this.rdbChuaThanhToan.Checked = true;
            this.rdbChuaThanhToan.Location = new System.Drawing.Point(7, 38);
            this.rdbChuaThanhToan.Name = "rdbChuaThanhToan";
            this.rdbChuaThanhToan.Size = new System.Drawing.Size(134, 21);
            this.rdbChuaThanhToan.TabIndex = 1;
            this.rdbChuaThanhToan.TabStop = true;
            this.rdbChuaThanhToan.Text = "Chưa thanh toán";
            this.rdbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnXuatHDon
            // 
            this.btnXuatHDon.Location = new System.Drawing.Point(72, 74);
            this.btnXuatHDon.Name = "btnXuatHDon";
            this.btnXuatHDon.Size = new System.Drawing.Size(105, 39);
            this.btnXuatHDon.TabIndex = 0;
            this.btnXuatHDon.Text = "Xuất";
            this.btnXuatHDon.UseVisualStyleBackColor = true;
            this.btnXuatHDon.Click += new System.EventHandler(this.btnXuatHDon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.rdbHd);
            this.groupBox3.Controls.Add(this.btnXuatHD);
            this.groupBox3.Location = new System.Drawing.Point(563, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 128);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hợp Đồng";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(143, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(110, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Chưa lấy cộc";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rdbHd
            // 
            this.rdbHd.AutoSize = true;
            this.rdbHd.Checked = true;
            this.rdbHd.Location = new System.Drawing.Point(30, 38);
            this.rdbHd.Name = "rdbHd";
            this.rdbHd.Size = new System.Drawing.Size(73, 21);
            this.rdbHd.TabIndex = 1;
            this.rdbHd.TabStop = true;
            this.rdbHd.Text = "Tất cả ";
            this.rdbHd.UseVisualStyleBackColor = true;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Location = new System.Drawing.Point(72, 74);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(105, 39);
            this.btnXuatHD.TabIndex = 0;
            this.btnXuatHD.Text = "Xuất";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.rdbTatCa);
            this.groupBox2.Controls.Add(this.btnXuatPT);
            this.groupBox2.Location = new System.Drawing.Point(291, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng Trọ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(143, 40);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Còn trống";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdbTatCa
            // 
            this.rdbTatCa.AutoSize = true;
            this.rdbTatCa.Checked = true;
            this.rdbTatCa.Location = new System.Drawing.Point(37, 38);
            this.rdbTatCa.Name = "rdbTatCa";
            this.rdbTatCa.Size = new System.Drawing.Size(69, 21);
            this.rdbTatCa.TabIndex = 1;
            this.rdbTatCa.TabStop = true;
            this.rdbTatCa.Text = "Tất cả";
            this.rdbTatCa.UseVisualStyleBackColor = true;
            // 
            // btnXuatPT
            // 
            this.btnXuatPT.Location = new System.Drawing.Point(72, 74);
            this.btnXuatPT.Name = "btnXuatPT";
            this.btnXuatPT.Size = new System.Drawing.Size(105, 39);
            this.btnXuatPT.TabIndex = 0;
            this.btnXuatPT.Text = "Xuất";
            this.btnXuatPT.UseVisualStyleBackColor = true;
            this.btnXuatPT.Click += new System.EventHandler(this.btnXuatPT_Click);
            // 
            // HoaDonsBindingSource
            // 
            this.HoaDonsBindingSource.DataMember = "HoaDons";
            this.HoaDonsBindingSource.DataSource = this.QuanLyPhongTroDataSet;
            // 
            // HoaDonsTableAdapter
            // 
            this.HoaDonsTableAdapter.ClearBeforeFill = true;
            // 
            // HopDongsBindingSource
            // 
            this.HopDongsBindingSource.DataMember = "HopDongs";
            this.HopDongsBindingSource.DataSource = this.QuanLyPhongTroDataSet;
            // 
            // HopDongsTableAdapter
            // 
            this.HopDongsTableAdapter.ClearBeforeFill = true;
            // 
            // PhongTroesBindingSource
            // 
            this.PhongTroesBindingSource.DataMember = "PhongTroes";
            this.PhongTroesBindingSource.DataSource = this.QuanLyPhongTroDataSet;
            // 
            // PhongTroesTableAdapter
            // 
            this.PhongTroesTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDonchiTietTableAdapter
            // 
            this.HoaDonchiTietTableAdapter.ClearBeforeFill = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(733, 33);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(98, 27);
            this.btnDangXuat.TabIndex = 26;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // FormChuTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 756);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ghihoadon);
            this.Controls.Add(this.btn_ThemNguoiThue);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ThemXoaPhong);
            this.Controls.Add(this.label1);
            this.Name = "FormChuTro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormChuTro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonChiTietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyPhongTroDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HopDongsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhongTroesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemXoaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button btn_ThemNguoiThue;
        private System.Windows.Forms.Button btn_ghihoadon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbChuaThanhToan;
        private System.Windows.Forms.Button btnXuatHDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rdbHd;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbTatCa;
        private System.Windows.Forms.Button btnXuatPT;
        private System.Windows.Forms.BindingSource HoaDonsBindingSource;
        private QuanLyPhongTroDataSet QuanLyPhongTroDataSet;
        private QuanLyPhongTroDataSetTableAdapters.HoaDonsTableAdapter HoaDonsTableAdapter;
        private System.Windows.Forms.BindingSource HopDongsBindingSource;
        private QuanLyPhongTroDataSetTableAdapters.HopDongsTableAdapter HopDongsTableAdapter;
        private System.Windows.Forms.BindingSource PhongTroesBindingSource;
        private QuanLyPhongTroDataSetTableAdapters.PhongTroesTableAdapter PhongTroesTableAdapter;
        private System.Windows.Forms.BindingSource HoaDonChiTietBindingSource;
        private QuanLyPhongTroDataSetTableAdapters.HoaDonchiTietTableAdapter HoaDonchiTietTableAdapter;
        private System.Windows.Forms.Button btnDangXuat;
    }
}

