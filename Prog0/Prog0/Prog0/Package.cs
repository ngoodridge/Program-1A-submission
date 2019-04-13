// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018
// By: D7184

//Package class derived from the Parcel class that adds dimension properties as well as a weight property
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1A
{
    public abstract class Package : Parcel
    {
        //Backing Fields
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        // Precondition:  None
        // Postcondition: The Package is created with the specified values for
        //                length, width, height, and weight, as well as values from the base class
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight) : base(originAddress, destAddress)
        {
            Height = height;
            Length = length;
            Width = width;
            Weight = weight;
        }

        public double Height
        {

            // Precondition:  None
            // Postcondition: The packages height has been returned
            get
            {
                return _height;
            }

            // Precondition:  Value >= 0
            // Postcondition: The packages height has been set to the specified value
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Please enter a valid height");
                else
                    _height = value;
            }
        }


        public double Length
        {
            // Precondition:  None
            // Postcondition: The packages lenght has been returned
            get
            {
                return _length;
            }

            // Precondition:  Value >= 0
            // Postcondition: The packages legnth has been set to the specified value
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Please enter a valid length");
                else
                    _length = value;
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The packages width has been returned
            get
            {
                return _width;
            }

            // Precondition:  Value >= 0
            // Postcondition: The packages width has been set to the specified value
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Please enter a valid width");
                else
                    _width = value;
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: The packages weight has been returned
            get
            {
                return _weight;
            }

            // Precondition:  Value >= 0
            // Postcondition: The packages width has been set to the specified value
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Please enter a valid weight");
                else
                    _weight = value;
            }
        }

        // Precondition:  None
        // Postcondition: A String with the package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Package{NL}{NL}{base.ToString()}{NL}{NL}Length in Inches:{Length}{NL}Width in Inches:{Width}{NL}" +
                $"Height in Inches:{Height}{NL}Weight in Pounds:{Weight}{NL}";
        }
    }
}
