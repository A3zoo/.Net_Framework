namespace QuanLyPhongTro.GUILayer
{
    partial class FormChiTietHoaDon
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
            this.hoaDonChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroDataSet = new QuanLyPhongTro.QuanLyPhongTroDataSet();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongThanhToan = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoaDonChiTietTableAdapter = new QuanLyPhongTro.QuanLyPhongTroDataSetTableAdapters.HoaDonChiTietTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonChiTietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonChiTietBindingSource
            // 
            this.hoaDonChiTietBindingSource.DataMember = "HoaDonChiTiet";
            this.hoaDonChiTietBindingSource.DataSource = this.quanLyPhongTroDataSet;
            // 
            // quanLyPhongTroDataSet
            // 
            this.quanLyPhongTroDataSet.DataSetName = "QuanLyPhongTroDataSet";
            this.quanLyPhongTroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnQuayLai.Location = new System.Drawing.Point(859, 442);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(78, 27);
            this.btnQuayLai.TabIndex = 26;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tổng thanh toán:";
            // 
            // lblTongThanhToan
            // 
            this.lblTongThanhToan.AutoSize = true;
            this.lblTongThanhToan.Location = new System.Drawing.Point(135, 442);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(0, 17);
            this.lblTongThanhToan.TabIndex = 29;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.hoaDonChiTietBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro.bin.Debug.ReportHoaDonChiTiet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(922, 423);
            this.reportViewer1.TabIndex = 30;
            // 
            // hoaDonChiTietTableAdapter
            // 
            this.hoaDonChiTietTableAdapter.ClearBeforeFill = true;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 478);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblTongThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayLai);
            this.Name = "FormChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonChiTietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongThanhToan;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyPhongTroDataSet quanLyPhongTroDataSet;
        private System.Windows.Forms.BindingSource hoaDonChiTietBindingSource;
        private QuanLyPhongTroDataSetTableAdapters.HoaDonChiTietTableAdapter hoaDonChiTietTableAdapter;
    }
}