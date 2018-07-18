using System.Windows.Forms;

namespace MarqPontoExtension
{
    public class Fader
    {
        #region Properties

        public double idleOpacity = 0.01;
        public double fadeRate = 0.010;
        Form Form;
        Control Control;

        #endregion

        #region Ctor

        public Fader(Form form, Control control)
        {
            Form = form;
            Control = control;
        }

        #endregion

        #region Methods

        private delegate void ChangeOpacityDelegate(double value);

        public void ChangeOpacity(double value)
        {
            if (Control.InvokeRequired)
            {
                ChangeOpacityDelegate del = new ChangeOpacityDelegate(ChangeOpacity);
                object[] parameters = { value };

                Control.Invoke(del, value);
            }
            else
            {
                Form.Opacity = value;
            }
        }

        public void FadeIn()
        {
            for (double i = Form.Opacity; i <= 1; i += fadeRate)
            {
                ChangeOpacity(i);
            }

            if (Form.Opacity != 1.00)
                ChangeOpacity(1.00);
        }

        public void FadeOut()
        {
            for (double i = Form.Opacity; i >= idleOpacity; i -= fadeRate)
            {
                ChangeOpacity(i);
            }

            if (Form.Opacity != idleOpacity)
                ChangeOpacity(idleOpacity);
        }

        #endregion
    }
}
