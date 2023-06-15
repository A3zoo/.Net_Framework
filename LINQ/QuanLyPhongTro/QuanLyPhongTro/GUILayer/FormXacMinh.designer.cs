
namespace QuanLyPhongTro.GUILayer
{
    partial class FormXacMinh
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
            this.txtDn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacMinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDn
            // 
            this.txtDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDn.Location = new System.Drawing.Point(157, 35);
            this.txtDn.Multiline = true;
            this.txtDn.Name = "txtDn";
            this.txtDn.Size = new System.Drawing.Size(184, 34);
            this.txtDn.TabIndex = 0;
            this.txtDn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // btnXacMinh
            // 
            this.btnXacMinh.Location = new System.Drawing.Point(121, 216);
            this.btnXacMinh.Name = "btnXacMinh";
            this.btnXacMinh.Size = new System.Drawing.Size(101, 34);
            this.btnXacMinh.TabIndex = 2;
            this.btnXacMinh.Text = "Xác minh";
            this.btnXacMinh.UseVisualStyleBackColor = true;
            this.btnXacMinh.Click += new System.EventHandler(this.btnXacMinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CCCD: ";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(157, 88);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(184, 34);
            this.txtCCCD.TabIndex = 3;
            this.txtCCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới: ";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(157, 145);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(184, 34);
            this.txtMK.TabIndex = 5;
            this.txtMK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.ForeColor = System.Drawing.Color.Red;
            this.lblTB.Location = new System.Drawing.Point(143, 189);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(0, 17);
            this.lblTB.TabIndex = 7;
            this.lblTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormXacMinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 259);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.btnXacMinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDn);
            this.Name = "FormXacMinh";
            this.Text = "FormQuenMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacMinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lblTB;
    }
}