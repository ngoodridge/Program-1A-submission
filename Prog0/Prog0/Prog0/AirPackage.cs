// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018
// By: D7184

//AirPackage class derived from the package Class.  Adds methods to dermine if a package is heavy or large and serves as the base class for NextDayAirPackage and TwoDayAirPackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public abstract class AirPackage : Package
    {
       private const int HEAVY_WEIGHT = 75;  //Constant that is the threshold of a heavy package in pounds
       private const int LARGE_DIMENSION = 100; //Constant that is the threshold of a large package in inches

        // Precondition:  None
        // Postcondition: The AirPackage is created with the specified values derived form the Package class
        public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) :
    base(originAddress, destAddress, length, width, height, weight)
        {
            //No body needed
        }

        // Precondition:  None
        // Postcondition: Returns a bool (true of false) that indicates if a package is classified heavy or not
        public bool IsHeavy()
        {
            return (base.Weight >= HEAVY_WEIGHT);
        }

        // Precondition:  None
        // Postcondition: Returns a bool (true of false) that indicates if a package is classified large or not
        public bool IsLarge()
        {
            return((base.Length + base.Width + base.Height) >= LARGE_DIMENSION);
        }

        // Precondition:  None
        // Postcondition: A String with the AirPackages data has been returned
        public override String ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Air {base.ToString()} " +
                $"{NL} Heavy Package: {IsHeavy()}" +
                $"{NL} Large Package: {IsLarge()}";
        }
    }
}
