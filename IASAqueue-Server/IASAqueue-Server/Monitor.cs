using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{
    partial class Monitor : Form
    {
        GlobalVariables global;
        public Monitor(GlobalVariables global)
        {
            InitializeComponent();
            this.global = global;
        }

        private void Monitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.PrintLogs("#"+global.queue.Add().ToString()+" added to queue!");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.Focus();
        }
    }
}
