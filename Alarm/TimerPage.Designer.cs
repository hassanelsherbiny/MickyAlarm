namespace Alarm
{
    partial class TimerPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToneBrowse_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.alarmtonetxt = new System.Windows.Forms.TextBox();
            this.alarmtxt = new System.Windows.Forms.TextBox();
            this.alarmname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondsnum = new System.Windows.Forms.NumericUpDown();
            this.minutsnum = new System.Windows.Forms.NumericUpDown();
            this.mcombo = new System.Windows.Forms.ComboBox();
            this.hoursnum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alarmat = new System.Windows.Forms.RadioButton();
            this.countdownto = new System.Windows.Forms.RadioButton();
            this.TextBtn = new System.Windows.Forms.RadioButton();
            this.taskbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tasks = new System.Windows.Forms.GroupBox();
            this.lockbtn = new System.Windows.Forms.RadioButton();
            this.sleepbtn = new System.Windows.Forms.RadioButton();
            this.restartbtn = new System.Windows.Forms.RadioButton();
            this.shutdownbtn = new System.Windows.Forms.RadioButton();
            this.AlarmTimeShow = new System.Windows.Forms.GroupBox();
            this.AlarmTimeLabel = new System.Windows.Forms.Label();
            this.editalarm = new System.Windows.Forms.PictureBox();
            this.deletalarm = new System.Windows.Forms.PictureBox();
            this.setalarm = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutsnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursnum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Tasks.SuspendLayout();
            this.AlarmTimeShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editalarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletalarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setalarm)).BeginInit();
            this.SuspendLayout();
            // 
            // ToneBrowse_btn
            // 
            this.ToneBrowse_btn.Location = new System.Drawing.Point(171, 248);
            this.ToneBrowse_btn.Name = "ToneBrowse_btn";
            this.ToneBrowse_btn.Size = new System.Drawing.Size(32, 20);
            this.ToneBrowse_btn.TabIndex = 21;
            this.ToneBrowse_btn.Text = "...";
            this.ToneBrowse_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ToneBrowse_btn.UseVisualStyleBackColor = true;
            this.ToneBrowse_btn.Click += new System.EventHandler(this.ToneBrowse_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Alarm Tone:";
            // 
            // alarmtonetxt
            // 
            this.alarmtonetxt.Location = new System.Drawing.Point(5, 248);
            this.alarmtonetxt.Name = "alarmtonetxt";
            this.alarmtonetxt.ReadOnly = true;
            this.alarmtonetxt.Size = new System.Drawing.Size(158, 20);
            this.alarmtonetxt.TabIndex = 18;
            // 
            // alarmtxt
            // 
            this.alarmtxt.Location = new System.Drawing.Point(5, 145);
            this.alarmtxt.MaxLength = 333;
            this.alarmtxt.Multiline = true;
            this.alarmtxt.Name = "alarmtxt";
            this.alarmtxt.Size = new System.Drawing.Size(194, 84);
            this.alarmtxt.TabIndex = 17;
            // 
            // alarmname
            // 
            this.alarmname.Location = new System.Drawing.Point(7, 94);
            this.alarmname.MaxLength = 30;
            this.alarmname.Name = "alarmname";
            this.alarmname.Size = new System.Drawing.Size(194, 20);
            this.alarmname.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alarm Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondsnum);
            this.groupBox1.Controls.Add(this.minutsnum);
            this.groupBox1.Controls.Add(this.mcombo);
            this.groupBox1.Controls.Add(this.hoursnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 50);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm Time";
            // 
            // secondsnum
            // 
            this.secondsnum.Location = new System.Drawing.Point(113, 19);
            this.secondsnum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secondsnum.Name = "secondsnum";
            this.secondsnum.Size = new System.Drawing.Size(37, 20);
            this.secondsnum.TabIndex = 8;
            this.secondsnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minutsnum
            // 
            this.minutsnum.Location = new System.Drawing.Point(62, 19);
            this.minutsnum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minutsnum.Name = "minutsnum";
            this.minutsnum.Size = new System.Drawing.Size(37, 20);
            this.minutsnum.TabIndex = 7;
            this.minutsnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mcombo
            // 
            this.mcombo.FormattingEnabled = true;
            this.mcombo.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.mcombo.Location = new System.Drawing.Point(156, 19);
            this.mcombo.Name = "mcombo";
            this.mcombo.Size = new System.Drawing.Size(42, 21);
            this.mcombo.TabIndex = 3;
            this.mcombo.Text = "AM";
            // 
            // hoursnum
            // 
            this.hoursnum.Location = new System.Drawing.Point(6, 19);
            this.hoursnum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hoursnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hoursnum.Name = "hoursnum";
            this.hoursnum.Size = new System.Drawing.Size(37, 20);
            this.hoursnum.TabIndex = 0;
            this.hoursnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // alarmat
            // 
            this.alarmat.AutoSize = true;
            this.alarmat.Checked = true;
            this.alarmat.Location = new System.Drawing.Point(7, 4);
            this.alarmat.Name = "alarmat";
            this.alarmat.Size = new System.Drawing.Size(64, 17);
            this.alarmat.TabIndex = 27;
            this.alarmat.TabStop = true;
            this.alarmat.Text = "Alarm At";
            this.toolTip1.SetToolTip(this.alarmat, "Set Alarm To a specific Time");
            this.alarmat.UseVisualStyleBackColor = true;
            this.alarmat.CheckedChanged += new System.EventHandler(this.alarmat_CheckedChanged);
            // 
            // countdownto
            // 
            this.countdownto.AutoSize = true;
            this.countdownto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countdownto.Location = new System.Drawing.Point(110, 4);
            this.countdownto.Name = "countdownto";
            this.countdownto.Size = new System.Drawing.Size(100, 17);
            this.countdownto.TabIndex = 28;
            this.countdownto.Text = "Count Down To";
            this.toolTip1.SetToolTip(this.countdownto, "Set Alarm After a specific Time");
            this.countdownto.UseVisualStyleBackColor = true;
            this.countdownto.CheckedChanged += new System.EventHandler(this.countdownto_CheckedChanged);
            // 
            // TextBtn
            // 
            this.TextBtn.AutoSize = true;
            this.TextBtn.Checked = true;
            this.TextBtn.Location = new System.Drawing.Point(3, 8);
            this.TextBtn.Name = "TextBtn";
            this.TextBtn.Size = new System.Drawing.Size(46, 17);
            this.TextBtn.TabIndex = 30;
            this.TextBtn.TabStop = true;
            this.TextBtn.Text = "Text";
            this.toolTip1.SetToolTip(this.TextBtn, "Set a Text To Be Shown At Alarm Time");
            this.TextBtn.UseVisualStyleBackColor = true;
            this.TextBtn.CheckedChanged += new System.EventHandler(this.TextBtn_CheckedChanged);
            // 
            // taskbtn
            // 
            this.taskbtn.AutoSize = true;
            this.taskbtn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taskbtn.Location = new System.Drawing.Point(149, 8);
            this.taskbtn.Name = "taskbtn";
            this.taskbtn.Size = new System.Drawing.Size(49, 17);
            this.taskbtn.TabIndex = 31;
            this.taskbtn.Text = "Task";
            this.toolTip1.SetToolTip(this.taskbtn, "Set a Task To Be Done At Alarm Time");
            this.taskbtn.UseVisualStyleBackColor = true;
            this.taskbtn.CheckedChanged += new System.EventHandler(this.Taskbtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.taskbtn);
            this.groupBox2.Controls.Add(this.TextBtn);
            this.groupBox2.Location = new System.Drawing.Point(5, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 28);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // Tasks
            // 
            this.Tasks.Controls.Add(this.lockbtn);
            this.Tasks.Controls.Add(this.sleepbtn);
            this.Tasks.Controls.Add(this.restartbtn);
            this.Tasks.Controls.Add(this.shutdownbtn);
            this.Tasks.Location = new System.Drawing.Point(5, 145);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(200, 84);
            this.Tasks.TabIndex = 33;
            this.Tasks.TabStop = false;
            this.Tasks.Text = "Tasks";
            this.Tasks.Visible = false;
            // 
            // lockbtn
            // 
            this.lockbtn.AutoSize = true;
            this.lockbtn.Location = new System.Drawing.Point(102, 55);
            this.lockbtn.Name = "lockbtn";
            this.lockbtn.Size = new System.Drawing.Size(97, 17);
            this.lockbtn.TabIndex = 37;
            this.lockbtn.Text = "Lock Computer";
            this.lockbtn.UseVisualStyleBackColor = true;
            // 
            // sleepbtn
            // 
            this.sleepbtn.AutoSize = true;
            this.sleepbtn.Checked = true;
            this.sleepbtn.Location = new System.Drawing.Point(113, 19);
            this.sleepbtn.Name = "sleepbtn";
            this.sleepbtn.Size = new System.Drawing.Size(52, 17);
            this.sleepbtn.TabIndex = 36;
            this.sleepbtn.TabStop = true;
            this.sleepbtn.Text = "Sleep";
            this.toolTip1.SetToolTip(this.sleepbtn, "Set Computer To Be Locked  At Alarm Time");
            this.sleepbtn.UseVisualStyleBackColor = true;
            // 
            // restartbtn
            // 
            this.restartbtn.AutoSize = true;
            this.restartbtn.Location = new System.Drawing.Point(6, 55);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(59, 17);
            this.restartbtn.TabIndex = 35;
            this.restartbtn.Text = "Restart";
            this.toolTip1.SetToolTip(this.restartbtn, "Set Computer To Be Restarted  At Alarm Time");
            this.restartbtn.UseVisualStyleBackColor = true;
            // 
            // shutdownbtn
            // 
            this.shutdownbtn.AutoSize = true;
            this.shutdownbtn.Location = new System.Drawing.Point(6, 19);
            this.shutdownbtn.Name = "shutdownbtn";
            this.shutdownbtn.Size = new System.Drawing.Size(75, 17);
            this.shutdownbtn.TabIndex = 34;
            this.shutdownbtn.Text = "ShutDown";
            this.toolTip1.SetToolTip(this.shutdownbtn, "Set Computer To ShutDown At Alarm Time");
            this.shutdownbtn.UseVisualStyleBackColor = true;
            // 
            // AlarmTimeShow
            // 
            this.AlarmTimeShow.Controls.Add(this.AlarmTimeLabel);
            this.AlarmTimeShow.Location = new System.Drawing.Point(5, 94);
            this.AlarmTimeShow.Name = "AlarmTimeShow";
            this.AlarmTimeShow.Size = new System.Drawing.Size(200, 100);
            this.AlarmTimeShow.TabIndex = 34;
            this.AlarmTimeShow.TabStop = false;
            this.AlarmTimeShow.Text = "Alarm Set To";
            this.AlarmTimeShow.Visible = false;
            // 
            // AlarmTimeLabel
            // 
            this.AlarmTimeLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmTimeLabel.Location = new System.Drawing.Point(7, 16);
            this.AlarmTimeLabel.Name = "AlarmTimeLabel";
            this.AlarmTimeLabel.Size = new System.Drawing.Size(187, 81);
            this.AlarmTimeLabel.TabIndex = 0;
            this.AlarmTimeLabel.Text = "label4";
            this.AlarmTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editalarm
            // 
            this.editalarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editalarm.Image = global::Alarm.Properties.Resources.edit;
            this.editalarm.Location = new System.Drawing.Point(95, 274);
            this.editalarm.Name = "editalarm";
            this.editalarm.Size = new System.Drawing.Size(24, 24);
            this.editalarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editalarm.TabIndex = 29;
            this.editalarm.TabStop = false;
            this.toolTip1.SetToolTip(this.editalarm, "Edit Alarm");
            this.editalarm.Visible = false;
            this.editalarm.Click += new System.EventHandler(this.editalarm_Click);
            // 
            // deletalarm
            // 
            this.deletalarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletalarm.Image = global::Alarm.Properties.Resources.cross;
            this.deletalarm.Location = new System.Drawing.Point(7, 274);
            this.deletalarm.Name = "deletalarm";
            this.deletalarm.Size = new System.Drawing.Size(24, 24);
            this.deletalarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletalarm.TabIndex = 25;
            this.deletalarm.TabStop = false;
            this.toolTip1.SetToolTip(this.deletalarm, "Delete Alarm");
            this.deletalarm.Click += new System.EventHandler(this.Deletalarm_Click);
            // 
            // setalarm
            // 
            this.setalarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setalarm.Image = global::Alarm.Properties.Resources.Tick;
            this.setalarm.Location = new System.Drawing.Point(179, 274);
            this.setalarm.Name = "setalarm";
            this.setalarm.Size = new System.Drawing.Size(24, 24);
            this.setalarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.setalarm.TabIndex = 20;
            this.setalarm.TabStop = false;
            this.toolTip1.SetToolTip(this.setalarm, "Set Alarm");
            this.setalarm.Click += new System.EventHandler(this.Setalarm_Click);
            // 
            // TimerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AlarmTimeShow);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.editalarm);
            this.Controls.Add(this.countdownto);
            this.Controls.Add(this.alarmat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deletalarm);
            this.Controls.Add(this.setalarm);
            this.Controls.Add(this.ToneBrowse_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alarmtonetxt);
            this.Controls.Add(this.alarmtxt);
            this.Controls.Add(this.alarmname);
            this.Controls.Add(this.label3);
            this.Name = "TimerPage";
            this.Size = new System.Drawing.Size(209, 304);
            this.Load += new System.EventHandler(this.TimerPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutsnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursnum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Tasks.ResumeLayout(false);
            this.Tasks.PerformLayout();
            this.AlarmTimeShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editalarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletalarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setalarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deletalarm;
        private System.Windows.Forms.PictureBox setalarm;
        private System.Windows.Forms.Button ToneBrowse_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alarmtonetxt;
        private System.Windows.Forms.TextBox alarmtxt;
        private System.Windows.Forms.TextBox alarmname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown secondsnum;
        private System.Windows.Forms.NumericUpDown minutsnum;
        private System.Windows.Forms.ComboBox mcombo;
        private System.Windows.Forms.NumericUpDown hoursnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton alarmat;
        private System.Windows.Forms.RadioButton countdownto;
        private System.Windows.Forms.PictureBox editalarm;
        private System.Windows.Forms.RadioButton TextBtn;
        private System.Windows.Forms.RadioButton taskbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Tasks;
        private System.Windows.Forms.RadioButton lockbtn;
        private System.Windows.Forms.RadioButton sleepbtn;
        private System.Windows.Forms.RadioButton restartbtn;
        private System.Windows.Forms.RadioButton shutdownbtn;
        private System.Windows.Forms.GroupBox AlarmTimeShow;
        private System.Windows.Forms.Label AlarmTimeLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
