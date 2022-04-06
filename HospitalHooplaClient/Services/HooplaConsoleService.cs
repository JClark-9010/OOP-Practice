using HospitalHooplaClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalHoopla.Services
{
    public class HooplaConsoleService : ConsoleService
    {


        public void OpeningMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to Hospital Hoopla!");
            Console.WriteLine("1: View Patients");
            Console.WriteLine("2: View Doctors");
            Console.WriteLine("3: View Nurses");
            Console.WriteLine("4: View All Staff");
            Console.WriteLine("5: View Drugs");
            Console.WriteLine("0: Exit Program");
        }

        public bool ListPatients(List<Patient> patients)
        {
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"{patient.PatientId} {patient.FirstName} {patient.LastName} {patient.DateOfBirth}");
            }
            return true;
        }
    }
}
