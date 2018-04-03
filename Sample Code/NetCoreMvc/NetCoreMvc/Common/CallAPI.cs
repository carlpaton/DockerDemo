using Newtonsoft.Json;
using System;
using System.Net;

namespace NetCoreMvc.Common
{
    public class CallAPI
    {
        public static T Go<T>(string url) where T : new()
        {
            using (var wc = new WebClient())
            {
                var json = "";
                try
                {
                    wc.Headers.Add("Content-Type", "application/json; charset=utf-8");
                    //wc.Headers.Add("apikey", "someapikeyvalue");
                    json = wc.DownloadString(url);
                }
                catch (Exception ex)
                {
                    //LOG
                }

                var list = JsonConvert.DeserializeObject<T>(json);

                if (!string.IsNullOrEmpty(json))
                    return list;
                else
                    return new T();
            }
        }
    }
}
