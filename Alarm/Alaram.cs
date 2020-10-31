using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Alarm
{
    class Alaram
    {
        DateTime alarmtime = DateTime.Now;
        System.Windows.Forms.Timer timer;
        /// <summary>
        /// Get Or Set The alarm Time
        /// </summary>
        public DateTime AlarmTime
        {
            get;

            private set;
        }

        /// <summary>
        /// Get Or Set The alarm Text
        /// </summary>
        public string AlarmText
        {
            get;
            set;
        }

        /// <summary>
        /// Get Or Set The Alarm Tone Path
        /// </summary>
        public string TonePath
        {
            get;
            set;
        }

        private string AlarmName
        {
            get;
            set;
        }



        public enum TaskType
        {
            None,
            ShutDown,
            Restart,
            Sleep,
            Lock
        }

        private TaskType Task;

        public Alaram(DateTime alarmtime, string alarmtext, string alarmname, string tonepath,TaskType task)
        {
                AlarmText = alarmtext;
                AlarmTime = alarmtime;
                TonePath = tonepath;
                AlarmName = alarmname;
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                Task = task;

                timer = new System.Windows.Forms.Timer();
                timer.Interval = 10;
                timer.Tick += StartAlarm;
                timer.Enabled = true;
        }

        private void StartAlarm(object sender,EventArgs e)
        {

                if (isequal(AlarmTime, DateTime.Now))
                {
                    timer.Enabled = false;
                    ExecuteTasks();
                    if (AlarmEnd != null)
                        AlarmEnd(this, EventArgs.Empty);
                   if (Task == TaskType.None)
                    {
                        AlarmForm fr = new AlarmForm(AlarmName, AlarmText, TonePath);
                        fr.ShowDialog();
                    }
                }
        }

        private void ExecuteTasks()
        {
            Process p = new Process();
            p.StartInfo.FileName = "Cmd.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            if(Task == TaskType.ShutDown)
                p.StartInfo.Arguments = "/C shutdown.exe -s -t 00 -f";
            else  if (Task == TaskType.Restart)
                p.StartInfo.Arguments = "/C shutdown.exe -r -t 00 -f";
            else if(Task == TaskType.Lock)
                p.StartInfo.Arguments = "/C Rundll32 User32.dll,LockWorkStation";
            else if(Task==TaskType.Sleep)
                p.StartInfo.Arguments = "/C rundll32.exe powrprof.dll,SetSuspendState 0,1,0";
            
            p.Start();
        }

        public event EventHandler AlarmEnd;

        /// <summary>
        /// An Event Will be Fired When Timer Ends
        /// </summary>


        /// <summary>
        /// Compars To Dates And Return True IF The Two Dates Are Equal
        /// </summary>
        /// <param name="d1">First Date</param>
        /// <param name="d2">Second Date</param>
        /// <returns></returns>
        bool isequal(DateTime d1, DateTime d2)
        {
            bool result = false;

            if (d1.Day == d2.Day)
                if (d1.Hour == d2.Hour)
                    if (d1.Minute == d2.Minute)
                        if (d1.Second == d2.Second)
                            result = true;
            
            return result;
        }
        ~Alaram()
        {
            timer.Enabled = false;
        }
    }
}
