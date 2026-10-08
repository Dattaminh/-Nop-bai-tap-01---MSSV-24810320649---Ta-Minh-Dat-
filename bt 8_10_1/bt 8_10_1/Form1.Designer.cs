namespace bt_8_10_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            lblDonGia = new Label();
            lblSoLuong = new Label();
            lblGiamGia = new Label();
            lblKetQua = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(230, 74);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(181, 27);
            txtDonGia.TabIndex = 0;
            txtDonGia.TextChanged += textBox1_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(230, 122);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(181, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(230, 172);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(181, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(99, 77);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(113, 20);
            lblDonGia.TabIndex = 3;
            lblDonGia.Text = "Đơn giá dịch vụ";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(99, 125);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(111, 20);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số lượng khách";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(99, 175);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(119, 20);
            lblGiamGia.TabIndex = 5;
            lblGiamGia.Text = "Mã giảm giá (%)";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(99, 244);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(175, 20);
            lblKetQua.TabIndex = 6;
            lblKetQua.Text = "Tổng tiền thanh toán: 0 đ";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(141, 304);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(270, 304);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblKetQua);
            Controls.Add(lblGiamGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblDonGia);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Label lblDonGia;
        private Label lblSoLuong;
        private Label lblGiamGia;
        private Label lblKetQua;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}
