using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Model.Entities;

namespace Model
{
    public static class PatientsDB
    {
        private static List<Patient> patients = new List<Patient>();

        private static Connection connection = new Connection();

        private static MySqlCommand mySqlCommand;

        private static MySqlDataReader reader;
        public static List<Patient> getListOfPatients()
        {
            mySqlCommand = new MySqlCommand("SELECT * FROM `patients`", connection.getConnection());

            connection.openConnection();

            reader = mySqlCommand.ExecuteReader();

            patients.Clear();

            while (reader.Read())
            {
                Patient patient = new Patient();

                patient.id = Int32.Parse(reader[0].ToString());
                patient.name = (reader[1].ToString());
                patient.surname = (reader[2].ToString());
                patient.sex = (reader[3].ToString());
                patient.dateOfBirth = reader[4].ToString();
                

                patients.Add(patient); 
            }

            reader.Close();

            connection.closeConnection();

            return patients;
           
        }

        public static bool insertPatient(Patient patient)
        {
            mySqlCommand = new MySqlCommand($"INSERT INTO `patients` (`id`, `name`, `surname`, `sex`, `dateOfBirth`) VALUES (NULL, '{patient.name}', '{patient.surname}', '{patient.sex}', '{patient.dateOfBirth}');", connection.getConnection());

            connection.openConnection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }


            
        }
        
    }
}
