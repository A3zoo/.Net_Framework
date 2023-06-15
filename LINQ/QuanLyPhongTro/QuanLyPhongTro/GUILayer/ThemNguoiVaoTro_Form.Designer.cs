namespace QuanLyPhongTro
{
    partial class ThemNguoiVaoTro_Form
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
            this.txt_machuTro1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNguoiThue = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_manguoithue = new System.Windows.Forms.TextBox();
            this.btn_show1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maphongtro1 = new System.Windows.Forms.TextBox();
            this.btn_themnguoithue = new System.Windows.Forms.Button();
            this.btn_xoanguoithue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_machuTro1
            // 
            this.txt_machuTro1.Enabled = false;
            this.txt_machuTro1.Location = new System.Drawing.Point(415, 25);
            this.txt_machuTro1.Name = "txt_machuTro1";
            this.txt_machuTro1.Size = new System.Drawing.Size(182, 22);
            this.txt_machuTro1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chủ trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNguoiThue
            // 
            this.dgvNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiThue.Location = new System.Drawing.Point(316, 71);
            this.dgvNguoiThue.Name = "dgvNguoiThue";
            this.dgvNguoiThue.RowHeadersVisible = false;
            this.dgvNguoiThue.RowHeadersWidth = 51;
            this.dgvNguoiThue.RowTemplate.Height = 24;
            this.dgvNguoiThue.Size = new System.Drawing.Size(459, 338);
            this.dgvNguoiThue.TabIndex = 2;
            this.dgvNguoiThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiThue_CellClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã người thuê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_manguoithue
            // 
            this.txt_manguoithue.Location = new System.Drawing.Point(141, 71);
            this.txt_manguoithue.Name = "txt_manguoithue";
            this.txt_manguoithue.Size = new System.Drawing.Size(128, 22);
            this.txt_manguoithue.TabIndex = 4;
            // 
            // btn_show1
            // 
            this.btn_show1.Location = new System.Drawing.Point(696, 18);
            this.btn_show1.Name = "btn_show1";
            this.btn_show1.Size = new System.Drawing.Size(79, 36);
            this.btn_show1.TabIndex = 5;
            this.btn_show1.Text = "Show";
            this.btn_show1.UseVisualStyleBackColor = true;
            this.btn_show1.Click += new System.EventHandler(this.btn_show1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã phòng trọ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_maphongtro1
            // 
            this.txt_maphongtro1.Location = new System.Drawing.Point(141, 122);
            this.txt_maphongtro1.Name = "txt_maphongtro1";
            this.txt_maphongtro1.Size = new System.Drawing.Size(128, 22);
            this.txt_maphongtro1.TabIndex = 7;
            // 
            // btn_themnguoithue
            // 
            this.btn_themnguoithue.Location = new System.Drawing.Point(12, 218);
            this.btn_themnguoithue.Name = "btn_themnguoithue";
            this.btn_themnguoithue.Size = new System.Drawing.Size(92, 30);
            this.btn_themnguoithue.TabIndex = 8;
            this.btn_themnguoithue.Text = "Thêm";
            this.btn_themnguoithue.UseVisualStyleBackColor = true;
            this.btn_themnguoithue.Click += new System.EventHandler(this.btn_themnguoithue_Click);
            // 
            // btn_xoanguoithue
            // 
            this.btn_xoanguoithue.Location = new System.Drawing.Point(175, 216);
            this.btn_xoanguoithue.Name = "btn_xoanguoithue";
            this.btn_xoanguoithue.Size = new System.Drawing.Size(94, 32);
            this.btn_xoanguoithue.TabIndex = 9;
            this.btn_xoanguoithue.Text = "Xóa";
            this.btn_xoanguoithue.UseVisualStyleBackColor = true;
            this.btn_xoanguoithue.Click += new System.EventHandler(this.btn_xoanguoithue_Click);
            // 
            // ThemNguoiVaoTro_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xoanguoithue);
            this.Controls.Add(this.btn_themnguoithue);
            this.Controls.Add(this.txt_maphongtro1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_show1);
            this.Controls.Add(this.txt_manguoithue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNguoiThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_machuTro1);
            this.Name = "ThemNguoiVaoTro_Form";
            this.Text = "ThemNguoiVaoTro_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_machuTro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNguoiThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_manguoithue;
        private System.Windows.Forms.Button btn_show1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maphongtro1;
        private System.Windows.Forms.Button btn_themnguoithue;
        private System.Windows.Forms.Button btn_xoanguoithue;
    }
}