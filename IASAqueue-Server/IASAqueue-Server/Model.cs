using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{

    class Model
    {
        public Dictionary<string, User> users;
        public Queue queue;
        RichTextBox logger;
        public Settings settings;
        public Media media;
        public SerialPort mySerialPort;
        public Printer printer;
        public WebGUI webgui;
        public Model(RichTextBox rtb)
        {
            logger = rtb;
            users = new Dictionary<string, User>()
            {
                { "user1", new User("user1",1) },
                { "user2", new User("user2",2) },
                { "user3", new User("user3",3) },
                { "user4", new User("user4",4) },
                { "user5", new User("user5",5) }
            };
            queue = new Queue();
            settings = new Settings();           
            media = new Media();
            mySerialPort = new SerialPort();
            printer = new Printer("");
            webgui = new WebGUI();
        }

            
        public void PrintLogs(string msg)
        {
            this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text = msg + "\n" + this.logger.Text));
        }
    }
}