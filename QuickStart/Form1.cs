using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace QuickStart
{
    public partial class MainWindow : Form
    {
        public string dataPath;
        public string jsonPath;
        Data data = new Data();

        public int inputID { get; set; }
        public string input { get; set; }


        // Imports
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Keys
        List<int> HOTKEYS = new List<int>();

        public MainWindow()
        {
            InitializeComponent();

            dataPath = Application.StartupPath + "/data";
            jsonPath = dataPath + "/data.json";

            CreateFiles();
            JSONRead();

            /*NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(60000);*/

            // Register Keys
            // Madifiers: Alt = 1; Ctrl = 2; Shift = 4; Win = 8
            // Alt + Ctrl -> 1 + 2 = 3 
            //RegisterHotKey(this.Handle, HOTKEY_ID_X, 3, (int)Keys.A);
            //RegisterHotKey(this.Handle, HOTKEY_ID_ESCAPE, 3, (int)Keys.Escape); 
            for (int i = 0; i < 256; i++)
            {
                HOTKEYS.Add(i);
                RegisterHotKey(this.Handle, HOTKEYS[i], 3, i);
            }
        }
        protected override void WndProc(ref Message m)
        {
            //Data data = new Data(); 
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[27]) // CHECK ALL
            {
                Application.Exit();
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[83]) // Save
            {
                JSONWrite();
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[76]) // Load
            {
                JSONRead();
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[112]) // Load
            {
                GetInput();
            }

            for (int i = 0; i < 256; i++)
            {
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[i]) // CHECK ALL
                {
                    Console.WriteLine($"{i} : {(Keys)Enum.Parse(typeof(Keys), ((Keys)i).ToString())} : {data.keys[i]}");
                    if (((Keys)i).ToString().Replace(", ", "_").Replace("64", "_64") != data.keys[i])
                    {
                        try
                        {
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "cmd.exe";
                            startInfo.Arguments = $"/c start {data.keys[i]}";
                            process.StartInfo = startInfo;
                            process.Start();
                            //Console.WriteLine($"{(Keys)Enum.Parse(typeof(Keys), ((Keys)i).ToString())}".Replace(", ", "_").Replace("64", "_64"));
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine (ex.ToString());
                        }
                    }
                }
            }

            /*if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[88]) // GET ALL IDs
            {
                Console.Write("public string[] keys = { ");
                for (int i = 0; i < 256; i++)
                {
                    //Console.WriteLine($"{i} : {(Keys)Enum.Parse(typeof(Keys), ((Keys)i).ToString())}");
                    //Console.WriteLine($"public string {(Keys)Enum.Parse(typeof(Keys), ((Keys)i).ToString())};");
                    //Console.Write("\"" + $"{ (Keys)Enum.Parse(typeof(Keys), ((Keys)i).ToString())}" + "\", ");
                    //File.AppendAllText(@"D:\pc\Development\VisualStudio\Workspaces\QuickStart\QuickStart\IDS.txt", $"{i} : {(Keys)Enum.Parse(typeof(Keys), ((Keys)i).ToString())}\n");
                }
                Console.Write($";");
            }*/
            base.WndProc(ref m);
        }

        public void JSONRead()
        {
            try
            {
                data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(jsonPath));
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void JSONWrite()
        {
            try
            {
                SerializeToJsonFile(data, jsonPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SerializeToJsonFile<T>(T obj, string filePath)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void GetInput()
        {
            SubWindow subWindow = new SubWindow();
            subWindow.Show();
        }

        public void SetInput(int id, string input)
        {
            data.keys[id] = input;
        }

        public void CreateFiles()
        {
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONWrite();
        }
    }
}
