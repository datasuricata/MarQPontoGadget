using MarqPontoExtension.Utils;
using System.Drawing;

namespace MarqPontoExtension.Effects
{
    public static class CustomPen
    {
        static string value;
        static int border = 1;
        static Color color = new Color();
        static Pen pen;

        public static Pen GetPenHome()
        {
            value = XmlUtilities.GetString("GadgetColor");
            Valid(value);

            return pen = new Pen(color, border);
        }

        public static Pen GetPenPopUp()
        {
            value = XmlUtilities.GetString("PopUpColor");
            Valid(value);

            return pen = new Pen(color, border);
        }

        public static Pen GetPenAlert()
        {
            value = XmlUtilities.GetString("AlertColor");
            Valid(value);

            return pen = new Pen(color, border);
        }

        public static Color Valid(string value)
        {
            if (value == "DarkOrange")
                color = Color.DarkOrange;

            if (value == "Purple")
                color = Color.Purple;

            if (value == "SteelBlue")
                color = Color.SteelBlue;

            if (value == "Tomato")
                color = Color.Tomato;

            if (value == "Yellow")
                color = Color.Yellow;

            if (value == "ForestGreen")
                color = Color.ForestGreen;

            if (value == "White")
                color = Color.White;

            if (value == "Black")
                color = Color.Black;

            return color;
        }
    }
}
