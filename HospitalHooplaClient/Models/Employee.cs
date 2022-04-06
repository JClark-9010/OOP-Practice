using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalHooplaClient.Models
{
    public class Employee
    {
        public Employee (int employeeId, string firstName, string lastName, string occupation, string hireDate)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;                                                                   //MAY NOT NEED CONSTRUCTOR
            Occupation = occupation;
            HireDate = hireDate;
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public string HireDate { get; set; }

    }
}
