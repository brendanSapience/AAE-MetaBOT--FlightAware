using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FlightAwareLib
{
    public class RestUtils
    {
        public String CallRestGETWithBasicAuth(String URL, String Login, String Password)
        {

            System.Net.HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(Login + ":" + Password));
            //using (var streamWriter = new System.IO.StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //   string json = "{\"x\":\"true\"}";

            //                streamWriter.Write(json);
            //               streamWriter.Flush();
            //         }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (System.Net.WebException e)
            {
                return "Error:" + e.Message;
            }
        }
    }
}
