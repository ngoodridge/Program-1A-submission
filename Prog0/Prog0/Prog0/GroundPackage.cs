// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018
// By: D7184

//GroundPackage class derived from the Package class that overides the calcost method to determine shipping costs
//based off of distance, size and weight.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    class GroundPackage : Package
    {
        private int _zoneDistance; //Backing field for Zone Distance

        // Precondition:  None
        // Postcondition: The letter is created with the specified values derived from the base class Package
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) : 
            base(originAddress, destAddress, length, width, height, weight)
        {
            //No body needed
        }

        // Precondition:  None
        // Postcondition: The groundPackages _zoneDistance has been returned
        public int ZoneDistance
        {
            get
            {
                const int DIST_FACTOR = 10000;  //constant used to divide the zip codes to get the first digit of the zip codes

                _zoneDistance = Math.Abs((OriginAddress.Zip / DIST_FACTOR) - (DestinationAddress.Zip / DIST_FACTOR));

                return _zoneDistance;
            }
        }

        // Precondition:  None
        // Postcondition: The groundPackages Cost is returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .20;  //Constant that is used to determine the cost associated with the size of the package
            const double WEIGHT_FACTOR = .05;  //Constant that is used to determine the cost associated with the weoght of the package
            decimal Cost;

            Cost = (decimal) (DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (ZoneDistance + 1) * (Weight));

            return Cost;
        }

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Ground {base.ToString()}" +
                $"Zone Distance: {ZoneDistance}";
        }
    }
}
