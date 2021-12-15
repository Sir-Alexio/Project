using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Entities;
using System.Windows.Forms;
using Model.Entities;


namespace Presentor
{
    public class AdministratorPresentor:IView
    {
        private Form _currentView;

        private List<string> stringPatients = new List<string>();

        private List<Patient> newPatients;

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

        public List<string> getStringPatients()
        {
            PatientsDB dataAccess = new PatientsDB();

            newPatients = dataAccess.getListOfPatients();

            foreach (Patient patient in newPatients)
            {
                string a = patient.id.ToString() + " " + patient.name + " " + patient.surname + " " + patient.sex;
                stringPatients.Add(a);
            }

            return stringPatients;
        }
       
    }
}
