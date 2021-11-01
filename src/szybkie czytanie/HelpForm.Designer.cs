
namespace szybkie_czytanie
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SystemBrowserbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(0, 1135);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(2240, 111);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(2240, 1135);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // SystemBrowserbutton
            // 
            this.SystemBrowserbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SystemBrowserbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SystemBrowserbutton.FlatAppearance.BorderSize = 0;
            this.SystemBrowserbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SystemBrowserbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SystemBrowserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemBrowserbutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemBrowserbutton.Location = new System.Drawing.Point(0, 1024);
            this.SystemBrowserbutton.Name = "SystemBrowserbutton";
            this.SystemBrowserbutton.Size = new System.Drawing.Size(2240, 111);
            this.SystemBrowserbutton.TabIndex = 2;
            this.SystemBrowserbutton.Text = "OPEN IN SYSTEM WEB BROWSER";
            this.SystemBrowserbutton.UseVisualStyleBackColor = false;
            this.SystemBrowserbutton.Click += new System.EventHandler(this.SystemBrowserbutton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2240, 1246);
            this.Controls.Add(this.SystemBrowserbutton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button SystemBrowserbutton;
    }
}