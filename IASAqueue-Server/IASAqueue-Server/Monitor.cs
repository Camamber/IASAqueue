using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
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

        Model model;
        Operator[] operators;
        SoundPlayer notification;
        public Monitor(Model model)
        {
            InitializeComponent();
            this.model = model;
            
        }

        private void Monitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

      
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            timer.Start();
            notification = new SoundPlayer(Properties.Resources.not2);
            operators = new Operator[]{ new Operator(tableLayoutPanel3,label1), new Operator(tableLayoutPanel4, label2), new Operator(tableLayoutPanel5, label3), new Operator(tableLayoutPanel6, label4), new Operator(tableLayoutPanel7, label5) };
            foreach (User u in model.users.Values)
                u.UserOnline += Usr_UserOnline;
            model.queue.QueueUpdated += Queue_QueueUpdated;
            Reload();           
            this.Activate();
            this.Focus();
            tmr_Media.Interval = model.settings.Media_interval*1000;
            tmr_Media.Start();

        }

        private void Queue_QueueUpdated(object sender, EventArgs e)
        {

            notification.Play();
            if (!IsDisposed)
                BeginInvoke((MethodInvoker)(() => Reload()));
        }

        private void Usr_UserOnline(object sender, EventArgs e)
        {
            if (!IsDisposed)           
                BeginInvoke((MethodInvoker)(() => Reload()));
        }


        private void Reload()
        {
            lbl_Next.Text = "You are next: " + model.queue.Predict(3);
            lbl_Wait.Text = "Waiting time: " + model.queue.Average().ToString(@"hh\:mm\:ss");
            foreach (User u in model.users.Values)
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

        private void tmr_Media_Tick(object sender, EventArgs e)
        {
            if (model.media.Played && !model.media.isEmpty)
            {               
                pb_Media.BackgroundImage = Image.FromFile(model.media.Get());
                model.media.Current++;
            }
        }

        private void Monitor_ResizeBegin(object sender, EventArgs e)
        {
           
        }

        private void Monitor_Resize(object sender, EventArgs e)
        {
            lbl_Title.Font = new Font(FontFamily.GenericSansSerif, (float)(0.7 * lbl_Title.Height), GraphicsUnit.Pixel);
            lbl_Time.Font = lbl_Next.Font = lbl_Wait.Font = new Font(FontFamily.GenericSansSerif, (float)(0.57 * panel2.Height), GraphicsUnit.Pixel);
            lbl_title1.Font = lbl_title2.Font = lbl_title3.Font = lbl_title4.Font = lbl_title5.Font = new Font(FontFamily.GenericSansSerif, (float)(0.7 * lbl_title1.Height), GraphicsUnit.Pixel);
            label1.Font = label2.Font = label3.Font = label4.Font = label5.Font = new Font(FontFamily.GenericSansSerif, (float)(0.9 * label1.Height), GraphicsUnit.Pixel);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("dd MMMM, HH:mm");
        }
    }
}
