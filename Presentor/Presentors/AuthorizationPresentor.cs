using System.Windows.Forms;

namespace Presentor
{
    public class AuthorizationPresentor: IPresenter
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
