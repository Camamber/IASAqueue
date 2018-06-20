using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace IASAqueue_Server
{   
    class Request
    {
        public string Login;
        public string Message;
    }

    class ClientObject
    {
        public TcpClient client;
        User user;
        Model global;
        public ClientObject(TcpClient tcpClient, Model global)
        {
            client = tcpClient;
            this.global = global;
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[1024];
                while (true)
                {
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    string response = "";
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                    string request = builder.ToString();

                    if (user == null)
                    {
                        if (global.users.Keys.Contains(request))
                        {
                            user = global.users[request];
                            user.Online = true;
                            global.PrintLogs(request + " connected!");                      
                            response = "OK!";
                        }
                        else
                        {
                            response = "Wrong username";
                            global.PrintLogs("Unknown user: " + request);
                        }
                    }
                    else
                    {
                        Request message = JsonConvert.DeserializeObject<Request>(builder.ToString());

                        global.PrintLogs(message.Login + ": " + message.Message);
                        if(message.Message.Equals("Next"))
                        {
                            response = global.queue.Next().ToString();
                        }
                        else
                        {
                            response = "Unknown command!";
                        }
                       
                    }

                    data = Encoding.UTF8.GetBytes(response);
                    stream.Write(data, 0, data.Length);
                }

            }
            catch (Exception ex)
            {
                global.PrintLogs(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
                if (client != null)
                {
                    global.PrintLogs(user.Login + " disconnected!");
                    user.Online = false;
                }

            }
        }   
    }
}