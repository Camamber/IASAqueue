using System;
using System.Collections.Generic;
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
                { "Egor", new User("Egor", "123") },
                { "Gleb", new User("Gleb", "321") },
                { "Sasha", new User("Sasha", "123") },
                { "xyi", new User("xyi", "321") }
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
