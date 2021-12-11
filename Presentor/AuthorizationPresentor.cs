﻿using System;
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

        public AuthorizationPresentor(Form view)
        {
            _currentView = view;
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