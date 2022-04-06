using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HospitalHooplaServer.Models;

namespace HospitalHooplaServer.DAO
{
    public class PatientSQLDao : IPatientDAO
    {
        private readonly string connectionString;

        public PatientSQLDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM patient_data");
                    cmd.Connection = conn;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Patient p = GetPatientFromReader(reader);
                        patients.Add(p);
                    }
                }
            }

            catch (SqlException)
            {
                throw;
            }

            return patients;
        }


        private Patient GetPatientFromReader(SqlDataReader reader)
        {
            Patient p = new Patient()
            {
                PatientId = Convert.ToInt32(reader["patient_id"]),
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                DateOfBirth = Convert.ToString(reader["birthday"]),
            };

            return p;
        }
    }
}
