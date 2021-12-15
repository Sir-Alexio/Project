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
    public partial class NewPatientView : Form
    {
        NewPatientPresentor _presentor;

        
        public NewPatientView()
        {
            InitializeComponent();
            _presentor = new NewPatientPresentor(this);
            
        }
        
       
        private void NewPatientView_Load(object sender, EventArgs e)
        {

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
            string sexTextBox;
            if (maleRadioButton.Checked) { sexTextBox = "Male"; }
            else { sexTextBox = "Female"; }

            _presentor.ShowView();

            _presentor.makePatient(nameTextBox.Text, 
                                    surnameTextBox.Text, 
                                    sexTextBox, 
                                    dateOfBirthTextBox.Text);


        }
    }
}
