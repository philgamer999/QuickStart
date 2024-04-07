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
        DataManagement dataManagement = new DataManagement();

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
            data = DataManagement.ReturnData(jsonPath);

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
                dataManagement.JSONWrite(data, jsonPath);
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEYS[76]) // Load
            {
                data = DataManagement.ReturnData(jsonPath);
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
                            startInfo.Arguments = $"/c {data.keys[i]}";
                            process.StartInfo = startInfo;
                            process.Start();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine (ex.ToString());
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void GetInput()
        {
            SubWindow subWindow = new SubWindow();
            subWindow.Show();
        }

        public void SetInput(int id, string input)
        {
            data.keys[id] = input;
            dataManagement.JSONWrite(data, jsonPath);
        }

        public void CreateFiles()
        {
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            if (!File.Exists(jsonPath))
            {
                File.AppendAllText(jsonPath, "{\r\n    \"keys\": [\r\n        \"None\",\r\n        \"LButton\",\r\n        \"RButton\",\r\n        \"Cancel\",\r\n        \"MButton\",\r\n        \"XButton1\",\r\n        \"XButton2\",\r\n        \"LButton, XButton2\",\r\n        \"Back\",\r\n        \"Tab\",\r\n        \"LineFeed\",\r\n        \"LButton, LineFeed\",\r\n        \"Clear\",\r\n        \"Return\",\r\n        \"RButton, Clear\",\r\n        \"RButton, Return\",\r\n        \"ShiftKey\",\r\n        \"ControlKey\",\r\n        \"Menu\",\r\n        \"Pause\",\r\n        \"Capital\",\r\n        \"KanaMode\",\r\n        \"RButton, Capital\",\r\n        \"JunjaMode\",\r\n        \"FinalMode\",\r\n        \"HanjaMode\",\r\n        \"RButton, FinalMode\",\r\n        \"Escape\",\r\n        \"IMEConvert\",\r\n        \"IMENonconvert\",\r\n        \"IMEAceept\",\r\n        \"IMEModeChange\",\r\n        \"Space\",\r\n        \"PageUp\",\r\n        \"Next\",\r\n        \"End\",\r\n        \"Home\",\r\n        \"Left\",\r\n        \"Up\",\r\n        \"Right\",\r\n        \"Down\",\r\n        \"Select\",\r\n        \"Print\",\r\n        \"Execute\",\r\n        \"PrintScreen\",\r\n        \"Insert\",\r\n        \"Delete\",\r\n        \"Help\",\r\n        \"D0\",\r\n        \"D1\",\r\n        \"D2\",\r\n        \"D3\",\r\n        \"D4\",\r\n        \"D5\",\r\n        \"D6\",\r\n        \"D7\",\r\n        \"D8\",\r\n        \"D9\",\r\n        \"RButton, D8\",\r\n        \"RButton, D9\",\r\n        \"MButton, D8\",\r\n        \"MButton, D9\",\r\n        \"XButton2, D8\",\r\n        \"XButton2, D9\",\r\n        \"64\",\r\n        \"A\",\r\n        \"B\",\r\n        \"C\",\r\n        \"D\",\r\n        \"E\",\r\n        \"F\",\r\n        \"G\",\r\n        \"H\",\r\n        \"I\",\r\n        \"J\",\r\n        \"K\",\r\n        \"L\",\r\n        \"M\",\r\n        \"N\",\r\n        \"O\",\r\n        \"P\",\r\n        \"Q\",\r\n        \"R\",\r\n        \"S\",\r\n        \"T\",\r\n        \"U\",\r\n        \"V\",\r\n        \"W\",\r\n        \"X\",\r\n        \"Y\",\r\n        \"Z\",\r\n        \"LWin\",\r\n        \"RWin\",\r\n        \"Apps\",\r\n        \"RButton, RWin\",\r\n        \"Sleep\",\r\n        \"NumPad0\",\r\n        \"NumPad1\",\r\n        \"NumPad2\",\r\n        \"NumPad3\",\r\n        \"NumPad4\",\r\n        \"NumPad5\",\r\n        \"NumPad6\",\r\n        \"NumPad7\",\r\n        \"NumPad8\",\r\n        \"NumPad9\",\r\n        \"Multiply\",\r\n        \"Add\",\r\n        \"Separator\",\r\n        \"Subtract\",\r\n        \"Decimal\",\r\n        \"Divide\",\r\n        \"F1\",\r\n        \"F2\",\r\n        \"F3\",\r\n        \"F4\",\r\n        \"F5\",\r\n        \"F6\",\r\n        \"F7\",\r\n        \"F8\",\r\n        \"F9\",\r\n        \"F10\",\r\n        \"F11\",\r\n        \"F12\",\r\n        \"F13\",\r\n        \"F14\",\r\n        \"F15\",\r\n        \"F16\",\r\n        \"F17\",\r\n        \"F18\",\r\n        \"F19\",\r\n        \"F20\",\r\n        \"F21\",\r\n        \"F22\",\r\n        \"F23\",\r\n        \"F24\",\r\n        \"Back, F17\",\r\n        \"Back, F18\",\r\n        \"Back, F19\",\r\n        \"Back, F20\",\r\n        \"Back, F21\",\r\n        \"Back, F22\",\r\n        \"Back, F23\",\r\n        \"Back, F24\",\r\n        \"NumLock\",\r\n        \"Scroll\",\r\n        \"RButton, NumLock\",\r\n        \"RButton, Scroll\",\r\n        \"MButton, NumLock\",\r\n        \"MButton, Scroll\",\r\n        \"XButton2, NumLock\",\r\n        \"XButton2, Scroll\",\r\n        \"Back, NumLock\",\r\n        \"Back, Scroll\",\r\n        \"LineFeed, NumLock\",\r\n        \"LineFeed, Scroll\",\r\n        \"Clear, NumLock\",\r\n        \"Clear, Scroll\",\r\n        \"RButton, Clear, NumLock\",\r\n        \"RButton, Clear, Scroll\",\r\n        \"LShiftKey\",\r\n        \"RShiftKey\",\r\n        \"LControlKey\",\r\n        \"RControlKey\",\r\n        \"LMenu\",\r\n        \"RMenu\",\r\n        \"BrowserBack\",\r\n        \"BrowserForward\",\r\n        \"BrowserRefresh\",\r\n        \"BrowserStop\",\r\n        \"BrowserSearch\",\r\n        \"BrowserFavorites\",\r\n        \"BrowserHome\",\r\n        \"VolumeMute\",\r\n        \"VolumeDown\",\r\n        \"VolumeUp\",\r\n        \"MediaNextTrack\",\r\n        \"MediaPreviousTrack\",\r\n        \"MediaStop\",\r\n        \"MediaPlayPause\",\r\n        \"LaunchMail\",\r\n        \"SelectMedia\",\r\n        \"LaunchApplication1\",\r\n        \"LaunchApplication2\",\r\n        \"Back, MediaNextTrack\",\r\n        \"Back, MediaPreviousTrack\",\r\n        \"Oem1\",\r\n        \"Oemplus\",\r\n        \"Oemcomma\",\r\n        \"OemMinus\",\r\n        \"OemPeriod\",\r\n        \"OemQuestion\",\r\n        \"Oemtilde\",\r\n        \"LButton, Oemtilde\",\r\n        \"RButton, Oemtilde\",\r\n        \"Cancel, Oemtilde\",\r\n        \"MButton, Oemtilde\",\r\n        \"XButton1, Oemtilde\",\r\n        \"XButton2, Oemtilde\",\r\n        \"LButton, XButton2, Oemtilde\",\r\n        \"Back, Oemtilde\",\r\n        \"Tab, Oemtilde\",\r\n        \"LineFeed, Oemtilde\",\r\n        \"LButton, LineFeed, Oemtilde\",\r\n        \"Clear, Oemtilde\",\r\n        \"Return, Oemtilde\",\r\n        \"RButton, Clear, Oemtilde\",\r\n        \"RButton, Return, Oemtilde\",\r\n        \"ShiftKey, Oemtilde\",\r\n        \"ControlKey, Oemtilde\",\r\n        \"Menu, Oemtilde\",\r\n        \"Pause, Oemtilde\",\r\n        \"Capital, Oemtilde\",\r\n        \"KanaMode, Oemtilde\",\r\n        \"RButton, Capital, Oemtilde\",\r\n        \"JunjaMode, Oemtilde\",\r\n        \"FinalMode, Oemtilde\",\r\n        \"HanjaMode, Oemtilde\",\r\n        \"RButton, FinalMode, Oemtilde\",\r\n        \"OemOpenBrackets\",\r\n        \"Oem5\",\r\n        \"Oem6\",\r\n        \"Oem7\",\r\n        \"Oem8\",\r\n        \"Space, Oemtilde\",\r\n        \"PageUp, Oemtilde\",\r\n        \"OemBackslash\",\r\n        \"LButton, OemBackslash\",\r\n        \"Home, Oemtilde\",\r\n        \"ProcessKey\",\r\n        \"MButton, OemBackslash\",\r\n        \"Packet\",\r\n        \"Down, Oemtilde\",\r\n        \"Select, Oemtilde\",\r\n        \"Back, OemBackslash\",\r\n        \"Tab, OemBackslash\",\r\n        \"PrintScreen, Oemtilde\",\r\n        \"Back, ProcessKey\",\r\n        \"Clear, OemBackslash\",\r\n        \"Back, Packet\",\r\n        \"D0, Oemtilde\",\r\n        \"D1, Oemtilde\",\r\n        \"ShiftKey, OemBackslash\",\r\n        \"ControlKey, OemBackslash\",\r\n        \"D4, Oemtilde\",\r\n        \"ShiftKey, ProcessKey\",\r\n        \"Attn\",\r\n        \"Crsel\",\r\n        \"Exsel\",\r\n        \"EraseEof\",\r\n        \"Play\",\r\n        \"Zoom\",\r\n        \"NoName\",\r\n        \"Pa1\",\r\n        \"OemClear\",\r\n        \"LButton, OemClear\" \r\n        ]\r\n    }");
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataManagement.JSONWrite(data, jsonPath);
        }
    }
}
