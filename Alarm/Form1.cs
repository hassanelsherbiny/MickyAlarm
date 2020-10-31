using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Reflection;
namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                NewTab();
            }
        }
        void NewTab()
        {
            TimerPage page = new TimerPage();
            page.Location = new Point(0, 5);

            TabPage p = new TabPage();
            p.Text = "Alarm" + (tabControl1.TabCount).ToString();
            p.BackColor = Color.White;
            p.Controls.Add(page);
            tabControl1.TabPages.Insert(tabControl1.TabCount - 1, p);
            tabControl1.SelectedIndex = tabControl1.TabCount - 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewTab();
        }
    }
}
