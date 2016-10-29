namespace ScreenBright
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BaloonNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DayTrack = new System.Windows.Forms.TrackBar();
            this.Title = new System.Windows.Forms.Label();
            this.labelMorning = new System.Windows.Forms.Label();
            this.label0Perc = new System.Windows.Forms.Label();
            this.label25Perc = new System.Windows.Forms.Label();
            this.label50Perc = new System.Windows.Forms.Label();
            this.label75Perc = new System.Windows.Forms.Label();
            this.label100Perc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NightTrack = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MidnightTrack = new System.Windows.Forms.TrackBar();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidnightTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // BaloonNotify
            // 
            this.BaloonNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.BaloonNotify.BalloonTipText = "AutoBright is Running";
            this.BaloonNotify.BalloonTipTitle = "AutoBright";
            this.BaloonNotify.ContextMenuStrip = this.MenuOptions;
            this.BaloonNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("BaloonNotify.Icon")));
            this.BaloonNotify.Tag = "AutoBright";
            this.BaloonNotify.Text = "AutoBright is Running";
            this.BaloonNotify.Visible = true;
            // 
            // MenuOptions
            // 
            this.MenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(153, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DayTrack
            // 
            this.DayTrack.Location = new System.Drawing.Point(132, 69);
            this.DayTrack.Maximum = 100;
            this.DayTrack.Name = "DayTrack";
            this.DayTrack.Size = new System.Drawing.Size(319, 45);
            this.DayTrack.SmallChange = 25;
            this.DayTrack.TabIndex = 1;
            this.DayTrack.TickFrequency = 25;
            this.DayTrack.Value = 100;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(103, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(287, 46);
            this.Title.TabIndex = 2;
            this.Title.Text = "Adjust Settings";
            // 
            // labelMorning
            // 
            this.labelMorning.AutoSize = true;
            this.labelMorning.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMorning.Location = new System.Drawing.Point(20, 79);
            this.labelMorning.Name = "labelMorning";
            this.labelMorning.Size = new System.Drawing.Size(88, 17);
            this.labelMorning.TabIndex = 3;
            this.labelMorning.Text = "6am to 7pm";
            // 
            // label0Perc
            // 
            this.label0Perc.AutoSize = true;
            this.label0Perc.Location = new System.Drawing.Point(138, 101);
            this.label0Perc.Name = "label0Perc";
            this.label0Perc.Size = new System.Drawing.Size(21, 13);
            this.label0Perc.TabIndex = 4;
            this.label0Perc.Text = "0%";
            // 
            // label25Perc
            // 
            this.label25Perc.AutoSize = true;
            this.label25Perc.Location = new System.Drawing.Point(211, 101);
            this.label25Perc.Name = "label25Perc";
            this.label25Perc.Size = new System.Drawing.Size(27, 13);
            this.label25Perc.TabIndex = 5;
            this.label25Perc.Text = "25%";
            // 
            // label50Perc
            // 
            this.label50Perc.AutoSize = true;
            this.label50Perc.Location = new System.Drawing.Point(282, 101);
            this.label50Perc.Name = "label50Perc";
            this.label50Perc.Size = new System.Drawing.Size(27, 13);
            this.label50Perc.TabIndex = 6;
            this.label50Perc.Text = "50%";
            // 
            // label75Perc
            // 
            this.label75Perc.AutoSize = true;
            this.label75Perc.Location = new System.Drawing.Point(356, 101);
            this.label75Perc.Name = "label75Perc";
            this.label75Perc.Size = new System.Drawing.Size(27, 13);
            this.label75Perc.TabIndex = 7;
            this.label75Perc.Text = "75%";
            // 
            // label100Perc
            // 
            this.label100Perc.AutoSize = true;
            this.label100Perc.Location = new System.Drawing.Point(418, 101);
            this.label100Perc.Name = "label100Perc";
            this.label100Perc.Size = new System.Drawing.Size(33, 13);
            this.label100Perc.TabIndex = 8;
            this.label100Perc.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "75%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "50%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "25%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "7pm to 12am";
            // 
            // NightTrack
            // 
            this.NightTrack.Location = new System.Drawing.Point(132, 139);
            this.NightTrack.Maximum = 100;
            this.NightTrack.Name = "NightTrack";
            this.NightTrack.Size = new System.Drawing.Size(319, 45);
            this.NightTrack.SmallChange = 25;
            this.NightTrack.TabIndex = 9;
            this.NightTrack.TickFrequency = 25;
            this.NightTrack.Value = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "100%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "75%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "50%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "25%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "0%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "12am to 6am";
            // 
            // MidnightTrack
            // 
            this.MidnightTrack.Location = new System.Drawing.Point(132, 212);
            this.MidnightTrack.Maximum = 100;
            this.MidnightTrack.Name = "MidnightTrack";
            this.MidnightTrack.Size = new System.Drawing.Size(319, 45);
            this.MidnightTrack.SmallChange = 25;
            this.MidnightTrack.TabIndex = 16;
            this.MidnightTrack.TickFrequency = 25;
            this.MidnightTrack.Value = 100;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(15, 268);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(436, 43);
            this.BtnSave.TabIndex = 23;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CheckTimer
            // 
            this.CheckTimer.Interval = 1000;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 323);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MidnightTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NightTrack);
            this.Controls.Add(this.label100Perc);
            this.Controls.Add(this.label75Perc);
            this.Controls.Add(this.label50Perc);
            this.Controls.Add(this.label25Perc);
            this.Controls.Add(this.label0Perc);
            this.Controls.Add(this.labelMorning);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DayTrack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "AutoBright";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.MenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DayTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidnightTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon BaloonNotify;
        private System.Windows.Forms.ContextMenuStrip MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar DayTrack;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label labelMorning;
        private System.Windows.Forms.Label label0Perc;
        private System.Windows.Forms.Label label25Perc;
        private System.Windows.Forms.Label label50Perc;
        private System.Windows.Forms.Label label75Perc;
        private System.Windows.Forms.Label label100Perc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar NightTrack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar MidnightTrack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Timer CheckTimer;
    }
}

