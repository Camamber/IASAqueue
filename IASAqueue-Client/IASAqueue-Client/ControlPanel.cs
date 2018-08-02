using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Client
{

    public partial class ControlPanel : Form
    {
        Client client;
        Stopwatch timer = new Stopwatch();
        string ip="127.0.0.1";
        public ControlPanel()
        {
            InitializeComponent();
        }
        private void ControlPanel_Load(object sender, EventArgs e)
        {
            
            Login();
            if (client != null)
                lbl_user.Text = client.Username;
        }

        private void Login()
        {
            timer_Update.Stop();
            using (LogIn login = new LogIn(ip))
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                {
                    client = login.client;
                    ip = login.IP;
                    lbl_abit.Text = "";
                }
                else
                    Close();               
            }
            timer_Update.Start();
        }
       
        private void btn_Next_Click(object sender, EventArgs e)
        {          
            StopTimers();
            lbl_abit.Text = client.SendCommand("Next", new Argument());
            if (lbl_abit.Text == "0")           
                lbl_abit.Text = "Nobody left";           
            else if(lbl_abit.Text == "Disconnected")
                ReLog();
            else
                StartTimers();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            int current;
            StopTimers();
            if (int.TryParse(lbl_abit.Text, out current))
            {
                lbl_abit.Text = client.SendCommand("Skip", new Argument() { Integers = current });

                if (lbl_abit.Text == "0")
                    lbl_abit.Text = "Nobody left";
                else if (lbl_abit.Text == "Disconnected")
                    ReLog();
                else
                    StartTimers();
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            client.SendCommand("Exit", new Argument());
            ReLog();
        }

        private void StopTimers()
        {
            timer.Stop();
            timer1.Stop();
            lbl_Timer.Text = "00:00:00";
        }

        private void StartTimers()
        {
            btn_Skip.Enabled = false;
            timer1.Stop();
            timer.Restart();
            timer1.Start();
        }

        private void CheckQueue()
        {
            string count = client.SendCommand("Queue", new Argument());
            if (count == "Disconnected")
                ReLog();
            else
                lbl_InQueue.Text = "In Queue: " + count;          
        }
        private void ReLog()
        {
            client.Disconnect();
            Login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          
            lbl_Timer.Text = timer.Elapsed.ToString(@"hh\:mm\:ss");
            if (timer.Elapsed >= new TimeSpan(0, 2, 0))
                btn_Skip.Enabled = true;
        }

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
                client.Disconnect();
        }

        private void timer_Update_Tick(object sender, EventArgs e)
        {
            CheckQueue();
        }

        private void btn_Maximized_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //Drag form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnl_ControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }

}