using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class User
    {
        private string login;
        private string number;
        private bool online;
        private int order;
        private int student;

        public event EventHandler UserOnline;
        protected virtual void OnUserOnline(EventArgs e)
        {
            if (UserOnline != null)
                UserOnline(this, e);
        }
        public User(string login, int order)
        {
            this.login = login;
            this.order = order; 
            this.online = false;
            student = 0;
        }

        public string Login
        {
            get { return login; }
        }
     
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public bool Online
        {
            get { return online; }
            set { online = value; OnUserOnline(new EventArgs()); }
        }

        public int Order
        {
            get { return order; }
        }

        public int Student
        {
            get { return student; }
            set { student = value; OnUserOnline(new EventArgs()); }
        }
    
        public bool isEmpty()
        {
            return login.Length == 0;
        }
    }
}
