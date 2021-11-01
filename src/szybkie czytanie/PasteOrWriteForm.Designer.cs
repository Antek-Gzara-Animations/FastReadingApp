
namespace szybkie_czytanie
{
    partial class PasteOrWriteForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.HEADERLABEL = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(0, 1171);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(2126, 111);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(0, 1060);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(2126, 111);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Clearbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Clearbutton.FlatAppearance.BorderSize = 0;
            this.Clearbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(0, 949);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(2126, 111);
            this.Clearbutton.TabIndex = 3;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            // 
            // HEADERLABEL
            // 
            this.HEADERLABEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.HEADERLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HEADERLABEL.Location = new System.Drawing.Point(0, 0);
            this.HEADERLABEL.Name = "HEADERLABEL";
            this.HEADERLABEL.Size = new System.Drawing.Size(2126, 47);
            this.HEADERLABEL.TabIndex = 4;
            this.HEADERLABEL.Text = "ENTER OR PASTE TEXT TO READ";
            this.HEADERLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(2126, 902);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // PasteOrWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2126, 1282);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HEADERLABEL);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.MinimizeBox = false;
            this.Name = "PasteOrWriteForm";
            this.Text = "PasteOrWriteForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Label HEADERLABEL;
        public System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}