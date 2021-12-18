using System;
using System.Windows.Forms;
using Presentor;

namespace View
{
    public partial class NewExaminationView : Form
    {
         private NewExaminationPresentor _presentor;
        public NewExaminationView()
        {
            InitializeComponent();
            _presentor = new NewExaminationPresentor(this);
            listOfPatients.DataSource = _presentor.getStringListOfPatients();
            typesOfMuscleLoading.Items.AddRange(new string[] { "running", "walking","cycling", "muscle-strengthening exercises" });

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _presentor.CloseView();
        }

        private void NewExaminationView_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void typesOfMuscleLoading_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            listOfPatients.DataSource = null;
            listOfPatients.DataSource = _presentor.getStringListOfPatients();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (listOfPatients.Items.Count == 0)
            {
                MessageBox.Show("No patients!");
                return;
            }
            string stringListOfSensors = "";
            if (temperatureCheckBox.Checked)
            {
                stringListOfSensors += "temperature  ";
            }
            if (pulseCheckBox.Checked)
            {
                stringListOfSensors += "pulse  ";
            }
            if (breathongCheckBox.Checked)
            {
                stringListOfSensors += "breathing  ";
            }
            if (oxygenLevelCheckBox.Checked)
            {
                stringListOfSensors += "oxygen level  ";
            }
        
            
            if(!_presentor.makeExamination(listOfPatients.SelectedIndex+1, typesOfMuscleLoading.SelectedItem.ToString(), stringListOfSensors, dateOfExaminationTextBox.Text))
            {
                MessageBox.Show("Error with data!");
            }

            _presentor.CloseView();
        }

        
    }
}
