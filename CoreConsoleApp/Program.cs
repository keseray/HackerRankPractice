using CoreConsoleApp.Arrays;
using System;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPractice practice = new NewYearChaos(); //static olmayan Interfaceden gelen
            practice.Run();


            //StaticExample.Run();  // static
        }
    }
}
