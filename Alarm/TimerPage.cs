using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class TimerPage : UserControl
    {
        public TimerPage()
        {
            InitializeComponent();
            AddEffect(setalarm);
            AddEffect(deletalarm);
            AddEffect(editalarm);
        }



        public static void AddEffect(Control c)
        {
            Point location = c.Location;
            Size size = c.Size;
            c.MouseEnter += (s, e) =>
            {
                location.X -= 4;
                location.Y -= 4;
                size.Width += 8;
                size.Height += 8;
                c.Size = size;
                c.Location = location;
            };
            c.MouseLeave += (s, e) =>
            {
                location.X += 4;
                location.Y += 4;
                size.Width -= 8;
                size.Height -= 8;
                c.Size = size;
                c.Location = location;
            };
            c.MouseDown += (s, e) =>
            {
                location.X += 4;
                location.Y += 4;
                size.Width -= 8;
                size.Height -= 8;
                c.Size = size;
                c.Location = location;
            };
            c.MouseUp += (s, e) =>
            {
                location.X -= 4;
                location.Y -= 4;
                size.Width += 8;
                size.Height += 8;
                c.Size = size;
                c.Location = location;
            };
        }

        Alaram myalarm;


        Timer t = new Timer();
        private void Setalarm_Click(object sender, EventArgs e)
        {
            int seconds = (int)secondsnum.Value;
            int minuts = (int)minutsnum.Value;
            int hours = (int)hoursnum.Value;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            ((sender as Control).Parent.Parent as TabPage).Text = alarmname.Text;

            hours = mcombo.SelectedItem.ToString() == "PM" ? hours + 12 : hours;
            DateTime alarmtime = new DateTime(year, month, day, hours, minuts, seconds);
            if (countdownto.Checked)
            {
                alarmtime = DateTime.Now;
                alarmtime = alarmtime.AddSeconds(seconds);
                alarmtime = alarmtime.AddMinutes(minuts);
                alarmtime = alarmtime.AddHours(hours);
            }

            Alaram.TaskType task = Alaram.TaskType.None;
            if (taskbtn.Checked)
            {
                if (shutdownbtn.Checked)
                    task = Alaram.TaskType.ShutDown;
                else if (restartbtn.Checked)
                    task = Alaram.TaskType.Restart;
                else if (lockbtn.Checked)
                    task = Alaram.TaskType.Lock;
                else if (sleepbtn.Checked)
                    task = Alaram.TaskType.Sleep;
            }

            // DateTime alarmtime = new DateTime(year, month, day, hours, minuts, seconds);
            myalarm = new Alaram(alarmtime, alarmtxt.Text, alarmname.Text, alarmtonetxt.Text, task);
            myalarm.AlarmEnd += editalarm_Click;
            foreach (Control c in this.Controls)
                c.Visible = false;
            editalarm.Visible = true;
            AlarmTimeShow.Visible = true;
            if (countdownto.Checked)
            {
                AlarmTimeShow.Text = "Alarm Runs After";

                t.Tick += (s, ex) => { countdown(alarmtime); };
                t.Interval = 1;
                t.Enabled = true;

            }
            else
            {
                AlarmTimeLabel.Text = alarmtime.ToLongTimeString();
                AlarmTimeShow.Text = "Alarm Set To";
            }

        }

        private void countdown(DateTime alarmtime)
        {

            int hours = (alarmtime.Subtract(DateTime.Now)).Hours;
            int mins = (alarmtime.Subtract(DateTime.Now)).Minutes;
            int seconds = (alarmtime.Subtract(DateTime.Now)).Seconds;

            AlarmTimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, seconds);
        }
        private void Deletalarm_Click(object sender, EventArgs e)
        {
            myalarm = null;
            GC.Collect();
            ((sender as Control).Parent.Parent.Parent as TabControl).TabPages.Remove((sender as Control).Parent.Parent as TabPage);
        }

        private void ToneBrowse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Sound Files|*.mp3;*.wav;*.wma";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                alarmtonetxt.Text = ofd.FileName;
            }
        }

        private void countdownto_CheckedChanged(object sender, EventArgs e)
        {
            hoursnum.Minimum = 0;
            mcombo.Enabled = false;
            mcombo.SelectedIndex = 0;
        }

        private void alarmat_CheckedChanged(object sender, EventArgs e)
        {
            hoursnum.Minimum = 1;
            hoursnum.Value = hoursnum.Value == 0 ? 1 : hoursnum.Value;
            mcombo.Enabled = true;
        }

        private void editalarm_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
                c.Visible = true;

            editalarm.Visible = false;
            AlarmTimeShow.Visible = false;
            Tasks.Visible = false;
        }

        private void TimerPage_Load(object sender, EventArgs e)
        {
            this.alarmname.Text = Parent.Text;
        }

        private void Taskbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (taskbtn.Checked)
            {
                this.alarmtxt.Visible = false;
                Tasks.Visible = true;
            }
        }

        private void TextBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TextBtn.Checked)
            {
                alarmtxt.Visible = true;
                Tasks.Visible = false;
            }
        }

    }
}
