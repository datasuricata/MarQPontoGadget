using MarqPontoExtension.Effects;
using System.Drawing;
using System.Windows.Forms;

namespace MarqPontoExtension.Views
{
    public partial class BlockView : Form
    {
        public BlockView()
        {
            InitializeComponent();
        }

        private void BlockView_Paint(object sender, PaintEventArgs e)
        {
            CustomPaint.StoreEffect(sender, e, this, new Pen(Color.DarkOrange, 1));
        }

        private void Close_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
