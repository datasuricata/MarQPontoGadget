using MarqPontoExtension.Commands;
using MarqPontoExtension.Controller;
using MarqPontoExtension.Effects;
using MarqPontoExtension.Endpoints.Base;
using MarqPontoExtension.Entities;
using MarqPontoExtension.Requests;
using MarqPontoExtension.Utils;
using MarqPontoExtension.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MarqPontoExtension
{
    public partial class HomeView : Form
    {
        #region [ Properties ]

        bool useFader, userLock, lockPoint = true;
        int timeWork, timeLeft, interacts, timerIn, timerOut;
        Thread fadeIn, fadeOut, thView;
        System.Drawing.Point lastPoint;
        Fader Fader;

        #endregion

        #region [ Ctor ]

        public HomeView()
        {

            FormController.LoginView();
            useFader = Convert.ToBoolean(XmlUtilities.GetInt("FadeAsDefault"));

            InitializeComponent();
        }

        #endregion

        #region [ Event Args Components ]

        private void CloseForm_Click(object sender, EventArgs e)
        {
            NotifyIcon.Visible = false;
            Dispose();
            Application.Exit();
        }

        private void LockForm_CheckedChanged(object sender, EventArgs e)
        {
            lockPoint = LockForm.Checked;
        }

        private void ButtonPerfil_Click(object sender, EventArgs e)
        {
            FormController.EmployeView();
            FormController.PopupView();

            SyncInfo.Visible = true;
            BackGroundRequests.RunWorkerAsync();
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            FormController.ConfigView();
        }

        #endregion

        #region [ Event Args Startup ]

        private void MarqPonto_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["LoginView"] == null)
            {
                Fader = new Fader(this, this);

                DoubleBuffered = true;
                TransparencyKey = Color.Lime;
                Opacity = Fader.idleOpacity;

                FaderThread();
                fadeIn.Start();

                //TODO aplicar tempo da carga horária
                timeLeft = 5000;

                //Start Timer Counter
                TimerMaster.Start();
                TimerInteractIn.Start();
            }

            NotifyIcon.Visible = true;

            Top = Screen.PrimaryScreen.WorkingArea.Right - Width;
            Top = 0;
        }

        private void MarqPonto_Paint(object sender, PaintEventArgs e)
        {
            CustomPaint.StoreEffect(sender, e, this, CustomPen.GetPenHome());
        }

        #endregion

        #region [ Event Args Mouse Handler ]

        private void MarqPonto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void MarqPonto_MouseMove(object sender, MouseEventArgs e)
        {
            if (!lockPoint)
                if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                {
                    Left += e.X - lastPoint.X;
                    Top += e.Y - lastPoint.Y;
                }
        }

        private void MarqPonto_MouseLeave(object sender, EventArgs e)
        {

            if (Bounds.Contains(Cursor.Position)) return;

            if (fadeIn.ThreadState == ThreadState.Running)
                fadeIn.Abort();

            if (fadeOut.ThreadState == ThreadState.Running)
                fadeOut.Abort();

            if (useFader)
            {
                ThreadStart fadeOutStart = new ThreadStart(Fader.FadeOut);
                fadeOut = new Thread(fadeOutStart);

                fadeOut.Start();
            }
            else
                Size = new Size(467, 6);

        }

        private void MarqPonto_MouseEnter(object sender, EventArgs e)
        {
            if (fadeIn.ThreadState == ThreadState.Running)
                fadeIn.Abort();

            if (fadeOut.ThreadState == ThreadState.Running)
                fadeOut.Abort();

            if (useFader)
            {
                ThreadStart fadeInStart = new ThreadStart(Fader.FadeIn);
                fadeIn = new Thread(fadeInStart);

                fadeIn.Start();
            }

            else
                Size = new Size(467, 38);
        }

        #endregion

        #region [ Event Args Ex Hook ] 

        #endregion

        #region [ BackGround Tasks ]

        private async void BackGroundRequests_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var request = await DataRequest.GetAll(_Employe.GetAll, Security.Token);

                var employe = new Employe();

                employe = request.ToObject<Employe>();
                List<UserPointJson> result = JsonConvert.DeserializeObject<List<UserPointJson>>(employe.point.userPointJson);

                if (request != null)
                    MessageBox.Show(request.ToString(), "API BackGround Task Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "API BackGround Task Result");
            }
        }

        private void BackGroundInteract_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChangeTimerTasks();
        }

        private void BackGroundInteract_DoWork(object sender, DoWorkEventArgs e)
        {
            thView = new Thread(new ThreadStart(OpenBlockView));
         // var thTimer = new Thread(new ThreadStart(ChangeTimerTasks(sender, e));

            while (interacts < 10)
            {
                if (timerIn == 10)
                {
                    if (thView != null)
                        if (thView.ThreadState == ThreadState.Running)
                            break;
                    thView.Start();
                }
            }
            //TODO enviar tempo sem iteractividade para a API
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeWork < timeLeft)
            {
                timeWork++;
                TimeSpan result = TimeSpan.FromSeconds(timeWork);
                string fromTimeString = result.ToString("hh':'mm':'ss");
                info.Text = Environment.UserName + " :  Tempo Trabalhado : " + fromTimeString;
                SyncInfo.Visible = BackGroundRequests.IsBusy;
            }
        }

        private void TimerInteractOut_Tick(object sender, EventArgs e)
        {
            //TODO valor do tempo que o timer de espera para proxima validação vai ficar correndo (Segundos)
            if (timerOut < 30)
                timerOut++;
            else
                ChangeTimerTasks();

        }

        private void TimerInteractIn_Tick(object sender, EventArgs e)
        {
            if (!BackGroundInteract.IsBusy)
                BackGroundInteract.RunWorkerAsync();

            if (thView != null)
            {
                if (thView.ThreadState == ThreadState.Running)
                    thView.Abort();
            }

            if (timerIn < 30)
                timerIn++;
            else
                ChangeTimerTasks();
        }

        #endregion

        #region [ Privates ]

        private void FaderThread()
        {
            ThreadStart In = new ThreadStart(Fader.FadeIn);
            fadeIn = new Thread(In);

            ThreadStart Out = new ThreadStart(Fader.FadeOut);
            fadeOut = new Thread(Out);
        }

        private void ChangeTimerTasks()
        {
            if (TimerInteractIn.Enabled)
            {
                SyncInfo.Visible = false;

                interacts = 0;
                timerIn = 0;
                TimerInteractIn.Stop();
                TimerInteractOut.Start();
            }

            else if (TimerInteractOut.Enabled)
            {
                SyncInfo.Visible = true;

                interacts = 0;
                timerOut = 0;
                TimerInteractOut.Stop();
                TimerInteractIn.Start();
            }
        }

        private void OpenBlockView()
        {
            Application.Run(new BlockView());
        }

        #endregion
    }
}

