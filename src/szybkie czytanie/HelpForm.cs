using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace szybkie_czytanie
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            //MessageBox.Show(new Uri(String.Format("{0}/HTML/index.html", curDir)).ToString());  //only for debugging
            this.webBrowser1.Url = new Uri(String.Format("{0}/HTML/index.html", curDir));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SystemBrowserbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", new Uri(String.Format("{0}/HTML/index.html", Directory.GetCurrentDirectory())).ToString());
        }
    }
}
