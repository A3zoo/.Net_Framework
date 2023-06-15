namespace QuanLyPhongTro.GUILayer
{
    partial class FormNguoiThueTimPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNguoiThueTimPhong));
            this.dgvDSPhongTro = new System.Windows.Forms.DataGridView();
            this.colMaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoGac = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThuCung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTienThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienRac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCongCu = new System.Windows.Forms.ToolStrip();
            this.tslblTieuDe = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnTimNhaTro = new System.Windows.Forms.ToolStripButton();
            this.tsbtnXemHopDong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnXemHoaDon = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTTCaNhan = new System.Windows.Forms.ToolStripButton();
            this.lblDeXuat = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.cboDiaChi = new System.Windows.Forms.ComboBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblm2 = new System.Windows.Forms.Label();
            this.lblSoNToiDa = new System.Windows.Forms.Label();
            this.nudSoNToiDa = new System.Windows.Forms.NumericUpDown();
            this.chkCoGac = new System.Windows.Forms.CheckBox();
            this.chkThuCung = new System.Windows.Forms.CheckBox();
            this.trbTienThue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTienThue = new System.Windows.Forms.Label();
            this.nudDienTich = new System.Windows.Forms.NumericUpDown();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongTro)).BeginInit();
            this.tsCongCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTienThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDienTich)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPhongTro
            // 
            this.dgvDSPhongTro.AllowUserToAddRows = false;
            this.dgvDSPhongTro.AllowUserToDeleteRows = false;
            this.dgvDSPhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDSPhongTro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDSPhongTro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSPhongTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhongTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSo,
            this.colDienTich,
            this.colDiaChi,
            this.colSoNgToiDa,
            this.colCoGac,
            this.colThuCung,
            this.colTienThue,
            this.colTienDien,
            this.colTienNuoc,
            this.colTienRac,
            this.colChuTro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSPhongTro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSPhongTro.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvDSPhongTro.Location = new System.Drawing.Point(68, 259);
            this.dgvDSPhongTro.MultiSelect = false;
            this.dgvDSPhongTro.Name = "dgvDSPhongTro";
            this.dgvDSPhongTro.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSPhongTro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSPhongTro.RowHeadersVisible = false;
            this.dgvDSPhongTro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDSPhongTro.RowTemplate.Height = 24;
            this.dgvDSPhongTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhongTro.Size = new System.Drawing.Size(811, 341);
            this.dgvDSPhongTro.TabIndex = 0;
            // 
            // colMaSo
            // 
            this.colMaSo.HeaderText = "Mã Số";
            this.colMaSo.MinimumWidth = 6;
            this.colMaSo.Name = "colMaSo";
            this.colMaSo.ReadOnly = true;
            this.colMaSo.Width = 76;
            // 
            // colDienTich
            // 
            this.colDienTich.HeaderText = "Diện Tích";
            this.colDienTich.MinimumWidth = 6;
            this.colDienTich.Name = "colDienTich";
            this.colDienTich.ReadOnly = true;
            this.colDienTich.Width = 95;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 82;
            // 
            // colSoNgToiDa
            // 
            this.colSoNgToiDa.HeaderText = "Số Người Tối Đa";
            this.colSoNgToiDa.MinimumWidth = 6;
            this.colSoNgToiDa.Name = "colSoNgToiDa";
            this.colSoNgToiDa.ReadOnly = true;
            this.colSoNgToiDa.Width = 138;
            // 
            // colCoGac
            // 
            this.colCoGac.HeaderText = "Có Gác";
            this.colCoGac.MinimumWidth = 6;
            this.colCoGac.Name = "colCoGac";
            this.colCoGac.ReadOnly = true;
            this.colCoGac.Width = 59;
            // 
            // colThuCung
            // 
            this.colThuCung.HeaderText = "Cho Nuôi Thú Cưng";
            this.colThuCung.MinimumWidth = 6;
            this.colThuCung.Name = "colThuCung";
            this.colThuCung.ReadOnly = true;
            this.colThuCung.Width = 133;
            // 
            // colTienThue
            // 
            this.colTienThue.HeaderText = "Tiền Thuê/Tháng";
            this.colTienThue.MinimumWidth = 6;
            this.colTienThue.Name = "colTienThue";
            this.colTienThue.ReadOnly = true;
            this.colTienThue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTienThue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTienThue.Width = 114;
            // 
            // colTienDien
            // 
            this.colTienDien.HeaderText = "Tiền Điện/kWh";
            this.colTienDien.MinimumWidth = 6;
            this.colTienDien.Name = "colTienDien";
            this.colTienDien.ReadOnly = true;
            this.colTienDien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTienDien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTienDien.Width = 103;
            // 
            // colTienNuoc
            // 
            this.colTienNuoc.HeaderText = "Tiền Nước/m³";
            this.colTienNuoc.MinimumWidth = 6;
            this.colTienNuoc.Name = "colTienNuoc";
            this.colTienNuoc.ReadOnly = true;
            this.colTienNuoc.Width = 120;
            // 
            // colTienRac
            // 
            this.colTienRac.HeaderText = "Tiền Rác/tháng";
            this.colTienRac.MinimumWidth = 6;
            this.colTienRac.Name = "colTienRac";
            this.colTienRac.ReadOnly = true;
            this.colTienRac.Width = 126;
            // 
            // colChuTro
            // 
            this.colChuTro.HeaderText = "Chủ Trọ";
            this.colChuTro.MinimumWidth = 6;
            this.colChuTro.Name = "colChuTro";
            this.colChuTro.ReadOnly = true;
            this.colChuTro.Width = 85;
            // 
            // tsCongCu
            // 
            this.tsCongCu.BackColor = System.Drawing.Color.RoyalBlue;
            this.tsCongCu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsCongCu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTieuDe,
            this.tsbtnTimNhaTro,
            this.tsbtnXemHopDong,
            this.tsbtnXemHoaDon,
            this.tsbtnTTCaNhan});
            this.tsCongCu.Location = new System.Drawing.Point(0, 0);
            this.tsCongCu.Name = "tsCongCu";
            this.tsCongCu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsCongCu.Size = new System.Drawing.Size(956, 43);
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
            this.tslblTieuDe.Size = new System.Drawing.Size(80, 40);
            this.tslblTieuDe.Text = "QUẢN LÝ\nNHÀ TRỌ";
            this.tslblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbtnTimNhaTro
            // 
            this.tsbtnTimNhaTro.AutoSize = false;
            this.tsbtnTimNhaTro.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnTimNhaTro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTimNhaTro.Enabled = false;
            this.tsbtnTimNhaTro.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTimNhaTro.ForeColor = System.Drawing.Color.White;
            this.tsbtnTimNhaTro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTimNhaTro.Name = "tsbtnTimNhaTro";
            this.tsbtnTimNhaTro.Size = new System.Drawing.Size(154, 40);
            this.tsbtnTimNhaTro.Text = "Tìm Nhà Trọ";
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
            this.tsbtnXemHopDong.Size = new System.Drawing.Size(154, 40);
            this.tsbtnXemHopDong.Text = "Xem Hợp Đồng";
            // 
            // tsbtnXemHoaDon
            // 
            this.tsbtnXemHoaDon.AutoSize = false;
            this.tsbtnXemHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnXemHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnXemHoaDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnXemHoaDon.ForeColor = System.Drawing.Color.White;
            this.tsbtnXemHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnXemHoaDon.Image")));
            this.tsbtnXemHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnXemHoaDon.Name = "tsbtnXemHoaDon";
            this.tsbtnXemHoaDon.Size = new System.Drawing.Size(158, 40);
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
            this.tsbtnTTCaNhan.Size = new System.Drawing.Size(158, 40);
            this.tsbtnTTCaNhan.Text = "Thông Tin Cá Nhân";
            this.tsbtnTTCaNhan.Click += new System.EventHandler(this.tsbtnTTCaNhan_Click);
            // 
            // lblDeXuat
            // 
            this.lblDeXuat.AutoSize = true;
            this.lblDeXuat.BackColor = System.Drawing.Color.Transparent;
            this.lblDeXuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeXuat.Location = new System.Drawing.Point(64, 219);
            this.lblDeXuat.Name = "lblDeXuat";
            this.lblDeXuat.Size = new System.Drawing.Size(105, 19);
            this.lblDeXuat.TabIndex = 3;
            this.lblDeXuat.Text = "Phòng đề xuất";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(64, 96);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(63, 19);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // cboDiaChi
            // 
            this.cboDiaChi.FormattingEnabled = true;
            this.cboDiaChi.Location = new System.Drawing.Point(145, 93);
            this.cboDiaChi.Name = "cboDiaChi";
            this.cboDiaChi.Size = new System.Drawing.Size(196, 24);
            this.cboDiaChi.TabIndex = 5;
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.BackColor = System.Drawing.Color.Transparent;
            this.lblDienTich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienTich.Location = new System.Drawing.Point(393, 156);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(77, 19);
            this.lblDienTich.TabIndex = 6;
            this.lblDienTich.Text = "Diện tích:";
            // 
            // lblm2
            // 
            this.lblm2.AutoSize = true;
            this.lblm2.BackColor = System.Drawing.Color.Transparent;
            this.lblm2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm2.Location = new System.Drawing.Point(584, 156);
            this.lblm2.Name = "lblm2";
            this.lblm2.Size = new System.Drawing.Size(27, 19);
            this.lblm2.TabIndex = 8;
            this.lblm2.Text = "m²";
            // 
            // lblSoNToiDa
            // 
            this.lblSoNToiDa.AutoSize = true;
            this.lblSoNToiDa.BackColor = System.Drawing.Color.Transparent;
            this.lblSoNToiDa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNToiDa.Location = new System.Drawing.Point(64, 156);
            this.lblSoNToiDa.Name = "lblSoNToiDa";
            this.lblSoNToiDa.Size = new System.Drawing.Size(118, 19);
            this.lblSoNToiDa.TabIndex = 9;
            this.lblSoNToiDa.Text = "Số người tối đa:";
            // 
            // nudSoNToiDa
            // 
            this.nudSoNToiDa.Location = new System.Drawing.Point(206, 154);
            this.nudSoNToiDa.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSoNToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoNToiDa.MinimumSize = new System.Drawing.Size(1, 0);
            this.nudSoNToiDa.Name = "nudSoNToiDa";
            this.nudSoNToiDa.Size = new System.Drawing.Size(79, 22);
            this.nudSoNToiDa.TabIndex = 10;
            this.nudSoNToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoNToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkCoGac
            // 
            this.chkCoGac.AutoSize = true;
            this.chkCoGac.BackColor = System.Drawing.Color.Transparent;
            this.chkCoGac.Checked = true;
            this.chkCoGac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoGac.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCoGac.Location = new System.Drawing.Point(724, 96);
            this.chkCoGac.Name = "chkCoGac";
            this.chkCoGac.Size = new System.Drawing.Size(78, 23);
            this.chkCoGac.TabIndex = 11;
            this.chkCoGac.Text = "Có gác";
            this.chkCoGac.UseVisualStyleBackColor = false;
            // 
            // chkThuCung
            // 
            this.chkThuCung.AutoSize = true;
            this.chkThuCung.BackColor = System.Drawing.Color.Transparent;
            this.chkThuCung.Checked = true;
            this.chkThuCung.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThuCung.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuCung.Location = new System.Drawing.Point(724, 158);
            this.chkThuCung.Name = "chkThuCung";
            this.chkThuCung.Size = new System.Drawing.Size(155, 23);
            this.chkThuCung.TabIndex = 12;
            this.chkThuCung.Text = "Cho nuôi thú cưng";
            this.chkThuCung.UseVisualStyleBackColor = false;
            // 
            // trbTienThue
            // 
            this.trbTienThue.Location = new System.Drawing.Point(476, 95);
            this.trbTienThue.Maximum = 100;
            this.trbTienThue.Name = "trbTienThue";
            this.trbTienThue.Size = new System.Drawing.Size(187, 56);
            this.trbTienThue.TabIndex = 13;
            this.trbTienThue.TickFrequency = 10;
            this.trbTienThue.ValueChanged += new System.EventHandler(this.trbTienThue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tiền thuê:";
            // 
            // lblTienThue
            // 
            this.lblTienThue.AutoSize = true;
            this.lblTienThue.BackColor = System.Drawing.Color.Transparent;
            this.lblTienThue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThue.Location = new System.Drawing.Point(484, 70);
            this.lblTienThue.Name = "lblTienThue";
            this.lblTienThue.Size = new System.Drawing.Size(18, 19);
            this.lblTienThue.TabIndex = 15;
            this.lblTienThue.Text = "0";
            // 
            // nudDienTich
            // 
            this.nudDienTich.Location = new System.Drawing.Point(499, 154);
            this.nudDienTich.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDienTich.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDienTich.MinimumSize = new System.Drawing.Size(1, 0);
            this.nudDienTich.Name = "nudDienTich";
            this.nudDienTich.Size = new System.Drawing.Size(79, 22);
            this.nudDienTich.TabIndex = 16;
            this.nudDienTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDienTich.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLoc
            // 
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Blue;
            this.btnLoc.Location = new System.Drawing.Point(810, 213);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(69, 31);
            this.btnLoc.TabIndex = 17;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Blue;
            this.btnReset.Location = new System.Drawing.Point(697, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 31);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThue
            // 
            this.btnThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThue.ForeColor = System.Drawing.Color.Blue;
            this.btnThue.Location = new System.Drawing.Point(811, 614);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(69, 31);
            this.btnThue.TabIndex = 19;
            this.btnThue.Text = "Thuê";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
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
            this.btnQuayLai.Location = new System.Drawing.Point(9, 618);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(78, 27);
            this.btnQuayLai.TabIndex = 27;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // FormNguoiThueTimPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 667);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.nudDienTich);
            this.Controls.Add(this.lblTienThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbTienThue);
            this.Controls.Add(this.chkThuCung);
            this.Controls.Add(this.chkCoGac);
            this.Controls.Add(this.nudSoNToiDa);
            this.Controls.Add(this.lblSoNToiDa);
            this.Controls.Add(this.lblm2);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.cboDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblDeXuat);
            this.Controls.Add(this.tsCongCu);
            this.Controls.Add(this.dgvDSPhongTro);
            this.Name = "FormNguoiThueTimPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNguoiThueTimPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongTro)).EndInit();
            this.tsCongCu.ResumeLayout(false);
            this.tsCongCu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTienThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDienTich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhongTro;
        private System.Windows.Forms.ToolStrip tsCongCu;
        private System.Windows.Forms.ToolStripLabel tslblTieuDe;
        private System.Windows.Forms.ToolStripButton tsbtnTimNhaTro;
        private System.Windows.Forms.Label lblDeXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgToiDa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCoGac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThuCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienRac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuTro;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.ComboBox cboDiaChi;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblm2;
        private System.Windows.Forms.Label lblSoNToiDa;
        private System.Windows.Forms.NumericUpDown nudSoNToiDa;
        private System.Windows.Forms.CheckBox chkCoGac;
        private System.Windows.Forms.CheckBox chkThuCung;
        private System.Windows.Forms.TrackBar trbTienThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTienThue;
        private System.Windows.Forms.NumericUpDown nudDienTich;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ToolStripButton tsbtnTTCaNhan;
        private System.Windows.Forms.ToolStripButton tsbtnXemHoaDon;
        private System.Windows.Forms.ToolStripButton tsbtnXemHopDong;
    }
}