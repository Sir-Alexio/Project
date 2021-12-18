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
using Presentor.Presentors;

namespace View
{
    public partial class MedicalExaminationView : Form
    {
        MedicalExaminationPresentor _presentor;
        GraphicPresentor graphicPresentor = new GraphicPresentor(new GraphicView());
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
            this.ControlBox = false;
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
            else
            {
                termometerPic.Visible = false;
                termometerPic.BackColor = Color.Gray;
            }
            if (OximeterCheckBox.Checked)
            {
                oxymeterPic.Visible = true;
            }
            else
            {
                oxymeterPic.Visible = false;
                oxymeterPic.BackColor = Color.Gray;
            }
            if (spirometerCheckBox.Checked)
            {
                spirometerPic.Visible = true;
            }
            else
            {
                spirometerPic.Visible = false;
                spirometerPic.BackColor = Color.Gray;
            }
            if (pulsometerCheckBox.Checked)
            {
                pulsometerPic.Visible = true;
            }
            else
            {
                pulsometerPic.Visible = false;
                pulsometerPic.BackColor = Color.Gray;
            }
        }

        private void diagnoseButton_Click(object sender, EventArgs e)
        {
            if (termometerCheckBox.Checked)
            {
                if (_presentor.isSensorWork()) termometerPic.BackColor = Color.Green;
                else termometerPic.BackColor = Color.Red;
            }

            if (OximeterCheckBox.Checked)
            {
                if (_presentor.isSensorWork()) oxymeterPic.BackColor = Color.Green;
                else oxymeterPic.BackColor = Color.Red;
            }

            if (spirometerCheckBox.Checked)
            {
                if (_presentor.isSensorWork()) spirometerPic.BackColor = Color.Green;
                else spirometerPic.BackColor = Color.Red;
            }

            if (pulsometerCheckBox.Checked)
            {
                if (_presentor.isSensorWork()) pulsometerPic.BackColor = Color.Green;
                else pulsometerPic.BackColor = Color.Red;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            graphicPresentor.ShowView();
            //graphicPresentor.showGraphic();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _presentor.CloseView();
        }
    }
}
