using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{
    public enum Status { Online, Offline, Paused }

    public partial class MainForm : Form
    {
        Monitor monitor;
        Screen screen;
        Screen[] screens;
        Server server;
        Model model;

        Button active;
        string autosavingPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            model = new Model(rtb_Logs);
            model.mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceviedHandler);
            model.queue.QueueUpdated += Queue_QueueUpdated;
            model.media.MediaUpdated += Media_MediaUpdated;

            monitor = new Monitor(model);

            Refresh_DisplaysList();
            Refresh_ButtonPortsList();
            Refresh_PrintersList();
            lbl_inQueue.Text = "0";
            lbl_Uptime.Text = "00:00:00";
            nUD_AutosaveInterval.Value = 5;
            tb_AutosavePath.Text = Environment.CurrentDirectory;
            active = btn_Dashboard;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server != null && server.GetSetStatus == Status.Online)
            {
                server.Stop();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //Dashboard

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(tb_Port.Text, out port))
            {
                server = new Server(port, model);
                server.StatusChanged += Server_StatusChanged;
                Thread thread = new Thread(server.Start);
                thread.Start();
            }
            else
            {
                rtb_Logs.Text = "Wrong port...\n" + rtb_Logs.Text;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            server.Stop();
            rtb_Logs.Text = "Server is down\n" + rtb_Logs.Text;
        }

        private void btn_Monitor_Click(object sender, EventArgs e)
        {
            Rectangle bounds = screen.Bounds;
            monitor = new Monitor(model);
            monitor.StartPosition = FormStartPosition.Manual;
            monitor.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            monitor.Show();
        }

        private void Server_StatusChanged(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => this.Refresh_Status()));
        }

        private void Refresh_Status()
        {
            if (server.GetSetStatus == Status.Offline)
            {
                lbl_Status.ForeColor = Color.Red;
                lbl_Status.Text = "Offline";
                btn_Stop.Visible = false;
                btn_Start.Visible = true;
            }
            else if (server.GetSetStatus == Status.Online)
            {

                lbl_Status.ForeColor = Color.Green;
                lbl_Status.Text = "Online";
                btn_Stop.Visible = true;
                btn_Start.Visible = false;
            }
        }



        //Queue

        private void Queue_QueueUpdated(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => this.UpdateQueueList()));
        }

        private void DataReceviedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            int i = model.queue.Add();
            model.PrintLogs("#" + i.ToString() + " added to queue!");
            model.printer.Print(i);
        }

        private void btn_SaveQueue_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JSON file|*.json";
            saveFileDialog1.Title = "Save queue";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                model.queue.Serialize(saveFileDialog1.FileName);
            }
        }

        private void btn_LoadQueue_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "JSON file|*.json";
            openFileDialog1.Title = "Load queue";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                model.queue.Deserialize(openFileDialog1.FileName);
            }
        }

        private void tb_AddQueue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_AddQueue_TextChanged(object sender, EventArgs e)
        {
            btn_AddQueue.Enabled = (sender as TextBox).Text.Length > 0;
        }

        private void lb_Queue_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_RemoveQueue.Enabled = (sender as ListBox).SelectedItem != null;
            btn_UpQueue.Enabled = (sender as ListBox).SelectedItem != null;
            btn_DownQueue.Enabled = (sender as ListBox).SelectedItem != null;
            btn_PrintQueue.Enabled = (sender as ListBox).SelectedItem != null;
        }

        private void btn_AddQueue_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(tb_AddQueue.Text, out i))
            {
                if (!model.queue.isContain(i))
                {
                    model.queue.Add(i);
                    rtb_Logs.Text = "#" + i.ToString() + " added to queue!\n" + rtb_Logs.Text;
                }
            }
        }

        private void btn_UpQueue_Click(object sender, EventArgs e)
        {
            int i = lb_Queue.SelectedIndex;
            if (int.TryParse(lb_Queue.Text, out i))
            {
                if (model.queue.isContain(i))
                {
                    i = model.queue.Move(i, -1);
                }
            }

            lb_Queue.SelectedIndex = i;
        }

        private void btn_DownQueue_Click(object sender, EventArgs e)
        {
            int i = lb_Queue.SelectedIndex;
            if (int.TryParse(lb_Queue.Text, out i))
            {
                if (model.queue.isContain(i))
                {
                    i = model.queue.Move(i, 1);
                }
            }
            lb_Queue.SelectedIndex = i;

        }

        private void btn_RemoveQueue_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(lb_Queue.Text, out i))
            {
                if (model.queue.isContain(i))
                {
                    model.queue.Remove(i);
                    rtb_Logs.Text = "#" + i.ToString() + " removed from queue!\n" + rtb_Logs.Text;
                }
            }
        }


        private void btn_PrintQueue_Click(object sender, EventArgs e)
        {
            if (lb_Queue.SelectedItem != null)
            {
                int i = 0;
                if (int.TryParse(lb_Queue.Text, out i))
                    model.printer.Print(i);
            }
        }

        private void UpdateQueueList()
        {
            lb_Queue.Items.Clear();
            lb_Queue.Items.AddRange(model.queue.QueueArr.Cast<object>().ToArray());
        }



        //Media

        private void Media_MediaUpdated(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => this.UpdateMediaList()));
        }

        private void btn_AddMedia_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog1.Title = "Select media";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                model.media.Add(openFileDialog1.FileNames);
            }
        }
        private void btn_RemoveMedia_Click(object sender, EventArgs e)
        {
            model.media.Remove(lb_Media.SelectedIndex);
        }

        private void lb_Media_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_RemoveMedia.Enabled = (sender as ListBox).SelectedItem != null;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.settings.Media_interval = (int)(sender as NumericUpDown).Value;
        }

        private void UpdateMediaList()
        {
            lb_Media.Items.Clear();
            lb_Media.Items.AddRange(model.media.MediaArr.Cast<object>().ToArray());
            lb_Media.SelectedIndex = model.media.Current;
        }



        //Settings           

        private void Refresh_ButtonPortsList()
        {
            cb_COMPorts.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                cb_COMPorts.Items.Add(s);

            if (cb_COMPorts.Items.Count > 0)
            {
                cb_COMPorts.SelectedIndex = 0;

            }
        }

        private void Refresh_DisplaysList()
        {
            screens = Screen.AllScreens;
            cb_Displays.Items.Clear();
            foreach (Screen scr in screens)
                cb_Displays.Items.Add(scr.DeviceName);
            cb_Displays.SelectedIndex = cb_Displays.Items.Count - 1;
        }

        private void Refresh_PrintersList()
        {
            cb_Printers.Items.Clear();
            foreach (string scr in Printer.GetPrinters())
                cb_Printers.Items.Add(scr);
            cb_Printers.SelectedIndex = 0;
        }

        private void cb_COMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.mySerialPort.Close();

            model.mySerialPort.PortName = cb_COMPorts.SelectedItem.ToString();
            model.mySerialPort.BaudRate = 9600;
            model.mySerialPort.Parity = Parity.None;
            model.mySerialPort.StopBits = StopBits.One;
            model.mySerialPort.DataBits = 8;
            model.mySerialPort.Handshake = Handshake.None;

            model.mySerialPort.Open();
        }

        private void cb_Displays_SelectedIndexChanged(object sender, EventArgs e)
        {
            screen = screens[cb_Displays.SelectedIndex];
        }

        private void cb_Printers_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.printer = new Printer(cb_Printers.SelectedItem.ToString());
        }

        private void btn_RButtonPorts_Click(object sender, EventArgs e)
        {
            Refresh_ButtonPortsList();
        }

        private void btn_RDisplays_Click(object sender, EventArgs e)
        {
            Refresh_DisplaysList();
        }

        private void btn_RPrinters_Click(object sender, EventArgs e)
        {
            Refresh_PrintersList();
        }


        //Tabs

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            active.BackColor = Color.FromArgb(25, 118, 210);
            btn_Dashboard.BackColor = Color.FromArgb(19, 90, 161);
            active = (Button)sender;
            tabControl1.SelectedIndex = 0;
        }

        private void btn_Queue_Click(object sender, EventArgs e)
        {
            active.BackColor = Color.FromArgb(25, 118, 210);
            btn_Queue.BackColor = Color.FromArgb(19, 90, 161);
            active = (Button)sender;
            tabControl1.SelectedIndex = 1;
        }

        private void btn_Media_Click(object sender, EventArgs e)
        {
            active.BackColor = Color.FromArgb(25, 118, 210);
            btn_Media.BackColor = Color.FromArgb(19, 90, 161);
            active = (Button)sender;
            tabControl1.SelectedIndex = 2;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            active.BackColor = Color.FromArgb(25, 118, 210);
            btn_Settings.BackColor = Color.FromArgb(19, 90, 161);
            active = (Button)sender;
            tabControl1.SelectedIndex = 3;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            active.BackColor = Color.FromArgb(25, 118, 210);
            btn_About.BackColor = Color.FromArgb(19, 90, 161);
            active = (Button)sender;
            tabControl1.SelectedIndex = 4;

        }



        //Autosave

        private void btn_AutosavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_AutosavePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tb_btn_AutosavePath_TextChanged(object sender, EventArgs e)
        {
            autosavingPath = tb_AutosavePath.Text;
        }

        private void tmr_Autosaver_Tick(object sender, EventArgs e)
        {
            model.queue.Serialize(autosavingPath + @"\" + DateTime.Now.ToString(@"MM-dd-yyyy HH-mm") + ".json");
        }

        private void nUD_AutosaveInterval_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_AutosaveInterval.Value > 0)
            {
                tmr_Autosaver.Interval = (int)nUD_AutosaveInterval.Value * 60;
                tmr_Autosaver.Start();
            }
            else
                tmr_Autosaver.Stop();
        }

        private void tb_IP_TextChanged(object sender, EventArgs e)
        {
            model.settings.IP = tb_IP.Text;
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
