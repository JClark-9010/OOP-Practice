using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalHooplaServer.Models;
using HospitalHooplaServer.DAO;

namespace HospitalHooplaServer.Controllers
{
    [Route("[controller]")]
    [ApiController]


    public class PatientController : ControllerBase
    {
        private readonly IPatientDAO patientDAO;

        public PatientController(IPatientDAO patientDAO)
        {
            this.patientDAO = patientDAO;
        }

        [HttpGet]
        public ActionResult<List<Patient>> GetPatients()
        {
            List<Patient> patients = patientDAO.GetPatients();
            
            return Ok(patients);
        }

    }
}
