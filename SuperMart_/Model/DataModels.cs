using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMart_.Model
{
  public  class DataModels
    {
    }

   public class ModelItem
    {
        int soThuTu = 0;
        int dg = 0;
        public int soTT { get; set; }
        public String maHang { get; set; }
        public String tenHang { get; set; }
        public String donVi { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
        public int chietKhau { get; set; }
        //  public int thue = 0;
        public int thanhTien { get; set; }
        public String mota { get; set; }
        public static List<ModelItem> lsModelItem;


        public ModelItem(String[] s)
        {
            Int32.TryParse(s[0], out soThuTu);
            soTT = soThuTu;
            maHang = s[1];
            tenHang = s[2];
            donVi = s[3];
            Int32.TryParse(s[4], out dg);
            donGia = dg;
            mota = s[5];

        }
        public ModelItem() { }


        class Customer
        {
            public static String abc;
            public static List<ModelItem> ls;
            public static Bitmap bm;
            public static String name_ = "";
            public static String phone_ = "";
            public static String soTien = "";
            public static Customer cc;
            public static int tongSoTien = 0;
            public static String soDTKhachHang = "";
            public static String tenKhachHang = "";


            /*  
            - PHân tích chuỗi thông báo.  : { loại gửi tiền. service type. số tiền. . transactionCoce. data-ta } 
            Chuỗi data : 
              // 01,1, T+cccd|sdt|ten| tieu đề | data : cc.bx.id | giá | là fix giá .
              // loại dịch vụ, là bí danh, cccd(hoặc mã số định danh)|
                01000171182175.0986989370.Nguyễn hà như ý.  -> không có bí danh
                01000171182175.0986989370.Nguyễn hà như ý.   ->  có bí danh
                Đường sắt cát linh là loại có bí danh .  có data . 
             */
            // Chuỗi đường sắt cát linh , là dịch vụ thứ 14.  và có bí danh . 
            // 1410098987654.098789810.Đường sắt cát linh. Cổng 5. 00-00-00. 9000.1.A
            String SERVICE_TYPE = "14";
            String ALIAS_TYPE = "1";
            int id;
            String name;
            String moneyCost;
            String stationStart;
            String stationTarget;
            String tiketCode;
            String serviceType = "14";
            String AliasValie = "1";

            public Customer getCustomer(String dataChain)
            {
                Customer cus = new Customer();
                // chain ="" với   chuỗi dữ liệu là đường sắt cát linh. 
                //  A140
                char[] splitKey = { '.' };
                String value0 = "";

                String[] chains = dataChain.Split(splitKey);
                try
                {
                    value0 = chains[0];
                    serviceType = value0.Substring(1, 2);
                    AliasValie = value0.Substring(2, 1);

                }
                catch (Exception x) { }
                if (SERVICE_TYPE.Equals(serviceType) && ALIAS_TYPE.Equals(AliasValie))
                {
                    try { } catch (Exception x) { }

                }

                cc = cus;
                return cus;
            }

         

            public static Bitmap genQR(String s)
            {
                ZXing.QrCode.QRCodeWriter qr = new ZXing.QrCode.QRCodeWriter();
                var b = qr.encode(s, ZXing.BarcodeFormat.QR_CODE, 550, 550);
                Bitmap bt = b.ToBitmap(ZXing.BarcodeFormat.QR_CODE, s);
                return bt;

            }


        }
    }
}
