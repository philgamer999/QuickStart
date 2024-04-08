using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStart
{
    public partial class SubWindow : Form
    {
        MainWindow mainWindow = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
        Data data = new Data();

        public SubWindow()
        {
            InitializeComponent();
            data = DataManagement.ReturnData(mainWindow.jsonPath);
            ComboPreset.SelectedIndex = 0;
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            if (ComboPreset.SelectedIndex == 0)
            {

                mainWindow.SetInput(ComboSelectioin.SelectedIndex, "start \"\" \"" + TextBoxInput.Text + "\"");
            }
            else if (ComboPreset.SelectedIndex == 1)
            {
                mainWindow.SetInput(ComboSelectioin.SelectedIndex, TextBoxInput.Text);
            }
            this.Close();
        }

        private void ComboSelectioin_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxInput.Text = data.keys[ComboSelectioin.SelectedIndex];
        }
    }
}
