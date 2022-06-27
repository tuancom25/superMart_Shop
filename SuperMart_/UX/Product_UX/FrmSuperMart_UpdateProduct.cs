using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuperMart_.UX
{
    public partial class FrmSuperMart_UpdateProduct : Form
    {
        //String action = "/product/search-product";
        String token = "";
        List<CategoryDto> categories = null;
        List<ProductSupplyDto> supplies = null;
        List<ProductUnitDto> units = null;


        int countToSetFocus = 0;
        int changedDataText = 0;
        int counterToProcessScanItemQR = 0;
        Boolean scanItemQrStatus = false;

        public FrmSuperMart_UpdateProduct(String token)
        {
            this.token = token;
            InitializeComponent();
            load();
        }

        void load()
        {
            //Load list supply
            String dataSupply = Utils.getJsondataFromRestAPI("/product-supply", this.token, "GET");
            ResponseDto<ProductSupplyDto> listSupply = JsonConvert.DeserializeObject<ResponseDto<ProductSupplyDto>>(dataSupply);
            this.supplies = listSupply.Data.Content;
            foreach (var i in supplies)
            {
                cbxNhaCungCap.Items.Add(i.name);
            }


            //Load list unit
            String dataUnit = Utils.getJsondataFromRestAPI("/product-unit", this.token, "GET");
            ResponseDto<ProductUnitDto> listUnit = JsonConvert.DeserializeObject<ResponseDto<ProductUnitDto>>(dataUnit);
            this.units = listUnit.Data.Content;
            foreach (var j in units)
            {
                Console.WriteLine("Ten : " + j.name);
                cbxDonVi.Items.Add(j.name);
            }

            //Load list category
            String dataCategory = Utils.getJsondataFromRestAPI("/category/findAll", this.token, "GET");
            ResponseDto<CategoryDto> listResponseCategory = JsonConvert.DeserializeObject<ResponseDto<CategoryDto>>(dataCategory);
            this.categories = listResponseCategory.Data.Content;
            foreach (var k in categories)
            {
                cbxLoaiSanPham.Items.Add(k.name);
            }


            //Load list status
            cbxTrangThai.Items.Add("Còn hàng");
            cbxTrangThai.Items.Add("Hết hàng");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String dataProduct = Utils.getJsondataFromRestAPI("/product/search-product?code=" + txtGetBarCodeProduct.Text, this.token, "GET");
            ResponseDto<ProductDto> response = JsonConvert.DeserializeObject<ResponseDto<ProductDto>>(dataProduct);

            List<ProductDto> products = response.Data.Content;
            ProductDto product = products[0];

            txtID.Text = Convert.ToString(product.id);
            txtTenSanPham.Text = product.name;
            txtMaSanPham.Text = product.code;
            txtGiaTien.Text = Convert.ToString(product.price);
            txtSoLuong.Text = Convert.ToString(product.quantity);

            foreach (CategoryDto c in categories)
            {
                if (c.id == product.categoryId)
                {
                    cbxLoaiSanPham.ValueMember = c.name;
                    cbxLoaiSanPham.SelectedItem = cbxLoaiSanPham.ValueMember;
                }
            }

            foreach (ProductSupplyDto ps in supplies)
            {
                if (ps.id == product.supplyId)
                {
                    cbxNhaCungCap.ValueMember = ps.name;
                    cbxNhaCungCap.SelectedItem = cbxNhaCungCap.ValueMember;
                }
            }

            foreach (ProductUnitDto pu in units)
            {
                if (pu.id == product.productUnitId)
                {
                    cbxDonVi.ValueMember = pu.name;
                    cbxDonVi.SelectedItem = cbxDonVi.ValueMember;
                }
            }
            cbxTrangThai.SelectedItem = product.status;
            if (product.status)
            {
                cbxTrangThai.ValueMember = cbxTrangThai.Items.IndexOf(1).ToString();
                cbxTrangThai.SelectedItem = cbxTrangThai.ValueMember;
            }
            else cbxTrangThai.SelectedItem = cbxTrangThai.Items.IndexOf(2);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            String dataProduct = Utils.getJsondataFromRestAPI("/product/delete?id=" + txtGetBarCodeProduct, this.token, "GET");
            MessageBox.Show(dataProduct);
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            ProductDto dto = new ProductDto();
            dto.id = Int32.Parse(txtID.Text);
            dto.name = txtTenSanPham.Text;
            dto.code = txtMaSanPham.Text;
            dto.quantity = Int32.Parse(txtSoLuong.Text);
            dto.price = Int32.Parse(txtGiaTien.Text);

            foreach (CategoryDto c in categories)
            {
                if (c.name.Equals(cbxLoaiSanPham.SelectedItem))
                {
                    dto.categoryId = c.id;
                }
            }

            foreach (ProductUnitDto pu in units)
            {
                if (pu.name.Equals(cbxDonVi.SelectedItem))
                {
                    dto.productUnitId = pu.id;
                }
            }

            foreach (ProductSupplyDto ps in supplies)
            {
                if (ps.name.Equals(cbxNhaCungCap.SelectedItem))
                {
                    dto.supplyId = ps.id;
                }
            }

            // HardCode phan nay            
            dto.userInputId = 1;
            dto.userLastUpdateId = 1;
            dto.type = true;
            dto.status = true;

            //String updateProduct = Utils.getJsondataFromRestAPI("/product/update-product", this.token, "POST");
            String updateProduct = Utils.PostData("/product/update-product", dto, token);
            MessageBox.Show(updateProduct);
        }

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
            MessageBox.Show("Lay thong tin san pham tu server  0000 ", "nnn ");
            if (scanItemQrStatus)
            {
                counterToProcessScanItemQR++;
            }
            //MessageBox.Show("Lay thong tin san pham tu server  0000 ", "nnn ");
            if (counterToProcessScanItemQR > 11)
            {
                MessageBox.Show("Lay thong tin san pham tu server  0000 ", "nnn ");
                scanItemQrStatus = false;
                counterToProcessScanItemQR = 0;
                String QR_Code = txtGetBarCodeProduct.Text;
                btnCapNhap_Click();
            }
        }
        void btnCapNhap_Click()
        {
            ProductDto dto = new ProductDto();
            dto.id = Int32.Parse(txtID.Text);
            dto.name = txtTenSanPham.Text;
            dto.code = txtMaSanPham.Text;
            dto.quantity = Int32.Parse(txtSoLuong.Text);
            dto.price = Int32.Parse(txtGiaTien.Text);

            foreach (CategoryDto c in categories)
            {
                if (c.name.Equals(cbxLoaiSanPham.SelectedItem))
                {
                    dto.categoryId = c.id;
                }
            }

            foreach (ProductUnitDto pu in units)
            {
                if (pu.name.Equals(cbxDonVi.SelectedItem))
                {
                    dto.productUnitId = pu.id;
                }
            }

            foreach (ProductSupplyDto ps in supplies)
            {
                if (ps.name.Equals(cbxNhaCungCap.SelectedItem))
                {
                    dto.supplyId = ps.id;
                }
            }

            // HardCode phan nay            
            dto.userInputId = 1;
            dto.userLastUpdateId = 1;
            dto.type = true;
            dto.status = true;

            //String updateProduct = Utils.getJsondataFromRestAPI("/product/update-product", this.token, "POST");
            String updateProduct = Utils.PostData("/product/update-product", dto, token);
            MessageBox.Show(updateProduct);
        }

        private void txtGetBarCodeProduct_TextChanged(object sender, EventArgs e)
        {
            scanItemQrStatus = true;
        }
    }
}
