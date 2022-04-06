using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalHoopla.Services
{
    public class ConsoleService
    {

        //CONTAINS METHODS THAT WILL BE USED OFTEN BY HospitalHooplaConsoleService
        //SUCH AS A PAUSE METHOD OR PROMPTING FOR INPUT METHODS

        public int PromptForInteger(string message, int minimum, int maximum)
        {
            while (true)
            {
                Console.WriteLine($"{message}");
                string input = Console.ReadLine();

                if(int.TryParse(input, out int selection) && selection >= minimum && selection <= maximum)
                {
                    return selection;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
        }
    }
}
