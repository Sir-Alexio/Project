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
    public partial class MedicalExaminationView : Form
    {
        MedicalExaminationPresentor _presentor;
        public MedicalExaminationView()
        {
            InitializeComponent();
            _presentor = new MedicalExaminationPresentor(this);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void MedicalExaminationView_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            infoTextBox.Text = _presentor.getInfo();
        }

        private void hangSensorsButton_Click(object sender, EventArgs e)
        {

            if (termometerCheckBox.Checked)
            {
                termometerPic.Visible = true;
            }
            else termometerPic.Visible = false;
            if (OximeterCheckBox.Checked)
            {
                oxymeterPic.Visible = true;
            }
            else oxymeterPic.Visible = false;
            if (spirometerCheckBox.Checked)
            {
                spirometerPic.Visible = true;
            }
            else spirometerPic.Visible = false;
            if (pulsometerCheckBox.Checked)
            {
                pulsometerPic.Visible = true;
            }
            else pulsometerPic.Visible = false;
        }
    }
}
