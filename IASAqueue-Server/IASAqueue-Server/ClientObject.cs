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
        public string Command;
        public Argument Arguments;
    }
    class Argument
    {
        public int Integers;
        public string Strings;
    }

    class ClientObject
    {
        TcpClient client;
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
            bool loop = true;
            byte[] data = new byte[1024];

            try
            {
                stream = client.GetStream();
                while (loop)
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
                    if (request == "")
                        continue;

                    Request message = JsonConvert.DeserializeObject<Request>(builder.ToString());
                    global.PrintLogs(message.Login + ": " + message.Command);

                    switch (message.Command)
                    {
                        case "Login":
                            if (global.users.Keys.Contains(message.Login) && !global.users[message.Login].Online)
                            {
                                user = global.users[message.Login];
                                user.Online = true;
                                global.PrintLogs(message.Login + " connected!");
                                response = "Connected";
                            }
                            else
                            {
                                response = "Wrong username or user already logged in";
                                global.PrintLogs("Unknown user: " + message.Login);
                            }
                            break;
                        case "Next":
                            user.Student = global.queue.Next();
                            response = user.Student.ToString();
                            break;
                        case "Skip":
                            user.Student = global.queue.Skip(message.Arguments.Integers);
                            response = user.Student.ToString();
                            break;
                        case "Queue":
                            response = global.queue.Length.ToString();
                            break;
                        case "Exit":
                            loop = false;
                            user.Student = 0;
                            response = "Goodbye";
                            break;
                        default:
                            response = "Unknown command!";
                            break;
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
                if (user != null)
                {
                    global.PrintLogs(user.Login + " disconnected!");
                    user.Online = false;
                }
            }
        }   
    }
}