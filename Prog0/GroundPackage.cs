// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// GRADING ID: D7010
//File: GroundPackage.cs
//This class is the ground package class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        //constructor of a ground package.
        //preconditions: all data fields submitted, ideally matching requiresments that length 
        //width and height must all be non zero values.
        //Postconditions: creates object of type groundpackage
        public GroundPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight)
            :base(originAddress, destAddress, length, width, height, weight)
        {

        }

        //property to return the zone distance
        //preconditions: Zip codes are defined.
        //postconditions: a single digit zone distance is returned.
        public int ZoneDistance
        {
            //preconditons: assumes the addess are already defined
            //postconditions: returns the value
            get
            {
                return Math.Abs((OriginAddress.Zip - DestinationAddress.Zip)/10000);
            }
        }

        //override of the calc cost method
        //preconditions: relevant properties are defined
        //postconditions: returns a decimal of the total cost
        public override decimal CalcCost()
        {
            return (decimal)(.20 * (Length + Width + Height) + .05 * (ZoneDistance + 1) * Weight);
        }

        //override of the previous tostring
        //no new values needed at this point
        //preconditions:object of this class created with needed values
        //postconditions: returns formatted string for object
        public override string ToString()
        {
            return "Ground Package" + System.Environment.NewLine+ base.ToString();
        }
    }
}
