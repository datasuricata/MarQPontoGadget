namespace MarqPontoExtension
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LockForm = new System.Windows.Forms.CheckBox();
            this.ButtonPerfil = new System.Windows.Forms.Button();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.SyncInfo = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.TimerMaster = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BackGroundRequests = new System.ComponentModel.BackgroundWorker();
            this.BackGroundInteract = new System.ComponentModel.BackgroundWorker();
            this.TimerInteractIn = new System.Windows.Forms.Timer(this.components);
            this.TimerInteractOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 100;
            // 
            // LockForm
            // 
            this.LockForm.AutoSize = true;
            this.LockForm.Checked = true;
            this.LockForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LockForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockForm.ForeColor = System.Drawing.Color.White;
            this.LockForm.Location = new System.Drawing.Point(12, 13);
            this.LockForm.Name = "LockForm";
            this.LockForm.Size = new System.Drawing.Size(12, 11);
            this.LockForm.TabIndex = 9;
            this.ToolTip.SetToolTip(this.LockForm, "Mover Gadget");
            this.LockForm.UseVisualStyleBackColor = true;
            this.LockForm.CheckedChanged += new System.EventHandler(this.LockForm_CheckedChanged);
            // 
            // ButtonPerfil
            // 
            this.ButtonPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPerfil.BackgroundImage")));
            this.ButtonPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonPerfil.FlatAppearance.BorderSize = 0;
            this.ButtonPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPerfil.Location = new System.Drawing.Point(86, 8);
            this.ButtonPerfil.Name = "ButtonPerfil";
            this.ButtonPerfil.Size = new System.Drawing.Size(22, 22);
            this.ButtonPerfil.TabIndex = 14;
            this.ToolTip.SetToolTip(this.ButtonPerfil, "Informações de perfil");
            this.ButtonPerfil.UseVisualStyleBackColor = true;
            this.ButtonPerfil.Click += new System.EventHandler(this.ButtonPerfil_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo.BackgroundImage")));
            this.ButtonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonInfo.FlatAppearance.BorderSize = 0;
            this.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo.Location = new System.Drawing.Point(58, 8);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(22, 22);
            this.ButtonInfo.TabIndex = 15;
            this.ToolTip.SetToolTip(this.ButtonInfo, "Exibir janelas de notificação");
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseForm.BackgroundImage")));
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Location = new System.Drawing.Point(439, 11);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(16, 16);
            this.CloseForm.TabIndex = 13;
            this.ToolTip.SetToolTip(this.CloseForm, "Sair");
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // SyncInfo
            // 
            this.SyncInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SyncInfo.BackgroundImage")));
            this.SyncInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SyncInfo.Location = new System.Drawing.Point(30, 8);
            this.SyncInfo.Name = "SyncInfo";
            this.SyncInfo.Size = new System.Drawing.Size(22, 22);
            this.SyncInfo.TabIndex = 16;
            this.ToolTip.SetToolTip(this.SyncInfo, "BackGround Services");
            this.SyncInfo.Visible = false;
            // 
            // info
            // 
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(120, 12);
            this.info.MaximumSize = new System.Drawing.Size(250, 13);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(241, 13);
            this.info.TabIndex = 11;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.status.Location = new System.Drawing.Point(368, 12);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 13);
            this.status.TabIndex = 12;
            this.status.Text = "Trabalhando";
            // 
            // TimerMaster
            // 
            this.TimerMaster.Interval = 1000;
            this.TimerMaster.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipText = "TEste";
            this.NotifyIcon.BalloonTipTitle = "asfasda";
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "MarQPonto";
            this.NotifyIcon.Visible = true;
            // 
            // BackGroundRequests
            // 
            this.BackGroundRequests.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundRequests_DoWork);
            // 
            // BackGroundInteract
            // 
            this.BackGroundInteract.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundInteract_DoWork);
            this.BackGroundInteract.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundInteract_RunWorkerCompleted);
            // 
            // TimerInteractIn
            // 
            this.TimerInteractIn.Interval = 1000;
            this.TimerInteractIn.Tick += new System.EventHandler(this.TimerInteractIn_Tick);
            // 
            // TimerInteractOut
            // 
            this.TimerInteractOut.Interval = 1000;
            this.TimerInteractOut.Tick += new System.EventHandler(this.TimerInteractOut_Tick);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(467, 38);
            this.Controls.Add(this.SyncInfo);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.ButtonPerfil);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.status);
            this.Controls.Add(this.info);
            this.Controls.Add(this.LockForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarQPonto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MarqPonto_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MarqPonto_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MarqPonto_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MarqPonto_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MarqPonto_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MarqPonto_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.CheckBox LockForm;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer TimerMaster;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button ButtonPerfil;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.ComponentModel.BackgroundWorker BackGroundRequests;
        private System.Windows.Forms.Panel SyncInfo;
        private System.ComponentModel.BackgroundWorker BackGroundInteract;
        private System.Windows.Forms.Timer TimerInteractIn;
        private System.Windows.Forms.Timer TimerInteractOut;
    }
}

