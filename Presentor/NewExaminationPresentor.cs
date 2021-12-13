﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentor
{
    public class NewExaminationPresentor : IView
    {
        private readonly Form _currentForm;

        public NewExaminationPresentor(Form form)
        {
            _currentForm = form;
        }
        public void CloseView()
        {
            _currentForm.Close();
        }

        public void ShowView()
        {
            _currentForm.Show();
        }
    }
}