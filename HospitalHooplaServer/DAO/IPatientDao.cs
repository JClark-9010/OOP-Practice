using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalHooplaServer.Models;

namespace HospitalHooplaServer.DAO
{
    public interface IPatientDAO
    {
        public List<Patient> GetPatients();

    }
}
