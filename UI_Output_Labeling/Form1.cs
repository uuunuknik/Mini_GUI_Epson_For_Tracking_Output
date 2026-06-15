using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RCAPINet;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace UI_Output_Labeling
{
    public partial class Form1 : Form
    {
        private Spel m_spel;
        public string minute = DateTime.Now.ToString("mm:ss");
        string cmd = "";
        int cd = 0;
        bool cmdComplete = false;
        string statusRun = "";
        bool isStart = false;

        FormSettings frmSettings1 = new FormSettings();

        OpenFileDialog browseRobotProject = new OpenFileDialog();

        public sealed class FormSettings : ApplicationSettingsBase
        {
            [UserScopedSettingAttribute()]
            [DefaultSettingValueAttribute("-")]
            public String projectPath
            {
                get { return (String)this["projectPath"]; }
                set { this["projectPath"] = value; }
            }

            [UserScopedSettingAttribute()]
            [DefaultSettingValueAttribute("1")]
            public String Connection
            {
                get { return (String)this["Connection"]; }
                set { this["Connection"] = value; }
            }
        }

        public Form1()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("erc70"))
                {
                    MessageBox.Show("Found process erc70");
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("erc70pServer"))
                {
                    MessageBox.Show("Found process erc70pServer");
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
            
            init();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (cmd != "")
            {
                if (cmd == "StartProject" && cd == 0)
                {
                    cmd = "";
                    startEpson();
                }
                else if (cmd == "StartPause" && cd == 3 && cmdComplete == false)
                {
                    cmdComplete = true;
                    pbExit.Enabled = false;

                    if (btnStartPause.Text == "START")
                    {
                        try
                        {
                            m_spel.Start(0);
                            btnStartPause.Text = "PAUSE";
                            btnStop.Enabled = true;
                            pbExit.Enabled = false;

                            statusRun = "Start";
                        }
                        catch
                        {
                            m_spel.ResetAbort();
                        }

                    }
                    else if (btnStartPause.Text == "PAUSE")
                    {
                        try
                        {
                            btnStartPause.Text = "CONTINUE";
                            m_spel.Call("TowerLightYellow");
                            m_spel.Call("ActivePause");
                            statusRun = "Pause";
                        }
                        catch
                        {

                        }
                    }
                    else if (btnStartPause.Text == "CONTINUE")
                    {
                        try
                        {
                            btnStartPause.Text = "PAUSE";
                            m_spel.Call("TowerLightYellow");
                            m_spel.Call("TowerLightGreen");
                            m_spel.Call("ActiveContinue");
                            statusRun = "Start";
                        }
                        catch
                        {

                        }
                    }
                }
                else if (cmd == "Stop" && cmdComplete == false)
                {
                    try
                    {
                        if (cd == 3)
                        {
                            m_spel.Call("TowerLightRed");
                            m_spel.Stop(SpelStopType.StopAllTasks);
                            m_spel.Stop();
                            m_spel.ResetAbort();
                        }
                        else if (cd == 0)
                        {
                            btnStartPause.Text = "START";
                            btnStartPause.Enabled = true;
                            btnStop.Enabled = false;
                            pbExit.Enabled = true;

                            statusRun = "Stop";
                            cmdComplete = true;
                        }
                    }
                    catch
                    {

                    }
                }
            }
            if (cmd != "" && cmdComplete == true)
            {
                cmd = "";
                if (statusRun == "Stop")
                {
                    pbExit.Enabled = true;
                    cd = 2;
                }
            }
            if (cmdComplete == true && m_spel.CommandInCycle == false && cd == 0)
            {
                updateEpson();
            }

            if (cd > 0)
            {
                cd--;
            }
            if (minute == "59:00")
            {
                saveConfigFile(lbOutput.Text);
                m_spel.SetVar("Output", "0");
            }
        }

        private void dtUpdate_Tick(object sender, EventArgs e)
        {
            minute = DateTime.Now.ToString("mm:ss");
        }

        void init()
        {
            frmSettings1.Reload();
            cbConnection.SelectedIndex = cbConnection.FindString(frmSettings1.Connection);
            tbPath.Text = frmSettings1.projectPath;

            lockButton();
        }

        void startEpson()
        {
            try
            {
                m_spel = new Spel();
                m_spel.Initialize();
                m_spel.NoProjectSync = true;
                m_spel.Project = tbPath.Text;
                m_spel.EventReceived += new Spel.EventReceivedEventHandler(m_spel_EventReceived);
                m_spel.EnableEvent(SpelEvents.EstopOn, true);
                m_spel.EnableEvent(SpelEvents.AllTasksStopped, true);
                m_spel.Connect(int.Parse(cbConnection.Text));

                isStart = true;
                cmdComplete = true;
                unlockButton();
            }
            catch (SpelException ex)
            {
                SaveLogError(DateTime.Now.ToString() + "  :: startEpson :: " + ex.ErrorNumber + " :: " + ex.Message);
            }
        }

        void updateEpson()
        {
            try
            {
                lbOutput.Text = Convert.ToString(m_spel.GetVar("Output"));
            }
            catch (SpelException ex)
            {
                SaveLogError(DateTime.Now.ToString() + "  :: updateEpson :: " + ex.ErrorNumber + " :: " + ex.Message);
            }
        }

        void lockButton()
        {
            btnStartPause.Enabled = false;
            btnStop.Enabled = false;
            pbIOT.Enabled = false;
        }

        void unlockButton()
        {
            btnStartPause.Enabled = true;
            pbExit.Enabled = true;
            pbIOT.Enabled = true;
        }

        void saveConfigFile(string output)
        {
            DateTime dt = DateTime.Now;
            string filename = dt.ToString("dd-MM-yyyy") + " " + (dt.Hour) + ".00";

            Stream fs = null;

            try
            {
                if (!Directory.Exists("C:\\OutputLabeling"))
                {
                    Directory.CreateDirectory("C:\\OutputLabeling\\");
                }
                if (!File.Exists("C:\\OutputLabeling\\" + filename + ".txt"))
                {
                    fs = new FileStream("C:\\OutputLabeling\\" + filename + ".txt", FileMode.CreateNew, FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        fs = null;
                        sw.WriteLine(output);
                    }
                }
            }
            catch (Exception e)
            {
                SaveLogError(DateTime.Now.ToString() + "  :: saveConfigFile : " + e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        public void SaveLogError(string data)
        {
            DateTime dt = DateTime.Now;
            string filename = dt.Day + "-" + dt.Month + "-" + dt.Year;

            Stream fs = null;

            try
            {
                if (!Directory.Exists("C:\\RobotLOG\\ErrorLog"))
                {
                    Directory.CreateDirectory("C:\\RobotLOG\\ErrorLog");
                }
                if (!File.Exists("C:\\RobotLOG\\ErrorLog\\" + filename + ".txt"))
                {
                    fs = new FileStream("C:\\RobotLOG\\ErrorLog\\" + filename + ".txt", FileMode.CreateNew, FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        fs = null;
                        sw.WriteLine(data);
                    }
                }
                else
                {
                    fs = new FileStream("C:\\RobotLOG\\ErrorLog\\" + filename + ".txt", FileMode.Append, FileAccess.Write);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        fs = null;
                        sw.WriteLine(data);
                    }
                }
            }
            catch (Exception e)
            {
                SaveLogError(DateTime.Now.ToString() + "  :: Error Log Exception : " + e.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        public void m_spel_EventReceived(object sender, SpelEventArgs e)
        {
            try
            {
                switch (e.Event)
                {
                    case SpelEvents.Error:

                        btnStartPause.Enabled = false;

                        try
                        {
                            cd = 3;
                            btnStartPause.Text = "START";
                            btnStartPause.Enabled = true;
                            btnStop.Enabled = false;
                            pbExit.Enabled = true;


                            statusRun = "Stop";
                            //cmdComplete = true;
                        }
                        catch
                        {
                        }

                        break;

                    case SpelEvents.AllTasksStopped:

                        try
                        {
                            if (cmd == "")
                            {
                                cd = 3;
                                btnStartPause.Text = "START";
                                btnStartPause.Enabled = true;
                                btnStop.Enabled = false;
                                pbExit.Enabled = true;

                                
                                statusRun = "Stop";
                                //cmdComplete = true;
                            }
                        }
                        catch
                        {
                        }

                        break;
                }
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.SetVar("Output", "0");
            }
            catch (SpelException ex)
            {
                MessageBox.Show("Error to reset output");
                SaveLogError(DateTime.Now.ToString() + "  :: reset output :: " + ex.ErrorNumber + " :: " + ex.Message);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the application ?", "Confirm Exit.", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(1);
            }
        }

        private void pbSelectPath_Click(object sender, EventArgs e)
        {
            browseRobotProject.InitialDirectory = "C:\\EpsonRC70\\projects";
            browseRobotProject.Filter = "RC50 Project File|*.sprj";
            if (browseRobotProject.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = browseRobotProject.FileName;
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (cmd == "" && cd == 0)
            {
                cmdComplete = false;
                cd = 4;
                cmd = "StartPause";
            }
            else
            {
                MessageBox.Show("Please wait command ready.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cmd == "" && cd == 0)
            {
                cmdComplete = false;
                cd = 4;
                cmd = "Stop";
            }
            else
            {
                MessageBox.Show("Please wait command ready.");
            }
        }

        private void btnStartProject_Click_1(object sender, EventArgs e)
        {
            if (tbPath.Text != "-" && tbPath.Text != "")
            {
                pbExit.Enabled = false;
                pbSelectPath.Enabled = false;
                btnStartProject.Enabled = false;
                tbPath.Enabled = false;
                cbConnection.Enabled = false;

                frmSettings1.projectPath = tbPath.Text;
                frmSettings1.Connection = cbConnection.Text;
                frmSettings1.Save();

                cmd = "StartProject";
                MainTimer.Enabled = true;
                cd = 5;
            }
            else
            {
                MessageBox.Show("Please choose project directory before start");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (isStart == true)
                {
                    m_spel.MotorsOn = false;
                    m_spel.Call("TowerLightRed");
                    m_spel.Disconnect();
                    m_spel.Dispose();
                    isStart = false;
                }
            }
            catch
            {
                m_spel.ResetAbort();
            }
        }

        private void pbIOT_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
