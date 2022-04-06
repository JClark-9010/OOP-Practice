using HospitalHoopla.Services;
using System;
using System.Collections.Generic;
using System.Text;
using HospitalHooplaClient.Models;

namespace HospitalHoopla
{
    public class HospitalHooplaApp
    {
        private readonly HooplaAPIService hooplaAPIService;
        private readonly HooplaConsoleService console = new HooplaConsoleService();

        public HospitalHooplaApp(string apiUrl)
        {
            hooplaAPIService = new HooplaAPIService(apiUrl);
        }

        public void Run()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                keepGoing = DisplayMenu();
            }
        }

        private bool DisplayMenu()
        {
            console.OpeningMenu();
            int menuSelection = console.PromptForInteger("Please choose what you'd like to do", 0, 5);

            while (true)
            {
                if (menuSelection == 0)
                {
                    return false;
                }

                if (menuSelection == 1)
                {
                    List<Patient> patients = hooplaAPIService.GetPatients();
                    Console.WriteLine(console.ListPatients(patients));
                    Console.ReadKey(); //Placeholder to stop the app
                    return true;
                }
            }
        }
    }
}
