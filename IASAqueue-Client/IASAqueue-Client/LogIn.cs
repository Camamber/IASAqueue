using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IASAqueue_Client
{
    public partial class LogIn : Form
    {
        public Client client;
        public string IP;
        public LogIn(string ip)
        {
            InitializeComponent();
            IP = ip;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int port;
            IP = tb_IP.Text;
            if (tb_Username.Text.Length > 0)
            {
                if (int.TryParse(tb_Port.Text, out port))
                {
                    client = new Client(IP, port, tb_Username.Text);
                    string response = client.Connect();
                    lbl_Info.Text = response;
                    if(response == "Connected")
                    {
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    lbl_Info.Text = "Wrong port";
                }
            }
            else
            {
                lbl_Info.Text = "Enter username";
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        //Drag form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tb_IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tb_Username;   
            tb_IP.Text = IP;
        }

        private void tb_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btn_Login_Click(null, null);
        }
    }
}
