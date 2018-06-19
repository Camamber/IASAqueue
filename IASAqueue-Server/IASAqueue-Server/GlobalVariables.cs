using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{
    
    class GlobalVariables
    {
        public Dictionary<string, User> users;
        public Queue queue;
        RichTextBox logger;
        public GlobalVariables(RichTextBox rtb)
        {
            users = new Dictionary<string, User>()
            {
                { "Egor", new User("Egor", "123") },
                { "Gleb", new User("Gleb", "321") }
            };
            queue = new Queue();
            logger = rtb;
        }

        public void PrintLogs(string msg)
        {
            this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text = msg + "\n" + this.logger.Text));
        }
    }
}
