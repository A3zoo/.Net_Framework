using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongTro.GUILayer
{
    partial class FormNguoiThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNguoiThue));
            this.tsCongCu = new System.Windows.Forms.ToolStrip();
            this.tslblTieuDe = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnTimNhaTro = new System.Windows.Forms.ToolStripButton();
            this.tsbtnXemHopDong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnXemHoaDon = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTTCaNhan = new System.Windows.Forms.ToolStripButton();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMSPhong = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblTienThue = new System.Windows.Forms.Label();
            this.lblKhongCoPhong = new System.Windows.Forms.Label();
            this.txtMSPhong = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.lblLoiChao = new System.Windows.Forms.Label();
            this.txtSoNThue = new System.Windows.Forms.TextBox();
            this.lblSoNThue = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnLayCoc = new System.Windows.Forms.Button();
            this.tsCongCu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCongCu
            // 
            this.tsCongCu.BackColor = System.Drawing.Color.RoyalBlue;
            this.tsCongCu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsCongCu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTieuDe,
            this.tsbtnTimNhaTro,
            this.tsbtnXemHopDong,
            this.tsbtnXemHoaDon,
            this.tsbtnTTCaNhan});
            this.tsCongCu.Location = new System.Drawing.Point(0, 0);
            this.tsCongCu.Name = "tsCongCu";
            this.tsCongCu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsCongCu.Size = new System.Drawing.Size(800, 43);
            this.tsCongCu.TabIndex = 0;
            this.tsCongCu.Text = "Công cụ";
            // 
            // tslblTieuDe
            // 
            this.tslblTieuDe.AutoSize = false;
            this.tslblTieuDe.AutoToolTip = true;
            this.tslblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.tslblTieuDe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblTieuDe.ForeColor = System.Drawing.Color.White;
            this.tslblTieuDe.Name = "tslblTieuDe";
            this.tslblTieuDe.Size = new System.Drawing.Size(80, 40);
            this.tslblTieuDe.Text = "QUẢN LÝ\nNHÀ TRỌ";
            this.tslblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbtnTimNhaTro
            // 
            this.tsbtnTimNhaTro.AutoSize = false;
            this.tsbtnTimNhaTro.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnTimNhaTro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTimNhaTro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTimNhaTro.ForeColor = System.Drawing.Color.White;
            this.tsbtnTimNhaTro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTimNhaTro.Name = "tsbtnTimNhaTro";
            this.tsbtnTimNhaTro.Size = new System.Drawing.Size(125, 40);
            this.tsbtnTimNhaTro.Text = "Tìm Nhà Trọ";
            this.tsbtnTimNhaTro.Click += new System.EventHandler(this.tsbtnTimNhaTro_Click);
            // 
            // tsbtnXemHopDong
            // 
            this.tsbtnXemHopDong.AutoSize = false;
            this.tsbtnXemHopDong.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnXemHopDong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnXemHopDong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnXemHopDong.ForeColor = System.Drawing.Color.White;
            this.tsbtnXemHopDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnXemHopDong.Name = "tsbtnXemHopDong";
            this.tsbtnXemHopDong.Size = new System.Drawing.Size(125, 40);
            this.tsbtnXemHopDong.Text = "Xem Hợp Đồng";
            this.tsbtnXemHopDong.Click += new System.EventHandler(this.tsbtnXemHopDong_Click);
            // 
            // tsbtnXemHoaDon
            // 
            this.tsbtnXemHoaDon.AutoSize = false;
            this.tsbtnXemHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnXemHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnXemHoaDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnXemHoaDon.ForeColor = System.Drawing.Color.White;
            this.tsbtnXemHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnXemHoaDon.Name = "tsbtnXemHoaDon";
            this.tsbtnXemHoaDon.Size = new System.Drawing.Size(125, 40);
            this.tsbtnXemHoaDon.Text = "Xem Hóa Đơn";
            this.tsbtnXemHoaDon.Click += new System.EventHandler(this.tsbtnXemHoaDon_Click);
            // 
            // tsbtnTTCaNhan
            // 
            this.tsbtnTTCaNhan.AutoSize = false;
            this.tsbtnTTCaNhan.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnTTCaNhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTTCaNhan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTTCaNhan.ForeColor = System.Drawing.Color.White;
            this.tsbtnTTCaNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTTCaNhan.Name = "tsbtnTTCaNhan";
            this.tsbtnTTCaNhan.Size = new System.Drawing.Size(135, 40);
            this.tsbtnTTCaNhan.Text = "Thông Tin Cá Nhân";
            this.tsbtnTTCaNhan.Click += new System.EventHandler(this.tsbtnTTCaNhan_Click);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.BackColor = System.Drawing.Color.Transparent;
            this.lblThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(12, 80);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(181, 22);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Phòng Trọ Đang Thuê";
            // 
            // lblMSPhong
            // 
            this.lblMSPhong.AutoSize = true;
            this.lblMSPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblMSPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMSPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSPhong.Location = new System.Drawing.Point(12, 130);
            this.lblMSPhong.Name = "lblMSPhong";
            this.lblMSPhong.Size = new System.Drawing.Size(117, 22);
            this.lblMSPhong.TabIndex = 2;
            this.lblMSPhong.Text = "Mã số phòng:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(12, 180);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 22);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.BackColor = System.Drawing.Color.Transparent;
            this.lblDienTich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDienTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienTich.Location = new System.Drawing.Point(12, 230);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(88, 22);
            this.lblDienTich.TabIndex = 4;
            this.lblDienTich.Text = "Diện tích:";
            // 
            // lblTienThue
            // 
            this.lblTienThue.AutoSize = true;
            this.lblTienThue.BackColor = System.Drawing.Color.Transparent;
            this.lblTienThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTienThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThue.Location = new System.Drawing.Point(12, 281);
            this.lblTienThue.Name = "lblTienThue";
            this.lblTienThue.Size = new System.Drawing.Size(135, 22);
            this.lblTienThue.TabIndex = 5;
            this.lblTienThue.Text = "Tiền thuê/tháng:";
            // 
            // lblKhongCoPhong
            // 
            this.lblKhongCoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblKhongCoPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhongCoPhong.ForeColor = System.Drawing.Color.Red;
            this.lblKhongCoPhong.Image = ((System.Drawing.Image)(resources.GetObject("lblKhongCoPhong.Image")));
            this.lblKhongCoPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKhongCoPhong.Location = new System.Drawing.Point(248, 169);
            this.lblKhongCoPhong.Name = "lblKhongCoPhong";
            this.lblKhongCoPhong.Size = new System.Drawing.Size(326, 73);
            this.lblKhongCoPhong.TabIndex = 6;
            this.lblKhongCoPhong.Text = "Bạn chưa thuê phòng!";
            this.lblKhongCoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMSPhong
            // 
            this.txtMSPhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSPhong.Location = new System.Drawing.Point(253, 130);
            this.txtMSPhong.Name = "txtMSPhong";
            this.txtMSPhong.ReadOnly = true;
            this.txtMSPhong.Size = new System.Drawing.Size(176, 27);
            this.txtMSPhong.TabIndex = 7;
            this.txtMSPhong.TabStop = false;
            this.txtMSPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(253, 180);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(176, 27);
            this.txtDiaChi.TabIndex = 8;
            this.txtDiaChi.TabStop = false;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(253, 230);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(176, 27);
            this.txtDienTich.TabIndex = 9;
            this.txtDienTich.TabStop = false;
            this.txtDienTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienThue
            // 
            this.txtTienThue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThue.Location = new System.Drawing.Point(253, 280);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.ReadOnly = true;
            this.txtTienThue.Size = new System.Drawing.Size(176, 27);
            this.txtTienThue.TabIndex = 10;
            this.txtTienThue.TabStop = false;
            this.txtTienThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLoiChao
            // 
            this.lblLoiChao.AutoSize = true;
            this.lblLoiChao.BackColor = System.Drawing.Color.Transparent;
            this.lblLoiChao.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLoiChao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoiChao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiChao.Location = new System.Drawing.Point(719, 43);
            this.lblLoiChao.Name = "lblLoiChao";
            this.lblLoiChao.Size = new System.Drawing.Size(81, 22);
            this.lblLoiChao.TabIndex = 11;
            this.lblLoiChao.Text = "Xin chào";
            this.lblLoiChao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoNThue
            // 
            this.txtSoNThue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNThue.Location = new System.Drawing.Point(253, 330);
            this.txtSoNThue.Name = "txtSoNThue";
            this.txtSoNThue.ReadOnly = true;
            this.txtSoNThue.Size = new System.Drawing.Size(176, 27);
            this.txtSoNThue.TabIndex = 12;
            this.txtSoNThue.TabStop = false;
            this.txtSoNThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSoNThue
            // 
            this.lblSoNThue.AutoSize = true;
            this.lblSoNThue.BackColor = System.Drawing.Color.Transparent;
            this.lblSoNThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSoNThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNThue.Location = new System.Drawing.Point(12, 330);
            this.lblSoNThue.Name = "lblSoNThue";
            this.lblSoNThue.Size = new System.Drawing.Size(146, 22);
            this.lblSoNThue.TabIndex = 13;
            this.lblSoNThue.Text = "Số người đang ở:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.Location = new System.Drawing.Point(12, 382);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(212, 27);
            this.btnDangNhap.TabIndex = 25;
            this.btnDangNhap.Text = "Quay Lại Trang Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.Location = new System.Drawing.Point(16, 421);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 27);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTraPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraPhong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.Red;
            this.btnTraPhong.Location = new System.Drawing.Point(686, 414);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(92, 34);
            this.btnTraPhong.TabIndex = 28;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnLayCoc
            // 
            this.btnLayCoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLayCoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLayCoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayCoc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLayCoc.Location = new System.Drawing.Point(540, 414);
            this.btnLayCoc.Name = "btnLayCoc";
            this.btnLayCoc.Size = new System.Drawing.Size(118, 34);
            this.btnLayCoc.TabIndex = 29;
            this.btnLayCoc.Text = "Lấy tiền cọc";
            this.btnLayCoc.UseVisualStyleBackColor = true;
            this.btnLayCoc.Click += new System.EventHandler(this.btnLayCoc_Click);
            // 
            // FormNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.btnLayCoc);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblSoNThue);
            this.Controls.Add(this.txtSoNThue);
            this.Controls.Add(this.lblLoiChao);
            this.Controls.Add(this.txtTienThue);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMSPhong);
            this.Controls.Add(this.lblTienThue);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblMSPhong);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.tsCongCu);
            this.Controls.Add(this.lblKhongCoPhong);
            this.DoubleBuffered = true;
            this.Name = "FormNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Trọ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNguoiThue_FormClosing);
            this.Load += new System.EventHandler(this.FormNguoiThue_Load);
            this.tsCongCu.ResumeLayout(false);
            this.tsCongCu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCongCu;
        private System.Windows.Forms.ToolStripLabel tslblTieuDe;
        private System.Windows.Forms.ToolStripButton tsbtnTimNhaTro;
        private Label lblThongTin;
        private Label lblMSPhong;
        private Label lblDiaChi;
        private Label lblDienTich;
        private Label lblTienThue;
        private Label lblKhongCoPhong;
        private TextBox txtMSPhong;
        private TextBox txtDiaChi;
        private TextBox txtDienTich;
        private TextBox txtTienThue;
        private Label lblLoiChao;
        private TextBox txtSoNThue;
        private Label lblSoNThue;
        private Button btnDangNhap;
        private Button btnThoat;
        private ToolStripButton tsbtnXemHopDong;
        private ToolStripButton tsbtnXemHoaDon;
        private ToolStripButton tsbtnTTCaNhan;
        private Button btnTraPhong;
        private Button btnLayCoc;

        class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected)
                {
                    base.OnRenderButtonBackground(e);
                }
                else
                {
                    Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                    e.Graphics.FillRectangle(Brushes.DarkBlue, rectangle);
                    e.Graphics.DrawRectangle(Pens.Transparent, rectangle);
                }
            }
        }

    }
}