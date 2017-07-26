using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Rajandeep Kaur Dhaliwal
/// 300926123
/// 7/25/2017
/// Comp123 Assignment04 Abstract Classes
/// This is a Abstarct Planet Class
/// This is the driver class
/// </summary>

namespace AbstarctPlanets_300926123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================");
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139822, 1898000, "Hydrogen", 8, 5);
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("================================================================================");
            Console.WriteLine("================================================================================");
            TerrestialPlanet terrestialPlanet = new TerrestialPlanet("Earth", 12742, 5972000, true, 1);
            Console.WriteLine(terrestialPlanet.ToString());
            Console.WriteLine("================================================================================");
            WaitForAnyKey();
        }
        public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
    }

