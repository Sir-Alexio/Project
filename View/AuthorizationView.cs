using System;
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
    public partial class AuthorizationView : Form
    {

        public AuthorizationView()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            AdministratorPresentor presentor = new AdministratorPresentor(new AdministratorView());
            presentor.ShowView();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            DoctorPresentor presentor = new DoctorPresentor(new DoctorView());
            presentor.ShowView();
            
        }

    }
}
