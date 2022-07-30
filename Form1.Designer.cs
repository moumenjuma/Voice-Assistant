namespace Voice_Assistant_Cyrus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmdBox = new System.Windows.Forms.ListBox();
            this.TSpeech = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdBox
            // 
            this.cmdBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmdBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBox.ForeColor = System.Drawing.SystemColors.Window;
            this.cmdBox.FormattingEnabled = true;
            this.cmdBox.Location = new System.Drawing.Point(0, 0);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(549, 330);
            this.cmdBox.TabIndex = 0;
            // 
            // TSpeech
            // 
            this.TSpeech.Enabled = true;
            this.TSpeech.Interval = 1000;
            this.TSpeech.Tick += new System.EventHandler(this.TSpeech_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(549, 330);
            this.Controls.Add(this.cmdBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cmdBox;
        private System.Windows.Forms.Timer TSpeech;
    }
}

