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
