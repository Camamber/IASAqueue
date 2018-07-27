using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{


    partial class Monitor : Form
    {
        class Operator
        {
            public TableLayoutPanel panel;
            public Label number;
            public Operator(TableLayoutPanel panel, Label number)
            {
                this.panel = panel;
                this.number = number;
            }
        }

        Model global;
        Operator[] operators;
        public Monitor(Model global)
        {
            InitializeComponent();
            this.global = global;
            
        }

        private void Monitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global.PrintLogs("#" + global.queue.Add().ToString() + " added to queue!");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            operators = new Operator[]{ new Operator(tableLayoutPanel3,label1), new Operator(tableLayoutPanel4, label2), new Operator(tableLayoutPanel5, label3), new Operator(tableLayoutPanel6, label4), new Operator(tableLayoutPanel7, label5) };
            foreach (User u in global.users.Values)
                u.UserOnline += Usr_UserOnline;
            Reload();           
            this.Activate();
            this.Focus();
        }

        private void Usr_UserOnline(object sender, EventArgs e)
        {
            if (!IsDisposed)           
                BeginInvoke((MethodInvoker)(() => Reload()));
        }


        private void Reload()
        {
            lbl_Next.Text = "You are next: " + global.queue.Predict(3);
            lbl_Wait.Text = "Waiting time: " + global.queue.Average().ToString(@"hh\:mm\:ss");
            foreach (User u in global.users.Values)
            {
                operators[u.Order - 1].panel.Enabled = u.Online;
                operators[u.Order - 1].number.Text = u.Student > 0 ? u.Student.ToString() : "-";
            }
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var panel = sender as TableLayoutPanel;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var rectangle = e.CellBounds;
            using (var pen = new Pen(Color.Yellow, 1))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                if (e.Row == (panel.RowCount - 1))
                {
                    rectangle.Height -= 1;
                }

                if (e.Column == (panel.ColumnCount - 1))
                {
                    rectangle.Width -= 1;
                }
                if (e.Column < panel.ColumnCount)
                    e.Graphics.DrawRectangle(pen, rectangle);
            }
        }
    }
}
