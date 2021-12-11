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
    public partial class DoctorView : Form, IView
    {
        public DoctorView()
        {
            InitializeComponent();
        }

        public void CloseView()
        {
            this.Close();
        }

        public void ShowView()
        {
            this.Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
