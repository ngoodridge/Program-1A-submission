// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018
// By: D7184

//Class derived from the AirPackage class that overides the calcCost method for shipping costs and also includes an express fee

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; //Backing field for ExpressFee

        // Precondition:  None
        // Postcondition: The letter is created with the specified values dericed from the Base class
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, decimal expressFee) :
            base(originAddress, destAddress, length, width, height, weight)
        {
            _expressFee = expressFee;
        }

        public decimal ExpressFee
        {
            // Precondition:  _expressFee => 0
            // Postcondition: The NextDayAirPackages exrpress fee is returned
            get
            {
                if (_expressFee < 0)
                    throw new ArgumentOutOfRangeException("Please enter a Fee that is 0 or greater");
                else
                    return _expressFee;    
            }
        }

        // Precondition:  None
        // Postcondition: The NextDayAirPackages total shipping cost is returned
        public override decimal CalcCost()
        {
            decimal baseCost;  //variable to hold the base cost
            decimal totalCost;  //variable to hold the total cost after fees
            const double DIM_FACTOR = .40;  //factor used to determine fees associated with size
            const double WEIGHT_FACTOR = .30; //factor used to determine fees associated with weight
            const double HEAVY_WEIGHT_CHARGE = .25; //factor used to determine fees associated with weight if package classified heavy
            const double LARGE_SIZE_CHARGE = .25; //factor used to determine fees associated with size if package classified large
            double weightCharge;  //variable to hold the total charge produced from a heavy package
            double sizeCharge; //variable to hold the total charge produced from a large package

            baseCost = ((decimal)(DIM_FACTOR) * (decimal)(Length + Width + Height)) + (decimal)(WEIGHT_FACTOR * Weight) + ExpressFee;

            if (IsHeavy())
            {
                weightCharge = HEAVY_WEIGHT_CHARGE * Weight;

                totalCost = baseCost + (decimal)(weightCharge);
            }
            else
            {
                totalCost = baseCost;
            }

            if (IsLarge())
            {
                sizeCharge = LARGE_SIZE_CHARGE * (Length + Width + Height);

                totalCost += (decimal)(sizeCharge);
            }

            return totalCost;
        }

        // Precondition:  None
        // Postcondition: A String with the NextDayAirPackages's data has been returned
        public override String ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Next Day {base.ToString()} ";
        }
    }
}
