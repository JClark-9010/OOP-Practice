using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalHooplaClient.Models
{
    public class Patient
    {

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}
