using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Model.Entities;
using Presentor;
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

        public List<string> convertToStringList()
        {
            stringPatients.Clear();

            foreach (Patient patient in PatientsDB.getListOfPatients())
            {
                string stringPatient = patient.id.ToString() + " " + 
                            patient.name + " " + 
                            patient.surname + " " + 
                            patient.sex+ " " + 
                            patient.dateOfBirth;

                stringPatients.Add(stringPatient);
            }

            return stringPatients;
        }
       
    }
}
