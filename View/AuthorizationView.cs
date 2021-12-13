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
        AdministratorPresentor administratorPresentor = new AdministratorPresentor(new AdministratorView());
        DoctorPresentor doctorPresentor = new DoctorPresentor(new DoctorView());
        

        public AuthorizationView()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            administratorPresentor.ShowView();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
           doctorPresentor.ShowView();
            
        }

    }
}
