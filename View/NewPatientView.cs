using System;
using System.Windows.Forms;
using Presentor;

namespace View
{
    public partial class NewPatientView : Form
    {
        private NewPatientPresentor _presentor;

        public NewPatientView()
        {
            InitializeComponent();
            _presentor = new NewPatientPresentor(this);
            
        }
       
        private void NewPatientView_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void femaleRadioBatton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            string sexTextBox = "";

            if (maleRadioButton.Checked) { sexTextBox = "Male"; }
            else if(femaleRadioBatton.Checked){ sexTextBox = "Female"; }
            else { sexTextBox = "Error"; }

            if (!_presentor.isInfoCorrect(nameTextBox.Text, surnameTextBox.Text, sexTextBox, dateOfBirthTextBox.Text))
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            if (!_presentor.isMakePatientInsert(nameTextBox.Text, surnameTextBox.Text, sexTextBox, dateOfBirthTextBox.Text))
            {
                MessageBox.Show("Error with Data Base!");
            }

            _presentor.CloseView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _presentor.CloseView();
        }
    }
}
