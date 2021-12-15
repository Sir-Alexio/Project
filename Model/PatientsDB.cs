using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model.Entities;
using System.Windows.Forms;

namespace Model
{
    public class PatientsDB
    {
        private List<Patient> patients = new List<Patient>();

        private Connection connection = new Connection();

        private MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `patients`", Connection.getConnection());

        private MySqlDataReader reader;
        public List<Patient> getListOfPatients()
        {
            connection.openConnection();

            reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Patient patient = new Patient();

                patient.id = Int32.Parse(reader[0].ToString());
                patient.name = (reader[1].ToString());
                patient.surname = (reader[2].ToString());
                patient.sex = (reader[3].ToString());

                patients.Add(patient); 
            }

             reader.Close();

             connection.closeConnection();

            return patients;
           
        }
    }
}
