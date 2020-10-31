using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using System.Reflection;
using WMPLib;
namespace Alarm
{
    public partial class AlarmForm : Form
    {
        string tonepath;
        public AlarmForm(string title,string content,string tonepath)
        {
            InitializeComponent();
            this.Text = title;
            this.label1.Text = content;
            label2.Text = title;
            Control.CheckForIllegalCrossThreadCalls = false;
            this.tonepath = tonepath;
            TimerPage.AddEffect(pictureBox1);
        }

        private void Appear()
        {
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            int x = screensize.Width - this.Width;
            this.Location = new Point(x, screensize.Height);
             int y = screensize.Height - this.Height;
            Thread th = new Thread(()=>{ScrollUp(y);});
            
            th.IsBackground = true;
            th.Start();
        }

        private void ScrollUp(int lastlocation)
        {
            if (this.Top > lastlocation)
            {
                this.Top--;
                Thread.Sleep(5);
                ScrollUp(lastlocation);
            }

        }

        private void ScrollDown(int lastlocation)
        {
            if (this.Top < lastlocation)
            {
                this.Top++;
                Thread.Sleep(5);
                ScrollDown(lastlocation);
            }
            else
            {
                this.Close();
                try
                {
                    player.controls.stop();
                }
                catch { }
            }

        }
         WindowsMediaPlayer player;
        private void AlarmForm_Load(object sender, EventArgs e)
        {
            player = new WindowsMediaPlayer();
           
            if (System.IO.File.Exists(tonepath))
            {
                
                player.URL = tonepath;
            }
            else
            {
                if (File.Exists("tone.mp3"))
                    player.URL = "tone.mp3";
            }
            try
            {
                player.controls.play();
            }
            catch { }

            //Send Form To Top
            this.Activate();
            this.BringToFront();
          Appear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => { ScrollDown(Screen.PrimaryScreen.WorkingArea.Height); });
            th.IsBackground = true;
            th.Start();
        }
    }
}
