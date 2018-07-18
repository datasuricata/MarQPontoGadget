namespace MarqPontoExtension.Views
{
    partial class AlertView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoHeader = new System.Windows.Forms.Label();
            this.InfoBody = new System.Windows.Forms.Label();
            this.infoFooter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.infoHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.InfoBody, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoFooter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 316);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // infoHeader
            // 
            this.infoHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoHeader.ForeColor = System.Drawing.Color.Tomato;
            this.infoHeader.Location = new System.Drawing.Point(113, 0);
            this.infoHeader.Name = "infoHeader";
            this.infoHeader.Size = new System.Drawing.Size(325, 79);
            this.infoHeader.TabIndex = 0;
            this.infoHeader.Text = "Atenção seu horário de expediente já foi finalizado";
            this.infoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoBody
            // 
            this.InfoBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBody.ForeColor = System.Drawing.Color.White;
            this.InfoBody.Location = new System.Drawing.Point(113, 79);
            this.InfoBody.Name = "InfoBody";
            this.InfoBody.Size = new System.Drawing.Size(325, 79);
            this.InfoBody.TabIndex = 1;
            this.InfoBody.Text = "É necessário bater o ponto para retornar o acesso ao host";
            this.InfoBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoFooter
            // 
            this.infoFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFooter.ForeColor = System.Drawing.Color.White;
            this.infoFooter.Location = new System.Drawing.Point(113, 158);
            this.infoFooter.Name = "infoFooter";
            this.infoFooter.Size = new System.Drawing.Size(325, 79);
            this.infoFooter.TabIndex = 2;
            this.infoFooter.Text = "{GetMessageApi}";
            this.infoFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(113, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Já bati pode fechar!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AlertView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(577, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertView";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AlertView_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label infoHeader;
        private System.Windows.Forms.Label InfoBody;
        private System.Windows.Forms.Label infoFooter;
        private System.Windows.Forms.Button button1;
    }
}