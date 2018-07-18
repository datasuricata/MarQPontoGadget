using MarqPontoExtension.Effects;
using MarqPontoExtension.Entities;
using MarqPontoExtension.Utils;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MarqPontoExtension.Views
{
    public partial class ConfigView : Form
    {

        #region Parameters

        System.Drawing.Point lastPoint;

        #endregion

        #region Ctor

        public ConfigView()
        {
            m_aeroEnabled = false;
            InitializeComponent();
        }

        #endregion

        #region Event Args StartUp

        #region Shadow (Beta)

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
             );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }

        #endregion

        private void ConfigView_Paint(object sender, PaintEventArgs e)
        {
            CustomPaint.StoreEffect(sender, e, this, new Pen(Color.Tomato, 1));
        }

        private void ConfigView_Load(object sender, EventArgs e)
        {
            XmlManager.GenereteXml();

            APIServer.Text = XmlUtilities.GetString("Server");
            AlertTime.Text = XmlUtilities.GetString("AlertTime");
            PopUpTime.Text = XmlUtilities.GetString("PopUpTime");
            UseFade.Checked = Convert.ToBoolean(XmlUtilities.GetInt("FadeAsDefault"));
            PopUpColor.Text = XmlUtilities.GetString("PopUpColor");
            GadgetColor.Text = XmlUtilities.GetString("GadgetColor");
            AlertColor.Text = XmlUtilities.GetString("AlertColor");
        }

        #endregion

        #region Event Args Mouse Handler

        private void ConfigView_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void ConfigView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        #endregion

        #region Components

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var configs = new Configurator()
                {
                    AlertColor = new _Config()
                    {
                        Name = "AlertColor",
                        Value = AlertColor.Text
                    },
                    AlertTime = new _Config()
                    {
                        Name = "AlertTime",
                        Value = AlertTime.Text
                    },
                    FadeAsDefault = new _Config()
                    {
                        Name = "FadeAsDefault",
                        Value = Convert.ToInt32(UseFade.Checked).ToString()
                    },
                    GadgetColor = new _Config()
                    {
                        Name = "GadgetColor",
                        Value = GadgetColor.Text,
                    },
                    PopUpColor = new _Config()
                    {
                        Name = "PopUpColor",
                        Value = PopUpColor.Text

                    },
                    PopUpTime = new _Config()
                    {
                        Name = "PopUpTime",
                        Value = PopUpTime.Text
                    },
                    Server = new _Config()
                    {
                        Name = "Server",
                        Value = APIServer.Text
                    }
                };

                XmlManager.UpdateXml(configs);

                MessageBox.Show("Reinicie o programa para que as alterações sejam afetadas", "Dados Atualizados");
                if (MessageBox.Show("Reiniciar Agora?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
                else
                    Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique as informações novamente", "Ops");
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void EnviormentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnviormentInfo.DisplayEnviorment();
        }

        private void ScreenLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnviormentInfo.DisplayScreenInfo();
        }

        #endregion
    }
}
