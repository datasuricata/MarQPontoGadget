using MarqPontoExtension.Effects;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MarqPontoExtension.Views
{
    public partial class PopupView : Form
    {
        #region Properties

        Thread fadeIn, fadeOut;
        Fader Fader;
        int seconds, ticks;

        #endregion

        #region Ctor

        public PopupView()
        {
            m_aeroEnabled = false;
            Fader = new Fader(this, this);
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

        private void PopupView_Paint(object sender, PaintEventArgs e)
        {
            CustomPaint.StoreEffect(sender, e, this, CustomPen.GetPenPopUp());
        }

        private void PopupView_Load(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.WorkingArea.Right - Width - 15;

            DoubleBuffered = true;
            TransparencyKey = Color.Lime;
            Opacity = Fader.idleOpacity;

            ThreadStart fadeInStart = new ThreadStart(Fader.FadeIn);
            fadeIn = new Thread(fadeInStart);

            ThreadStart fadeOutStart = new ThreadStart(Fader.FadeOut);
            fadeOut = new Thread(fadeOutStart);

            fadeIn.Start();

            //  seconds = XmlUtilities.GetInt("PopupTime");
            seconds = 5;
            timer.Start();
        }

        #endregion

        #region  Event Args Components

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ticks <= seconds)
                ticks++;
            else
            {
                fadeOut.Start();

                if (Fader.idleOpacity == 0.01)
                {
                    fadeOut.Abort();
                    fadeIn.Abort();
                    timer.Stop();
                    Dispose();
                }
            }
        }

        private void PopupView_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
