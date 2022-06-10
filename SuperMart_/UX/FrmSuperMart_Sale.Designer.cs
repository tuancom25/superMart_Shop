
namespace SuperMart_.UX
{
    partial class FrmSuperMart_Sale
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
            this.txtGetBarCodeProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtOrderProcessCheck = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnShowCustomerDisplay = new System.Windows.Forms.Button();
            this.lblTongTien2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTongDon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaGiaoDich = new System.Windows.Forms.Label();
            this.cmbLoaiThanhToan = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDaThanhToanSoTienLa = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picQr1 = new System.Windows.Forms.PictureBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChotDon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGetBarCodeProduct
            // 
            this.txtGetBarCodeProduct.Location = new System.Drawing.Point(87, 20);
            this.txtGetBarCodeProduct.Name = "txtGetBarCodeProduct";
            this.txtGetBarCodeProduct.Size = new System.Drawing.Size(188, 20);
            this.txtGetBarCodeProduct.TabIndex = 0;
            this.txtGetBarCodeProduct.TextChanged += new System.EventHandler(this.txtGetBarCodeProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quét mã vạch:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtOrderProcessCheck
            // 
            this.txtOrderProcessCheck.Location = new System.Drawing.Point(62, 501);
            this.txtOrderProcessCheck.Name = "txtOrderProcessCheck";
            this.txtOrderProcessCheck.Size = new System.Drawing.Size(100, 20);
            this.txtOrderProcessCheck.TabIndex = 2;
            this.txtOrderProcessCheck.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 76);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(850, 398);
            this.dgv1.TabIndex = 3;
            // 
            // btnShowCustomerDisplay
            // 
            this.btnShowCustomerDisplay.Location = new System.Drawing.Point(677, -80);
            this.btnShowCustomerDisplay.Name = "btnShowCustomerDisplay";
            this.btnShowCustomerDisplay.Size = new System.Drawing.Size(107, 23);
            this.btnShowCustomerDisplay.TabIndex = 31;
            this.btnShowCustomerDisplay.Text = "show customer";
            this.btnShowCustomerDisplay.UseVisualStyleBackColor = true;
            // 
            // lblTongTien2
            // 
            this.lblTongTien2.AutoSize = true;
            this.lblTongTien2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien2.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien2.Location = new System.Drawing.Point(480, 23);
            this.lblTongTien2.Name = "lblTongTien2";
            this.lblTongTien2.Size = new System.Drawing.Size(34, 20);
            this.lblTongTien2.TabIndex = 30;
            this.lblTongTien2.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Tổng tiền :";
            // 
            // lblTongDon
            // 
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Location = new System.Drawing.Point(648, 514);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(25, 13);
            this.lblTongDon.TabIndex = 27;
            this.lblTongDon.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tổng đơn trong ngày:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(204, -74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(91, 21);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Location = new System.Drawing.Point(972, 534);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(132, 23);
            this.btnHuyDon.TabIndex = 25;
            this.btnHuyDon.Text = "Hủy đơn ";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sắp xếp"});
            this.comboBox1.Location = new System.Drawing.Point(168, 501);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(813, 534);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(132, 23);
            this.btnHoanThanh.TabIndex = 22;
            this.btnHoanThanh.Text = "Hoàn thành thanh toán ";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "394 Mỹ đình Hà nội";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa chỉ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaGiaoDich);
            this.groupBox2.Controls.Add(this.cmbLoaiThanhToan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblDaThanhToanSoTienLa);
            this.groupBox2.Controls.Add(this.lblSoDienThoai);
            this.groupBox2.Controls.Add(this.lblTenKhachHang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(883, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 182);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách hàng ";
            // 
            // lblMaGiaoDich
            // 
            this.lblMaGiaoDich.AutoSize = true;
            this.lblMaGiaoDich.Location = new System.Drawing.Point(106, 148);
            this.lblMaGiaoDich.Name = "lblMaGiaoDich";
            this.lblMaGiaoDich.Size = new System.Drawing.Size(26, 13);
            this.lblMaGiaoDich.TabIndex = 13;
            this.lblMaGiaoDich.Text = "00X";
            // 
            // cmbLoaiThanhToan
            // 
            this.cmbLoaiThanhToan.FormattingEnabled = true;
            this.cmbLoaiThanhToan.Items.AddRange(new object[] {
            "Tiền mặt ",
            "Trực tuyến "});
            this.cmbLoaiThanhToan.Location = new System.Drawing.Point(109, 109);
            this.cmbLoaiThanhToan.Name = "cmbLoaiThanhToan";
            this.cmbLoaiThanhToan.Size = new System.Drawing.Size(98, 21);
            this.cmbLoaiThanhToan.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Mã giao dịch:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Loại thanh toán :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đã thanh toán:";
            // 
            // lblDaThanhToanSoTienLa
            // 
            this.lblDaThanhToanSoTienLa.AutoSize = true;
            this.lblDaThanhToanSoTienLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaThanhToanSoTienLa.ForeColor = System.Drawing.Color.Red;
            this.lblDaThanhToanSoTienLa.Location = new System.Drawing.Point(106, 79);
            this.lblDaThanhToanSoTienLa.Name = "lblDaThanhToanSoTienLa";
            this.lblDaThanhToanSoTienLa.Size = new System.Drawing.Size(47, 15);
            this.lblDaThanhToanSoTienLa.TabIndex = 4;
            this.lblDaThanhToanSoTienLa.Text = "label3";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.Blue;
            this.lblSoDienThoai.Location = new System.Drawing.Point(106, 52);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(47, 15);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "label3";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblTenKhachHang.Location = new System.Drawing.Point(106, 28);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(47, 15);
            this.lblTenKhachHang.TabIndex = 5;
            this.lblTenKhachHang.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số đt :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picQr1);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.lblMaDonHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnChotDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(883, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 285);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn hàng";
            // 
            // picQr1
            // 
            this.picQr1.Location = new System.Drawing.Point(49, 119);
            this.picQr1.Name = "picQr1";
            this.picQr1.Size = new System.Drawing.Size(158, 147);
            this.picQr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQr1.TabIndex = 2;
            this.picQr1.TabStop = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(96, 49);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(34, 20);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "0.00";
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.Location = new System.Drawing.Point(96, 25);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(49, 15);
            this.lblMaDonHang.TabIndex = 1;
            this.lblMaDonHang.Text = "A0000A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã đơn hàng:";
            // 
            // btnChotDon
            // 
            this.btnChotDon.Location = new System.Drawing.Point(70, 81);
            this.btnChotDon.Name = "btnChotDon";
            this.btnChotDon.Size = new System.Drawing.Size(75, 23);
            this.btnChotDon.TabIndex = 2;
            this.btnChotDon.Text = "Chốt đơn";
            this.btnChotDon.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // FrmSuperMart_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 609);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowCustomerDisplay);
            this.Controls.Add(this.lblTongTien2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTongDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnHuyDon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtOrderProcessCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGetBarCodeProduct);
            this.Name = "FrmSuperMart_Sale";
            this.Text = "FrmSuperMart_Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSuperMart_Sale_FormClosed);
            this.Load += new System.EventHandler(this.FrmSuperMart_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetBarCodeProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtOrderProcessCheck;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnShowCustomerDisplay;
        private System.Windows.Forms.Label lblTongTien2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTongDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaGiaoDich;
        private System.Windows.Forms.ComboBox cmbLoaiThanhToan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDaThanhToanSoTienLa;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picQr1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChotDon;
        private System.Windows.Forms.TextBox textBox1;
    }
}