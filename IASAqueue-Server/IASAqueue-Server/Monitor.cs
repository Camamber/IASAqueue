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
        Model global;
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
            Reload();
            this.Activate();
            this.Focus();
        }

        private void Usr_UserOnline(object sender, EventArgs e)
        {
            Reload();
        }

        
        private void Reload()
        {
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            foreach (User usr in global.users.Values)
            {
                if (usr.Online)
                {
                    tableLayoutPanel1.ColumnCount++;
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.50F));
                }
                usr.UserOnline += Usr_UserOnline;
                
            }
            for (int i = 0; i < tableLayoutPanel1.ColumnCount - 1; i++)
            {
                tableLayoutPanel1.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, (int)((100 - 0.50) / (tableLayoutPanel1.ColumnCount - 1)));
                this.tableLayoutPanel1.BeginInvoke((MethodInvoker)(()=> this.tableLayoutPanel1.Controls.Add(new Label() { Text = global.users.Keys.ElementAt(i), ForeColor=Color.Yellow, Font = new Font(FontFamily.GenericSerif, 30), BackColor=Color.Transparent, Location = new Point((int)tableLayoutPanel1.ColumnStyles[i].Width/2, (int)tableLayoutPanel1.RowStyles[0].Height/2)}, i, 0)));
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
                if (e.Column < panel.ColumnCount - 1)
                    e.Graphics.DrawRectangle(pen, rectangle);
            }
        }
    }
}
