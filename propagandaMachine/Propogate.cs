using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO; 
using System.Timers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;


namespace propagandaMachine
{
    public partial class Propagate : Form
    {
        private Process openBrowser = new Process();
        private string powerPointProject = @"";
        private string powerPointOpener = @"C:\Program Files\Microsoft Office\Office16\POWERPNT.exe";        
        private string cheers4Peers = @"https://app.tinypulse.com/engage?cheerfeed#sharing/cheer_feed?url=https%3A%2F%2Fapp.tinypulse.com%2Fapi%2Fcheers%3Factive_only%3Dtrue%26api_token%3Ddaf4e35c0eaf2489e11ab0%26organization_id%3D18876";
        private string tinyPulseStats = @"";
        private string mozilla = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
        private int toggle = 0;

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

        public FirefoxDriver startBrowser(string file, string url)
        {
//            var browserOptions = new FirefoxOptions();
            var driver = new FirefoxDriver();
            driver.Manage().Window.FullScreen();
            driver.Navigate().GoToUrl(url);

            return driver; 
        }

        public FirefoxDriver newTab(FirefoxDriver driver, string url)
        {
            
            return driver; 
        }

        public void killBrowser(FirefoxDriver driver)
        {
            driver.Quit();
        }

        public void startPowerPointSlideShow (string ppAppfile, string ppfile)
        {
            var openPower = new Process();
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
            killBrowser(startBrowser()); 
            start.Enabled = true;
            stop.Enabled = false;

        }

        private void tmrRunPP_Tick(object sender, EventArgs e)
        {
            startPowerPointSlideShow(powerPointOpener, powerPointProject);
        }

        private void tmrToggleBrowsers_Tick(object sender, EventArgs e)
        {
            killBrowser(openBrowser);
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
