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
    public partial class Form1 : Form
    {
        private List<string> text = new List<string>
        {
            "To",
            "jest",
            "testowy",
            "tekst",
            "aplikacji",
            "do",
            "szybkiego",
            "czytania.",
            "Mam",
            "nadzieję",
            "że",
            "Ci",
            "się",
            "podoba.",
            "Jeśli",
            "tak",
            "to",
            "napisz",
            "mi",
            "o",
            "tym"
        };

        private int count = 0;
        private bool IsRunning = false;

        private bool SmartSpeedEnabled = false;

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private PasteOrWriteForm pasteOrWriteForm = new PasteOrWriteForm();
        private HelpForm helpForm = new HelpForm();

        private debugWindow DebugWindow = new debugWindow(); //window showing debug information (opened by pressing ctrl + d) 

        public Form1()
        {
            InitializeComponent();

            pasteOrWriteForm.FormClosed += new FormClosedEventHandler(PasteOrWriteForm_FormClosed);
            pasteOrWriteForm.OKButton.Click += new EventHandler(PasteOrWriteForm_OKbutton_Click);
            helpForm.FormClosed += new FormClosedEventHandler(HelpForm_FormClosed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DebugWindow.print("FormLoaded");

            MainText.Text = "Select file or press start";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DebugWindow.CloseForm = true; // when user want to close this form it's actually hides instead of closing
            DebugWindow.Close();
            Application.Exit();
        }

        private void HIDEbutton_Click(object sender, EventArgs e)
        {
            DebugWindow.print("Form hidden", "form1");

            WindowState = FormWindowState.Minimized;
        }

        private void OPENFILEbutton_Click(object sender, EventArgs e)
        {

            text.Clear();

            DebugWindow.print("open file dialog visible", "open file button");

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                DebugWindow.print("dialogResult OK", "OpenFileDialog");

                path = openFileDialog1.FileName;
                //MessageBox.Show(path);
                string TextFromFile = File.ReadAllText(path) + ' ';
                string bufferText = "";

                for(int i = 0; i < TextFromFile.Length; i++)
                {
                    bufferText += TextFromFile[i];
                    if(TextFromFile[i] == ' ' || TextFromFile[i] == '\n')
                    {
                        text.Add(bufferText);
                        bufferText = "";            
                    }
                }
            }
        }

        private void STARTSTOPbutton_Click(object sender, EventArgs e)
        {
            DebugWindow.print("START/STOP button clicked", "start/stop button");

            if (!IsRunning)
            {
                DebugWindow.print("main text timer has started", "start/stop button");

                MainTextTimer.Start();
                STARTSTOPbutton.Text = "STOP";
                count = 0;

                IsRunning = true;
            }
            else
            {
                DebugWindow.print("main text timer has stopped", "start/stop button");

                MainTextTimer.Stop();
                STARTSTOPbutton.Text = "START";
                count = 0;
                MainText.Text = "Select file or press start";

                IsRunning = false;
            }
        }

        private void MainText_Click(object sender, EventArgs e)
        {

        }

        private void MainTextTimer_Tick(object sender, EventArgs e)
        {
            if (count < text.Count)
            {
                MainText.Text = text[count];
                #region smart speed
                if (SmartSpeedEnabled && count < text.Count + 1)
                {
                    int NextInterval = 0;
                    switch (text[count].Length)
                    {
                        case 0:
                            NextInterval = 50;
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            NextInterval = 300;
                            break;
                        case 5:
                        case 6:
                            NextInterval = 500;
                            break;
                        case 7:
                        case 8:
                            NextInterval = 600;
                            break;
                        default:
                            NextInterval = 700;
                            break;
                    }

                    DebugWindow.print(NextInterval.ToString(), "SmartSpeed Interval");

                    MainTextTimer.Interval = NextInterval;
                }
                else
                {
                    MainTextTimer.Interval = 300; // default value
                }
                count++;
                #endregion
            }
            else
            {
                MainTextTimer.Stop();
                IsRunning = false;
                STARTSTOPbutton.Text = "START";
                MainText.Text = "Select file or press start";

                DebugWindow.print("main text timer finished", "main text timer");
            }
            
        }



        #region context menu strip
        private void pASTEFROMCLIPBOARDORWRITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteOrWriteButton_Click(sender, e);
        }

        private void sTARTSTOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STARTSTOPbutton_Click(sender, e);
        }

        private void oPENFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPENFILEbutton_Click(sender, e);
        }

        private void hIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HIDEbutton_Click(sender, e);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
        }

        #endregion

        private void PasteOrWriteButton_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            DebugWindow.print("pasteOrwriteWindow visible", "PAsteORWrite button");

            pasteOrWriteForm.ShowDialog();
        }

        private void PasteOrWriteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.TopMost = true;
        }
        private void PasteOrWriteForm_OKbutton_Click(object sender, EventArgs e)
        {
            text.Clear();

            string EnteredText = pasteOrWriteForm.richTextBox1.Text + ' ';
            string bufferText = "";

            for (int i = 0; i < EnteredText.Length; i++)
            {
                bufferText += EnteredText[i];
                if (EnteredText[i] == ' ' || EnteredText[i] == '\n')
                {
                    text.Add(bufferText);
                    bufferText = "";
                }
            }

            pasteOrWriteForm.Close();
        }

        private void PasteOrWriteForm_CANCELbutton_Click(object sender, FormClosedEventArgs e)
        {
            //nothing
            
            pasteOrWriteForm.Close();
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            helpForm.ShowDialog();
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.TopMost = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.TopMost = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            hELPToolStripMenuItem_Click(sender, e);
        }

        private void speedLabel_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            speedLabel.Text = "speed:" + ((double)trackBar1.Value * 0.01).ToString() + "s - " + (trackBar1.Value * 10).ToString() + "ms";
            MainTextTimer.Interval = trackBar1.Value * 10;
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 30;
            trackBar1_Scroll(sender, e); //I shouldnt do that, but it works
            DebugWindow.print("changed interval to default value (0)", "default button");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DebugWindow.print("checkbox1pressed", "smartspeed checkbox");
            if (checkBox1.Checked)
            {
                trackBar1.Enabled = false; //disable mannual speed controll
                defaultButton.Enabled = false;

                SmartSpeedEnabled = true;
                DebugWindow.print("true", "smartspeedEnabled?");
                
            }
            else
            {
                trackBar1.Enabled = true; //enable mannual speed controll
                defaultButton.Enabled = true;

                SmartSpeedEnabled = false;
                DebugWindow.print("false", "smartspeedEnabled?");
                
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //keyboard shortcuts
        {
            if(e.Control && e.KeyCode == Keys.D) //debug window
            {
                if (!DebugWindow.Visible)
                {
                    DebugWindow.Show();
                }
                else
                {
                    DebugWindow.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DebugWindow.CloseForm = true; // when user want to close this form it's actually hides instead of closing
        }
    }
}
