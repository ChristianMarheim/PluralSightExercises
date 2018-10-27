using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

namespace RestTest
{
    public class Rest
    {
        private static readonly HttpClient client = new HttpClient();

        public async void DoPost()
        {
            var values = new Dictionary<string, string>
            {
                { "thing1", "hello" },
                { "thing2", "world" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }


        public void DoGetWebpage()
        {
            Get("http://google.no");
        }

        private void Get(string url)
        {
            string html = string.Empty;
            //string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);
        }
    }
}