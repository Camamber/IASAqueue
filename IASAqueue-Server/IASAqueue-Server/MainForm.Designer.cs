namespace IASAqueue_Server
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtb_Logs = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Monitor = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lbl_inQueue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Uptime = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Dashboard = new System.Windows.Forms.TabPage();
            this.tab_Queue = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_LoadQueue = new System.Windows.Forms.Button();
            this.btn_SaveQueue = new System.Windows.Forms.Button();
            this.tab_Media = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tab_Settings = new System.Windows.Forms.TabPage();
            this.btn_AutosavePath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nUD_AutosaveInterval = new System.Windows.Forms.NumericUpDown();
            this.tb_AutosavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Setting_IP = new System.Windows.Forms.Label();
            this.cb_Printers = new System.Windows.Forms.ComboBox();
            this.lbl_Settings_Printer = new System.Windows.Forms.Label();
            this.lbl_Settings_Display = new System.Windows.Forms.Label();
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.btn_RefreshMonitor = new System.Windows.Forms.Button();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.cb_Displays = new System.Windows.Forms.ComboBox();
            this.lbl_Setting_Port = new System.Windows.Forms.Label();
            this.cb_COMPorts = new System.Windows.Forms.ComboBox();
            this.lbl_Settings_ButtonPorts = new System.Windows.Forms.Label();
            this.btn_RButtonPorts = new System.Windows.Forms.Button();
            this.btn_RDisplays = new System.Windows.Forms.Button();
            this.btn_RPrinters = new System.Windows.Forms.Button();
            this.tab_About = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.pnl_ControlBox = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Media = new System.Windows.Forms.Button();
            this.btn_Queue = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tmr_Autosaver = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Dashboard.SuspendLayout();
            this.tab_Queue.SuspendLayout();
            this.tab_Media.SuspendLayout();
            this.tab_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AutosaveInterval)).BeginInit();
            this.tab_About.SuspendLayout();
            this.pnl_ControlBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Logs
            // 
            this.rtb_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Logs.Location = new System.Drawing.Point(3, 255);
            this.rtb_Logs.Name = "rtb_Logs";
            this.rtb_Logs.ReadOnly = true;
            this.rtb_Logs.Size = new System.Drawing.Size(560, 123);
            this.rtb_Logs.TabIndex = 1;
            this.rtb_Logs.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_Dashboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Logs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.34146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.65854F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 381);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.btn_Start);
            this.pnl_Dashboard.Controls.Add(this.label14);
            this.pnl_Dashboard.Controls.Add(this.btn_Monitor);
            this.pnl_Dashboard.Controls.Add(this.btn_Stop);
            this.pnl_Dashboard.Controls.Add(this.lbl_inQueue);
            this.pnl_Dashboard.Controls.Add(this.label2);
            this.pnl_Dashboard.Controls.Add(this.label4);
            this.pnl_Dashboard.Controls.Add(this.label1);
            this.pnl_Dashboard.Controls.Add(this.lbl_Uptime);
            this.pnl_Dashboard.Controls.Add(this.lbl_Status);
            this.pnl_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(566, 252);
            this.pnl_Dashboard.TabIndex = 3;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(13, 190);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(101, 36);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "Dashboard";
            // 
            // btn_Monitor
            // 
            this.btn_Monitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_Monitor.FlatAppearance.BorderSize = 0;
            this.btn_Monitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Monitor.ForeColor = System.Drawing.Color.White;
            this.btn_Monitor.Location = new System.Drawing.Point(120, 190);
            this.btn_Monitor.Name = "btn_Monitor";
            this.btn_Monitor.Size = new System.Drawing.Size(133, 36);
            this.btn_Monitor.TabIndex = 11;
            this.btn_Monitor.Text = "Open monitor";
            this.btn_Monitor.UseVisualStyleBackColor = false;
            this.btn_Monitor.Click += new System.EventHandler(this.btn_Monitor_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(13, 190);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(101, 36);
            this.btn_Stop.TabIndex = 10;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lbl_inQueue
            // 
            this.lbl_inQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_inQueue.Location = new System.Drawing.Point(164, 111);
            this.lbl_inQueue.Name = "lbl_inQueue";
            this.lbl_inQueue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_inQueue.Size = new System.Drawing.Size(65, 20);
            this.lbl_inQueue.TabIndex = 5;
            this.lbl_inQueue.Text = "4000";
            this.lbl_inQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "People in a queue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Uptime: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server status:";
            // 
            // lbl_Uptime
            // 
            this.lbl_Uptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Uptime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Uptime.Location = new System.Drawing.Point(153, 76);
            this.lbl_Uptime.Name = "lbl_Uptime";
            this.lbl_Uptime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Uptime.Size = new System.Drawing.Size(76, 20);
            this.lbl_Uptime.TabIndex = 5;
            this.lbl_Uptime.Text = "12:10:25";
            this.lbl_Uptime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Status.Location = new System.Drawing.Point(170, 45);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Status.Size = new System.Drawing.Size(59, 20);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "None";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tab_Dashboard);
            this.tabControl1.Controls.Add(this.tab_Queue);
            this.tabControl1.Controls.Add(this.tab_Media);
            this.tabControl1.Controls.Add(this.tab_Settings);
            this.tabControl1.Controls.Add(this.tab_About);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(253, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 396);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tab_Dashboard
            // 
            this.tab_Dashboard.Controls.Add(this.tableLayoutPanel1);
            this.tab_Dashboard.Location = new System.Drawing.Point(4, 5);
            this.tab_Dashboard.Name = "tab_Dashboard";
            this.tab_Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Dashboard.Size = new System.Drawing.Size(572, 387);
            this.tab_Dashboard.TabIndex = 0;
            this.tab_Dashboard.Text = "Dashboard";
            this.tab_Dashboard.UseVisualStyleBackColor = true;
            // 
            // tab_Queue
            // 
            this.tab_Queue.Controls.Add(this.label15);
            this.tab_Queue.Controls.Add(this.button5);
            this.tab_Queue.Controls.Add(this.btn_LoadQueue);
            this.tab_Queue.Controls.Add(this.btn_SaveQueue);
            this.tab_Queue.Location = new System.Drawing.Point(4, 5);
            this.tab_Queue.Name = "tab_Queue";
            this.tab_Queue.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Queue.Size = new System.Drawing.Size(572, 387);
            this.tab_Queue.TabIndex = 1;
            this.tab_Queue.Text = "Queue";
            this.tab_Queue.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Queue";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(189, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Export Data";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btn_LoadQueue
            // 
            this.btn_LoadQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_LoadQueue.FlatAppearance.BorderSize = 0;
            this.btn_LoadQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadQueue.ForeColor = System.Drawing.Color.White;
            this.btn_LoadQueue.Location = new System.Drawing.Point(383, 124);
            this.btn_LoadQueue.Name = "btn_LoadQueue";
            this.btn_LoadQueue.Size = new System.Drawing.Size(95, 34);
            this.btn_LoadQueue.TabIndex = 4;
            this.btn_LoadQueue.Text = "Load";
            this.btn_LoadQueue.UseVisualStyleBackColor = false;
            this.btn_LoadQueue.Click += new System.EventHandler(this.btn_LoadQueue_Click);
            // 
            // btn_SaveQueue
            // 
            this.btn_SaveQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_SaveQueue.FlatAppearance.BorderSize = 0;
            this.btn_SaveQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveQueue.ForeColor = System.Drawing.Color.White;
            this.btn_SaveQueue.Location = new System.Drawing.Point(111, 124);
            this.btn_SaveQueue.Name = "btn_SaveQueue";
            this.btn_SaveQueue.Size = new System.Drawing.Size(95, 34);
            this.btn_SaveQueue.TabIndex = 3;
            this.btn_SaveQueue.Text = "Save";
            this.btn_SaveQueue.UseVisualStyleBackColor = false;
            this.btn_SaveQueue.Click += new System.EventHandler(this.btn_SaveQueue_Click);
            // 
            // tab_Media
            // 
            this.tab_Media.Controls.Add(this.label16);
            this.tab_Media.Location = new System.Drawing.Point(4, 5);
            this.tab_Media.Name = "tab_Media";
            this.tab_Media.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Media.Size = new System.Drawing.Size(572, 387);
            this.tab_Media.TabIndex = 2;
            this.tab_Media.Text = "Media";
            this.tab_Media.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 24);
            this.label16.TabIndex = 15;
            this.label16.Text = "Media";
            // 
            // tab_Settings
            // 
            this.tab_Settings.Controls.Add(this.btn_AutosavePath);
            this.tab_Settings.Controls.Add(this.label5);
            this.tab_Settings.Controls.Add(this.nUD_AutosaveInterval);
            this.tab_Settings.Controls.Add(this.tb_AutosavePath);
            this.tab_Settings.Controls.Add(this.label3);
            this.tab_Settings.Controls.Add(this.lbl_Setting_IP);
            this.tab_Settings.Controls.Add(this.cb_Printers);
            this.tab_Settings.Controls.Add(this.lbl_Settings_Printer);
            this.tab_Settings.Controls.Add(this.lbl_Settings_Display);
            this.tab_Settings.Controls.Add(this.lbl_Settings);
            this.tab_Settings.Controls.Add(this.btn_RefreshMonitor);
            this.tab_Settings.Controls.Add(this.tb_IP);
            this.tab_Settings.Controls.Add(this.tb_Port);
            this.tab_Settings.Controls.Add(this.cb_Displays);
            this.tab_Settings.Controls.Add(this.lbl_Setting_Port);
            this.tab_Settings.Controls.Add(this.cb_COMPorts);
            this.tab_Settings.Controls.Add(this.lbl_Settings_ButtonPorts);
            this.tab_Settings.Controls.Add(this.btn_RButtonPorts);
            this.tab_Settings.Controls.Add(this.btn_RDisplays);
            this.tab_Settings.Controls.Add(this.btn_RPrinters);
            this.tab_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tab_Settings.Location = new System.Drawing.Point(4, 5);
            this.tab_Settings.Name = "tab_Settings";
            this.tab_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Settings.Size = new System.Drawing.Size(572, 387);
            this.tab_Settings.TabIndex = 3;
            this.tab_Settings.Text = "Settings";
            this.tab_Settings.UseVisualStyleBackColor = true;
            // 
            // btn_AutosavePath
            // 
            this.btn_AutosavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_AutosavePath.FlatAppearance.BorderSize = 0;
            this.btn_AutosavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AutosavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AutosavePath.ForeColor = System.Drawing.Color.White;
            this.btn_AutosavePath.Location = new System.Drawing.Point(442, 233);
            this.btn_AutosavePath.Name = "btn_AutosavePath";
            this.btn_AutosavePath.Size = new System.Drawing.Size(26, 26);
            this.btn_AutosavePath.TabIndex = 28;
            this.btn_AutosavePath.Text = "...";
            this.btn_AutosavePath.UseVisualStyleBackColor = false;
            this.btn_AutosavePath.Click += new System.EventHandler(this.btn_AutosavePath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "min.";
            // 
            // nUD_AutosaveInterval
            // 
            this.nUD_AutosaveInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUD_AutosaveInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nUD_AutosaveInterval.Location = new System.Drawing.Point(103, 233);
            this.nUD_AutosaveInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_AutosaveInterval.Name = "nUD_AutosaveInterval";
            this.nUD_AutosaveInterval.Size = new System.Drawing.Size(57, 26);
            this.nUD_AutosaveInterval.TabIndex = 26;
            this.nUD_AutosaveInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_AutosaveInterval.ValueChanged += new System.EventHandler(this.nUD_AutosaveInterval_ValueChanged);
            // 
            // tb_AutosavePath
            // 
            this.tb_AutosavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_AutosavePath.Location = new System.Drawing.Point(200, 233);
            this.tb_AutosavePath.Name = "tb_AutosavePath";
            this.tb_AutosavePath.Size = new System.Drawing.Size(245, 26);
            this.tb_AutosavePath.TabIndex = 25;
            this.tb_AutosavePath.TextChanged += new System.EventHandler(this.tb_btn_AutosavePath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Autosave: ";
            // 
            // lbl_Setting_IP
            // 
            this.lbl_Setting_IP.AutoSize = true;
            this.lbl_Setting_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Setting_IP.Location = new System.Drawing.Point(6, 50);
            this.lbl_Setting_IP.Name = "lbl_Setting_IP";
            this.lbl_Setting_IP.Size = new System.Drawing.Size(78, 20);
            this.lbl_Setting_IP.TabIndex = 19;
            this.lbl_Setting_IP.Text = "Server IP:";
            // 
            // cb_Printers
            // 
            this.cb_Printers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Printers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Printers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cb_Printers.FormattingEnabled = true;
            this.cb_Printers.Location = new System.Drawing.Point(103, 186);
            this.cb_Printers.Name = "cb_Printers";
            this.cb_Printers.Size = new System.Drawing.Size(91, 28);
            this.cb_Printers.TabIndex = 18;
            this.cb_Printers.SelectedIndexChanged += new System.EventHandler(this.cb_Printers_SelectedIndexChanged);
            // 
            // lbl_Settings_Printer
            // 
            this.lbl_Settings_Printer.AutoSize = true;
            this.lbl_Settings_Printer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Settings_Printer.Location = new System.Drawing.Point(6, 189);
            this.lbl_Settings_Printer.Name = "lbl_Settings_Printer";
            this.lbl_Settings_Printer.Size = new System.Drawing.Size(59, 20);
            this.lbl_Settings_Printer.TabIndex = 17;
            this.lbl_Settings_Printer.Text = "Printer:";
            // 
            // lbl_Settings_Display
            // 
            this.lbl_Settings_Display.AutoSize = true;
            this.lbl_Settings_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Settings_Display.Location = new System.Drawing.Point(6, 142);
            this.lbl_Settings_Display.Name = "lbl_Settings_Display";
            this.lbl_Settings_Display.Size = new System.Drawing.Size(64, 20);
            this.lbl_Settings_Display.TabIndex = 15;
            this.lbl_Settings_Display.Text = "Display:";
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.AutoSize = true;
            this.lbl_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Settings.Location = new System.Drawing.Point(6, 3);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(84, 24);
            this.lbl_Settings.TabIndex = 14;
            this.lbl_Settings.Text = "Settings";
            // 
            // btn_RefreshMonitor
            // 
            this.btn_RefreshMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_RefreshMonitor.FlatAppearance.BorderSize = 0;
            this.btn_RefreshMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RefreshMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RefreshMonitor.ForeColor = System.Drawing.Color.White;
            this.btn_RefreshMonitor.Location = new System.Drawing.Point(259, 139);
            this.btn_RefreshMonitor.Name = "btn_RefreshMonitor";
            this.btn_RefreshMonitor.Size = new System.Drawing.Size(131, 28);
            this.btn_RefreshMonitor.TabIndex = 13;
            this.btn_RefreshMonitor.Text = "Refresh monitor";
            this.btn_RefreshMonitor.UseVisualStyleBackColor = false;
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tb_IP.Location = new System.Drawing.Point(103, 47);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(91, 26);
            this.tb_IP.TabIndex = 3;
            this.tb_IP.Text = "127.0.0.1";
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tb_Port.Location = new System.Drawing.Point(354, 47);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(91, 26);
            this.tb_Port.TabIndex = 3;
            this.tb_Port.Text = "11000";
            // 
            // cb_Displays
            // 
            this.cb_Displays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Displays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Displays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cb_Displays.FormattingEnabled = true;
            this.cb_Displays.Location = new System.Drawing.Point(103, 139);
            this.cb_Displays.Name = "cb_Displays";
            this.cb_Displays.Size = new System.Drawing.Size(91, 28);
            this.cb_Displays.TabIndex = 6;
            this.cb_Displays.SelectedIndexChanged += new System.EventHandler(this.cb_Displays_SelectedIndexChanged);
            // 
            // lbl_Setting_Port
            // 
            this.lbl_Setting_Port.AutoSize = true;
            this.lbl_Setting_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Setting_Port.Location = new System.Drawing.Point(255, 50);
            this.lbl_Setting_Port.Name = "lbl_Setting_Port";
            this.lbl_Setting_Port.Size = new System.Drawing.Size(91, 20);
            this.lbl_Setting_Port.TabIndex = 4;
            this.lbl_Setting_Port.Text = "Server port:";
            // 
            // cb_COMPorts
            // 
            this.cb_COMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_COMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_COMPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.cb_COMPorts.FormattingEnabled = true;
            this.cb_COMPorts.Location = new System.Drawing.Point(103, 92);
            this.cb_COMPorts.Name = "cb_COMPorts";
            this.cb_COMPorts.Size = new System.Drawing.Size(91, 28);
            this.cb_COMPorts.TabIndex = 12;
            this.cb_COMPorts.SelectedIndexChanged += new System.EventHandler(this.cb_COMPorts_SelectedIndexChanged);
            // 
            // lbl_Settings_ButtonPorts
            // 
            this.lbl_Settings_ButtonPorts.AutoSize = true;
            this.lbl_Settings_ButtonPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Settings_ButtonPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbl_Settings_ButtonPorts.Location = new System.Drawing.Point(6, 95);
            this.lbl_Settings_ButtonPorts.Name = "lbl_Settings_ButtonPorts";
            this.lbl_Settings_ButtonPorts.Size = new System.Drawing.Size(93, 20);
            this.lbl_Settings_ButtonPorts.TabIndex = 11;
            this.lbl_Settings_ButtonPorts.Text = "Button port:";
            // 
            // btn_RButtonPorts
            // 
            this.btn_RButtonPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_RButtonPorts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RButtonPorts.BackgroundImage")));
            this.btn_RButtonPorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RButtonPorts.FlatAppearance.BorderSize = 0;
            this.btn_RButtonPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RButtonPorts.ForeColor = System.Drawing.Color.White;
            this.btn_RButtonPorts.Location = new System.Drawing.Point(200, 92);
            this.btn_RButtonPorts.Name = "btn_RButtonPorts";
            this.btn_RButtonPorts.Size = new System.Drawing.Size(28, 28);
            this.btn_RButtonPorts.TabIndex = 22;
            this.btn_RButtonPorts.UseVisualStyleBackColor = false;
            this.btn_RButtonPorts.Click += new System.EventHandler(this.btn_RButtonPorts_Click);
            // 
            // btn_RDisplays
            // 
            this.btn_RDisplays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_RDisplays.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RDisplays.BackgroundImage")));
            this.btn_RDisplays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RDisplays.FlatAppearance.BorderSize = 0;
            this.btn_RDisplays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RDisplays.ForeColor = System.Drawing.Color.White;
            this.btn_RDisplays.Location = new System.Drawing.Point(200, 139);
            this.btn_RDisplays.Name = "btn_RDisplays";
            this.btn_RDisplays.Size = new System.Drawing.Size(28, 28);
            this.btn_RDisplays.TabIndex = 21;
            this.btn_RDisplays.UseVisualStyleBackColor = false;
            this.btn_RDisplays.Click += new System.EventHandler(this.btn_RDisplays_Click);
            // 
            // btn_RPrinters
            // 
            this.btn_RPrinters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_RPrinters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RPrinters.BackgroundImage")));
            this.btn_RPrinters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RPrinters.FlatAppearance.BorderSize = 0;
            this.btn_RPrinters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RPrinters.ForeColor = System.Drawing.Color.White;
            this.btn_RPrinters.Location = new System.Drawing.Point(200, 186);
            this.btn_RPrinters.Name = "btn_RPrinters";
            this.btn_RPrinters.Size = new System.Drawing.Size(28, 28);
            this.btn_RPrinters.TabIndex = 20;
            this.btn_RPrinters.UseVisualStyleBackColor = false;
            this.btn_RPrinters.Click += new System.EventHandler(this.btn_RPrinters_Click);
            // 
            // tab_About
            // 
            this.tab_About.Controls.Add(this.label17);
            this.tab_About.Location = new System.Drawing.Point(4, 5);
            this.tab_About.Name = "tab_About";
            this.tab_About.Padding = new System.Windows.Forms.Padding(3);
            this.tab_About.Size = new System.Drawing.Size(572, 387);
            this.tab_About.TabIndex = 4;
            this.tab_About.Text = "About";
            this.tab_About.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 24);
            this.label17.TabIndex = 15;
            this.label17.Text = "About";
            // 
            // pnl_ControlBox
            // 
            this.pnl_ControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnl_ControlBox.Controls.Add(this.btn_Exit);
            this.pnl_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.pnl_ControlBox.Name = "pnl_ControlBox";
            this.pnl_ControlBox.Size = new System.Drawing.Size(836, 30);
            this.pnl_ControlBox.TabIndex = 4;
            this.pnl_ControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_ControlBox_MouseDown);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(808, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnl_Menu, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(836, 402);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.pnl_Menu.Controls.Add(this.btn_About);
            this.pnl_Menu.Controls.Add(this.btn_Settings);
            this.pnl_Menu.Controls.Add(this.btn_Media);
            this.pnl_Menu.Controls.Add(this.btn_Queue);
            this.pnl_Menu.Controls.Add(this.btn_Dashboard);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(250, 402);
            this.pnl_Menu.TabIndex = 6;
            // 
            // btn_About
            // 
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_About.ForeColor = System.Drawing.Color.White;
            this.btn_About.Image = global::IASAqueue_Server.Properties.Resources.About_icon_30;
            this.btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.Location = new System.Drawing.Point(0, 225);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(250, 40);
            this.btn_About.TabIndex = 5;
            this.btn_About.Text = "  About";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Image = global::IASAqueue_Server.Properties.Resources.ic_settings30;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(0, 185);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(250, 40);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "  Settings";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Media
            // 
            this.btn_Media.FlatAppearance.BorderSize = 0;
            this.btn_Media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Media.ForeColor = System.Drawing.Color.White;
            this.btn_Media.Image = global::IASAqueue_Server.Properties.Resources.ic_perm_media30;
            this.btn_Media.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Media.Location = new System.Drawing.Point(0, 145);
            this.btn_Media.Name = "btn_Media";
            this.btn_Media.Size = new System.Drawing.Size(250, 40);
            this.btn_Media.TabIndex = 3;
            this.btn_Media.Text = "  Media";
            this.btn_Media.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Media.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Media.UseVisualStyleBackColor = true;
            this.btn_Media.Click += new System.EventHandler(this.btn_Media_Click);
            // 
            // btn_Queue
            // 
            this.btn_Queue.FlatAppearance.BorderSize = 0;
            this.btn_Queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Queue.ForeColor = System.Drawing.Color.White;
            this.btn_Queue.Image = global::IASAqueue_Server.Properties.Resources._722553_group_30;
            this.btn_Queue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Queue.Location = new System.Drawing.Point(0, 105);
            this.btn_Queue.Name = "btn_Queue";
            this.btn_Queue.Size = new System.Drawing.Size(250, 40);
            this.btn_Queue.TabIndex = 2;
            this.btn_Queue.Text = "  Queue";
            this.btn_Queue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Queue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Queue.UseVisualStyleBackColor = true;
            this.btn_Queue.Click += new System.EventHandler(this.btn_Queue_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = global::IASAqueue_Server.Properties.Resources._32465_30;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 65);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(250, 40);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "  Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // tmr_Autosaver
            // 
            this.tmr_Autosaver.Tick += new System.EventHandler(this.tmr_Autosaver_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 432);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pnl_ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Dashboard.ResumeLayout(false);
            this.tab_Queue.ResumeLayout(false);
            this.tab_Queue.PerformLayout();
            this.tab_Media.ResumeLayout(false);
            this.tab_Media.PerformLayout();
            this.tab_Settings.ResumeLayout(false);
            this.tab_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_AutosaveInterval)).EndInit();
            this.tab_About.ResumeLayout(false);
            this.tab_About.PerformLayout();
            this.pnl_ControlBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Logs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_inQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Uptime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Dashboard;
        private System.Windows.Forms.TabPage tab_Queue;
        private System.Windows.Forms.Panel pnl_ControlBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.TabPage tab_Media;
        private System.Windows.Forms.TabPage tab_Settings;
        private System.Windows.Forms.Button btn_RefreshMonitor;
        private System.Windows.Forms.ComboBox cb_Displays;
        private System.Windows.Forms.TabPage tab_About;
        private System.Windows.Forms.ComboBox cb_COMPorts;
        private System.Windows.Forms.Label lbl_Settings_ButtonPorts;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Label lbl_Setting_Port;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Monitor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_LoadQueue;
        private System.Windows.Forms.Button btn_SaveQueue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_Setting_IP;
        private System.Windows.Forms.ComboBox cb_Printers;
        private System.Windows.Forms.Label lbl_Settings_Printer;
        private System.Windows.Forms.Label lbl_Settings_Display;
        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_RButtonPorts;
        private System.Windows.Forms.Button btn_RDisplays;
        private System.Windows.Forms.Button btn_RPrinters;
        private System.Windows.Forms.Button btn_AutosavePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUD_AutosaveInterval;
        private System.Windows.Forms.TextBox tb_AutosavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Media;
        private System.Windows.Forms.Button btn_Queue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer tmr_Autosaver;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

