namespace MarqPontoExtension.Views
{
    partial class ConfigView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScreenLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.GadgetColor = new System.Windows.Forms.TextBox();
            this.AlertColor = new System.Windows.Forms.TextBox();
            this.PopUpColor = new System.Windows.Forms.TextBox();
            this.UseFade = new System.Windows.Forms.CheckBox();
            this.PopUpTime = new System.Windows.Forms.TextBox();
            this.AlertTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.APIServer = new System.Windows.Forms.TextBox();
            this.EnviormentLink = new System.Windows.Forms.LinkLabel();
            this.CloseForm = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.35115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.64886F));
            this.tableLayoutPanel1.Controls.Add(this.ScreenLink, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.GadgetColor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AlertColor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.PopUpColor, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.UseFade, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PopUpTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AlertTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.APIServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EnviormentLink, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ScreenLink
            // 
            this.ScreenLink.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.ScreenLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenLink.LinkColor = System.Drawing.Color.DarkOrange;
            this.ScreenLink.Location = new System.Drawing.Point(93, 208);
            this.ScreenLink.Name = "ScreenLink";
            this.ScreenLink.Size = new System.Drawing.Size(166, 27);
            this.ScreenLink.TabIndex = 47;
            this.ScreenLink.TabStop = true;
            this.ScreenLink.Text = "Show Screen Infos";
            this.ScreenLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScreenLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ScreenLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "Screen Info";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GadgetColor
            // 
            this.GadgetColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GadgetColor.Location = new System.Drawing.Point(93, 159);
            this.GadgetColor.Name = "GadgetColor";
            this.GadgetColor.Size = new System.Drawing.Size(166, 20);
            this.GadgetColor.TabIndex = 7;
            // 
            // AlertColor
            // 
            this.AlertColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlertColor.Location = new System.Drawing.Point(93, 133);
            this.AlertColor.Name = "AlertColor";
            this.AlertColor.Size = new System.Drawing.Size(166, 20);
            this.AlertColor.TabIndex = 6;
            // 
            // PopUpColor
            // 
            this.PopUpColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopUpColor.Location = new System.Drawing.Point(93, 107);
            this.PopUpColor.Name = "PopUpColor";
            this.PopUpColor.Size = new System.Drawing.Size(166, 20);
            this.PopUpColor.TabIndex = 5;
            // 
            // UseFade
            // 
            this.UseFade.Checked = true;
            this.UseFade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseFade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UseFade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseFade.ForeColor = System.Drawing.Color.White;
            this.UseFade.Location = new System.Drawing.Point(93, 81);
            this.UseFade.Name = "UseFade";
            this.UseFade.Padding = new System.Windows.Forms.Padding(77, 0, 0, 0);
            this.UseFade.Size = new System.Drawing.Size(166, 20);
            this.UseFade.TabIndex = 4;
            this.UseFade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UseFade.UseVisualStyleBackColor = true;
            // 
            // PopUpTime
            // 
            this.PopUpTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopUpTime.Location = new System.Drawing.Point(93, 55);
            this.PopUpTime.Name = "PopUpTime";
            this.PopUpTime.Size = new System.Drawing.Size(166, 20);
            this.PopUpTime.TabIndex = 3;
            // 
            // AlertTime
            // 
            this.AlertTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlertTime.Location = new System.Drawing.Point(93, 29);
            this.AlertTime.Name = "AlertTime";
            this.AlertTime.Size = new System.Drawing.Size(166, 20);
            this.AlertTime.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 26);
            this.label18.TabIndex = 22;
            this.label18.Text = "Enviorment Info";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 26);
            this.label17.TabIndex = 21;
            this.label17.Text = "Gadget Color";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 26);
            this.label15.TabIndex = 19;
            this.label15.Text = "Alert Color";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "PopUp Color";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Use Fade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "PopUp Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alert Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "API Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // APIServer
            // 
            this.APIServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.APIServer.Location = new System.Drawing.Point(93, 3);
            this.APIServer.Name = "APIServer";
            this.APIServer.Size = new System.Drawing.Size(166, 20);
            this.APIServer.TabIndex = 1;
            // 
            // EnviormentLink
            // 
            this.EnviormentLink.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.EnviormentLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnviormentLink.LinkColor = System.Drawing.Color.DarkOrange;
            this.EnviormentLink.Location = new System.Drawing.Point(93, 182);
            this.EnviormentLink.Name = "EnviormentLink";
            this.EnviormentLink.Size = new System.Drawing.Size(166, 26);
            this.EnviormentLink.TabIndex = 46;
            this.EnviormentLink.TabStop = true;
            this.EnviormentLink.Text = "Show Enviorment Info";
            this.EnviormentLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnviormentLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnviormentLink_LinkClicked);
            // 
            // CloseForm
            // 
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseForm.BackgroundImage")));
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Location = new System.Drawing.Point(258, 12);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(16, 16);
            this.CloseForm.TabIndex = 14;
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.Tomato;
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(12, 300);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(262, 23);
            this.SaveChanges.TabIndex = 15;
            this.SaveChanges.Text = "Salvar";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Configurações";
            // 
            // ConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(286, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigView";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.ConfigView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConfigView_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigView_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PopUpTime;
        private System.Windows.Forms.TextBox AlertTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox APIServer;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UseFade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GadgetColor;
        private System.Windows.Forms.TextBox AlertColor;
        private System.Windows.Forms.TextBox PopUpColor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel ScreenLink;
        private System.Windows.Forms.LinkLabel EnviormentLink;
    }
}