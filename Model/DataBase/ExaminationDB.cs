using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using MySql.Data.MySqlClient;

namespace Model
{
    public static class ExaminationDB
    {
        private static List<Examination> examinations = new List<Examination>();

        private static Connection connection = new Connection();

        private static MySqlCommand mySqlCommand;

        private static MySqlDataReader reader;

        public static List<Examination> getListOfExaminations()
        {
            mySqlCommand = new MySqlCommand("SELECT * FROM `examinations`", connection.getConnection());

            connection.openConnection();

            reader = mySqlCommand.ExecuteReader();

            examinations.Clear();

            while (reader.Read())
            {
                Examination examination = new Examination();

                examination.id = Int32.Parse(reader[0].ToString());
                examination.typeOfMuscleLoading = reader[1].ToString();
                examination.listOfSensors = reader[2].ToString();
                examination.dateOfExamination = reader[3].ToString();

                examinations.Add(examination);
            }

            reader.Close();

            connection.closeConnection();

            return examinations;

        }
        public static bool insertExamination(Examination examination)
        {
            mySqlCommand = new MySqlCommand($"INSERT INTO `examinations` (`id`, `typeOfMuscleLoading`, `listOfSensors`, `dateOfExamination`) VALUES ('{examination.id}', '{examination.typeOfMuscleLoading}', '{examination.listOfSensors}', '{examination.dateOfExamination}');", connection.getConnection());

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

        public static Examination getInfoById(int id)
        {
            foreach (Examination examination in examinations)
            {
                if (examination.id == id)
                {
                    return examination;
                }
            }
            return new Examination();
        }
    }
}
