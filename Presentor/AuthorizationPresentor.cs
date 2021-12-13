using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentor
{
    public class AuthorizationPresentor: IView
    {
        public Form _currentView { get; }


        public AuthorizationPresentor(Form authorizationView)
        {
            _currentView = authorizationView;
        }

        public void CloseView()
        {
            _currentView.Close();
        }

        public void ShowView()
        {
            _currentView.Show();
        }
    }
}
