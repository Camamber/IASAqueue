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
        RichTextBox logger;
        public TcpClient client;
        User user;
        Dictionary<string, User> users = new Dictionary<string, User>() { {"Egor", new User() {password="123" } }, { "Gleb", new User() { password = "321" } } };
        public ClientObject(TcpClient tcpClient, RichTextBox richtextbox)
        {
            logger = richtextbox;
            client = tcpClient;
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
                        if (users.Keys.Contains(request))
                        {
                            user = users[request];
                            PrintLogs(request + " connected!");
                            response = "OK!";
                        }
                        else
                        {
                            response = "Wrong username";
                            PrintLogs("Unknown user: " + request);
                        }
                    }
                    else
                    {
                        Request message = JsonConvert.DeserializeObject<Request>(builder.ToString());

                        PrintLogs(message.Login + ": " + message.Message);
                        response = "Hi, " + message.Login + "! " + message.Message.ToUpper();
                    }

                    data = Encoding.UTF8.GetBytes(response);
                    stream.Write(data, 0, data.Length);
                }

            }
            catch (Exception ex)
            {
                PrintLogs(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
                if (client != null)
                    PrintLogs(user.login + " disconnected!");
            }
        }


        private void PrintLogs(string msg)
        {
            this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text = msg + "\n" + this.logger.Text));
        }
    }
}