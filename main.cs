using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the speed limit?");
            string inputSpeedLimit = Console.ReadLine();
            int speedLimit = Convert.ToInt32(Regex.Replace(inputSpeedLimit, "[^0-9]", ""));

            Console.WriteLine("What speed are you going?");
            string speedOfCar = Console.ReadLine();
            int usersSpeed = Convert.ToInt32(Regex.Replace(speedOfCar, "[^0-9]", ""));

            if (speedLimit >= usersSpeed)
            {
                Console.WriteLine("Ok");
                Console.ReadLine();
            }
            if (speedLimit < usersSpeed)
            {
                foreach(usersSpeed)
            }
        }
    }
}
