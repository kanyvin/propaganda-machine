using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO; 
using System.Timers;


namespace propagandaMachine
{
    public partial class Propagate : Form
    {
        Process openBrowser = new Process();
        string powerPointProject = @"";
        string powerPointOpener = @"C:\Program Files\Microsoft Office\Office16\POWERPNT.exe";        
        string cheers4Peers = @"https://app.tinypulse.com/engage?cheerfeed#sharing/cheer_feed?url=https%3A%2F%2Fapp.tinypulse.com%2Fapi%2Fcheers%3Factive_only%3Dtrue%26api_token%3Ddaf4e35c0eaf2489e11ab0%26organization_id%3D18876";
        string tinyPulseStats = @"";
        string mozilla = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
        int toggle = 0;

        public Propagate()
        {
            InitializeComponent();

            //creating two timers in order to have a loop. Although, this could also just be solved by a loop? Anyway, two timers keep the thing going. 
            System.Timers.Timer powerPointRepeat = new System.Timers.Timer();
            System.Timers.Timer browserToggle = new System.Timers.Timer();
            powerPointRepeat.Elapsed += new ElapsedEventHandler(tmrRunPP_Tick);
            browserToggle.Elapsed += new ElapsedEventHandler(tmrToggleBrowsers_Tick);
            powerPointRepeat.Interval = 2*60*1000;
            browserToggle.Interval = 10*60*1000; 
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

        private string toggleURLs(string url1, string url2)
        {
            if (toggle == 0)
            {
                toggle += 1;
                return url1; 
            }
            else
            {
                toggle = 0;
                return url2; 
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            stop.Enabled = true;
            try
            {
                startBrowser(mozilla, cheers4Peers);
            }
            catch
            {
                mozilla = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                startBrowser(mozilla, cheers4Peers);
            }
            start.Enabled = false;
            tmrRunPP.Enabled = true;
            tmrToggleBrowsers.Enabled = true; 
        }

        private void stop_Click(object sender, EventArgs e)
        {
            tmrRunPP.Enabled = false;
            tmrToggleBrowsers.Enabled = false;
            killBrowser(); 
            start.Enabled = true;
            stop.Enabled = false;

        }

        private void tmrRunPP_Tick(object sender, EventArgs e)
        {
            startPowerPointSlideShow(powerPointOpener, powerPointProject);
        }

        private void tmrToggleBrowsers_Tick(object sender, EventArgs e)
        {
            killBrowser();
            startBrowser(mozilla, toggleURLs(tinyPulseStats, cheers4Peers));
        }

        private void txtTinyPulseURL_TextChanged(object sender, EventArgs e)
        {
            tinyPulseStats = Path.Combine(tinyPulseStats, txtTinyPulseURL.Text);
        }

        private void txtPowerFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog importSelect = new OpenFileDialog();

            if (importSelect.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPowerFile.Text = importSelect.FileName;    
            }
            powerPointProject = Path.Combine(powerPointProject, txtPowerFile.Text);
        }
    }
}
