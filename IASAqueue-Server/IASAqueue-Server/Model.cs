using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{

    class Model
    {
        public Dictionary<string, User> users;
        public Form monitor;
        public Queue queue;
        RichTextBox logger;
        
        public Model(RichTextBox rtb, Form monitor)
        {            
            users = new Dictionary<string, User>()
            {
                { "user1", new User("user1",1) },
                { "user2", new User("user2",2) },
                { "user3", new User("user3",3) },
                { "user4", new User("user4",4) },
                { "user5", new User("user5",5) }
            };
            queue = new Queue();
            logger = rtb;
            this.monitor = monitor;

        }
            
        public void PrintLogs(string msg)
        {
            this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text = msg + "\n" + this.logger.Text));
        }


    }
}