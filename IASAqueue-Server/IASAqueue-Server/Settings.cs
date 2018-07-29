using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class Settings
    {
        private string ip = "127.0.0.1";
        private int port;
        private string button_port;
        private string printer;
        private int media_interval=15;

        public string IP
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public int Media_interval
        {
            get
            {
                return media_interval;
            }

            set
            {
                media_interval = value;
            }
        }

        public Settings()
        {

        }
    }
}
