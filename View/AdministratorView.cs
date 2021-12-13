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
    public partial class AdministratorView : Form
    {
        AdministratorPresentor administratorPresentor;
        
        public AdministratorView()
        {
            administratorPresentor = new AdministratorPresentor(this);
            InitializeComponent();
        }


        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void listOfPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void administratorBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newExaminationButton_Click(object sender, EventArgs e)
        {
            administratorPresentor.ShowMessage(listOfPatients);
            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
