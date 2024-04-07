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

        public SubWindow()
        {
            InitializeComponent();
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            mainWindow.SetInput(ComboSelectioin.SelectedIndex, TextBoxInput.Text);
            this.Close();
        }
    }
}
