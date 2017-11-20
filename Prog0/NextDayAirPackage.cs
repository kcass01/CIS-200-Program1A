// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// GRADING ID: D7010
//file: NextDayAirPackage.cs
//clas with child of airpackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        //backing fields for new properties
        private decimal _expressFee;
        //constructor of a next day air package.
        //preconditions: all properties have valid values
        //Postconditions: creates object of type Next Day Air Package
        public NextDayAirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight, decimal expressFee)
            :base(originAddress, destAddress, length, width, height, weight)
        {
            //makes sure express fee is a non negative number
            if(expressFee >= 0)
            {
                _expressFee = expressFee;
            }
            else
            {
                //returns error if value is invalid
                throw new ArgumentOutOfRangeException("Invalid Express Fee Entered");
            }
            
        }

        //read only property for Express Fee
        public decimal ExpressFee
        {
            //preconditions: none
            //postconditions: returns the express fee
            get
            {
                return _expressFee;
            }
        }

        //override of the calccost method
        //preconditions: none
        //postconditions: returns the cost of the object
        public override decimal CalcCost()
        {
            //variable to hold potential size surcharge; starts at zero, no charge
            decimal sizeCharge = 0;
            //checks if size is large
            if (IsLarge())
            {
                sizeCharge = (decimal)(.25 * (Length + Width + Height));
            }
            //variable to hold potential weight surcharge; starts at no charge
            decimal weightCharge = 0;
            //check if weight is heavy
            if (IsHeavy())
            {
                weightCharge = (decimal)(.25 * Weight);
            }

            return .40M * ((decimal)Length + (decimal)Width + (decimal)Height) + .30M * ((decimal)Weight) 
                + ExpressFee + sizeCharge + weightCharge;
            
        }

        //override of the tostring
        //preconditions:nnone
        //postconditions: returns a formatted string
        public override string ToString()
        {
            return "Next Day Air Package" + Environment.NewLine+ base.ToString();
        }
    }
}
