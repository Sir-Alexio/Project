using System.Collections.Generic;
using System.Windows.Forms;
using Model.Entities;
using Model;


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

            foreach (Examination examination in ExaminationDB.getListOfExaminations())
            {
                string stringPatient = examination.id.ToString().PadRight(2) +
                            examination.typeOfMuscleLoading.PadRight(20) +
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
    }
}
