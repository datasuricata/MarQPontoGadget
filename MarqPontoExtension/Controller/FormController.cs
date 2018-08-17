using MarqPontoExtension.Views;
using System.Windows.Forms;

namespace MarqPontoExtension.Controller
{
    public static class FormController
    {
        public static string Message { get; set; }
        public static string Token { get; set; }

        public static void LoginView(FormWindowState windowState = FormWindowState.Normal)
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
        public static void EmployeView(FormWindowState windowState = FormWindowState.Normal)
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
        public static void AlertView(FormWindowState windowState = FormWindowState.Normal)
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
        public static void PopupView(FormWindowState windowState = FormWindowState.Normal)
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
        public static void HomeView(FormWindowState windowState = FormWindowState.Normal)
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
        public static void ConfigView(FormWindowState windowState = FormWindowState.Normal)
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
        public static void BlockView(FormWindowState windowState = FormWindowState.Normal)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms["BlockView"] == null)
            {
                BlockView action = new BlockView();
                action.Show();
               // action.Hide();
            }
            else
            {
                {
                    Application.OpenForms["BlockView"].Activate();
                    Application.OpenForms["BlockView"].WindowState = windowState;
                    Application.OpenForms["BlockView"].Show();
                }
            }
        }

        public static void BaseView(Form form, string formName, FormWindowState windowState = FormWindowState.Normal)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Application.OpenForms[formName] == null)
            {
                form = new Form();
                form.Show();
            }
            else
            {
                {
                    Application.OpenForms[formName].Activate();
                    Application.OpenForms[formName].WindowState = windowState;
                    Application.OpenForms[formName].Show();
                }
            }
        }

        //TODO transformar em extension
        public static void HideView(string formName)
        {
            Application.OpenForms[formName].Hide();
        }
        public static void ShowView(string formName)
        {
            Application.OpenForms[formName].Activate();
            Application.OpenForms[formName].Show();
        }
    }
}
