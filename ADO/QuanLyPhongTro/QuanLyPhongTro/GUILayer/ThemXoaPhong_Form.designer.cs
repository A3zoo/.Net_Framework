namespace QuanLyPhongTro
{
    partial class ThemXoaPhong_Form
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
            this.dgvPhongTro = new System.Windows.Forms.DataGridView();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.btn_XoaPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNguoiMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_gac = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_thucung = new System.Windows.Forms.ComboBox();
            this.txt_tienthue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tienrac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tiennuoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tiendien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.txtmachutro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhongTro
            // 
            this.dgvPhongTro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTro.Location = new System.Drawing.Point(343, 58);
            this.dgvPhongTro.Name = "dgvPhongTro";
            this.dgvPhongTro.RowHeadersWidth = 51;
            this.dgvPhongTro.RowTemplate.Height = 24;
            this.dgvPhongTro.Size = new System.Drawing.Size(437, 473);
            this.dgvPhongTro.TabIndex = 1;
            this.dgvPhongTro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongTro_CellClick);
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ThemPhong.Location = new System.Drawing.Point(196, 494);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(118, 37);
            this.btn_ThemPhong.TabIndex = 2;
            this.btn_ThemPhong.Text = "Thêm phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = true;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // btn_XoaPhong
            // 
            this.btn_XoaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XoaPhong.Location = new System.Drawing.Point(16, 494);
            this.btn_XoaPhong.Name = "btn_XoaPhong";
            this.btn_XoaPhong.Size = new System.Drawing.Size(118, 37);
            this.btn_XoaPhong.TabIndex = 3;
            this.btn_XoaPhong.Text = "Xóa phòng";
            this.btn_XoaPhong.UseVisualStyleBackColor = true;
            this.btn_XoaPhong.Click += new System.EventHandler(this.btn_XoaPhong_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(112, 13);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(166, 22);
            this.txtMaphong.TabIndex = 1;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(112, 51);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(165, 22);
            this.txtDienTich.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diện tích";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(112, 92);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(165, 22);
            this.txtDiachi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoNguoiMax
            // 
            this.txtSoNguoiMax.Location = new System.Drawing.Point(112, 130);
            this.txtSoNguoiMax.Name = "txtSoNguoiMax";
            this.txtSoNguoiMax.Size = new System.Drawing.Size(165, 22);
            this.txtSoNguoiMax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số người max";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gác";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_gac
            // 
            this.cbb_gac.FormattingEnabled = true;
            this.cbb_gac.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbb_gac.Location = new System.Drawing.Point(112, 167);
            this.cbb_gac.Name = "cbb_gac";
            this.cbb_gac.Size = new System.Drawing.Size(96, 24);
            this.cbb_gac.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nuôi thú cưng";
            // 
            // cbb_thucung
            // 
            this.cbb_thucung.FormattingEnabled = true;
            this.cbb_thucung.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbb_thucung.Location = new System.Drawing.Point(112, 204);
            this.cbb_thucung.Name = "cbb_thucung";
            this.cbb_thucung.Size = new System.Drawing.Size(96, 24);
            this.cbb_thucung.TabIndex = 11;
            // 
            // txt_tienthue
            // 
            this.txt_tienthue.Location = new System.Drawing.Point(112, 248);
            this.txt_tienthue.Name = "txt_tienthue";
            this.txt_tienthue.Size = new System.Drawing.Size(165, 22);
            this.txt_tienthue.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txt_tienrac);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_tiennuoc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_tiendien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_tienthue);
            this.panel1.Controls.Add(this.cbb_thucung);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbb_gac);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoNguoiMax);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDienTich);
            this.panel1.Controls.Add(this.txtMaphong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 466);
            this.panel1.TabIndex = 0;
            // 
            // txt_tienrac
            // 
            this.txt_tienrac.Location = new System.Drawing.Point(112, 363);
            this.txt_tienrac.Name = "txt_tienrac";
            this.txt_tienrac.Size = new System.Drawing.Size(165, 22);
            this.txt_tienrac.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tiền rác";
            // 
            // txt_tiennuoc
            // 
            this.txt_tiennuoc.Location = new System.Drawing.Point(112, 324);
            this.txt_tiennuoc.Name = "txt_tiennuoc";
            this.txt_tiennuoc.Size = new System.Drawing.Size(165, 22);
            this.txt_tiennuoc.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tiền nước";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tiền điện";
            // 
            // txt_tiendien
            // 
            this.txt_tiendien.Location = new System.Drawing.Point(112, 288);
            this.txt_tiendien.Name = "txt_tiendien";
            this.txt_tiendien.Size = new System.Drawing.Size(165, 22);
            this.txt_tiendien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tiền thuê";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(340, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "Chủ trọ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show
            // 
            this.btn_show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show.Location = new System.Drawing.Point(698, 20);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(82, 24);
            this.btn_show.TabIndex = 9;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txtmachutro
            // 
            this.txtmachutro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmachutro.Enabled = false;
            this.txtmachutro.Location = new System.Drawing.Point(427, 20);
            this.txtmachutro.Name = "txtmachutro";
            this.txtmachutro.Size = new System.Drawing.Size(253, 22);
            this.txtmachutro.TabIndex = 10;
            // 
            // ThemXoaPhong_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.txtmachutro);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_XoaPhong);
            this.Controls.Add(this.btn_ThemPhong);
            this.Controls.Add(this.dgvPhongTro);
            this.Controls.Add(this.panel1);
            this.Name = "ThemXoaPhong_Form";
            this.Text = "Thêm và xóa phòng";
            this.Load += new System.EventHandler(this.ThemXoaPhong_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhongTro;
        private System.Windows.Forms.Button btn_ThemPhong;
        private System.Windows.Forms.Button btn_XoaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNguoiMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_gac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_thucung;
        private System.Windows.Forms.TextBox txt_tienthue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tienrac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tiennuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tiendien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txtmachutro;
    }
}