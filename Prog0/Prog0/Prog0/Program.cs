// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018
// By: D7184

// Simple test program for the Package progrmas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
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

            //Test data for ground packages:

            GroundPackage g1 = new GroundPackage(a1, a2, 5, 5, 5, 10);
            GroundPackage g2 = new GroundPackage(a3, a4, 3.3, 4.4, 5.5, 6.6);
            GroundPackage g3 = new GroundPackage(a4, a1, 4, 5, 6, 1);

            List<GroundPackage> groundPackages = new List<GroundPackage>(); // Test list of parcels

            // Add test data to list
            groundPackages.Add(g1);
            groundPackages.Add(g2);
            groundPackages.Add(g3);

            // Display data
            Console.WriteLine("\nProgram 1A - List of Ground Packages\n");

            foreach (GroundPackage g in groundPackages)
            {
                Console.WriteLine(g);
                Console.WriteLine("--------------------");
            }

            //Test data for NextDayAirPackage:            

            NextDayAirPackage n1 = new NextDayAirPackage(a1, a2, 5, 5, 5, 10, 5);
            NextDayAirPackage n2 = new NextDayAirPackage(a3, a4, 40, 40, 40, 6, 10);
            NextDayAirPackage n3 = new NextDayAirPackage(a4, a1, 10, 10, 10, 75, 20);
            NextDayAirPackage n4 = new NextDayAirPackage(a4, a1, 40, 40, 40, 75, 30);


            List<NextDayAirPackage> nextDayAirPackages = new List<NextDayAirPackage>(); // Test list of parcels

            // Add test data to list
            nextDayAirPackages.Add(n1);
            nextDayAirPackages.Add(n2);
            nextDayAirPackages.Add(n3);
            nextDayAirPackages.Add(n4);

            // Display data
            Console.WriteLine("\nProgram 1A - List of Next day Air Packages\n");

            foreach (NextDayAirPackage n in nextDayAirPackages)
            {
                Console.WriteLine(n);
                Console.WriteLine("--------------------");
            }

            //Test data for TwoDayAirPackage:            

            TwoDayAirPackage t1 = new TwoDayAirPackage(a1, a2, 5, 5, 5, 10, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage t2 = new TwoDayAirPackage(a3, a4, 40, 40, 40, 6, TwoDayAirPackage.Delivery.Saver);

            List<TwoDayAirPackage> twoDayAirPackages = new List<TwoDayAirPackage>(); // Test list of parcels

            // Add test data to list
            twoDayAirPackages.Add(t1);
            twoDayAirPackages.Add(t2);

            // Display data
            Console.WriteLine("\nProgram 1A - List of Two day Air Packages\n");

            foreach (TwoDayAirPackage n in twoDayAirPackages)
            {
                Console.WriteLine(n);
                Console.WriteLine("--------------------");
            }
        }
    }
}
