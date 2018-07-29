namespace IASAqueue_Client
{
    partial class ControlPanel
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
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Skip = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_InQueue = new System.Windows.Forms.Label();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.lbl_abit = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.pnl_ControlBox = new System.Windows.Forms.Panel();
            this.btn_Minimized = new System.Windows.Forms.Button();
            this.btn_Maximized = new System.Windows.Forms.Button();
            this.btn_Exit2 = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_ControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Green;
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Next.Location = new System.Drawing.Point(3, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(253, 176);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.BackColor = System.Drawing.Color.Yellow;
            this.btn_Skip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Skip.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Skip.Location = new System.Drawing.Point(262, 3);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(253, 176);
            this.btn_Skip.TabIndex = 1;
            this.btn_Skip.Text = "Skip";
            this.btn_Skip.UseVisualStyleBackColor = false;
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(521, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(254, 176);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 376);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_InQueue);
            this.panel1.Controls.Add(this.lbl_Timer);
            this.panel1.Controls.Add(this.lbl_abit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 182);
            this.panel1.TabIndex = 7;
            // 
            // lbl_InQueue
            // 
            this.lbl_InQueue.AutoSize = true;
            this.lbl_InQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_InQueue.ForeColor = System.Drawing.Color.White;
            this.lbl_InQueue.Location = new System.Drawing.Point(3, 2);
            this.lbl_InQueue.Name = "lbl_InQueue";
            this.lbl_InQueue.Size = new System.Drawing.Size(83, 20);
            this.lbl_InQueue.TabIndex = 9;
            this.lbl_InQueue.Text = "In Queue: ";
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.White;
            this.lbl_Timer.Location = new System.Drawing.Point(678, 2);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(100, 23);
            this.lbl_Timer.TabIndex = 8;
            this.lbl_Timer.Text = "00:00:00";
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_abit
            // 
            this.lbl_abit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lbl_abit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_abit.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_abit.ForeColor = System.Drawing.Color.White;
            this.lbl_abit.Location = new System.Drawing.Point(0, 0);
            this.lbl_abit.Name = "lbl_abit";
            this.lbl_abit.Size = new System.Drawing.Size(778, 182);
            this.lbl_abit.TabIndex = 7;
            this.lbl_abit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Next, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Skip, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Exit, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 191);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 182);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_Update
            // 
            this.timer_Update.Interval = 60000;
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // pnl_ControlBox
            // 
            this.pnl_ControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnl_ControlBox.Controls.Add(this.lbl_user);
            this.pnl_ControlBox.Controls.Add(this.btn_Minimized);
            this.pnl_ControlBox.Controls.Add(this.btn_Maximized);
            this.pnl_ControlBox.Controls.Add(this.btn_Exit2);
            this.pnl_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.pnl_ControlBox.Name = "pnl_ControlBox";
            this.pnl_ControlBox.Size = new System.Drawing.Size(784, 30);
            this.pnl_ControlBox.TabIndex = 7;
            this.pnl_ControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_ControlBox_MouseDown);
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Minimized.BackgroundImage = global::IASAqueue_Client.Properties.Resources.Significon_Minimize_5121;
            this.btn_Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.ForeColor = System.Drawing.Color.White;
            this.btn_Minimized.Location = new System.Drawing.Point(691, 2);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(25, 25);
            this.btn_Minimized.TabIndex = 3;
            this.btn_Minimized.Text = " —";
            this.btn_Minimized.UseVisualStyleBackColor = false;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_Maximized
            // 
            this.btn_Maximized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Maximized.BackgroundImage = global::IASAqueue_Client.Properties.Resources.Significon_Maximize_512;
            this.btn_Maximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Maximized.FlatAppearance.BorderSize = 0;
            this.btn_Maximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximized.Location = new System.Drawing.Point(727, 5);
            this.btn_Maximized.Name = "btn_Maximized";
            this.btn_Maximized.Size = new System.Drawing.Size(20, 20);
            this.btn_Maximized.TabIndex = 2;
            this.btn_Maximized.UseVisualStyleBackColor = false;
            this.btn_Maximized.Click += new System.EventHandler(this.btn_Maximized_Click);
            // 
            // btn_Exit2
            // 
            this.btn_Exit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_Exit2.BackgroundImage = global::IASAqueue_Client.Properties.Resources.ic_power_settings_new_black_48dp;
            this.btn_Exit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit2.FlatAppearance.BorderSize = 0;
            this.btn_Exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit2.Location = new System.Drawing.Point(753, 2);
            this.btn_Exit2.Name = "btn_Exit2";
            this.btn_Exit2.Size = new System.Drawing.Size(25, 25);
            this.btn_Exit2.TabIndex = 1;
            this.btn_Exit2.UseVisualStyleBackColor = false;
            this.btn_Exit2.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(7, 5);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 17);
            this.lbl_user.TabIndex = 4;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.Text = "username";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanel_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_ControlBox.ResumeLayout(false);
            this.pnl_ControlBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Skip;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_abit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_InQueue;
        private System.Windows.Forms.Timer timer_Update;
        private System.Windows.Forms.Panel pnl_ControlBox;
        private System.Windows.Forms.Button btn_Exit2;
        private System.Windows.Forms.Button btn_Minimized;
        private System.Windows.Forms.Button btn_Maximized;
        private System.Windows.Forms.Label lbl_user;
    }
}

