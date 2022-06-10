using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMart_.Model
{
   public class DataModelResponse
    {
    }

    /*
     * Đang dùng class này để mapping data - từ server trả về . 
     */
    public class DataObjectResponse<T>
    {
        private int responseCode;
        private String message;
        private ObjectData<T> data;

        public int ResponseCode { get => responseCode; set => responseCode = value; }
        public string Message { get => message; set => message = value; }
        public ObjectData<T> Data { get => data; set => data = value; }
    }

    public class ObjectData<T>
    {
        List<T> content;
        public List<T> Content { get => content; set => content = value; }
    }

}
