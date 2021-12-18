using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Model.Entities;

namespace Presentor
{
    public class AdministratorPresentor:IView,IToStringList
    {
        private Form _currentView;

        private List<string> stringPatients = new List<string>();

        public AdministratorPresentor(Form view)
        {
            _currentView = view;
        }

        public void ShowView()
        {
            _currentView.Visible = true;
        }

        public void CloseView()
        {
            _currentView.Visible = false;
        }

        public List<string> getStringListOfPatients()
        {
            stringPatients.Clear();

            stringPatients.Add("ID".PadRight(2)+"Name:".PadRight(20)+"Surname:".PadRight(20)+"Sex:".PadRight(20)+"Date of birth:");
            foreach (Patient patient in PatientsDB.getListOfPatients())
            {
                string stringPatient = patient.id.ToString().PadRight(2) +
                            patient.name.PadRight(20) +
                            patient.surname.PadRight(20) +
                            patient.sex.PadRight(20) +
                            patient.dateOfBirth;

                stringPatients.Add(stringPatient);
            }

            return stringPatients;
        }
       
    }
}
