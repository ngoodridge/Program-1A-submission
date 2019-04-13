// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018
// By: D7184

//Class derived from the AirPackage class that overides the calcCost method for shipping costs and also the delivery enum with the early and savey values

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public class TwoDayAirPackage : AirPackage
    {
       public enum Delivery { Early, Saver }

        // Precondition:  None
        // Postcondition: The letter is created with the specified values dericed from the Base class
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, Delivery deliveryType) :
            base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }


        public Delivery DeliveryType
        {
            // Precondition:  None
            // Postcondition: The TwoDayAirPackages's Delivery type has been returned
            get;

            // Precondition:  value = Early || value = Saver
            // Postcondition: the delivery type is set to the specified value
            set;
        }

        public override decimal CalcCost()
        {
            decimal baseCost;  //variable to hold the base cost
            decimal totalCost;  //variable to hold the total cost after fees
            const double DIM_FACTOR = .25;  //factor used to determine fees associated with size
            const double WEIGHT_FACTOR = .25; //factor used to determine fees associated with weight
            const double SAVER_DISCOUNT = .90; //factor used to discount the base cost if the delivery type is saver

            baseCost = (decimal)(DIM_FACTOR * (Length + Width + Height) + (WEIGHT_FACTOR * (Weight)));

            if (DeliveryType == Delivery.Saver)
                totalCost = baseCost * (decimal)(SAVER_DISCOUNT);
            else
                totalCost = baseCost;

            return totalCost;
        }

        // Precondition:  None
        // Postcondition: A String with the TwoDayAirPackages's data has been returned
        public override String ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Two Day {base.ToString()} ";
        }
    }
}
