using MarqPontoExtension.Commands;
using MarqPontoExtension.Endpoints.Base;
using MarqPontoExtension.Requests;
using System.ComponentModel;
using System.Windows.Forms;

namespace MarqPontoExtension.Views
{
    public partial class EmployeView : Form
    {
        public EmployeView()
        {
            InitializeComponent();
        }

        private async void BackGroundRequests_DoWork(object sender, DoWorkEventArgs e)
        {
            var request = await DataRequest.GetAll(_Employe.GetAll, Security.Token);
        }
    }
}
