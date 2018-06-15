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
            this.rtb_Logs = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Monitor = new System.Windows.Forms.Button();
            this.cb_Displays = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_inQueue = new System.Windows.Forms.Label();
            this.lbl_Uptime = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Logs
            // 
            this.rtb_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Logs.Location = new System.Drawing.Point(3, 245);
            this.rtb_Logs.Name = "rtb_Logs";
            this.rtb_Logs.ReadOnly = true;
            this.rtb_Logs.Size = new System.Drawing.Size(546, 117);
            this.rtb_Logs.TabIndex = 1;
            this.rtb_Logs.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Logs, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.34146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.65854F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 365);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 236);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.btn_Monitor);
            this.groupBox4.Controls.Add(this.cb_Displays);
            this.groupBox4.Location = new System.Drawing.Point(9, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monitor settings";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 59);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(296, 36);
            this.button6.TabIndex = 13;
            this.button6.Text = "Refresh monitor";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_Monitor
            // 
            this.btn_Monitor.Location = new System.Drawing.Point(169, 24);
            this.btn_Monitor.Name = "btn_Monitor";
            this.btn_Monitor.Size = new System.Drawing.Size(133, 29);
            this.btn_Monitor.TabIndex = 2;
            this.btn_Monitor.Text = "Open monitor";
            this.btn_Monitor.UseVisualStyleBackColor = true;
            this.btn_Monitor.Click += new System.EventHandler(this.btn_Monitor_Click);
            // 
            // cb_Displays
            // 
            this.cb_Displays.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Displays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Displays.FormattingEnabled = true;
            this.cb_Displays.Location = new System.Drawing.Point(6, 25);
            this.cb_Displays.Name = "cb_Displays";
            this.cb_Displays.Size = new System.Drawing.Size(157, 28);
            this.cb_Displays.TabIndex = 6;
            this.cb_Displays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tb_Port);
            this.groupBox3.Controls.Add(this.lbl_Port);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(325, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 117);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Panel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Port.Location = new System.Drawing.Point(113, 45);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(91, 26);
            this.tb_Port.TabIndex = 3;
            this.tb_Port.Text = "11000";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Port.Location = new System.Drawing.Point(113, 22);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(91, 20);
            this.lbl_Port.TabIndex = 4;
            this.lbl_Port.Text = "Server port:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Pause Queue";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_inQueue);
            this.groupBox2.Controls.Add(this.lbl_Uptime);
            this.groupBox2.Controls.Add(this.lbl_Status);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Uptime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "People in a queue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status:";
            // 
            // lbl_inQueue
            // 
            this.lbl_inQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_inQueue.Location = new System.Drawing.Point(152, 62);
            this.lbl_inQueue.Name = "lbl_inQueue";
            this.lbl_inQueue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_inQueue.Size = new System.Drawing.Size(137, 20);
            this.lbl_inQueue.TabIndex = 5;
            this.lbl_inQueue.Text = "0";
            this.lbl_inQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Uptime
            // 
            this.lbl_Uptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Uptime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Uptime.Location = new System.Drawing.Point(226, 22);
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
            this.lbl_Status.Location = new System.Drawing.Point(72, 22);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Status.Size = new System.Drawing.Size(59, 20);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "Offline";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(325, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "Export Data";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Logs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Monitor;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_inQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Displays;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Uptime;
        private System.Windows.Forms.Button button5;
    }
}

