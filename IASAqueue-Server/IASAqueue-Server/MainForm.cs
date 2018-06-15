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
    public partial class MainForm : Form
    {
        Monitor monitor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            monitor = new Monitor();
        }

        private void btn_Monitor_Click(object sender, EventArgs e)
        {
            monitor.Close();
            monitor = new Monitor();
            monitor.Show();
        }

    }
}
