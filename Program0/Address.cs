/*Michael Bergamini

Program0 This Program uses the Address class as an object. It derives the Letter
class from the Parcel class. Creates a list of objects. Uses a ToString Method
that is overriden several times. 
Due: Sept 9th
CIS 200 - 50
This is the class that creates Address objects*/

using System;

namespace Program0
{
    public class Address 
    {
        private string name; //private variable limits, access to this class, declares string in memory
        private string addressLine1; //private variable limits, access to this class, declares string in memory
        private string addressLine2; //private variable limits, access to this class, declares string in memory
        private string city; //private variable limits, access to this class, declares string in memory
        private string state; //private variable limits, access to this class, declares string in memory
        private int zipCode; //private variable limits, access to this class, declares int in memory
        private char whiteSpace = ' '; //this char is used in the Trim() method to remove white space

        //Address constructor with 6 parameters, Precondition: None
        //PostCondition: Address with 6 arguments is created
        public Address(string name, string addressLine1, string addressLine2,
            string city, string state, int zipCode) 
        {
            //here the property names of each variable is declared and assigned a property
            Name = name; 
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
        //this is the second constructor without the second addressLine
        //this constructor is called when only one addressLine is put in 
        //as an argument
        //Address construcort with 5 parameters, Precondition: None
        //PostCondition: Address with 5 values is created
        public Address(string name, string addressLine1,
            string city, string state, int zipCode) 
        {
            Name = name; //Property assignments for this constructors variables
            AddressLine1 = addressLine1;
            City = city;
            State = state;
            ZipCode = zipCode;
        }          
        
        
        public string Name
        {
            //Precondition: None
            //PostCondition: the string name has been return
            get { return name; }
            //Precondition: name must not be null or white space
            //PostCondition: name has been set to value
            set
            {                
                if ((String.IsNullOrWhiteSpace(value)))
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Name)} must be filled in.");
                }

                name = value.Trim(whiteSpace); //uses whitespace char to trim whitespace
            }
        }
        public string AddressLine1
        {
            //Precondition: None
            //PostCondition: the string addressline1 has been returned
            get { return addressLine1; }
            //Predcondition: the string adressline1 must not be null or white space
            //PostCondition: addressline 1 has been set to value
            set
            {                
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(addressLine1)} must be filled in.");
                }

                addressLine1 = value.Trim(whiteSpace); //uses whitespace char to trim whitespace
            }
        }
        public string AddressLine2
        {
            //PreCondition: None
            //PostCondition: the string addressline2 has been returned
            get { return addressLine2; }
            //Procondition: must not be null or whitespace
            //PostCondition: addressline2 is set to value
            set
            {                
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(addressLine2)} must be filled in.");
                }

                addressLine2 = value.Trim(whiteSpace); //uses whitespace char to trim whitespace
            }
        }
        public string City
        {
            //PreCondition: None
            //PostCondition: the string city has been returned
            get { return city; }
            //Procondition: must not be null or whitespace
            //PostCondition: city is set to value
            set
            {                
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(city)} must be filled in.");
                }

                city = value.Trim(whiteSpace); //uses whitespace char to trim whitespace
            }
        }
        public string State
        {
            //PreCondition: None
            //PostCondition: the string state has been returned
            get { return state; }
            //Procondition: must not be null or whitespace
            //PostCondition: state is set to value
            set
            {                
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(state)} must be filled in.");
                }

                state = value.Trim(whiteSpace); //uses whitespace char to trim whitespace
            }
        }
        public int ZipCode
        {
            //PreCondition: None
            //PostCondition: the int zipcode has been return
            get { return zipCode; }
            //Procondition: must not be less than zero or greater than 99999
            //PostCondition: zipcode is set to value
            set
            {                       
                    if(value < 0 || value > 99999){
                        throw new ArgumentOutOfRangeException(nameof(value),
                            value, $"{nameof(zipCode)} must be filled in and between 0 and 99999.");
                    }                
                zipCode = value;
            }
        }
        //PreCondition: None
        //PostCondition: Outputs formatted string of properties
        public override string ToString() =>
            $"Name: {Name}\n" +
            $"Address: {AddressLine1}\n" + 
            $"{AddressLine2}\n" +
            $"City, State, Zip: {City}, {State} {ZipCode:D5}\n";
               
    } 
}

