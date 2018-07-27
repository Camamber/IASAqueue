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
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int port;
            if (tb_Username.Text.Length > 0)
            {
                if (int.TryParse(tb_Port.Text, out port))
                {
                    client = new Client(port, tb_Username.Text);
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
    }
}
