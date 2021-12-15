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
        private  AdministratorPresentor administratorPresentor;
        private  NewExaminationPresentor examinationPresentor = new NewExaminationPresentor(new NewExaminationView());
        private NewPatientPresentor patientPresentor = new NewPatientPresentor(new NewPatientView());
        
        public AdministratorView()
        {
            InitializeComponent();

            administratorPresentor = new AdministratorPresentor(this);
            listOfPatients.DataSource = administratorPresentor.convertToStringList();  
        }


        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void listOfPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void administratorBackButton_Click(object sender, EventArgs e)
        {
            administratorPresentor.CloseView();
        }

        private void newExaminationButton_Click(object sender, EventArgs e)
        {
            examinationPresentor.ShowView();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            patientPresentor.ShowView();
        }
    }
}
