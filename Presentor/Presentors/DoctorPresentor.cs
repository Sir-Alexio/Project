using System.Collections.Generic;
using System.Windows.Forms;
using Model.Entities;
using Model;
using System;

namespace Presentor
{
    public class DoctorPresentor : IView
    {
        private readonly Form _currentForm;

        private List<string> stringExaminations = new List<string>();
        public DoctorPresentor(Form form)
        {
            _currentForm = form;
        }

        public List<string> getStringListOfExaminations()
        {
            stringExaminations.Clear();
           
            stringExaminations.Add("ID".PadRight(10)+"Type of muscle loading:".PadRight(50)+"Date of Examenation:");
            
            foreach (Examination examination in ExaminationDB.getListOfExaminations())
            {
                string stringPatient = examination.id.ToString().PadRight(10) +
                            examination.typeOfMuscleLoading.PadRight(60) +
                            examination.dateOfExamination;

                stringExaminations.Add(stringPatient);
            }

            return stringExaminations;
        }
        public void CloseView()
        {
            _currentForm.Visible = false;
        }

        public void ShowView()
        {
            _currentForm.Visible = true;
        }

        public void findId(string examination)
        {
            int id = 0;

            Int32.TryParse(examination[0] + examination[1].ToString(), out id);

            MedicalExaminationPresentor.id = id;
        }
        
    }
}
