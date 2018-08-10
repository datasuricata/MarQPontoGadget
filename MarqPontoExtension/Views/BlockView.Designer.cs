namespace MarqPontoExtension.Views
{
    partial class BlockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoHeader = new System.Windows.Forms.Label();
            this.InfoBody = new System.Windows.Forms.Label();
            this.infoFooter = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 45);
            this.panel1.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.Close, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 426);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // infoHeader
            // 
            this.infoHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.infoHeader.Location = new System.Drawing.Point(137, 0);
            this.infoHeader.Name = "infoHeader";
            this.infoHeader.Size = new System.Drawing.Size(398, 106);
            this.infoHeader.TabIndex = 0;
            this.infoHeader.Text = "Atenção você foi bloqueado por inatividade";
            this.infoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoBody
            // 
            this.InfoBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBody.ForeColor = System.Drawing.Color.White;
            this.InfoBody.Location = new System.Drawing.Point(137, 106);
            this.InfoBody.Name = "InfoBody";
            this.InfoBody.Size = new System.Drawing.Size(398, 106);
            this.InfoBody.TabIndex = 1;
            this.InfoBody.Text = "É necessário solicitar a liberação ao supervisor";
            this.InfoBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoFooter
            // 
            this.infoFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFooter.ForeColor = System.Drawing.Color.White;
            this.infoFooter.Location = new System.Drawing.Point(137, 212);
            this.infoFooter.Name = "infoFooter";
            this.infoFooter.Size = new System.Drawing.Size(398, 106);
            this.infoFooter.TabIndex = 2;
            this.infoFooter.Text = "{GetMessageApi}";
            this.infoFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(137, 321);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(398, 102);
            this.Close.TabIndex = 3;
            this.Close.Text = "Já solicitei pode fechar!";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(743, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 45);
            this.panel2.TabIndex = 17;
            // 
            // BlockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlockView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colaborador Bloqueado";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BlockView_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label infoHeader;
        private System.Windows.Forms.Label InfoBody;
        private System.Windows.Forms.Label infoFooter;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel2;
    }
}