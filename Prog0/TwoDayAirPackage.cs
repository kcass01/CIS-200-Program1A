// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// GRADING ID: D7010
//file: TwoDayAirPackage.cs
//class covering a child of airpackage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class TwoDayAirPackage : AirPackage
    {
        //backing field for the new property
        private Delivery _deliveryType;

        //constructor of a two day air package.
        //preconditions: all properties have valid values
        //Postconditions: creates object of type Two Day Air Package
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight, Delivery deliveryType)
            : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }

        //creates enum value of early or saver
        public enum Delivery {Early, Saver};

        public Delivery DeliveryType
        {
            //preconditions:none
            //postconditions: returns the delivery type
            get
            {
                return _deliveryType;
            }
            //preconditions: none, type is enforced by enumeration
            //postconditions: sets the delivery type
            set
            {
                _deliveryType = value;
            }
        }

        //override for calccost
        public override decimal CalcCost()
        {
            //variable multiplier to hold percentage of cost
            //default to 1
            decimal multiplier = 1;
            //checks if type is saver, adjust multipier accoridingly
            if(DeliveryType == Delivery.Saver)
            {
                multiplier = .9M;
            }
            return multiplier*(.25M * ((decimal)Length + (decimal)Width + (decimal)Height) + .25M * ((decimal)Weight));
        }

        //overriden tostring method
        //the only new field is delivery type
        public override string ToString()
        {
            //variable to hold new line
            string NL = System.Environment.NewLine;
            return "Two Day Air Package" + NL+ base.ToString()+ $"{NL}Delivery Type: {DeliveryType}";
        }
    }
}
