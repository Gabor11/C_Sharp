using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace csharpRestClient
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        public string ParameterString { get; set; }
        public string Url { get; set; }
        public HttpVerb HttpMethod { get; set; }


        protected Dictionary<string, string> dataSetForRequestBody;

        public RestClient(string url, string parameterString)
        {
            ParameterString = parameterString;
            Url = url;
            HttpMethod = HttpVerb.GET;
            this.dataSetForRequestBody = new Dictionary<string, string>();
        }

        public RestClient(string url, Dictionary<string, string> dataSetForRequestBody)
        {
            ParameterString = string.Empty;
            Url = url;
            HttpMethod = HttpVerb.POST;
            this.dataSetForRequestBody = dataSetForRequestBody;
        }

        public string makeGetRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = initializeHttpWebRequest();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return strResponseValue;
        }

        public string makePostRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = initializeHttpWebRequest();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            return strResponseValue;
        }

        private HttpWebRequest initializeHttpWebRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + ParameterString);
            request.Method = HttpMethod.ToString();
            if (HttpMethod == HttpVerb.POST)
            {
                request.ContentType = "application/json";
                byte[] requestBuf = createRequestBufByteArray();
                request.ContentLength = requestBuf.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(requestBuf, 0, requestBuf.Length);
            }
            return request;
        }

        private byte[] createRequestBufByteArray()
        {
            byte[] requestBody;
            UTF8Encoding encoding = new UTF8Encoding();
            requestBody = encoding.GetBytes(makeJSON(dataSetForRequestBody));
            return requestBody;
        }

        protected string makeJSON (Dictionary<string, string> dataSet)
        {
            string retJSON = "{";
            foreach (KeyValuePair<string, string> entry in dataSet)
            {
                string key = entry.Key;
                string value = entry.Value;

                retJSON += "\"" + key + "\":\"" + value + "\",";
            }
            retJSON = retJSON.Remove(retJSON.Length - 1);
            retJSON += "}";
            return retJSON;
        }
    }
}
