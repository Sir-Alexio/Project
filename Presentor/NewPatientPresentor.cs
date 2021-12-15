using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entities;

namespace Presentor
{
    public class NewPatientPresentor : IView
    {
        private readonly Form _currentForm;

        private Patient newPatient;

        public NewPatientPresentor(Form form)
        {
            _currentForm = form;
        }
        public void CloseView()
        {
            _currentForm.Close();
        }

        public void ShowView()
        {
            _currentForm.Show();
        }

        public void makePatient(string name,string surname, string sex, string dateOfBirth)
        {
            newPatient = new Patient();

            newPatient.name = name;
            newPatient.surname = surname;
            newPatient.sex = sex;
            newPatient.dateOfBirth = dateOfBirth;

        }

    }
}
