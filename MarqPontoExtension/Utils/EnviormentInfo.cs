using System;
using System.Windows.Forms;

namespace MarqPontoExtension.Utils
{
    public static class EnviormentInfo
    {
        private static string path;

        public static void DisplayEnviorment()
        {
            MessageBox.Show
                (
                    "Olá! " + GetUserName() + Environment.NewLine +
                    Environment.NewLine +

                    "Informações do Ambiente:" + Environment.NewLine +
                    Environment.NewLine +

                    "Dominio: " + GetDomain() + Environment.NewLine +
                    "Computador: " + GetHostName() + Environment.NewLine +
                    "OS: " + GetSystemOS() + Environment.NewLine +
                    "Plataforma: " + GetPlataform().ToString() + Environment.NewLine +
                    "Home: " + GetHomePath() + Environment.NewLine +
                    "Documentos: " + GetDocumentsPath() + Environment.NewLine +
                    "Especial: " + GetSpecialPath() + Environment.NewLine +
                    "Xml: " + GetXmlPath(), "MarQPonto");
        }

        public static void DisplayScreenInfo()
        {
            MessageBox.Show
                (
                    "Informações de Tela:" + Environment.NewLine +
                    Environment.NewLine +

                    "Left: " + Screen.PrimaryScreen.WorkingArea.Left.ToString() + Environment.NewLine +
                    "Right: " + Screen.PrimaryScreen.WorkingArea.Right.ToString() + Environment.NewLine +
                    "Top: " + Screen.PrimaryScreen.WorkingArea.Top + Environment.NewLine +
                    "Bottom: " + Screen.PrimaryScreen.WorkingArea.Bottom.ToString() + Environment.NewLine +
                    "Height: " + Screen.PrimaryScreen.WorkingArea.Height.ToString() + Environment.NewLine +
                    "Width: " + Screen.PrimaryScreen.WorkingArea.Width + Environment.NewLine +
                    "Size: " + Screen.PrimaryScreen.WorkingArea.Size.ToString() + Environment.NewLine +
                    Environment.NewLine +

                    "Cores Customizadas:" + Environment.NewLine +
                    Environment.NewLine +

                    "DarkOrange" + Environment.NewLine +
                    "Purple" + Environment.NewLine +
                    "SteelBlue" + Environment.NewLine +
                    "Tomato" + Environment.NewLine +
                    "Yellow" + Environment.NewLine +
                    "ForestGreen" + Environment.NewLine +
                    "White" + Environment.NewLine +
                    "Black" + Environment.NewLine, "MarQPonto"
                 );
        }

        #region Enviorment

        public static string GetDomain()
        {
            return Environment.UserDomainName;
        }

        public static string GetUserName()
        {
            return Environment.UserName;
        }

        public static string GetHostName()
        {
            return Environment.MachineName;
        }

        public static string GetSystemOS()
        {
            return Environment.OSVersion.ToString();
        }

        public static string GetHomePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        public static string GetDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        public static string GetXmlPath()
        {
            if (GetPlataform() == PlatformID.Unix || GetPlataform() == PlatformID.MacOSX)
            {
                path = GetSpecialPath() + "/MarQPonto";
            }

            if (GetPlataform() == PlatformID.WinCE || GetPlataform() == PlatformID.Win32Windows || GetPlataform() == PlatformID.Win32NT)
            {
                path = GetSpecialPath() + "\\MarQPonto";
            }

            return path;
        }

        public static string GetXmlPathConf()
        {
            if (GetPlataform() == PlatformID.Unix || GetPlataform() == PlatformID.MacOSX)
            {
                path = GetXmlPath() + "/conf.xml";
            }

            if (GetPlataform() == PlatformID.WinCE || GetPlataform() == PlatformID.Win32Windows || GetPlataform() == PlatformID.Win32NT)
            {
                path = GetXmlPath() + "\\conf.xml";
            }

            return path;
        }

        public static string GetSpecialPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        public static PlatformID GetPlataform()
        {
            return Environment.OSVersion.Platform;
        }

        #endregion

    }
}
