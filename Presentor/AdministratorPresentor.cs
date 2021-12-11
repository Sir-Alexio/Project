﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentor
{
    public class AdministratorPresentor:IView
    {
        Form _currentView;

        public AdministratorPresentor(Form view)
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