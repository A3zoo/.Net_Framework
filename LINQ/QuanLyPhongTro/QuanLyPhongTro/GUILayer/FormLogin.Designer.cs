using System.Windows.Forms;

namespace QuanLyPhongTro.GUILayer
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.grpUserType = new System.Windows.Forms.GroupBox();
            this.rdoNguoiThue = new System.Windows.Forms.RadioButton();
            this.rdoNChoThue = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.picPeople = new System.Windows.Forms.PictureBox();
            this.picMatKhau = new System.Windows.Forms.PictureBox();
            this.picTenDangNhap = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tipTenDangNhap = new System.Windows.Forms.ToolTip(this.components);
            this.tipMatKhau = new System.Windows.Forms.ToolTip(this.components);
            this.btnShowPass = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnQuenMatKhau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpUserType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUserType
            // 
            this.grpUserType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpUserType.BackColor = System.Drawing.Color.Transparent;
            this.grpUserType.Controls.Add(this.rdoNguoiThue);
            this.grpUserType.Controls.Add(this.rdoNChoThue);
            this.grpUserType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserType.Location = new System.Drawing.Point(262, 377);
            this.grpUserType.Name = "grpUserType";
            this.grpUserType.Size = new System.Drawing.Size(306, 52);
            this.grpUserType.TabIndex = 19;
            this.grpUserType.TabStop = false;
            this.grpUserType.Text = "Người Dùng";
            // 
            // rdoNguoiThue
            // 
            this.rdoNguoiThue.AutoSize = true;
            this.rdoNguoiThue.BackColor = System.Drawing.Color.Transparent;
            this.rdoNguoiThue.Location = new System.Drawing.Point(163, 21);
            this.rdoNguoiThue.Name = "rdoNguoiThue";
            this.rdoNguoiThue.Size = new System.Drawing.Size(100, 21);
            this.rdoNguoiThue.TabIndex = 3;
            this.rdoNguoiThue.TabStop = true;
            this.rdoNguoiThue.Text = "Người Thuê";
            this.rdoNguoiThue.UseVisualStyleBackColor = false;
            // 
            // rdoNChoThue
            // 
            this.rdoNChoThue.AutoSize = true;
            this.rdoNChoThue.BackColor = System.Drawing.Color.Transparent;
            this.rdoNChoThue.CausesValidation = false;
            this.rdoNChoThue.Checked = true;
            this.rdoNChoThue.Location = new System.Drawing.Point(9, 21);
            this.rdoNChoThue.Name = "rdoNChoThue";
            this.rdoNChoThue.Size = new System.Drawing.Size(128, 21);
            this.rdoNChoThue.TabIndex = 4;
            this.rdoNChoThue.TabStop = true;
            this.rdoNChoThue.Text = "Người Cho Thuê";
            this.rdoNChoThue.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.Location = new System.Drawing.Point(337, 458);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(179, 47);
            this.btnDangNhap.TabIndex = 15;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(253, 312);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(353, 41);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picPeople
            // 
            this.picPeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPeople.BackColor = System.Drawing.Color.Transparent;
            this.picPeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPeople.BackgroundImage")));
            this.picPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPeople.Image = global::QuanLyPhongTro.Properties.Resources.people;
            this.picPeople.InitialImage = ((System.Drawing.Image)(resources.GetObject("picPeople.InitialImage")));
            this.picPeople.Location = new System.Drawing.Point(338, 67);
            this.picPeople.Name = "picPeople";
            this.picPeople.Size = new System.Drawing.Size(151, 122);
            this.picPeople.TabIndex = 18;
            this.picPeople.TabStop = false;
            // 
            // picMatKhau
            // 
            this.picMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.picMatKhau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMatKhau.BackgroundImage")));
            this.picMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMatKhau.Image = global::QuanLyPhongTro.Properties.Resources.password;
            this.picMatKhau.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMatKhau.InitialImage")));
            this.picMatKhau.Location = new System.Drawing.Point(177, 312);
            this.picMatKhau.Name = "picMatKhau";
            this.picMatKhau.Size = new System.Drawing.Size(43, 41);
            this.picMatKhau.TabIndex = 17;
            this.picMatKhau.TabStop = false;
            this.picMatKhau.MouseHover += new System.EventHandler(this.picMatKhau_MouseHover);
            // 
            // picTenDangNhap
            // 
            this.picTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.picTenDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTenDangNhap.BackgroundImage")));
            this.picTenDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTenDangNhap.Image = global::QuanLyPhongTro.Properties.Resources.user;
            this.picTenDangNhap.InitialImage = ((System.Drawing.Image)(resources.GetObject("picTenDangNhap.InitialImage")));
            this.picTenDangNhap.Location = new System.Drawing.Point(177, 226);
            this.picTenDangNhap.Name = "picTenDangNhap";
            this.picTenDangNhap.Size = new System.Drawing.Size(43, 41);
            this.picTenDangNhap.TabIndex = 16;
            this.picTenDangNhap.TabStop = false;
            this.picTenDangNhap.MouseHover += new System.EventHandler(this.picTenDangNhap_MouseHover);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(820, 77);
            this.lblTieuDe.TabIndex = 21;
            this.lblTieuDe.Text = "CHÀO MỪNG BẠN ĐẾN VỚI ỨNG DỤNG QUẢN LÝ PHÒNG TRỌ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.show_pass;
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Location = new System.Drawing.Point(638, 312);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(43, 41);
            this.btnShowPass.TabIndex = 22;
            this.btnShowPass.Tag = "hide";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(253, 226);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(353, 41);
            this.txtTenDangNhap.TabIndex = 13;
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangKy.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDangKy.Location = new System.Drawing.Point(12, 458);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(98, 27);
            this.btnDangKy.TabIndex = 24;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuenMatKhau.FlatAppearance.BorderSize = 0;
            this.btnQuenMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuenMatKhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuenMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuenMatKhau.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnQuenMatKhau.Location = new System.Drawing.Point(12, 491);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(138, 27);
            this.btnQuenMatKhau.TabIndex = 25;
            this.btnQuenMatKhau.Text = "Quên Mật Khẩu";
            this.btnQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuenMatKhau.UseVisualStyleBackColor = false;
            this.btnQuenMatKhau.Click += new System.EventHandler(this.btnQuenMatKhau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThoat.Location = new System.Drawing.Point(712, 492);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 27);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.login_background;
            this.ClientSize = new System.Drawing.Size(820, 531);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpUserType);
            this.Controls.Add(this.picPeople);
            this.Controls.Add(this.picMatKhau);
            this.Controls.Add(this.picTenDangNhap);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Trọ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.grpUserType.ResumeLayout(false);
            this.grpUserType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenDangNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUserType;
        private System.Windows.Forms.RadioButton rdoNguoiThue;
        private System.Windows.Forms.RadioButton rdoNChoThue;
        private System.Windows.Forms.PictureBox picPeople;
        private System.Windows.Forms.PictureBox picMatKhau;
        private System.Windows.Forms.PictureBox picTenDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private Label lblTieuDe;
        private ToolTip tipTenDangNhap;
        private ToolTip tipMatKhau;
        private Button btnShowPass;
        private TextBox txtTenDangNhap;
        private Button btnDangKy;
        private Button btnQuenMatKhau;
        private Button btnThoat;
    }
}