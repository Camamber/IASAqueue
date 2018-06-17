using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IASAqueue_Server
{
    class User
    {
        public string login;
        public string password;
        public bool isEmpty()
        {
            return login.Length == 0 && password.Length == 0;
        }
    }
}
