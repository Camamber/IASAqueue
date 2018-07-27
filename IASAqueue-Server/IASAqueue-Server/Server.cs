using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{
    class Server
    {
        private Status status;
        int port;
        static TcpListener listener;
        List<TcpClient> clients;
        public event EventHandler StatusChanged;
        Model global;
     
        public Server(int port, Model global )
        {
            this.port = port;
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            status = Status.Offline;
            this.global = global;
            clients = new List<TcpClient>();
        }

        public void Start()
        {
            try
            {              
                listener.Start();
                GetSetStatus = Status.Online;
                global.PrintLogs("Server is up. Waiting for clients...");
                while (status == Status.Online)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client);
                    ClientObject clientObject = new ClientObject(client, global);

                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();

                    List<TcpClient> cl = clients.FindAll(x => x.Connected == false);
                    foreach (TcpClient c in cl)
                        clients.Remove(c);
                }
            }
            catch (Exception ex)
            {
                global.PrintLogs(ex.Message);
            }
            finally
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (listener != null)
                listener.Stop();
            GetSetStatus = Status.Offline;

            if (clients.Count > 0)
            {
                foreach (TcpClient c in clients)
                {
                    if (c.Connected)
                        c.Close();
                }
            }
            clients.Clear();
        }

        public Status GetSetStatus
        {
            get { return status; }
            set
            {
                status = value;
                OnStatusChanged(new EventArgs());
            }
        }

        protected virtual void OnStatusChanged(EventArgs e)
        {
            if (StatusChanged != null)
                StatusChanged(this, e);
        }
    }
}
