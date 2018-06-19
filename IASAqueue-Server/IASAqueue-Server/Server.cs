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
        RichTextBox logger;
        public event EventHandler StatusChanged;
        GlobalVariables global;

        protected virtual void OnStatusChanged(EventArgs e)
        {
            if (StatusChanged != null)
                StatusChanged(this, e);
        }

        public Server(int port, RichTextBox richtextbox, GlobalVariables global )
        {
            this.port = port;
            logger = richtextbox;
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            status = Status.Offline;
            this.global = global;
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
                    ClientObject clientObject = new ClientObject(client, global);

                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                global.PrintLogs(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
                global.PrintLogs("Server is down");
                GetSetStatus = Status.Offline;
            }
        }

        public void Stop()
        {
            status = Status.Offline;
            listener.Stop();
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
    }
}
