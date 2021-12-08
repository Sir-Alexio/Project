﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentor;

namespace View
{
    public partial class Authorization : Form
    {
        private AuthorizationPresentor _presentor = new AuthorizationPresentor(new Form());

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            _presentor.ShowView(new Administrator());
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            _presentor.ShowView(new Doctor());
        }
    }
}
