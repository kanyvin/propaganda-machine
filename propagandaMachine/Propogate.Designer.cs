﻿namespace propagandaMachine
{
    partial class Propagate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propagate));
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.tmrRunPP = new System.Windows.Forms.Timer(this.components);
            this.txtTinyPulseURL = new System.Windows.Forms.TextBox();
            this.lblTinyPulseURL = new System.Windows.Forms.Label();
            this.tmrToggleBrowsers = new System.Windows.Forms.Timer(this.components);
            this.erpBlankURL = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPowerFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpBlankURL)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start.FlatAppearance.BorderSize = 5;
            this.start.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(240, 300);
            this.start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(393, 89);
            this.start.TabIndex = 0;
            this.start.Text = "Propagate!";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stop.Cursor = System.Windows.Forms.Cursors.Default;
            this.stop.Enabled = false;
            this.stop.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(761, 300);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(393, 93);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop!";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // tmrRunPP
            // 
            this.tmrRunPP.Interval = 120000;
            this.tmrRunPP.Tick += new System.EventHandler(this.tmrRunPP_Tick);
            // 
            // txtTinyPulseURL
            // 
            this.txtTinyPulseURL.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinyPulseURL.Location = new System.Drawing.Point(394, 190);
            this.txtTinyPulseURL.Name = "txtTinyPulseURL";
            this.txtTinyPulseURL.Size = new System.Drawing.Size(625, 20);
            this.txtTinyPulseURL.TabIndex = 2;
            this.txtTinyPulseURL.TextChanged += new System.EventHandler(this.txtTinyPulseURL_TextChanged);
            // 
            // lblTinyPulseURL
            // 
            this.lblTinyPulseURL.AutoSize = true;
            this.lblTinyPulseURL.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTinyPulseURL.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinyPulseURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTinyPulseURL.Location = new System.Drawing.Point(391, 172);
            this.lblTinyPulseURL.Name = "lblTinyPulseURL";
            this.lblTinyPulseURL.Size = new System.Drawing.Size(200, 15);
            this.lblTinyPulseURL.TabIndex = 3;
            this.lblTinyPulseURL.Text = "Enter TinyPulse Report URL: ";
            // 
            // tmrToggleBrowsers
            // 
            this.tmrToggleBrowsers.Interval = 60000;
            this.tmrToggleBrowsers.Tick += new System.EventHandler(this.tmrToggleBrowsers_Tick);
            // 
            // erpBlankURL
            // 
            this.erpBlankURL.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPowerFile
            // 
            this.lblPowerFile.AutoSize = true;
            this.lblPowerFile.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPowerFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPowerFile.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPowerFile.Location = new System.Drawing.Point(392, 227);
            this.lblPowerFile.Name = "lblPowerFile";
            this.lblPowerFile.Size = new System.Drawing.Size(161, 15);
            this.lblPowerFile.TabIndex = 5;
            this.lblPowerFile.Text = "Find Power Point File : ";
            // 
            // Propagate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1421, 519);
            this.Controls.Add(this.lblPowerFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTinyPulseURL);
            this.Controls.Add(this.txtTinyPulseURL);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Propagate";
            this.Text = "TheMachine";
            ((System.ComponentModel.ISupportInitialize)(this.erpBlankURL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer tmrRunPP;
        public System.Windows.Forms.TextBox txtTinyPulseURL;
        private System.Windows.Forms.Label lblTinyPulseURL;
        private System.Windows.Forms.Timer tmrToggleBrowsers;
        private System.Windows.Forms.ErrorProvider erpBlankURL;
        private System.Windows.Forms.Label lblPowerFile;
        private System.Windows.Forms.TextBox textBox1;
    }
}

