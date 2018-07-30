using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class WebGUI
    {
        const string tg_url = "https://api.telegram.org/bot{0}/{1}";
        string token;
        string url;
        int message_id;
        string channel;
        string text;
        private static readonly HttpClient client = new HttpClient();
        public WebGUI()
        {

        }
        public WebGUI(string token, string url, string channel)
        {
            this.token = token;
            this.channel = channel;
            this.url = url;
            message_id = 0;
        }
        public void Update(string msg)
        {
            if (message_id != 0 && this.text!=msg)
            {
                this.text = msg;
                var values = new Dictionary<string, string>
                {
                    { "chat_id", channel },
                    { "message_id",message_id.ToString()},
                     { "text", msg },
                    { "parse_mode", "Markdown" }
                };

                var content = new FormUrlEncodedContent(values);
                var response = client.PostAsync(String.Format(tg_url, token, "editMessageText"), content);

                //using (WebClient wc = new WebClient())
                //{
                //    var values = new NameValueCollection();                   
                //    values["chat_id"] = channel;
                //    values["message_id"] = message_id.ToString();
                //    values["text"] = msg;
                //    values["parse_mode"] = "Markdown";

                //    var response = wc.UploadValues((), values);                 
                //}
            }
        }

        public void Post(string msg)
        {         
            using (WebClient wc = new WebClient())
            {
                try
                {
                    JObject rss = JObject.Parse(wc.DownloadString(String.Format(tg_url, token, "sendMessage?chat_id=" + channel + "&text=" + msg + "&parse_mode=Markdown")));
                    message_id = (int)rss["result"]["message_id"];
                    this.text = msg;
                }
                catch
                {

                }                             
            }
        }
    }
}
