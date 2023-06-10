using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Reference
    {
        public string chosenReference;
        
        private int _referenceNumber;

        

        public string ChooseReference()
        {
            Random randomGenerator = new Random();
            _referenceNumber = randomGenerator.Next(0,2);

            if (_referenceNumber == 0)
            {
                chosenReference = "John 13:14";
            }
            if (_referenceNumber == 1)
            {
                chosenReference = "Mike 22";
            }
            if (_referenceNumber == 2)
            {
                chosenReference = "Tony 22";
            }

            return chosenReference;
        }

    }
}