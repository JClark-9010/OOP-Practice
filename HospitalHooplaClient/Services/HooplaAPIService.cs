using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Net.Http;
using HospitalHooplaClient.Models;
using System.Collections.Generic;
using System;

namespace HospitalHoopla.Services
{
    public class HooplaAPIService
    {
        public static IRestClient client = null;
        public readonly string ApiUrl;

        public HooplaAPIService(string apiUrl)
        {
            if (client == null)
            {
                client = new RestClient(apiUrl);
            }
        }

        public HooplaAPIService(IRestClient restClient)
        {
            client = restClient;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            RestRequest request = new RestRequest("patient");
            IRestResponse<List<Patient>> response = client.Get<List<Patient>>(request);

            if (response.Data != null)
            {
                patients.AddRange(response.Data);
            }
            return patients;
        }

    }
}
