using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Entities;

namespace Presentor
{
    public class NewExaminationPresentor : IView, IToStringList
    {
        private readonly Form _currentForm;

        private List<string> stringPatients = new List<string>();

        private Examination examination;

        public NewExaminationPresentor(Form form)
        {
            _currentForm = form;
        }

        public void CloseView()
        {
            _currentForm.Visible = false;
        }

        public List<string> getStringListOfPatients()
        {
            stringPatients.Clear();

            foreach (Patient patient in PatientsDB.getListOfPatients())
            {
                string stringPatient = patient.id.ToString() + " " +
                            patient.name + " " +
                            patient.surname + " " +
                            patient.sex + " " +
                            patient.dateOfBirth;

                stringPatients.Add(stringPatient);
            }

            return stringPatients;
        }

        public bool makeExamination(int number, string typeOfMuscleLoading , string listOfPhysiologicMonitoring, string dateOfExamination)
        {
            examination = new Examination();
            examination.id = number;
            examination.typeOfMuscleLoading = typeOfMuscleLoading;
            examination.listOfSensors = listOfPhysiologicMonitoring;
            examination.dateOfExamination = dateOfExamination;

            return ExaminationDB.insertExamination(examination);
        }

        

        public void ShowView()
        {
            _currentForm.Visible = true;
        }


    }
}
