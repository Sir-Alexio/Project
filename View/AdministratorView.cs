using System;
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
            listOfPatients.DataSource = administratorPresentor.getStringListOfPatients();  
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

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Update_Click(object sender, EventArgs e)
        {

            listOfPatients.DataSource = null;
            listOfPatients.Items.Clear();
            listOfPatients.DataSource = administratorPresentor.getStringListOfPatients();
        }

        private void listOfPatients_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
