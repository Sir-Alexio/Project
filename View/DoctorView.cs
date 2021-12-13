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
            doctorPresentor = new DoctorPresentor(this);
            InitializeComponent();
        }

        

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void startMadicalExaminationButton_Click(object sender, EventArgs e)
        {
            medicalExaminationPresentor.ShowView();
        }
    }
}
