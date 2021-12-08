using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentor
{
    public class AuthorizationPresentor:IShowView
    {
        private Form _currentForm;

        public AuthorizationPresentor(Form form)
        {
            _currentForm = form;
        }

        public void ShowView(Form form)
        {
            form.Show();
            _currentForm.Show();
        }
    }
}
