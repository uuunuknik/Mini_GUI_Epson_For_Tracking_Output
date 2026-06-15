using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace UI_Output_Labeling
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            findConfigFile();
        }

        void findConfigFile()
        {
            dataGridViewOutput.Rows.Clear();
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 24; i++)
            {
                string filename = dtPick.Value.ToString("dd-MM-yyyy") + " " + i + ".00";
                Stream fs = null;

                try
                {
                    if (File.Exists("C:\\OutputLabeling\\" + filename + ".txt"))
                    {
                        string[] filePathOutput = Directory.GetFiles("C:\\OutputLabeling", filename + ".txt");
                        foreach (string current in filePathOutput)
                        {
                            try
                            {
                                string readText = System.IO.File.ReadAllText(current);
                                dataGridViewOutput.Rows.Add(i + ".00 - " + i + ".59", readText);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.ToString());
                            }
                            finally
                            {
                                if (fs != null)
                                    fs.Close();
                            }
                        }
                    }
                    else
                    {
                        dataGridViewOutput.Rows.Add(i + ".00 - " + i + ".59", 0);
                    }
                }
                catch (Exception e)
                {
                    SaveLogError(DateTime.Now.ToString() + "  :: findConfigFile : " + e.Message);
                }
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtPick_ValueChanged(object sender, EventArgs e)
        {
            if(dtPick.Value <= DateTime.Now)
            {
                findConfigFile();
            }
            else
            {
                MessageBox.Show("Error DateTime!!!");
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
    }
}
