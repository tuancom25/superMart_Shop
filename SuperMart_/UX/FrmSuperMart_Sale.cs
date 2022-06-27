using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMart_.Model;
using ZXing.QrCode;

namespace SuperMart_.UX
{
    public partial class FrmSuperMart_Sale : Form
    {
        public FrmSuperMart_Sale()
        {
            InitializeComponent();
        }

        int countToSetFocus = 0;
        int changedDataText = 0;
        int counterToProcessScanItemQR = 0;
        Boolean scanItemQrStatus = false;
        public List<ModelItem> lsOrders = new List<ModelItem>();
        /*
         
         */ 

        private void timer1_Tick(object sender, EventArgs e)
        {
            countToSetFocus++;
            if (countToSetFocus == 7)
            {
                txtGetBarCodeProduct.Focus();
                countToSetFocus = 0;
            }
            if (changedDataText == 2)
            {
                /* Thuc hien goi truy van lay Item san pham Info . Quet ma vach hoan thanh`*/
            }
            if (changedDataText > 0) { changedDataText++; }
            if (changedDataText >= 2) { changedDataText = 0; }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (scanItemQrStatus)
            {
                counterToProcessScanItemQR++;
            }
            //MessageBox.Show("Lay thong tin san pham tu server  0000 ", "nnn ");
            if (counterToProcessScanItemQR > 11)
            { 
                scanItemQrStatus = false;
                counterToProcessScanItemQR = 0;
                //  đã nhập thanh công, ->  process QR-Mã vạch . 
                // Xử lý  chọn  hàng sản phẩm . vào đơn hàng . 
                String QR_Code = txtGetBarCodeProduct.Text;
                // process đơn hàng .
                txtOrderProcessCheck.Text = QR_Code;
                txtGetBarCodeProduct.Text = "";
                scanItemQrStatus = false;
                //MessageBox.Show("Lay thong tin san pham tu server 11111 KKKKK . counterToProcessScanItemQR= " + counterToProcessScanItemQR, "nnn ");

                //////   dgv1.DataSource = null;
                //ModelItem m = new ModelItem();
                //m.chietKhau = 0;
                //m.donGia = 50;
                //m.maHang = QR_Code;
                //m.soLuong = 1;
                //m.donVi = "hộp";
                //m.tenHang = "Bank bông lan";
                //m.mota = "Banh bông lan Sai gòn";
                //ls.Add(m);
                // int sum = processOrder(ls);
                ModelItem m = Servicess.GetRanDomModelItem(QR_Code);

                lsOrders.Add(m);
                int sum = processOrder(lsOrders);
                lblTongTien.Text = "" + sum + " .00 vnđ";
                lblTongTien2.Text = "" + sum + " .00 vnđ";
                dgv1.DataSource = lsOrders;
                this.dgv1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                // dgv1.Update();
              //  setDataForCustomerDisplay();
            }

        }


        Bitmap genQR(String s)
        {
            ZXing.QrCode.QRCodeWriter qr = new QRCodeWriter();
            var b = qr.encode(s, ZXing.BarcodeFormat.QR_CODE, 550, 550);
            Bitmap bt = b.ToBitmap(ZXing.BarcodeFormat.QR_CODE, s);
            return bt;

        }
        String name = "", sdt = "";
        int tongTien = 0;

        private void FrmSuperMart_Sale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmSuperMart_Sale_Load(object sender, EventArgs e)
        {

        }

        private void txtGetBarCodeProduct_TextChanged(object sender, EventArgs e)
        {
            scanItemQrStatus = true;
        }

        int processOrder(List<ModelItem> ls)
        {
            int sum = 0;
            foreach (ModelItem it in ls)
            {
                if (it != null)
                {
                    try
                    {
                        it.thanhTien = it.donGia * it.soLuong;
                        sum += it.donGia * it.soLuong;
                    }
                    catch (Exception x)
                    {

                    }
                }
            }
            Bitmap mm = genQR("0100988877770." + sdt + "." + name + "." + sum);
         ////   Customer.bm = mm;
            picQr1.Image = mm;
         ////   Customer.tongSoTien = sum;
            tongTien = sum;
            return sum;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        void setColor(DataGridView mydataGridView)
        {
            int i = 0;
            foreach (DataGridViewRow row in mydataGridView.Rows)
            {
                // if (i == 0) { row.DefaultCellStyle.BackColor = Color.Coral ; }
                i++;
                if (i % 2 == 1) { row.DefaultCellStyle.BackColor = Color.Beige; }
            }
            this.dgv1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
