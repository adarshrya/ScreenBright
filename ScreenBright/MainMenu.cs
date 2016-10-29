using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenBright
{
    public partial class MainMenu : Form
    {
        private int daybright;

        private int nightbright;

        private int midnightbright;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.daybright = Convert.ToInt32(ConfigurationManager.AppSettings["day"]);
            this.nightbright = Convert.ToInt32(ConfigurationManager.AppSettings["night"]);
            this.midnightbright = Convert.ToInt32(ConfigurationManager.AppSettings["midnight"]);
            this.DayTrack.Value = this.daybright;
            this.NightTrack.Value = this.nightbright;
            this.MidnightTrack.Value = this.midnightbright;
            this.CheckTimer.Interval = 75000;
            this.CheckTimer.Enabled = true; 
            this.whattimeisit();
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            this.whattimeisit();
        }

        private void SetBrightness(int value)
        {
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new ManagementScope("root\\WMI"), new SelectQuery("WmiMonitorBrightnessMethods")))
            {
                using (ManagementObjectCollection managementObjectCollections = managementObjectSearcher.Get())
                {
                    using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollections.GetEnumerator())
                    {
                        if (enumerator.MoveNext())
                        {
                            ManagementObject current = (ManagementObject)enumerator.Current;
                            current.InvokeMethod("WmiSetBrightness", new object[] { (uint)0, value });
                        }
                    }
                }
            }
        }


        private void whattimeisit()
        {
            DateTime now = DateTime.Now;
            DateTime date = DateTime.Now.Date;
            if (DateTime.Compare(now, date.AddHours(6)) >= 0 && DateTime.Compare(now, date.AddHours(19)) < 0)
            {
                this.SetBrightness(this.daybright);
            }
            else if (DateTime.Compare(now, date.AddHours(19)) >= 0 && DateTime.Compare(now,date.AddDays(1)) < 0)
            {
                this.SetBrightness(this.nightbright);
            }
            else if (DateTime.Compare(now, date) >= 0 && DateTime.Compare(now, date.AddHours(6)) < 0)
            {
                this.SetBrightness(this.midnightbright);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.daybright = this.DayTrack.Value;
            this.nightbright = this.NightTrack.Value;
            this.midnightbright = this.MidnightTrack.Value;
            Configuration str = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            str.AppSettings.Settings["day"].Value = this.daybright.ToString();
            str.AppSettings.Settings["night"].Value = this.nightbright.ToString();
            str.AppSettings.Settings["midnight"].Value = this.midnightbright.ToString();
            str.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.whattimeisit();
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == base.WindowState)
            {
                this.BaloonNotify.Visible = true;
                this.BaloonNotify.ShowBalloonTip(500);
                base.Hide();
            }
            else if (base.WindowState == FormWindowState.Normal)
            {
                this.BaloonNotify.Visible = false;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Show();
            base.WindowState = FormWindowState.Normal;
            this.BaloonNotify.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
