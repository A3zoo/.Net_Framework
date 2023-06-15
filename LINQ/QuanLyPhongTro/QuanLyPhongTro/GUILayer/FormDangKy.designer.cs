
namespace QuanLyPhongTro
{
    partial class FormDangKy
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.rdoNguoiThue = new System.Windows.Forms.RadioButton();
            this.grpUserType = new System.Windows.Forms.GroupBox();
            this.rdoNChoThue = new System.Windows.Forms.RadioButton();
            this.lblTrunTen = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTdn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNsinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQq = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.txtHvt = new System.Windows.Forms.TextBox();
            this.grpUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(542, 77);
            this.lblTieuDe.TabIndex = 40;
            this.lblTieuDe.Text = "Đăng Kí";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // grpUserType
            // 
            this.grpUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserType.BackColor = System.Drawing.Color.Transparent;
            this.grpUserType.Controls.Add(this.rdoNguoiThue);
            this.grpUserType.Controls.Add(this.rdoNChoThue);
            this.grpUserType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserType.Location = new System.Drawing.Point(141, 423);
            this.grpUserType.Name = "grpUserType";
            this.grpUserType.Size = new System.Drawing.Size(306, 52);
            this.grpUserType.TabIndex = 39;
            this.grpUserType.TabStop = false;
            this.grpUserType.Text = "Người Dùng";
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
            // lblTrunTen
            // 
            this.lblTrunTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrunTen.AutoSize = true;
            this.lblTrunTen.ForeColor = System.Drawing.Color.Red;
            this.lblTrunTen.Location = new System.Drawing.Point(177, 367);
            this.lblTrunTen.Name = "lblTrunTen";
            this.lblTrunTen.Size = new System.Drawing.Size(0, 17);
            this.lblTrunTen.TabIndex = 38;
            this.lblTrunTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDangKi.Location = new System.Drawing.Point(224, 487);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(149, 47);
            this.btnDangKi.TabIndex = 37;
            this.btnDangKi.Text = "Đăng Ký";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(93, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mật Khẩu";
            // 
            // txtMk
            // 
            this.txtMk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMk.Location = new System.Drawing.Point(173, 388);
            this.txtMk.Multiline = true;
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(270, 22);
            this.txtMk.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(55, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tên Đăng Nhập";
            // 
            // txtTdn
            // 
            this.txtTdn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTdn.Location = new System.Drawing.Point(173, 340);
            this.txtTdn.Multiline = true;
            this.txtTdn.Name = "txtTdn";
            this.txtTdn.Size = new System.Drawing.Size(270, 22);
            this.txtTdn.TabIndex = 33;
            this.txtTdn.TextChanged += new System.EventHandler(this.txtTdn_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(93, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày Sinh";
            // 
            // dtNsinh
            // 
            this.dtNsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNsinh.Location = new System.Drawing.Point(173, 292);
            this.dtNsinh.Name = "dtNsinh";
            this.dtNsinh.Size = new System.Drawing.Size(200, 22);
            this.dtNsinh.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(93, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quê Quán";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(71, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(78, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "CCCD/CMND";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(93, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Họ và Tên";
            // 
            // txtQq
            // 
            this.txtQq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQq.Location = new System.Drawing.Point(173, 247);
            this.txtQq.Multiline = true;
            this.txtQq.Name = "txtQq";
            this.txtQq.Size = new System.Drawing.Size(270, 22);
            this.txtQq.TabIndex = 26;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdt.Location = new System.Drawing.Point(173, 205);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(270, 22);
            this.txtSdt.TabIndex = 25;
            // 
            // txtCccd
            // 
            this.txtCccd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCccd.Location = new System.Drawing.Point(173, 152);
            this.txtCccd.Multiline = true;
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(270, 27);
            this.txtCccd.TabIndex = 24;
            // 
            // txtHvt
            // 
            this.txtHvt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHvt.Location = new System.Drawing.Point(173, 102);
            this.txtHvt.Multiline = true;
            this.txtHvt.Name = "txtHvt";
            this.txtHvt.Size = new System.Drawing.Size(270, 22);
            this.txtHvt.TabIndex = 23;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.login_background;
            this.ClientSize = new System.Drawing.Size(542, 544);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpUserType);
            this.Controls.Add(this.lblTrunTen);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTdn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtNsinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQq);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtCccd);
            this.Controls.Add(this.txtHvt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDangKy";
            this.Text = "Đăng Ký";
            this.grpUserType.ResumeLayout(false);
            this.grpUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.RadioButton rdoNguoiThue;
        private System.Windows.Forms.GroupBox grpUserType;
        private System.Windows.Forms.RadioButton rdoNChoThue;
        private System.Windows.Forms.Label lblTrunTen;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTdn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNsinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQq;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtHvt;
    }
}