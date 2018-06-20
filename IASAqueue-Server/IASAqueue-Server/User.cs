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
        private string password;
        private string number;
        private bool online;

        public event EventHandler UserOnline;
        protected virtual void OnUserOnline(EventArgs e)
        {
            if (UserOnline != null)
                UserOnline(this, e);
        }
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
            this.online = false;
        }

        public string Login
        {
            get { return login; }
        }

        public string Password
        {
            get { return password; }
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

        public bool isEmpty()
        {
            return login.Length == 0 && password.Length == 0;
        }
    }
}
