
/*Michael Bergamini

Program0
Due: Sept 9th
CIS 200 - 50
This class inherits from Parcel and creates a letter object*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Program0
{
    //Letter class inherits Parcel class
    public class Letter : Parcel
    {        
        private decimal fixedCost; //accessible to only this class, recieves input from main()

        //3 parameter Letter constructor that uses base origin and destination class objects from Parcel class
        //PreCondition: Class Address objects from Parcel class
        //PostCondtion: Class Address objects and fixedcost are assigned to Letter constructor 
        public Letter(Address originAddress, Address destinationAddress, decimal fixedCost)
            : base(originAddress, destinationAddress) 
        {
            FixedCost = fixedCost; //sets fixed cost to property
        }
        //Precondtion: None
        //PostCondition: fixed cost is returned           
        private decimal FixedCost 
        {
            //Precondtion: None
            //PostCondition: fixed cost is returned 
            get { return fixedCost; }
            //Precondition: fixedcost must be non-negative
            //PostCondition: fixedCost = value
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(fixedCost)} must be greater than Zero");
                }
                else
                    fixedCost = value;
            }
        }
        //PreCondition: CalcCost() method to override
        //PostCondition: CalcCost() method is overriden
        public override decimal CalcCost() => fixedCost;

        //PreCondition: ToString method to override from Parcel class
        //PostCondition: ToString method is overriden
        public override string ToString() =>
            $"Origin Address:\n{OriginAddress}\n" +
            $"Destination Address:\n{DestinationAddress}\n" +
            $"Fixed Cost: {CalcCost():C}\n" +
            $"------------------------------";


    }
}

