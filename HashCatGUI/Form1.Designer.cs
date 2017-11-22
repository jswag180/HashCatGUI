namespace HashCatGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hashTypeGB = new System.Windows.Forms.GroupBox();
            this.manualRad = new System.Windows.Forms.RadioButton();
            this.autoRad = new System.Windows.Forms.RadioButton();
            this.md5Rad = new System.Windows.Forms.RadioButton();
            this.attackModeGB = new System.Windows.Forms.GroupBox();
            this.bruteForceRad = new System.Windows.Forms.RadioButton();
            this.inputHashTxt = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCrack = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.manualTxt = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnBypass = new System.Windows.Forms.Button();
            this.btnCheckpoint = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.hashTypeGB.SuspendLayout();
            this.attackModeGB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hashTypeGB
            // 
            this.hashTypeGB.Controls.Add(this.manualRad);
            this.hashTypeGB.Controls.Add(this.autoRad);
            this.hashTypeGB.Controls.Add(this.md5Rad);
            this.hashTypeGB.Location = new System.Drawing.Point(12, 189);
            this.hashTypeGB.Name = "hashTypeGB";
            this.hashTypeGB.Size = new System.Drawing.Size(200, 100);
            this.hashTypeGB.TabIndex = 0;
            this.hashTypeGB.TabStop = false;
            this.hashTypeGB.Text = "Hash Type";
            // 
            // manualRad
            // 
            this.manualRad.AutoSize = true;
            this.manualRad.Location = new System.Drawing.Point(7, 68);
            this.manualRad.Name = "manualRad";
            this.manualRad.Size = new System.Drawing.Size(87, 17);
            this.manualRad.TabIndex = 2;
            this.manualRad.TabStop = true;
            this.manualRad.Text = "Manual Input";
            this.manualRad.UseVisualStyleBackColor = true;
            this.manualRad.CheckedChanged += new System.EventHandler(this.manualRad_CheckedChanged);
            // 
            // autoRad
            // 
            this.autoRad.AutoSize = true;
            this.autoRad.Location = new System.Drawing.Point(7, 44);
            this.autoRad.Name = "autoRad";
            this.autoRad.Size = new System.Drawing.Size(132, 17);
            this.autoRad.TabIndex = 1;
            this.autoRad.TabStop = true;
            this.autoRad.Text = "Auto(NOT WORKING)";
            this.autoRad.UseVisualStyleBackColor = true;
            // 
            // md5Rad
            // 
            this.md5Rad.AutoSize = true;
            this.md5Rad.Location = new System.Drawing.Point(7, 20);
            this.md5Rad.Name = "md5Rad";
            this.md5Rad.Size = new System.Drawing.Size(48, 17);
            this.md5Rad.TabIndex = 0;
            this.md5Rad.TabStop = true;
            this.md5Rad.Text = "MD5";
            this.md5Rad.UseVisualStyleBackColor = true;
            // 
            // attackModeGB
            // 
            this.attackModeGB.Controls.Add(this.bruteForceRad);
            this.attackModeGB.Location = new System.Drawing.Point(504, 189);
            this.attackModeGB.Name = "attackModeGB";
            this.attackModeGB.Size = new System.Drawing.Size(200, 100);
            this.attackModeGB.TabIndex = 1;
            this.attackModeGB.TabStop = false;
            this.attackModeGB.Text = "Attack Mode";
            // 
            // bruteForceRad
            // 
            this.bruteForceRad.AutoSize = true;
            this.bruteForceRad.Location = new System.Drawing.Point(7, 20);
            this.bruteForceRad.Name = "bruteForceRad";
            this.bruteForceRad.Size = new System.Drawing.Size(77, 17);
            this.bruteForceRad.TabIndex = 0;
            this.bruteForceRad.TabStop = true;
            this.bruteForceRad.Text = "Brute-force";
            this.bruteForceRad.UseVisualStyleBackColor = true;
            // 
            // inputHashTxt
            // 
            this.inputHashTxt.Location = new System.Drawing.Point(309, 189);
            this.inputHashTxt.Name = "inputHashTxt";
            this.inputHashTxt.Size = new System.Drawing.Size(100, 20);
            this.inputHashTxt.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(219, 192);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Input hash here:";
            // 
            // btnCrack
            // 
            this.btnCrack.Location = new System.Drawing.Point(309, 266);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(75, 23);
            this.btnCrack.TabIndex = 4;
            this.btnCrack.Text = "Crack";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(629, 520);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btnClearHistory.TabIndex = 5;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // manualTxt
            // 
            this.manualTxt.Location = new System.Drawing.Point(19, 296);
            this.manualTxt.Name = "manualTxt";
            this.manualTxt.Size = new System.Drawing.Size(100, 20);
            this.manualTxt.TabIndex = 6;
            this.manualTxt.Visible = false;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(3, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(0, 13);
            this.lblCon.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblCon);
            this.panel1.Location = new System.Drawing.Point(222, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 200);
            this.panel1.TabIndex = 8;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(141, 314);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "Satus";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(141, 344);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(141, 374);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 11;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnBypass
            // 
            this.btnBypass.Location = new System.Drawing.Point(141, 404);
            this.btnBypass.Name = "btnBypass";
            this.btnBypass.Size = new System.Drawing.Size(75, 23);
            this.btnBypass.TabIndex = 12;
            this.btnBypass.Text = "Bypass";
            this.btnBypass.UseVisualStyleBackColor = true;
            this.btnBypass.Click += new System.EventHandler(this.btnBypass_Click);
            // 
            // btnCheckpoint
            // 
            this.btnCheckpoint.Location = new System.Drawing.Point(141, 434);
            this.btnCheckpoint.Name = "btnCheckpoint";
            this.btnCheckpoint.Size = new System.Drawing.Size(75, 23);
            this.btnCheckpoint.TabIndex = 13;
            this.btnCheckpoint.Text = "Checkpoint";
            this.btnCheckpoint.UseVisualStyleBackColor = true;
            this.btnCheckpoint.Click += new System.EventHandler(this.btnCheckpoint_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(141, 464);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 555);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCheckpoint);
            this.Controls.Add(this.btnBypass);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.manualTxt);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.inputHashTxt);
            this.Controls.Add(this.attackModeGB);
            this.Controls.Add(this.hashTypeGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hashcat GUI";
            this.hashTypeGB.ResumeLayout(false);
            this.hashTypeGB.PerformLayout();
            this.attackModeGB.ResumeLayout(false);
            this.attackModeGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hashTypeGB;
        private System.Windows.Forms.RadioButton md5Rad;
        private System.Windows.Forms.GroupBox attackModeGB;
        private System.Windows.Forms.RadioButton bruteForceRad;
        private System.Windows.Forms.TextBox inputHashTxt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.RadioButton autoRad;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.RadioButton manualRad;
        private System.Windows.Forms.TextBox manualTxt;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnBypass;
        private System.Windows.Forms.Button btnCheckpoint;
        private System.Windows.Forms.Button btnQuit;
    }
}

