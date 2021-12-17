using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentor
{
    public class MedicalExaminationPresentor:IView
    {
        private Form _currentView;

        public MedicalExaminationPresentor(Form view)
        {
            _currentView = view;
        }

        public void ShowView()
        {
            _currentView.Show();
        }

        public void CloseView()
        {
            _currentView.Close();
        }
    }
}
