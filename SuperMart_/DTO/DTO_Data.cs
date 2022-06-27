using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMart_.DTO
{
    class DTO_Data
    {  public String name { get; set; }
        /*
         {
    "accessToken": "eyJhbGciOiJIUzUxMiJ9.eyJzaG9waWQiOjEsInR5cGUiOiJTSE9QIiwic3ViIjoiYWRtaW4iLCJpYXQiOjE2NTQxNjE4NzcsImV4cCI6MTY1NDI0ODI3N30.uuSnN0mYSj5wMAwKpAuQ5KHZYYQWVZfJMx6_I4aBdfyV8zUkEWJJBbrh3WRYKCRGFYttphXJ0ee9_fiqMmAnww",
    "tokenType": "Bearer",
    "user": {
        "id": 2,
        "username": "admin",
        "fullname": "Administrator",
        "phone": "1509510925",
        "email": null,
        "cccd": null,
        "address": null,
        "rsa": {
            "publicKey": null,
            "privateKey": null
        },
        "ipLastWork": null,
        "functions": [
            "User_findAll"
        ]
    }
}*/
    }
    public class LoginSuccessDto
    {
        public String accessToken { get; set; }
        public String tokenType { get; set; }
        public UserDto user { get; set; }


    }
    public class UserDto
    { public int id { get; set; }
        public String username { get; set; }
        public String fullname { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String address { get; set; }
        // public String cccd { get; set; }
        // public String cccd { get; set; }
        public String ipLastWork { get; set; }
        public List<String> functions { get; set; }
    }
    public class RSADto
    {
        public String publicKey { get; set; }
        public String privateKey { get; set; }
    }

  //  {
  // "username": "admin",
  //  "password": "13546222"
  //  }
public class LoginPostDto {
        public String username { get; set; }
        public String password { get; set; }
    }
    
}
public class ProductDto
{
    private long _id;
    private String _code;
    private Boolean _type;
    private int _categoryId;
    private String _name;
    private long _price;
    private int _quantity;
    private int _supplyId;
    private int _userInputId;
    private int _userLastUpdateId;
    private Boolean _status;
    private String _avatar;
    private long _productParent;
    private int _saleStatus;
    private int _hasTopUp;
    private int _isTopUp;
    private int _productUnitId;
    private int _shopId;

    public long id { get => _id; set => _id = value; }
    public string code { get => _code; set => _code = value; }
    public bool type { get => _type; set => _type = value; }
    public int categoryId { get => _categoryId; set => _categoryId = value; }
    public string name { get => _name; set => _name = value; }
    public long price { get => _price; set => _price = value; }
    public int quantity { get => _quantity; set => _quantity = value; }
    public int supplyId { get => _supplyId; set => _supplyId = value; }
    public int userInputId { get => _userInputId; set => _userInputId = value; }
    public int userLastUpdateId { get => _userLastUpdateId; set => _userLastUpdateId = value; }
    public bool status { get => _status; set => _status = value; }
    public string avatar { get => _avatar; set => _avatar = value; }
    public long productParent { get => _productParent; set => _productParent = value; }
    public int saleStatus { get => _saleStatus; set => _saleStatus = value; }
    public int hasTopUp { get => _hasTopUp; set => _hasTopUp = value; }
    public int isTopUp { get => _isTopUp; set => _isTopUp = value; }
    public int productUnitId { get => _productUnitId; set => _productUnitId = value; }
    public int shopId { get => _shopId; set => _shopId = value; }



    public ProductDto() { }
}

public class ProductSupplyDto
{
    private int _id;
    private String _name;
    private String _address;
    private int _shopId;

    public ProductSupplyDto()
    {
    }

    public int id { get => _id; set => _id = value; }
    public string name { get => _name; set => _name = value; }
    public string address { get => _address; set => _address = value; }
    public int shopId { get => _shopId; set => _shopId = value; }
}

public class CategoryDto
{
    private int _id;
    private String _name;
    private int _categoryParent;
    private int _categoryGroupId;
    private String _comment;
    private String _imageLink;

    CategoryDto() { }

    public int id { get => _id; set => _id = value; }
    public string name { get => _name; set => _name = value; }
    public int categoryParent { get => _categoryParent; set => _categoryParent = value; }
    public int categoryGroupId { get => _categoryGroupId; set => _categoryGroupId = value; }
    public string comment { get => _comment; set => _comment = value; }
    public string imageLink { get => _imageLink; set => _imageLink = value; }
}

public class ProductUnitDto
{
    private int _id;
    private String _name;

    public ProductUnitDto()
    {
    }

    public int id { get => _id; set => _id = value; }
    public string name { get => _name; set => _name = value; }
}

public class OrderDto
{
    private long _id;
    private String _orderCode;
    private int _customerId;
    private int _userId;
    private String _date1;
    //private Instant date2;
    private int _totalMoney;
    private int _moneyType;
    private int _getMoney;
    private int _rejectMoney;
    private String _customerName;
    private String _customerPhone;
    private int _statusPay;
    private int _statusShip;
    private String _statusShipComment;
    private int _type;
    private int _payType;
    private String _customerAdrress;
    private String _customerAdrress2;
    private int _shopId;
    private int _shipperId;
    private int _shipCompanyId;
    private String _orderComment;

    public long id { get => _id; set => _id = value; }
    public string orderCode { get => _orderCode; set => _orderCode = value; }
    public int customerId { get => _customerId; set => _customerId = value; }
    public int userId { get => _userId; set => _userId = value; }
    public string date1 { get => _date1; set => _date1 = value; }
    public int totalMoney { get => _totalMoney; set => _totalMoney = value; }
    public int moneyType { get => _moneyType; set => _moneyType = value; }
    public int getMoney { get => _getMoney; set => _getMoney = value; }
    public int rejectMoney { get => _rejectMoney; set => _rejectMoney = value; }
    public string customerName { get => _customerName; set => _customerName = value; }
    public string customerPhone { get => _customerPhone; set => _customerPhone = value; }
    public int statusPay { get => _statusPay; set => _statusPay = value; }
    public int statusShip { get => _statusShip; set => _statusShip = value; }
    public string statusShipComment { get => _statusShipComment; set => _statusShipComment = value; }
    public int type { get => _type; set => _type = value; }
    public int payType { get => _payType; set => _payType = value; }
    public string customerAdrress { get => _customerAdrress; set => _customerAdrress = value; }
    public string customerAdrress2 { get => _customerAdrress2; set => _customerAdrress2 = value; }
    public int shopId { get => _shopId; set => _shopId = value; }
    public int shipperId { get => _shipperId; set => _shipperId = value; }
    public int shipCompanyId { get => _shipCompanyId; set => _shipCompanyId = value; }
    public string orderComment { get => _orderComment; set => _orderComment = value; }
}

public class ResponseDto<T>
{
    int _responseCode;
    String _message;
    DataDto<T> _data;

    public ResponseDto()
    {
    }

    public int ResponseCode { get => _responseCode; set => _responseCode = value; }
    public string Message { get => _message; set => _message = value; }
    public DataDto<T> Data { get => _data; set => _data = value; }
}

public class DataDto<T>
{
    List<T> _content;
    Object _pageable;
    Object _totalElements;
    Object _numberOfElements;
    Object _first;
    Object _empty;

    public object Pageable { get => _pageable; set => _pageable = value; }
    public object TotalElements { get => _totalElements; set => _totalElements = value; }
    public object NumberOfElements { get => _numberOfElements; set => _numberOfElements = value; }
    public object First { get => _first; set => _first = value; }
    public object Empty { get => _empty; set => _empty = value; }
    public List<T> Content { get => _content; set => _content = value; }
}
