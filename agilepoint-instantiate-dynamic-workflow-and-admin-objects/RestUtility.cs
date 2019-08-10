using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    static class RestUtility
    {

      

        public static string MakeRESTHTTPRequest(string RequestURL, HttpMethod RequestMethod, WebHeaderCollection webHeaderCollection, string RequestData,string contentType)
        {
            string content = string.Empty;
            try
            {
                 var HttpRequest = (HttpWebRequest)WebRequest.Create(RequestURL);

                HttpRequest.Accept = "application/json";                
                HttpRequest.Method = RequestMethod.ToString();
                HttpRequest.Headers = webHeaderCollection;
                if (!string.IsNullOrEmpty(contentType))
                {
                    HttpRequest.ContentType = contentType;
                }
                else
                    HttpRequest.ContentType = "application/json";
                if (RequestMethod.Method.ToString() == HttpMethod.Post.ToString())
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(RequestData);
                    HttpRequest.ContentLength = byteArray.Length;
                    using (Stream dataStream = HttpRequest.GetRequestStream())
                    {
                        // Write the data to the request stream.
                        dataStream.Write(byteArray, 0, byteArray.Length);
                        // Close the Stream object.
                        dataStream.Close();
                    }
                }
                using (var response = (HttpWebResponse)HttpRequest.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
                return content;
            }
            catch (WebException ex)
            {
                string WebExceptionStream = string.Empty;
                if (ex.Response != null)
                {
                    using (StreamReader responseReader = new StreamReader(ex.Response.GetResponseStream()))
                    {
                        WebExceptionStream = responseReader.ReadToEnd();
                        throw new Exception(WebExceptionStream);
                    }
                }
                else
                    throw;
            }
            catch (Exception Ex)
            {
                throw;
            }
            return content;

        }


    }
}
