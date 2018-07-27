using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace IASAqueue_Client
{
    class Request
    {
        public string Login;
        public string Command;
        public Argument Arguments;
    }
    public class Argument
    {
        public int Integers;
        public string Strings;
    }


    public class Client
    {
        TcpClient client;
        private NetworkStream stream;
        private int port;
        const string address = "127.0.0.1";
        private string username;

        public Client(int port, string username)
        {
            this.port = port;
            this.username = username;

        }
        public string Connect()
        {
            try
            {
                client = new TcpClient(address, port);
                stream = client.GetStream();
                string response = SendCommand("Login", new Argument());
                if (response != "Connected")
                {
                    stream.Close();
                    client.Close();
                }
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }


        public string SendCommand(string command, Argument arg)
        {
            Request request = new Request { Login = username, Command = command, Arguments = arg };

            try
            {
                byte[] data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(request));
                stream.Write(data, 0, data.Length);
                return RecieveMsg();
            }
            catch
            {
                Disconnect();
                return "Disconnected";
            }
        }

        private string RecieveMsg()
        {

            // получаем ответ
            byte[] data = new byte[1024]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            return builder.ToString();
        }

        public string Username
        {
            get { return username; }
        }
    }
}
