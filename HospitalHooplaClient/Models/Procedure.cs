using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalHooplaClient.Models
{
    public class Procedure
    {
        public Procedure (string name, Employee doctor, Employee nurse)
        {
                                                                            //MAY NOT NEED CONSTRUCTOR
        }
        public string Name { get; set; }
        public Employee Doctor { get; set; }
        public Employee Nurse { get; set; }
    }
}
