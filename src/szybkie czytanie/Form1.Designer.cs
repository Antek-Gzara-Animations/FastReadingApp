
namespace szybkie_czytanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTARTSTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOMOCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HIDEbutton = new System.Windows.Forms.Button();
            this.OPENFILEbutton = new System.Windows.Forms.Button();
            this.STARTSTOPbutton = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.Label();
            this.MainTextTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PasteOrWriteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.defaultButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.ContextMenuStrip = this.contextMenuStrip1;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(0, 945);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(2480, 81);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.toolTip1.SetToolTip(this.ExitButton, "exit");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem,
            this.sTARTSTOPToolStripMenuItem,
            this.oPENFILEToolStripMenuItem,
            this.hIDEToolStripMenuItem,
            this.eXITToolStripMenuItem,
            this.pOMOCToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(374, 196);
            // 
            // pASTEFROMCLIPBOARDORWRITEToolStripMenuItem
            // 
            this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem.Name = "pASTEFROMCLIPBOARDORWRITEToolStripMenuItem";
            this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem.Text = "PASTE FROM CLIPBOARD OR WRITE";
            this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem.Click += new System.EventHandler(this.pASTEFROMCLIPBOARDORWRITEToolStripMenuItem_Click);
            // 
            // sTARTSTOPToolStripMenuItem
            // 
            this.sTARTSTOPToolStripMenuItem.Name = "sTARTSTOPToolStripMenuItem";
            this.sTARTSTOPToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.sTARTSTOPToolStripMenuItem.Text = "START/STOP";
            this.sTARTSTOPToolStripMenuItem.Click += new System.EventHandler(this.sTARTSTOPToolStripMenuItem_Click);
            // 
            // oPENFILEToolStripMenuItem
            // 
            this.oPENFILEToolStripMenuItem.Name = "oPENFILEToolStripMenuItem";
            this.oPENFILEToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.oPENFILEToolStripMenuItem.Text = "OPEN FILE";
            this.oPENFILEToolStripMenuItem.Click += new System.EventHandler(this.oPENFILEToolStripMenuItem_Click);
            // 
            // hIDEToolStripMenuItem
            // 
            this.hIDEToolStripMenuItem.Name = "hIDEToolStripMenuItem";
            this.hIDEToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.hIDEToolStripMenuItem.Text = "HIDE";
            this.hIDEToolStripMenuItem.Click += new System.EventHandler(this.hIDEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // pOMOCToolStripMenuItem
            // 
            this.pOMOCToolStripMenuItem.Name = "pOMOCToolStripMenuItem";
            this.pOMOCToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.pOMOCToolStripMenuItem.Text = "HELP";
            this.pOMOCToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // HIDEbutton
            // 
            this.HIDEbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HIDEbutton.ContextMenuStrip = this.contextMenuStrip1;
            this.HIDEbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HIDEbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HIDEbutton.FlatAppearance.BorderSize = 0;
            this.HIDEbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HIDEbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.HIDEbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HIDEbutton.Location = new System.Drawing.Point(0, 864);
            this.HIDEbutton.Name = "HIDEbutton";
            this.HIDEbutton.Size = new System.Drawing.Size(2480, 81);
            this.HIDEbutton.TabIndex = 3;
            this.HIDEbutton.Text = "HIDE";
            this.toolTip1.SetToolTip(this.HIDEbutton, "hide");
            this.HIDEbutton.UseVisualStyleBackColor = false;
            this.HIDEbutton.Click += new System.EventHandler(this.HIDEbutton_Click);
            // 
            // OPENFILEbutton
            // 
            this.OPENFILEbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OPENFILEbutton.ContextMenuStrip = this.contextMenuStrip1;
            this.OPENFILEbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OPENFILEbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OPENFILEbutton.FlatAppearance.BorderSize = 0;
            this.OPENFILEbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OPENFILEbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OPENFILEbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OPENFILEbutton.Location = new System.Drawing.Point(0, 783);
            this.OPENFILEbutton.Name = "OPENFILEbutton";
            this.OPENFILEbutton.Size = new System.Drawing.Size(2480, 81);
            this.OPENFILEbutton.TabIndex = 4;
            this.OPENFILEbutton.Text = "OPEN FILE";
            this.toolTip1.SetToolTip(this.OPENFILEbutton, "open file");
            this.OPENFILEbutton.UseVisualStyleBackColor = false;
            this.OPENFILEbutton.Click += new System.EventHandler(this.OPENFILEbutton_Click);
            // 
            // STARTSTOPbutton
            // 
            this.STARTSTOPbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.STARTSTOPbutton.ContextMenuStrip = this.contextMenuStrip1;
            this.STARTSTOPbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.STARTSTOPbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.STARTSTOPbutton.FlatAppearance.BorderSize = 0;
            this.STARTSTOPbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.STARTSTOPbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.STARTSTOPbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STARTSTOPbutton.Location = new System.Drawing.Point(0, 712);
            this.STARTSTOPbutton.Name = "STARTSTOPbutton";
            this.STARTSTOPbutton.Size = new System.Drawing.Size(2480, 71);
            this.STARTSTOPbutton.TabIndex = 1;
            this.STARTSTOPbutton.Text = "START/STOP";
            this.toolTip1.SetToolTip(this.STARTSTOPbutton, "start or stop");
            this.STARTSTOPbutton.UseVisualStyleBackColor = false;
            this.STARTSTOPbutton.Click += new System.EventHandler(this.STARTSTOPbutton_Click);
            // 
            // MainText
            // 
            this.MainText.ContextMenuStrip = this.contextMenuStrip1;
            this.MainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainText.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.MainText.Location = new System.Drawing.Point(0, 0);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(2480, 712);
            this.MainText.TabIndex = 5;
            this.MainText.Text = "Text";
            this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.MainText, "read this text");
            this.MainText.Click += new System.EventHandler(this.MainText_Click);
            // 
            // MainTextTimer
            // 
            this.MainTextTimer.Interval = 300;
            this.MainTextTimer.Tick += new System.EventHandler(this.MainTextTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = ".txt";
            this.openFileDialog1.Filter = "text files|*.txt|All files|*.*";
            // 
            // PasteOrWriteButton
            // 
            this.PasteOrWriteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasteOrWriteButton.ContextMenuStrip = this.contextMenuStrip1;
            this.PasteOrWriteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PasteOrWriteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PasteOrWriteButton.FlatAppearance.BorderSize = 0;
            this.PasteOrWriteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasteOrWriteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PasteOrWriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteOrWriteButton.Location = new System.Drawing.Point(0, 635);
            this.PasteOrWriteButton.Name = "PasteOrWriteButton";
            this.PasteOrWriteButton.Size = new System.Drawing.Size(2480, 77);
            this.PasteOrWriteButton.TabIndex = 6;
            this.PasteOrWriteButton.Text = "PASTE FROM CLIPBOARD OR WRITE";
            this.toolTip1.SetToolTip(this.PasteOrWriteButton, "paste from clipboard or write");
            this.PasteOrWriteButton.UseVisualStyleBackColor = false;
            this.PasteOrWriteButton.Click += new System.EventHandler(this.PasteOrWriteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::szybkie_czytanie.Properties.Resources.questionMark1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 96);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(117, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(365, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(117, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(152, 20);
            this.speedLabel.TabIndex = 9;
            this.speedLabel.Text = "speed: 0.3s - 300ms";
            this.speedLabel.Click += new System.EventHandler(this.speedLabel_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.defaultButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.defaultButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.defaultButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.defaultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultButton.Location = new System.Drawing.Point(488, 0);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(100, 58);
            this.defaultButton.TabIndex = 10;
            this.defaultButton.Text = "default value";
            this.defaultButton.UseVisualStyleBackColor = false;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(121, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Smart speed (experimantal)";
            this.toolTip1.SetToolTip(this.checkBox1, "time between displayed \r\nwords will be based on\r\ndisplayed word length");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(2298, -2);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(182, 80);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "orginal content from\r\nAntek Gzara Animations\r\nYoungDevPl\r\n2021";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(2480, 1026);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasteOrWriteButton);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.STARTSTOPbutton);
            this.Controls.Add(this.OPENFILEbutton);
            this.Controls.Add(this.HIDEbutton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "EXIT";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HIDEbutton;
        private System.Windows.Forms.Button OPENFILEbutton;
        private System.Windows.Forms.Button STARTSTOPbutton;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Timer MainTextTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PasteOrWriteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pASTEFROMCLIPBOARDORWRITEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTARTSTOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENFILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOMOCToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label NameLabel;
    }
}

