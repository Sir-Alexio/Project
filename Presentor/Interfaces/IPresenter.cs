using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentor
{
    public interface IPresenter
    {
        void ShowView();
        void CloseView();
    }
}
