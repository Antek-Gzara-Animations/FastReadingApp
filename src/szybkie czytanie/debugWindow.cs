using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szybkie_czytanie
{
    public partial class debugWindow : Form
    {
        public bool CloseForm = false;

        public debugWindow()
        {
            InitializeComponent();
        }

        private void debugWindow_Load(object sender, EventArgs e)
        {

        }

        public void print(string textInput, string sender = "unknown")
        {
            text.Items.Add("<" + sender + ">: " + textInput);
        }

        private void debugWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseForm)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                //close this form
            }
        }
    }
}
