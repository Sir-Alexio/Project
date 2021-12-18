using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Entities;

namespace Presentor
{
    public class MedicalExaminationPresentor:IView
    {
        private Form _currentView;
        public static int id { get; set; }

        public MedicalExaminationPresentor(Form view)
        {
            _currentView = view;
        }

        private Examination getInfoExamination()
        {
            foreach (Examination examination in ExaminationDB.getListOfExaminations())
            {
                if (examination.id == id)
                {
                    return examination;
                }
            }
            return new Examination();
        }

        private Patient getInfoPatient()
        {
            foreach (Patient patient in PatientsDB.getListOfPatients())
            {
                if (patient.id == id)
                {
                    return patient;
                }
            }
            return new Patient();
        }

        public string getInfo()
        {
            Patient patient = getInfoPatient();
            Examination examination = getInfoExamination();

            return "Name:   " + patient.name + Environment.NewLine+
                         "Surname:   " + patient.surname + Environment.NewLine +
                         "Sex:   " + patient.sex + Environment.NewLine +
                         "Date of birth:   " + patient.dateOfBirth + Environment.NewLine +
                         "Type of muscle loading:   " + examination.typeOfMuscleLoading + Environment.NewLine +
                         "Date of examination:   " + examination.dateOfExamination + Environment.NewLine +
                        "List of physiological monitoring:   " + examination.listOfSensors;


        }
        public void ShowView()
        {
            _currentView.Visible = true;
        }

        public void CloseView()
        {
            _currentView.Visible = false;
        }

        public bool isSensorWork()
        {
            Random flag = new Random();

            Thread.Sleep(100);

            if (flag.NextDouble() < 0.15) return false;
            else return true;
        }
    }
}
