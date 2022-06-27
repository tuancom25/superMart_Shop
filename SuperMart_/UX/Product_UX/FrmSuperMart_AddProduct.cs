
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SuperMart_.UX
{
    public partial class FrmSuperMart_AddProduct : Form
    {
        String action = "/product/create-product";
        String token = "";
        String data = "";
        String imgPath = null;
        List<CategoryDto> categories = null;
        List<ProductSupplyDto> supplies = null;
        List<ProductUnitDto> units = null;

        public FrmSuperMart_AddProduct(String token)
        {
            this.token = token;  
            InitializeComponent();
            load();
        }

        void load()
        {
            //Load list supply
            String dataSupply = Utils.getJsondataFromRestAPI("/product-supply",this.token,"GET");
            txtTenSanPham.Text = data;
            ResponseDto<ProductSupplyDto> listSupply = JsonConvert.DeserializeObject<ResponseDto<ProductSupplyDto>>(dataSupply);
            this.supplies = listSupply.Data.Content;
            foreach (var i in supplies)
            {
                cbxNhaCungCap.Items.Add(i.name);
            }


            //Load list unit
            String dataUnit = Utils.getJsondataFromRestAPI("/product-unit", this.token, "GET");
            txtTenSanPham.Text = data;
            ResponseDto<ProductUnitDto> listUnit = JsonConvert.DeserializeObject<ResponseDto<ProductUnitDto>>(dataUnit);
            this.units = listUnit.Data.Content;
            foreach (var j in units)
            {
                Console.WriteLine("Ten : " +j.name);
            }

            //Load list category
            String dataCategory = Utils.getJsondataFromRestAPI("/category/findAll", this.token, "GET");
            ResponseDto<CategoryDto> listResponseCategory = JsonConvert.DeserializeObject<ResponseDto<CategoryDto>>(dataCategory);
            this.categories = listResponseCategory.Data.Content;
            foreach (var k in categories)
            {
                cbxLoaiSanPham.Items.Add(k.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProductDto dto = new ProductDto();
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

            String createProduct = Utils.PostData(action, dto, token);
            MessageBox.Show(createProduct);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imgPath = openFileDialog1.FileName;
            txtMaSanPham.Text = imgPath;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
