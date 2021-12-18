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
    public partial class DoctorView : Form
    {
        private DoctorPresentor doctorPresentor;
        private MedicalExaminationPresentor medicalExaminationPresentor = 
            new MedicalExaminationPresentor(new MedicalExaminationView());
        public DoctorView()
        {
            InitializeComponent();
            doctorPresentor = new DoctorPresentor(this);
            listOfExaminations.DataSource = doctorPresentor.getStringListOfExaminations();
            
        }

        

        private void Doctor_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void startMadicalExaminationButton_Click(object sender, EventArgs e)
        {
            medicalExaminationPresentor.ShowView();
            doctorPresentor.findId(listOfExaminations.SelectedItem.ToString());
            
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            doctorPresentor.CloseView();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            listOfExaminations.DataSource = null;
            listOfExaminations.Items.Clear();
            listOfExaminations.DataSource = doctorPresentor.getStringListOfExaminations();
        }
    }
}
