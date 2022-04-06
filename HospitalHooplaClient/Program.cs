using System;

namespace HospitalHoopla
{
    class Program
    {

        private const string apiUrl = "https://localhost:44331/";
        static void Main(string[] args)
        {
            HospitalHooplaApp app = new HospitalHooplaApp(apiUrl);
            app.Run();
        }
    }
}
