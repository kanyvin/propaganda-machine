using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Timers;


namespace propagandaMachine
{
    public partial class Propagate : Form
    {
        Process openBrowser = new Process();
        string powerPointProject = @"G:\MyDrive\FactionScoreboard4-4-18.pptx";
        string powerPointOpener = @"C:\Program Files\Microsoft Office\Office16\POWERPNT.exe";        
        string tinyPulse = @"https://app.tinypulse.com/engage?cheerfeed#sharing/cheer_feed?url=https%3A%2F%2Fapp.tinypulse.com%2Fapi%2Fcheers%3Factive_only%3Dtrue%26api_token%3Ddaf4e35c0eaf2489e11ab0%26organization_id%3D18876";
        string mozilla = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";

        public Propagate()
        {
            InitializeComponent();

            System.Timers.Timer powerPointRepeat = new System.Timers.Timer();
            powerPointRepeat.Elapsed += new ElapsedEventHandler(runPP_Tick);
            powerPointRepeat.Interval = 2*60*1000;
        }

        public void startBrowser(string file, string url)
        {
            openBrowser.StartInfo.FileName = file;
            openBrowser.StartInfo.Arguments = string.Format(url);
            openBrowser.Start();
        }

        public void killBrowser()
        {
            if (!openBrowser.HasExited)
                openBrowser.CloseMainWindow();
        }

        public void startPowerPointSlideShow (string ppAppfile, string ppfile)
        {
            Process openPower = new Process();
            openPower.StartInfo.FileName = ppAppfile;
            openPower.StartInfo.Arguments = string.Format("{0} {1}", "/s", ppfile);
            openPower.Start();
            openPower.WaitForExit();
        }

        private void start_Click(object sender, EventArgs e)
        {
            stop.Enabled = true;
            startBrowser(mozilla, tinyPulse);
            start.Enabled = false;
            runPP.Enabled = true; 
        }

        private void stop_Click(object sender, EventArgs e)
        {
            runPP.Enabled = false;
            killBrowser();
            start.Enabled = true;
            stop.Enabled = false;
        }

        private void runPP_Tick(object sender, EventArgs e)
        {
            startPowerPointSlideShow(powerPointOpener, powerPointProject);
        }
    }
}
