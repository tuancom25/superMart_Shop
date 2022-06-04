using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SuperMart_.Model;
namespace SuperMart_
{
  public  class Utils
    {
        public static String Server_url = "http://150.95.109.25:8888";
        public static String urlDomain =  "http://150.95.109.25:8888";
        public static String Server_url_s = "http://";
        public static String domain = "http://150.95.109.25:8888";
        public static String token ="";
        public static String Port = "8888";
        static HttpWebRequest request = null;
        //public static 

        public static String PostData(String action, Object _post)
        {
            var result = string.Empty;
            try
            {
                String domain = urlDomain + action;
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + DataFromServer.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                String data = JsonConvert.SerializeObject(_post);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = client.PostAsync(domain, content).Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                return " kết quả :  " + result;
            }
            catch (Exception e) { }
            return " kết quả :  " + result;
        }
        public static String PostData(String action, Object _post, String token)
        {
            var result = string.Empty;
            try
            {
                String domain = urlDomain + action;
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + DataFromServer.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                String data = JsonConvert.SerializeObject(_post);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = client.PostAsync(domain, content).Result;
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                return " kết quả :  " + result;
            }
            catch (Exception e) { }
            return " kết quả :  " + result;
        }

        //====================================================

         static HttpWebRequest getHttpWebRequest(String action, String token, String method)
        {
            // if (request == null)
            // {
            HttpWebRequest request_ = (HttpWebRequest)WebRequest.Create(urlDomain + action);
            request_.Method = method;
            request_.ContentType = "application/json";
            request_.Headers.Add("Authorization", token);
            request_.Accept = "*/*";
            request = request_;
            //  }
            return request;
        }
       public  static String getJsondataFromRestAPI(String action, String token, String method)
        {
            //action = urlDomain + action;
            HttpWebRequest request = Utils.getHttpWebRequest(action, "Bearer " + token.Replace("Bearer", ""), method);
            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                responseReader.Close();
                String data = response.Replace("null", "0");
                return data;
            }
            catch (Exception x) { }
            return "null";
        }

        public static List<T> getListObjectDataFromServer<T>(String action, String token, String method)
        {
            List<T> ListObjectJsonData = new List<T>();
            String data = getJsondataFromRestAPI(action, token, method);
            DataObjectResponse<T> abc = JsonConvert.DeserializeObject<DataObjectResponse<T>>(data);
            ListObjectJsonData = abc.Data.Content;
            return ListObjectJsonData;
        }
        //=======================****===========================//

    }
}
