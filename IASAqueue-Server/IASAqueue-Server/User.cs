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
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        public bool isEmpty()
        {
            return login.Length == 0 && password.Length == 0;
        }
    }
}
