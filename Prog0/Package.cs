// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// GRADING ID: D7010
//file: Package.cs
//is a abstract class for other packages to be based on.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    abstract class Package : Parcel
    {
        //backing fields for the properties
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        //constructor, calls base class for addresses
        //preconditions: all fields have valid values
        //postconditions: object created
        public Package(Address originAddress, Address destAddress, 
            double length, double width, double height, double weight)
            :base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        //property to store length value
        public double Length
        {
            //precondition: none
            //postconditions: returns the length value
            get
            {
                return _length;
            }
            //precondition: nonzero value entered
            //postcondition: length set
            set
            {
                if(value >0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Enter a non-zero value for Length");
                }
            }
        }

        //property to store width value
        public double Width
        {
            //precondition: none
            //postconditions: returns the width value
            get
            {
                return _width;
            }
            //precondition: nonzero value entered
            //postcondition: width set
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Enter a non-zero value for Width");
                }
            }
        }

        //property that stores height value
        public double Height
        {
            //precondition: none
            //postconditions: returns the height value
            get
            {
                return _height;
            }
            //precondition: nonzero value entered
            //postcondition: height set
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Enter a non-zero value for Height");
                }
            }
        }

        //property to store weight value;
        public double Weight
        {
            //precondition: none
            //postconditions: returns the weight value
            get
            {
                return _weight;
            }
            //precondition: nonzero value entered
            //postcondition: weight set
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Enter a non-zero value for Weight");
                }
            }
        }

        //overide base class to string method
        //precondition: none
        //postcondition: returns formatted string
        public override string ToString()
        {
            string NL = System.Environment.NewLine;
            return base.ToString() + $"{NL}{NL}Length: {Length}{NL}Width: " +
                $"{Width}{NL}Height: {Height}{NL}Weight: {Weight}";
        }

    }
}
