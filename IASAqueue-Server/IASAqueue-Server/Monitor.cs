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
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
        }

        private void Monitor_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Monitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
