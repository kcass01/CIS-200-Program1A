// Program 1A
// CIS 200-01/76
// Fall 2017
// Due: 9/25/2017
// GRADING ID: D7010
//file: AirPackage.cs
//is a abstract class for The airpackages to be based on

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    abstract class AirPackage : Package
    {
        //constants for the weight values
        private const double HEAVYWEIGHT = 75;
        private const double LARGESIZE = 100;
        //constructor of an air package.
        //preconditions: all properties have valid values
        //Postconditions: creates object of type Air Package
        public AirPackage(Address originAddress, Address destAddress, double length,
            double width, double height, double weight)
            :base(originAddress, destAddress, length, width, height, weight)
        {

        }

        //is heavy method to return if heavy
        //preconditions:object exists
        //postconditions: returns bool of if object is heavy or not
        public bool IsHeavy()
        {
            if (Weight >= HEAVYWEIGHT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //is heavy method to return if heavy
        //preconditions:object exists
        //postconditions: returns bool of if object is heavy or not
        public bool IsLarge()
        {
            if (Length + Width + Height >= LARGESIZE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //overrides base to string
        //preconditions: none
        //postconditions: returns formatted string for object
        public override string ToString()
        {
            //string to hold new line for easier access
            string NL = System.Environment.NewLine;
            return base.ToString() + $"{NL}Heavy?: {IsHeavy()}{NL}Large?: {IsLarge()} ";
        }
    }
}
