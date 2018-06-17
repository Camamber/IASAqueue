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

        protected virtual void OnStatusChanged(EventArgs e)
        {
            if (StatusChanged != null)
                StatusChanged(this, e);
        }

        public Server(int port, RichTextBox richtextbox )
        {
            this.port = port;
            logger = richtextbox;
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            status = Status.Offline;
        }

        public void Start()
        {
            try
            {              
                listener.Start();
                GetSetStatus = Status.Online;
                this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text = ("Server is up. Waiting for clients...\n") + this.logger.Text));
                while (status == Status.Online)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject clientObject = new ClientObject(client, logger);

                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {               
                this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text  = (ex.Message+"\n") + this.logger.Text));            
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
                this.logger.BeginInvoke((MethodInvoker)(() => this.logger.Text = ("Server is down\n") + this.logger.Text));
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
