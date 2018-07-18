using MarqPontoExtension.Commands;
using MarqPontoExtension.Controller;
using MarqPontoExtension.Effects;
using MarqPontoExtension.Endpoints.Base;
using MarqPontoExtension.Entities;
using MarqPontoExtension.Requests;
using MarqPontoExtension.Utils;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MarqPontoExtension.Views
{
    public partial class LoginView : Form
    {
        #region Parameters

        FormController controller = new FormController();
        int count = 0;

        #endregion

        #region Ctor

        public LoginView()
        {
            m_aeroEnabled = false;
            XmlManager.GenereteXml();
            InitializeComponent();
        }

        #endregion

        #region Event Args Startup

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

        private void LoginView_Paint(object sender, PaintEventArgs e)
        {
            CustomPaint.DefaultBorder(sender, e, this);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            if (SaveLogin.Checked)
                Login.Text = XmlUtilities.GetString("UserLogin");
        }

        #endregion

        #region Components

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        #endregion

        #region Authenticate

        private async void Authenticate_Click(object sender, EventArgs e)
        {
            count++;

            var request = await DataRequest.Authenticate(_Security.Authenticate, Login.Text, Pass.Text);

            if (request != null)
            {
                Security.Token = request.access_token;
                Close();
            }

            if (count >= 5)
            {
                MessageBox.Show("A quantidade de tentativas foi excedida, por favor, tente novamente mais tarde!", "MarqPonto Security");
                Application.Exit();
            }
        }

        #endregion
    }
}
