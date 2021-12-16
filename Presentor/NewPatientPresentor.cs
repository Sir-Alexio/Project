using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entities;
using Model;

namespace Presentor
{
    public class NewPatientPresentor : IView
    {
        private readonly Form _currentForm;

        public NewPatientPresentor(Form form)
        {
            _currentForm = form;
        }
        public void CloseView()
        {
            _currentForm.Visible = false;
        }

        public void ShowView()
        {
            _currentForm.Visible = true;
        }

        public bool isMakePatientInsert(string name,string surname, string sex, string dateOfBirth)
        {
            Patient newPatient = new Patient();

            newPatient.name = name;
            newPatient.surname = surname;
            newPatient.sex = sex;
            newPatient.dateOfBirth = dateOfBirth;

            return PatientsDB.insertPatient(newPatient);
        }

        public bool isInfoCorrect(string name, string surname, string sex, string dateOfBirth)
        {
            if (name == "" || surname == "" || sex == "Error" || dateOfBirth == "")
            {
                return false;
            }
            else return true;
        }

    }
}
