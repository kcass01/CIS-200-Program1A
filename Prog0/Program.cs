// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// GRADING ID: D7010
//file: Program.cs
//File to test the class hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);

            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }

            //Testing Output for Program 1A
            Console.WriteLine("---------- 1A Testing ----------");

            List<Parcel> progAParcels = new List<Parcel>();

            TwoDayAirPackage airCrate = new TwoDayAirPackage(a1, a2, 12,5,3,4,TwoDayAirPackage.Delivery.Early);
            progAParcels.Add(airCrate);
            NextDayAirPackage nextDayAirCrate = new NextDayAirPackage(a3, a1, 23, 14, 10, 13, 10);
            progAParcels.Add(nextDayAirCrate);
            GroundPackage groundCrate = new GroundPackage(a2, a1, 12,5,4,100);
            progAParcels.Add(groundCrate);

            foreach(Parcel e in progAParcels)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("--------------------");
            }
        }
    }
}
