using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class WebGUI
    {
        const string tg_url = "https://api.telegram.org/bot{0}/{1}";
        string token;
        string msg_id;      
        string url;
        public WebGUI(string token, string url)
        {
            this.token = token;
            this.url = url;
        }
        public void Update()
        {
            using (WebClient wc = new WebClient())
            {

            }
        }
    }
}
