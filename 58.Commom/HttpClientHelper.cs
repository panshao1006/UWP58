using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _58.Commom
{
    /// <summary>
    /// HttpRequest and HttpRespone 帮助类
    /// </summary>
    public class HttpClientHelper
    {
        HttpWebRequest Requestor;

        public HttpClientHelper()
        {
            //this.Requestor = new HttpWebRequest();
        }

        public HttpClientHelper(string url)
        {

        }

        public async Task<HttpWebResponse> RequestData(string url)
        {
            HttpWebRequest requestor = (HttpWebRequest)WebRequest.Create(url);

            var response  = (HttpWebResponse)(await requestor.GetResponseAsync());

            return response;
        }
    }
}
