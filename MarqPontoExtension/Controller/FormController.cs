using MarqPontoExtension.Views;
using System.Windows.Forms;

namespace MarqPontoExtension.Controller
{
    public class FormController
    {
        public string Message { get; set; }
        public string Token { get; set; }

        public void LoginView(FormWindowState windowState)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["LoginView"] == null)
            {
                LoginView action = new LoginView();
                action.ShowDialog();
            }
            else
            {
                {
                    Application.OpenForms["LoginView"].Activate();
                    Application.OpenForms["LoginView"].WindowState = windowState;
                    Application.OpenForms["LoginView"].Show();
                }
            }
        }

        public void EmployeView(FormWindowState windowState)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["EmployeView"] == null)
            {
                EmployeView action = new EmployeView();
                action.Show();
            }
            else
            {
                {
                    Application.OpenForms["EmployeView"].Activate();
                    Application.OpenForms["EmployeView"].WindowState = windowState;
                    Application.OpenForms["EmployeView"].Show();
                }
            }
        }

        public void AlertView(FormWindowState windowState)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["AlertView"] == null)
            {
                AlertView action = new AlertView();
                action.Show();
            }
            else
            {
                {
                    Application.OpenForms["AlertView"].Activate();
                    Application.OpenForms["AlertView"].WindowState = windowState;
                    Application.OpenForms["AlertView"].Show();
                }
            }
        }

        public void PopupView(FormWindowState windowState)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["PopupView"] == null)
            {
                PopupView action = new PopupView();
                action.Show();
            }
            else
            {
                {
                    Application.OpenForms["PopupView"].Activate();
                    Application.OpenForms["PopupView"].WindowState = windowState;
                    Application.OpenForms["PopupView"].Show();
                }
            }
        }

        public void HomeView(FormWindowState windowState)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["HomeView"] == null)
            {
                HomeView action = new HomeView();
                action.Show();
            }
            else
            {
                {
                    Application.OpenForms["HomeView"].Activate();
                    Application.OpenForms["HomeView"].WindowState = windowState;
                    Application.OpenForms["HomeView"].Show();
                }
            }
        }

        public void ConfigView(FormWindowState windowState)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["ConfigView"] == null)
            {
                ConfigView action = new ConfigView();
                action.Show();
            }
            else
            {
                {
                    Application.OpenForms["ConfigView"].Activate();
                    Application.OpenForms["ConfigView"].WindowState = windowState;
                    Application.OpenForms["ConfigView"].Show();
                }
            }
        }
    }
}
