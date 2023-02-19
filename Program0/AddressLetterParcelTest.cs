/*Michael Bergamini

Program0
Due: Sept 9th
CIS 200 - 50
This class create a LIST and objects from the other 3 classes*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Program0
{
    class AddressLetterParcelTest
    {
        //PreConditions: Address and Letter constructors must be created
        //PostConditions: Address and Letter objects are created
        static void Main()
        {
            var address1 = new Address( "  Mike Berg    ", "   555 NoWhere", "      Apt 99", " Louisville",
                "KY", 550);
            var address2 = new Address("Herbert Sherbert", "878 SumWhere Street", "Louisville     ",
                "KY", 98345);
            var address3 = new Address("Remy Lemmy", "945 Apple Way", "Loft 421", "Los Angeles      ",
                "CA", 90256);
            var address4 = new Address("     Jim Halpert", "     999 Dunder Mifflin BLVD", "Scranton",
                "PA", 508);

            //creating new Letter objects from the objects of the Address class
            var letter1 = new Letter(address4, address1, (decimal)40.99);
            var letter2 = new Letter(address3, address4, (decimal)19.65);
            var letter3 = new Letter(address2, address3, (decimal)25.99);

            //List of base class Parcel objects are created
            var listOfLetters = new List<Parcel>();
            //PreCondition: Letter objects created
            //PostCondition: letter object added to list of letters
            listOfLetters.Add(letter1);
            listOfLetters.Add(letter2);
            listOfLetters.Add(letter3);
                     
           foreach (var letter in listOfLetters) //loop that interates through each letter in list of letters
            {
                //PreCondition: overridden to ToString Methods
                //PostCondition: output of letter objects in formatted string
                Console.WriteLine(letter.ToString());
                
            }
                              


        }
    }
}
