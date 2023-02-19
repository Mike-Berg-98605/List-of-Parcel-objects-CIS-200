/*Michael Bergamini

Program0
Due: Sept 9th
CIS 200 - 50
This class creates desination and origin objects*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Program0
{
    //base class for the Letter class
    public abstract class Parcel
    {
        private Address _originAddress; // origin address of the parcel
        private Address _destinationAddress; //destination address of parcel
        
        //2 parameter parcel constructor that constructs destination and origin address 
        //Precondition: Address origin and destination arguments must be input
        //PostCondition: Parcel origin and destination objects are created
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress; //assigns origin variable to a property
            DestinationAddress = destinationAddress; //assigns destination variable to a property
        }
        public Address OriginAddress
        {
            //PreCondition:None
            //PostCondition: origin address is returned
            get { return _originAddress; }
            //PreCondition: must not be null
            //PostCondition: origin address is assigned value
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(OriginAddress)} must not be null.");
                }
                else
                   _originAddress = value;
            }
        }
        public Address DestinationAddress
        {
            //PreCondition: None
            //PostCondition: destination address is returned
            get { return _destinationAddress; }
            //PreCondition: must not be null
            //PostCondition: destination address is assigned
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(DestinationAddress)} must not be null.");
                }
                _destinationAddress = value;
            }
        }
        //PreCondition: None
        //PostCondition: abstract method to be overriden is created
        public abstract decimal CalcCost();
        //PreCondition: Creation of origin and destination address class object
        //PostCondition: origin and destination class obejct are assing to ToString() method
        public override string ToString() => 
            $"{OriginAddress}"+
            $"{DestinationAddress}";
            
        
    }
}
