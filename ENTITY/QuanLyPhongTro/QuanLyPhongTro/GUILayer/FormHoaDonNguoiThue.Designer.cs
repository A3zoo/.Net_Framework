namespace QuanLyPhongTro.GUILayer
{
    partial class FormHoaDonNguoiThue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsCongCu = new System.Windows.Forms.ToolStrip();
            this.tslblTieuDe = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnTimNhaTro = new System.Windows.Forms.ToolStripButton();
            this.tsbtnXemHopDong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnXemHoaDon = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTTCaNhan = new System.Windows.Forms.ToolStripButton();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNuocTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDaThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.tsCongCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
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
            this.tsCongCu.TabIndex = 1;
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
            this.tslblTieuDe.Size = new System.Drawing.Size(100, 40);
            this.tslblTieuDe.Text = "QUẢN LÝ\nNHÀ TRỌ";
            this.tslblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbtnTimNhaTro
            // 
            this.tsbtnTimNhaTro.AutoSize = false;
            this.tsbtnTimNhaTro.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnTimNhaTro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTimNhaTro.ForeColor = System.Drawing.Color.White;
            this.tsbtnTimNhaTro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsbtnTimNhaTro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnTimNhaTro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTimNhaTro.Name = "tsbtnTimNhaTro";
            this.tsbtnTimNhaTro.Size = new System.Drawing.Size(122, 40);
            this.tsbtnTimNhaTro.Text = "Tìm Nhà Trọ";
            this.tsbtnTimNhaTro.Click += new System.EventHandler(this.tsbtnTimNhaTro_Click);
            // 
            // tsbtnXemHopDong
            // 
            this.tsbtnXemHopDong.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnXemHopDong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnXemHopDong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnXemHopDong.ForeColor = System.Drawing.Color.White;
            this.tsbtnXemHopDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnXemHopDong.Name = "tsbtnXemHopDong";
            this.tsbtnXemHopDong.Size = new System.Drawing.Size(113, 40);
            this.tsbtnXemHopDong.Text = "Xem Hợp Đồng";
            // 
            // tsbtnXemHoaDon
            // 
            this.tsbtnXemHoaDon.AutoSize = false;
            this.tsbtnXemHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnXemHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnXemHoaDon.Enabled = false;
            this.tsbtnXemHoaDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnXemHoaDon.ForeColor = System.Drawing.Color.White;
            this.tsbtnXemHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnXemHoaDon.Name = "tsbtnXemHoaDon";
            this.tsbtnXemHoaDon.Size = new System.Drawing.Size(122, 40);
            this.tsbtnXemHoaDon.Text = "Xem Hóa Đơn";
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
            this.tsbtnTTCaNhan.Size = new System.Drawing.Size(150, 40);
            this.tsbtnTTCaNhan.Text = "Thông Tin Cá Nhân";
            this.tsbtnTTCaNhan.Click += new System.EventHandler(this.tsbtnTTCaNhan_Click);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lblHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(22, 76);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(136, 19);
            this.lblHoaDon.TabIndex = 2;
            this.lblHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSo,
            this.colSoDienTieuThu,
            this.colSoNuocTieuThu,
            this.colNgayDau,
            this.colNgayCuoi,
            this.colDaThanhToan,
            this.colNgayThanhToan,
            this.colPhong});
            this.dgvHoaDon.Location = new System.Drawing.Point(26, 119);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(735, 303);
            this.dgvHoaDon.TabIndex = 3;
            // 
            // colMaSo
            // 
            this.colMaSo.HeaderText = "Mã Số";
            this.colMaSo.MinimumWidth = 6;
            this.colMaSo.Name = "colMaSo";
            this.colMaSo.ReadOnly = true;
            this.colMaSo.Width = 82;
            // 
            // colSoDienTieuThu
            // 
            this.colSoDienTieuThu.HeaderText = "Số kW Điện Tiêu Thụ";
            this.colSoDienTieuThu.MinimumWidth = 6;
            this.colSoDienTieuThu.Name = "colSoDienTieuThu";
            this.colSoDienTieuThu.ReadOnly = true;
            this.colSoDienTieuThu.Width = 183;
            // 
            // colSoNuocTieuThu
            // 
            this.colSoNuocTieuThu.HeaderText = "Số m³ Nước Tiêu Thụ";
            this.colSoNuocTieuThu.MinimumWidth = 6;
            this.colSoNuocTieuThu.Name = "colSoNuocTieuThu";
            this.colSoNuocTieuThu.ReadOnly = true;
            this.colSoNuocTieuThu.Width = 182;
            // 
            // colNgayDau
            // 
            this.colNgayDau.HeaderText = "Ngày Đầu";
            this.colNgayDau.MinimumWidth = 6;
            this.colNgayDau.Name = "colNgayDau";
            this.colNgayDau.ReadOnly = true;
            this.colNgayDau.Width = 104;
            // 
            // colNgayCuoi
            // 
            this.colNgayCuoi.HeaderText = "Ngày Cuối";
            this.colNgayCuoi.MinimumWidth = 6;
            this.colNgayCuoi.Name = "colNgayCuoi";
            this.colNgayCuoi.ReadOnly = true;
            this.colNgayCuoi.Width = 110;
            // 
            // colDaThanhToan
            // 
            this.colDaThanhToan.HeaderText = "Đã Thanh Toán";
            this.colDaThanhToan.MinimumWidth = 6;
            this.colDaThanhToan.Name = "colDaThanhToan";
            this.colDaThanhToan.ReadOnly = true;
            this.colDaThanhToan.Width = 114;
            // 
            // colNgayThanhToan
            // 
            this.colNgayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.colNgayThanhToan.MinimumWidth = 6;
            this.colNgayThanhToan.Name = "colNgayThanhToan";
            this.colNgayThanhToan.ReadOnly = true;
            this.colNgayThanhToan.Width = 153;
            // 
            // colPhong
            // 
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            this.colPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPhong.Width = 58;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnChiTiet.Location = new System.Drawing.Point(26, 446);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(118, 27);
            this.btnChiTiet.TabIndex = 28;
            this.btnChiTiet.Text = "Xem Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(643, 446);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(118, 27);
            this.btnThanhToan.TabIndex = 29;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnQuayLai.Location = new System.Drawing.Point(26, 485);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(78, 27);
            this.btnQuayLai.TabIndex = 30;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // FormHoaDonNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.tsCongCu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormHoaDonNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.tsCongCu.ResumeLayout(false);
            this.tsCongCu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCongCu;
        private System.Windows.Forms.ToolStripLabel tslblTieuDe;
        private System.Windows.Forms.ToolStripButton tsbtnTimNhaTro;
        private System.Windows.Forms.ToolStripButton tsbtnXemHopDong;
        private System.Windows.Forms.ToolStripButton tsbtnXemHoaDon;
        private System.Windows.Forms.ToolStripButton tsbtnTTCaNhan;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNuocTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayCuoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnQuayLai;
    }
}