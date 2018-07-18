namespace MarqPontoExtension.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.Button();
            this.Authenticate = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.SaveLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Senha";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Login";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login - MarQPonto";
            this.label1.UseWaitCursor = true;
            // 
            // CloseForm
            // 
            this.CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseForm.BackgroundImage")));
            this.CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseForm.FlatAppearance.BorderSize = 0;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Location = new System.Drawing.Point(192, 8);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(16, 16);
            this.CloseForm.TabIndex = 16;
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // Authenticate
            // 
            this.Authenticate.BackColor = System.Drawing.Color.SteelBlue;
            this.Authenticate.FlatAppearance.BorderSize = 0;
            this.Authenticate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Authenticate.ForeColor = System.Drawing.Color.White;
            this.Authenticate.Location = new System.Drawing.Point(130, 122);
            this.Authenticate.Name = "Authenticate";
            this.Authenticate.Size = new System.Drawing.Size(75, 23);
            this.Authenticate.TabIndex = 14;
            this.Authenticate.Text = "Logon";
            this.Authenticate.UseVisualStyleBackColor = false;
            this.Authenticate.Click += new System.EventHandler(this.Authenticate_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(12, 96);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(193, 20);
            this.Pass.TabIndex = 12;
            this.Pass.Text = "123456";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 57);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(193, 20);
            this.Login.TabIndex = 13;
            this.Login.Text = "marko.bls@hotmail.com";
            // 
            // SaveLogin
            // 
            this.SaveLogin.AutoSize = true;
            this.SaveLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLogin.ForeColor = System.Drawing.Color.White;
            this.SaveLogin.Location = new System.Drawing.Point(12, 125);
            this.SaveLogin.Name = "SaveLogin";
            this.SaveLogin.Size = new System.Drawing.Size(82, 17);
            this.SaveLogin.TabIndex = 20;
            this.SaveLogin.Text = "Salvar Login";
            this.SaveLogin.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(217, 155);
            this.Controls.Add(this.SaveLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.Authenticate);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginView_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button Authenticate;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.CheckBox SaveLogin;
    }
}